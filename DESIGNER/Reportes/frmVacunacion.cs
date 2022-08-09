using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

//Libreria personal
using BOL;
using ENTITIES;

namespace DESIGNER.Reportes
{
	public partial class frmVacunacion : Form
	{
		// Logica de negocio
		Vacunacion vacunacion = new Vacunacion();
		EVacunacion eVacunacion = new EVacunacion();
		DataTable tablaVacunacion = new DataTable();
		DataView dvVacunacion;
		
		public frmVacunacion()
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

		// Métdo que actualiza el grid
		private void actualizarDatosGrid()
        {
			gridVacunacion.DataSource = vacunacion.listarVacunaciones();
			gridVacunacion.Refresh();
			gridVacunacion.ClearSelection();

			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridVacunacion.Rows.Count.ToString();
		}
		
		void FrmVacunacionLoad(object sender, EventArgs e)
		{
			// La tabla toma los datos del método
			tablaVacunacion = vacunacion.listarVacunaciones();

			// El grid toma los datos de la tabla
			gridVacunacion.DataSource = tablaVacunacion;

			// El dada view se asocia con la tabla
			dvVacunacion = tablaVacunacion.DefaultView;

			gridVacunacion.Columns[0].Visible = false;
			gridVacunacion.Columns[1].Visible = false;
			gridVacunacion.Columns[2].Visible = false;
			gridVacunacion.Columns[4].Visible = false;

			gridVacunacion.Columns[0].HeaderText = "ID VAC";
			gridVacunacion.Columns[1].HeaderText = "ID CENTRO";
			gridVacunacion.Columns[2].HeaderText = "ID ATENDIDO";
			gridVacunacion.Columns[3].HeaderText = "PERSONA ATENDIDA";
			gridVacunacion.Columns[4].HeaderText = "ID RESPONSABLE";
			gridVacunacion.Columns[5].HeaderText = "RESPONSABLE";
			gridVacunacion.Columns[6].HeaderText = "ID STOCK VAC";
			gridVacunacion.Columns[7].HeaderText = "FECHA Y HORA";

			gridVacunacion.Columns[0].Width = 50;
			gridVacunacion.Columns[1].Width = 50;
			gridVacunacion.Columns[2].Width = 50;
			gridVacunacion.Columns[3].Width = 200;
			gridVacunacion.Columns[4].Width = 100;
			gridVacunacion.Columns[5].Width = 200;
			gridVacunacion.Columns[6].Width = 120;
			gridVacunacion.Columns[7].Width = 120;

			lblTitulo.Text = lblTitulo.Text.ToUpper();
			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridVacunacion.Rows.Count.ToString();

			// Cargar datos
			cboCamposFiltrar.Items.Add("Persona atendida");
			cboCamposFiltrar.Items.Add("Encargado de vacunar");
			cboCamposFiltrar.Text = "";
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			// Total de registros
			int totalRegistro = gridVacunacion.Rows.Count;

			if (totalRegistro > 0)
            {
				// Valida selección
				if (eVacunacion.idvacunacion <= 0)
                {
					// Mensaje seleccione
					Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("vacunación", "Por favor seleccione un registro.");
					infoSeleccione.ShowDialog();
                }
                else
                {
					// Mostrar formulario
					Mantenimientos.frmVacunacionActualizar vacunacionActualizar = new Mantenimientos.frmVacunacionActualizar(eVacunacion);
					vacunacionActualizar.ShowDialog();

					// Resetear datos
					eVacunacion.idvacunacion = 0;

					// Actualizar grid
					actualizarDatosGrid();
                }
            }
        }

        private void gridVacunacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			// Capturar lso valores
			eVacunacion.idvacunacion = Convert.ToInt32(gridVacunacion.CurrentRow.Cells[0].Value);
			eVacunacion.idcentro = Convert.ToInt32(gridVacunacion.CurrentRow.Cells[1].Value);
			eVacunacion.idatendido = Convert.ToInt32(gridVacunacion.CurrentRow.Cells[2].Value);
			eVacunacion.atendido = gridVacunacion.CurrentRow.Cells[3].Value.ToString();
			eVacunacion.idresponsable = Convert.ToInt32(gridVacunacion.CurrentRow.Cells[4].Value);
			eVacunacion.idstockvac = Convert.ToInt32(gridVacunacion.CurrentRow.Cells[6].Value);
			eVacunacion.fechahoravac = gridVacunacion.CurrentRow.Cells[7].Value.ToString();
		}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
			// Total de registros
			int totalRegistro = gridVacunacion.Rows.Count;

			if (totalRegistro > 0)
			{
				// Valida selección
				if (eVacunacion.idvacunacion <= 0)
				{
					// Mensaje seleccione
					Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("vacunación", "Por favor seleccione un registro.");
					infoSeleccione.ShowDialog();
				}
				else
				{
					// Preguntar eliminar
					Dialogo.frmAlerta confiEliminar = new Dialogo.frmAlerta("vacunación", "¿Estás seguro eliminar el registro seleccionado?");
					if (confiEliminar.ShowDialog() == DialogResult.OK)
                    {
						// Capturar error al intentar Eliminar
						String error = vacunacion.eliminarVacunacion(eVacunacion.idvacunacion);

						// Mostrar alerta
						if (error != "")
						{
							Dialogo.frmAdvertencia noEliminado = new Dialogo.frmAdvertencia("vacunación", error);
							noEliminado.ShowDialog();
                        }
                        else
                        {
							// Resetear datos
							eVacunacion.idvacunacion = 0;

							//Mostrar mensaje eliminado
							Dialogo.frmInformacion infoEliminado = new Dialogo.frmInformacion("vacunación", "Registro eliminado de forma permanente.");
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
			Dialogo.frmConfirmar confiExportar = new Dialogo.frmConfirmar("Vacunación", "¿Estás seguro de querer exportar todos los registros actuales?");
			if (confiExportar.ShowDialog() == DialogResult.OK)
			{
				// Exportar
				exportarDatosExecel(gridVacunacion);
			}
		}

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
			// Campo
			String campo = "";

			if (cboCamposFiltrar.SelectedIndex == 0)
			{
				campo = "atendido";
			}
			else if (cboCamposFiltrar.SelectedIndex == 1)
			{
				campo = "responsable";
			}

			// Filtrar
			if (cboCamposFiltrar.Text != "")
			{
				dvVacunacion.RowFilter = campo + " LIKE'" + txtFiltrar.Text + "%'";
			}
			else
			{
				Dialogo.frmAdvertencia advertSeleccione = new Dialogo.frmAdvertencia("Vacunación", "Por favor seleccione un elemento de la lista");
				advertSeleccione.ShowDialog();
			}


			// limpiar selección
			if (txtFiltrar.Text == "")
            {
				gridVacunacion.ClearSelection();
            }

			// Total de registros
			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridVacunacion.Rows.Count.ToString();
		}
    }
}
