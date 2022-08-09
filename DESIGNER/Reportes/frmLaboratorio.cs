using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

// Libreria basada en mi propio Proyecto
using BOL;
using ENTITIES;

namespace DESIGNER.Reportes
{
	public partial class frmLaboratorio : Form
	{
		// Instancias
		Laboratorio laboratorio = new Laboratorio();
		DataTable tablaLaboratorio = new DataTable();
		DataView dvLaboratorio;
		
		
		// Actualizar Datos
		public void actualizarDatosGrid(){
			gridLaboratorio.DataSource = laboratorio.listarLaboratorios();
			gridLaboratorio.Refresh();
			gridLaboratorio.ClearSelection();

			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridLaboratorio.Rows.Count.ToString();
		}
		
		public frmLaboratorio()
		{
			InitializeComponent();	
		}

		// Variables de alcanse global
		private int idlaboratorio = -1;
		private String nomLaboratorio;
		private String pais;

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
		
		void FrmLaboratorioLoad(object sender, EventArgs e)
		{
			// La tabla toma los datos del método
			tablaLaboratorio = laboratorio.listarLaboratorios();

			// El grid toma los datos de la tabla
			gridLaboratorio.DataSource = tablaLaboratorio;

			// El vada view se asocia con la tabla
			dvLaboratorio = tablaLaboratorio.DefaultView;
			
			gridLaboratorio.Columns[0].HeaderText = "ID";
			gridLaboratorio.Columns[1].HeaderText = "LABORATORIO";
			gridLaboratorio.Columns[2].HeaderText = "PAÍS";
			
			gridLaboratorio.Columns[0].Width = 50;
			gridLaboratorio.Columns[1].Width = 250;
			gridLaboratorio.Columns[2].Width = 200;

			gridLaboratorio.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(54, 71, 91);

			lblTitulo.Text = lblTitulo.Text.ToUpper();
			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridLaboratorio.Rows.Count.ToString();

			// Campos para filtrar
			cboCamposFiltrar.Items.Add("Laboratorio");
			cboCamposFiltrar.Items.Add("Pais");
			cboCamposFiltrar.Text = "";
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			// Validar seleccion
			if (idlaboratorio == -1 || nomLaboratorio == "" || pais == "")
            {
				// Advertencia
				Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Laboratorio", "Por favor seleccione un registro.");
				infoComplete.ShowDialog();
            }
            else
            {
				// Mostrar ventana de actualización
				Mantenimientos.frmLaboratorio laboratorioActualizar = new Mantenimientos.frmLaboratorio(idlaboratorio, nomLaboratorio, pais);
				laboratorioActualizar.ShowDialog();

				// Actualizar datos del grid
				actualizarDatosGrid();

				// Resetear idlaboratorio
				this.idlaboratorio = -1;
			}
		}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
			//
			Dialogo.frmAdvertencia advertir = new Dialogo.frmAdvertencia("Advertencia", "Cuidado!");
			advertir.ShowDialog();
        }

        private void gridLaboratorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			// Obtener los datos y guardarlos en las variables 
			this.idlaboratorio = Convert.ToInt32(gridLaboratorio.CurrentRow.Cells[0].Value);
			this.nomLaboratorio = gridLaboratorio.CurrentRow.Cells[1].Value.ToString();
			this.pais = gridLaboratorio.CurrentRow.Cells[2].Value.ToString();

		}

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
			int totalRegistro = gridLaboratorio.Rows.Count;
			if (totalRegistro > 0)
            {
				if (this.idlaboratorio <= 0)
                {
					// Mensaje seleccione
					Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Laboratorio", "Por favor seleccione un registro de la lista.");
					infoSeleccione.ShowDialog();
				}
                else
                {
					// preguntar para proceder a eliminar
					Dialogo.frmAlerta confiEliminacion = new Dialogo.frmAlerta("Laboratorio", "¿Estás seguro de eliminar el registro. se borraran de forma permanente?");

					if (confiEliminacion.ShowDialog() == DialogResult.OK)
					{
						// Capturar error al intentar Eliminar
						String error = laboratorio.eliminarLaboratorio(this.idlaboratorio);

						// Mostrar alerta
						if (error != "")
						{
							Dialogo.frmAdvertencia noEliminado = new Dialogo.frmAdvertencia("Laboratorio", error);
							noEliminado.ShowDialog();
                        }
                        else
                        {
							// Resetear id 
							this.idlaboratorio = -1;

							// Mostrar mensaje
							Dialogo.frmInformacion infoEliminado = new Dialogo.frmInformacion("Laboratorio", "Registro eliminado correctamente.");
							infoEliminado.ShowDialog();

							// Actualizar grid
							actualizarDatosGrid();
						}
					}
				}
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			// resetear seleccion y id
			gridLaboratorio.ClearSelection();
			this.idlaboratorio = -1;
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
			string campo = "";

			if (cboCamposFiltrar.SelectedIndex == 0)
            {
				campo = "laboratorio";
            }
			else if (cboCamposFiltrar.SelectedIndex == 1)
            {
				campo = "pais";
            }

			if (campo != "")
            {
				// Filtrar
				dvLaboratorio.RowFilter = campo + " LIKE'" + txtFiltrar.Text + "%'";
            }
            else
            {
				// Mostrar alerta
				Dialogo.frmAdvertencia alertSeleccione = new Dialogo.frmAdvertencia("Laboratorio", "Por favor seleccione un elemento de la lista");
				alertSeleccione.ShowDialog();
            }

			if (txtFiltrar.Text == "")
            {
				gridLaboratorio.ClearSelection();
            }

			// Total de registros encontrados
			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridLaboratorio.Rows.Count.ToString();
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
			// Confimrar exportación
			Dialogo.frmConfirmar confiExportar = new Dialogo.frmConfirmar("Laboratorio", "¿Estás seguro de exportar los datos en formato excel?");
			if (confiExportar.ShowDialog() == DialogResult.OK)
            {
				// Exportar
				exportarDatosExecel(gridLaboratorio);
			}
        }
    }
}
