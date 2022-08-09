using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using BOL;
using ENTITIES;

namespace DESIGNER.Reportes
{
	public partial class frmLote : Form
	{
		// Instancias
		Lote lote = new Lote();
		ELote eLote = new ELote();
		DataTable tablaLote = new DataTable();
		DataView dvLote;
		
		// Actualizar datos
		public void actualizarDatosGrid(){
			gridLote.DataSource = lote.listarLotes();
			gridLote.Refresh();
			gridLote.ClearSelection();
		}
		
		public frmLote()
		{
			InitializeComponent();
		}

		// Método utilizado para exportar datos en formato excel
		public void exportarDatosExecel(DataGridView datos)
		{
			// Instancia de la clase aplicación
			Microsoft.Office.Interop.Excel.Application exportaExcel = new Microsoft.Office.Interop.Excel.Application();

			// Indicar que creareamos un nuevo libro
			exportaExcel.Application.Workbooks.Add(true);

			// Leer las columnas
			int indexColumn = 0;

			// Recorrer el dataGrid
			foreach (DataGridViewColumn columna in datos.Columns)
			{
				// Aumentar indice
				indexColumn++;

				// leer nombres de todas las columnas
				exportaExcel.Cells[1, indexColumn] = columna.Name;
			}

			// Leer las filas
			int indexFila = 0;
			foreach (DataGridViewRow fila in datos.Rows)
			{
				// Aumentar en 1
				indexFila++;
				indexColumn = 0;

				foreach (DataGridViewColumn columna in datos.Columns)
				{
					// Aumentar
					indexColumn++;
					exportaExcel.Cells[indexFila + 1, indexColumn] = fila.Cells[columna.Name].Value;
				}

			}

			exportaExcel.Visible = true;
		}

		void FrmLoteLoad(object sender, EventArgs e)
		{
			// La tabla toma los datos del método
			tablaLote = lote.listarLotes();

			// El grid toma los datos de la tabla
			gridLote.DataSource = tablaLote;

			// El vada view se asocia con la tabla
			dvLote = tablaLote.DefaultView;
			
			gridLote.Columns[1].Visible = false;
			
			gridLote.Columns[0].HeaderText = "ID LOTE";
			gridLote.Columns[2].HeaderText = "LABORATORIO";
			gridLote.Columns[3].HeaderText = "FECHA DE LLEGADA";
			gridLote.Columns[4].HeaderText = "CANTIDAD";
			
			gridLote.Columns[0].Width = 50;
			gridLote.Columns[2].Width = 250;
			gridLote.Columns[3].Width = 200;
			gridLote.Columns[4].Width = 100;

			gridLote.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(54, 71, 91);
			lblTitulo.Text = lblTitulo.Text.ToUpper();
			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridLote.Rows.Count.ToString();

			gridLote.ClearSelection();
		}

        private void btnModificar_Click(object sender, EventArgs e)
        {
			// Abrir formulario para actualizar
			if (eLote.idlote > 0)
            {
				// Mostrar ventana de actualización
				Mantenimientos.frmLoteActualizar loteActualizar = new Mantenimientos.frmLoteActualizar(eLote);
				loteActualizar.ShowDialog();

				// Actualizar los datos
				actualizarDatosGrid();

				// Resetear id
				eLote.idlote = 0;
			}
            else
            {
				// Mensaje Seleccione
				Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Lote", "Por favor seleccione un registro");
				infoSeleccione.ShowDialog();
			}
		}

		private void gridLote_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// obtener datos
			eLote.idlote = Convert.ToInt32(gridLote.CurrentRow.Cells[0].Value);
			eLote.idlaboratorio = Convert.ToInt32(gridLote.CurrentRow.Cells[1].Value);
			eLote.fechaentrada = gridLote.CurrentRow.Cells[3].Value.ToString();
			eLote.cantidad = Convert.ToInt32(gridLote.CurrentRow.Cells[4].Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			// resetear selección
			gridLote.ClearSelection();

			// idlote
			eLote.idlote = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
			int totalRegistro = gridLote.Rows.Count;
			if (totalRegistro > 0)
            {
				if (eLote.idlote >= 1)
                {
					// confirmar para eliminar
					Dialogo.frmAlerta confiEliminacion = new Dialogo.frmAlerta("Lote", "¿Estás seguro de eliminar el registro. los datos seran borrados de forma permanente?");
					if (confiEliminacion.ShowDialog() == DialogResult.OK)
                    {
						// Capturar error al intentar Eliminar
						String error =  lote.metodosCUD("eliminar", eLote);

						// Mostrar alerta
						if (error != "")
						{
							Dialogo.frmAdvertencia noEliminado = new Dialogo.frmAdvertencia("Lote", error);
							noEliminado.ShowDialog();
                        }
                        else
                        {
							// Resetear id
							eLote.idlote = 0;

							// Mostrar mensaje
							Dialogo.frmInformacion infoEliminado = new Dialogo.frmInformacion("Lote", "Registro eliminado correctamente.");
							infoEliminado.ShowDialog();

							// Actualizar datos
							actualizarDatosGrid();
						}	
                    }
				}
                else
                {
					// Mensaje seleccione
					Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Lote", "Por favor seleccione un registro de la lista.");
					infoSeleccione.ShowDialog();
				}
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
			// filtrar
			dvLote.RowFilter = "laboratorio" + " LIKE'" + txtFiltrar.Text + "%'";

			// Eliminar selección
			if (txtFiltrar.Text == "")
            {
				gridLote.ClearSelection();
            }

			// total de registros encontrados
			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridLote.Rows.Count.ToString();
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
			// Confimrar exportación
			Dialogo.frmConfirmar confiExportar = new Dialogo.frmConfirmar("Lote", "¿Estás seguro de exportar los datos en formato excel?");
			if (confiExportar.ShowDialog() == DialogResult.OK)
			{
				// Exportar
				exportarDatosExecel(gridLote);
			}
		}
    }
}
