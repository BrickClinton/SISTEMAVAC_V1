using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

// Libreira personal
using BOL;
using ENTITIES;

namespace DESIGNER.Reportes
{

	public partial class frmStockVac : Form
	{
		// Logica de negocio
		StockVac stockvac = new StockVac();
		EStockVac eStockvac = new EStockVac();
		DataTable tablaStockVac = new DataTable();
		DataView dvStockVac;

		// Método que actualiza los datos del grid
		private void actualizarDatosGrid()
        {
			gridStockVacunas.DataSource = stockvac.listarStockVacunas();
			gridStockVacunas.Refresh();
			gridStockVacunas.ClearSelection();
		}
		
		public frmStockVac()
		{
			InitializeComponent();
		}

		// Variable global
		private int totalRegistro = 0;

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

		void FrmStockVacLoad(object sender, EventArgs e)
		{

			// La tabla toma los datos del método
			tablaStockVac = stockvac.listarStockVacunas();

			// El grid toma los datos de la tabla
			gridStockVacunas.DataSource = tablaStockVac;

			// El dada view se asocia con la tabla
			dvStockVac = tablaStockVac.DefaultView;

			gridStockVacunas.Columns[2].Visible = false;

			gridStockVacunas.Columns[0].HeaderText = "ID STOCK";
			gridStockVacunas.Columns[1].HeaderText = "ID LOTE";
			gridStockVacunas.Columns[2].HeaderText = "ID CENTRO";
			gridStockVacunas.Columns[3].HeaderText = "CENTRO DE VACUNACIÓN";
			gridStockVacunas.Columns[4].HeaderText = "FECHA ASIGNADA";
			gridStockVacunas.Columns[5].HeaderText = "CANTIDAD";
			gridStockVacunas.Columns[6].HeaderText = "FECHA DE INICIO";
			gridStockVacunas.Columns[7].HeaderText = "FECHA FINAL";
			
			gridStockVacunas.Columns[0].Width = 80;
			gridStockVacunas.Columns[1].Width = 80;
			gridStockVacunas.Columns[3].Width = 250;
			gridStockVacunas.Columns[4].Width = 150;
			gridStockVacunas.Columns[5].Width = 100;
			gridStockVacunas.Columns[6].Width = 130;
			gridStockVacunas.Columns[7].Width = 110;

			lblTitulo.Text = lblTitulo.Text.ToUpper();
			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridStockVacunas.Rows.Count.ToString();
		}

        private void gridStockVacunas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			// Capturar valores del registro seleccionado
			eStockvac.idstockvac = Convert.ToInt32(gridStockVacunas.CurrentRow.Cells[0].Value);
			eStockvac.idlote = Convert.ToInt32(gridStockVacunas.CurrentRow.Cells[1].Value);
			eStockvac.idcentrovac = Convert.ToInt32(gridStockVacunas.CurrentRow.Cells[2].Value);
			eStockvac.fechaasignacion = gridStockVacunas.CurrentRow.Cells[4].Value.ToString();
			eStockvac.cantidad = Convert.ToInt32(gridStockVacunas.CurrentRow.Cells[5].Value);
			eStockvac.fechainicio = gridStockVacunas.CurrentRow.Cells[6].Value.ToString();
			eStockvac.fechafin = gridStockVacunas.CurrentRow.Cells[7].Value.ToString();
		}

        private void btnModificar_Click(object sender, EventArgs e)
        {
			// Comprobar datos
			totalRegistro = gridStockVacunas.Rows.Count;

			if (totalRegistro > 0)
            {
				// Validar selección
				if (eStockvac.idstockvac < 1)
                {
					// Mensaje de aviso. seleccione
					Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Stock de vacunas", "Por favor seleccione un registro de la lista.");
					infoSeleccione.ShowDialog();
				}
                else
                {
					// Mostrar en el formulario. para actualizar
					Mantenimientos.frmStockVacActualizar stockActualizar = new Mantenimientos.frmStockVacActualizar(eStockvac);
					stockActualizar.ShowDialog();

					// Resetear datos
					eStockvac.idstockvac = 0;

					// Actualizar grid
					actualizarDatosGrid();
				}
			}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			// Resetear datos
			eStockvac.idstockvac = 0;

			// Resetea selección
			gridStockVacunas.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
			// Comprobar datos
			totalRegistro = gridStockVacunas.Rows.Count;

			if (totalRegistro > 0)
			{
				// Validar selección
				if (eStockvac.idstockvac <= 0)
				{
					// Mensaje de aviso. seleccione
					Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Stock de vacunas", "Por favor seleccione un registro de la lista.");
					infoSeleccione.ShowDialog();
				}
				else
				{
					// Pregunta de confirmación
					Dialogo.frmAlerta confiEliminar = new Dialogo.frmAlerta("Stock de vacunas", "¿Estás seguro de eliminar el registro?. se borraran de la base de datos");
					if (confiEliminar.ShowDialog() == DialogResult.OK)
					{
						// Capturar error al intentar Eliminar
						String error = "";
						error = stockvac.eliminarStockVacunas(eStockvac.idstockvac);

						// Mostrar alerta
						if (error != "")
						{
							Dialogo.frmAdvertencia noEliminado = new Dialogo.frmAdvertencia("Stock de vacunas", error);
							noEliminado.ShowDialog();
                        }
                        else
                        {
							// Resetear datos
							eStockvac.idstockvac = 0;

							// Mostrar mensaje eliminado
							Dialogo.frmInformacion eliminado = new Dialogo.frmInformacion("Stock de vacunas", "Registro eliminado de forma permanente.");
							eliminado.ShowDialog();

							// Actualizar grid
							actualizarDatosGrid();
						}
					}
				}
			}
		}

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
			// Filtrar
			dvStockVac.RowFilter = "nombrecentro" + " LIKE'" + txtFiltrar.Text + "%'";

			// eliminar selección
			if (txtFiltrar.Text == "")
            {
				gridStockVacunas.ClearSelection();
            }

			// Contar registros
			lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridStockVacunas.Rows.Count.ToString();
		}

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
			// Confimrar exportación
			Dialogo.frmConfirmar confiExportar = new Dialogo.frmConfirmar("Stock de vacunas", "¿Estás seguro de exportar los datos en formato excel?");
			if (confiExportar.ShowDialog() == DialogResult.OK)
			{
				// Exportar
				exportarDatosExecel(gridStockVacunas);
			}
		}
    }
}
