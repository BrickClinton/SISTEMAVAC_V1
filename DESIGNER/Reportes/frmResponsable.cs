using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

// Libreria personal
using BOL;
using ENTITIES;

namespace DESIGNER.Reportes
{
	public partial class frmResponsable : Form
	{
		// Logica de negocio
		Responsable responsable = new Responsable();
		EResponsable eResponsable = new EResponsable();
		DataTable tablaResponsable = new DataTable();
		DataView dvResponsable;
		
		public frmResponsable()
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

		// Método actualziar
		private void actualizarDatosGrid()
        {
			gridResponsable.DataSource = responsable.listarResponsables();
			gridResponsable.Refresh();
			gridResponsable.ClearSelection();

			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridResponsable.Rows.Count.ToString();
		}

		void FrmResponsableLoad(object sender, EventArgs e)
		{
			// La tabla toma los datos del método
			tablaResponsable = responsable.listarResponsables();

			// El grid toma los datos de la tabla
			gridResponsable.DataSource = tablaResponsable;

			// El dada view se asocia con la tabla
			dvResponsable = tablaResponsable.DefaultView;

			gridResponsable.Columns[0].Visible = false;
			gridResponsable.Columns[1].Visible = false;
			gridResponsable.Columns[3].Visible = false;
			gridResponsable.Columns[5].Visible = false;

			gridResponsable.Columns[0].HeaderText = "ID";
			gridResponsable.Columns[1].HeaderText = "ID CENTRO VAC";
			gridResponsable.Columns[2].HeaderText = "CENTRO DE VACUNACIÓN";
			gridResponsable.Columns[3].HeaderText = "ID PERSONA";
			gridResponsable.Columns[4].HeaderText = "APELLIDOS Y NOMBRES";
			gridResponsable.Columns[5].HeaderText = "ID ROL";
			gridResponsable.Columns[6].HeaderText = "ROL";
			gridResponsable.Columns[7].HeaderText = "FECHA DE ALTA";
			gridResponsable.Columns[8].HeaderText = "FECHA DE BAJA";
			gridResponsable.Columns[9].HeaderText = "ESTADO";
			
			gridResponsable.Columns[2].Width = 200;
			gridResponsable.Columns[4].Width = 200;
			gridResponsable.Columns[6].Width = 180;
			gridResponsable.Columns[7].Width = 150;
			gridResponsable.Columns[8].Width = 150;
			gridResponsable.Columns[9].Width = 115;

			lblTitulo.Text = lblTitulo.Text.ToUpper();
			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridResponsable.Rows.Count.ToString();

			// Cargar datos en el combo
			cboCamposFiltrar.Items.Add("Centro de vacunación");
			cboCamposFiltrar.Items.Add("Apellidos y nombres");
			cboCamposFiltrar.Text = "";
		}

        private void gridResponsable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			// Capturar los valores del registro
			eResponsable.idresponsable = Convert.ToInt32(gridResponsable.CurrentRow.Cells[0].Value);
			eResponsable.idcentrovac = Convert.ToInt32(gridResponsable.CurrentRow.Cells[1].Value);
			eResponsable.idpersona = Convert.ToInt32(gridResponsable.CurrentRow.Cells[3].Value);
			eResponsable.persona = gridResponsable.CurrentRow.Cells[4].Value.ToString();
			eResponsable.idrol = Convert.ToInt32(gridResponsable.CurrentRow.Cells[5].Value);
			eResponsable.fechalta = gridResponsable.CurrentRow.Cells[7].Value.ToString();
			eResponsable.fechabaja = gridResponsable.CurrentRow.Cells[8].Value.ToString();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			// Resetaer valores
			gridResponsable.ClearSelection();

			eResponsable.idresponsable = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
			// Validar 
			int totalRegistro = gridResponsable.Rows.Count;

			if (totalRegistro > 0)
            {
				// Validar selección
				if (eResponsable.idresponsable <= 0)
                {
					// mensaje seleccione un registro
					Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Responsable", "Por favor seleccione un registro.");
					infoSeleccione.ShowDialog();
				}
                else
                {
					// Abrir formulario 
					Mantenimientos.frmResponsableActualizar responsableActualizar = new Mantenimientos.frmResponsableActualizar(eResponsable);
					responsableActualizar.ShowDialog();

					// Resetear valores
					eResponsable.idresponsable = 0;

					// Actualizar grid
					actualizarDatosGrid();
					
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
			// Validar 
			int totalRegistro = gridResponsable.Rows.Count;

			if (totalRegistro > 0)
			{
				// Validar selección
				if (eResponsable.idresponsable <= 0)
				{
					// mensaje seleccione un registro
					Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Responsable", "Por favor seleccione un registro.");
					infoSeleccione.ShowDialog();
				}
				else
				{
					// Preguntar eliminar
					Dialogo.frmAlerta confiEliminar = new Dialogo.frmAlerta("Responsable", "Estás seguro de eliminar el registro de forma permanente?");
					if (confiEliminar.ShowDialog() == DialogResult.OK)
                    {
						// Capturar error al intentar Eliminar
						String error = responsable.eliminarResponsable(eResponsable.idresponsable);

						// Mostrar alerta
						if (error != "")
						{
							Dialogo.frmAdvertencia noEliminado = new Dialogo.frmAdvertencia("Responsable", error);
							noEliminado.ShowDialog();
                        }
                        else
                        {
							// Resetear valores
							eResponsable.idresponsable = 0;

							// Mostrar mensaje eliminado
							Dialogo.frmInformacion infoEliminado = new Dialogo.frmInformacion("Responsable", "Registro eliminado correctamente.");
							infoEliminado.ShowDialog();

							// Actualizar grid
							actualizarDatosGrid();
						}
					}
				}
			}
		}

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
			// Confimrar exportación
			Dialogo.frmConfirmar confiExportar = new Dialogo.frmConfirmar("Responsable", "¿Estás seguro de exportar los datos en formato excel?");
			if (confiExportar.ShowDialog() == DialogResult.OK)
			{
				// Exportar
				exportarDatosExecel(gridResponsable);
			}
		}

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
			// Campo
			String campo = "";

			if (cboCamposFiltrar.SelectedIndex == 0)
            {
				campo = "nombrecentro";
            }
			else if (cboCamposFiltrar.SelectedIndex == 1)
            {
				campo = "persona";
            }

			// Filtrar
			if (cboCamposFiltrar.Text != "")
            {
				dvResponsable.RowFilter = campo + " LIKE'" + txtFiltrar.Text + "%'";
			}
            else
            {
				Dialogo.frmAdvertencia advertSeleccione = new Dialogo.frmAdvertencia("Responsable", "Por favor seleccione un elemento de la lista");
				advertSeleccione.ShowDialog();
            }
			

			// Limpiar selección
			if (txtFiltrar.Text == "")
            {
				gridResponsable.ClearSelection();
            }

			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridResponsable.Rows.Count.ToString();
        }
    }
}
