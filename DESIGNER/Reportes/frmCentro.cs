using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using BOL;
using ENTITIES;

namespace DESIGNER.Reportes
{
	public partial class frmCentro : Form
	{
		// Instancias
		TipoCentroVacunacion tipoCentro = new TipoCentroVacunacion();
		Centro centrovac = new Centro();
		ECentro ecentro = new ECentro();
		DataTable tablaCentroVac = new DataTable();
		DataView dvCentroVac;

		// Método para Actualizar datos del grid
		private void actualizarDatosGRid()
        {
			gridCentroVac.DataSource = centrovac.listarCentros();
			gridCentroVac.Refresh();
			gridCentroVac.ClearSelection();
		}
		
		public frmCentro()
		{
			InitializeComponent();
		}

		// Id tipo centro
		private int idtipocentro;
		private String nomTipocentro;

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

		// Actualizar tipo de centros
		private void actualizarDatosTipoCentro()
        {
			gridTipoCentro.DataSource = tipoCentro.listarTipoCentroVacunacion();
			gridTipoCentro.Refresh();
			gridTipoCentro.ClearSelection();

			lblTotalRegistroTipoC.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridTipoCentro.Rows.Count.ToString();
		}

		void FrmCentroLoad(object sender, EventArgs e)
		{
			// titulo y subtitulos
			lblTipoCentro.Text = lblTipoCentro.Text.ToUpper();
			lblCentrosVac.Text = lblCentrosVac.Text.ToUpper();

			// Grid Tipo centro
			gridTipoCentro.DataSource = tipoCentro.listarTipoCentroVacunacion();
			gridTipoCentro.Refresh();
			gridTipoCentro.ClearSelection();

			gridTipoCentro.Columns[0].HeaderText = "ID";
			gridTipoCentro.Columns[1].HeaderText = "TIPO DE CENTRO";

			gridTipoCentro.Columns[0].Width = 80;
			gridTipoCentro.Columns[1].Width = 320;

			gridTipoCentro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(54, 71, 91);
			lblTotalRegistroTipoC.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridTipoCentro.Rows.Count.ToString();

			// La tabla toma los datos del método
			tablaCentroVac = centrovac.listarCentros();

			// El grid toma los datos de la tabla
			gridCentroVac.DataSource = tablaCentroVac;

			// El Dada view se asocia con la tabla
			dvCentroVac = tablaCentroVac.DefaultView;
			
			gridCentroVac.Columns[0].HeaderText = "ID CENTROVAC";
			gridCentroVac.Columns[1].HeaderText = "ID TIPO CENTRO";
			gridCentroVac.Columns[2].HeaderText = "TIPO CENTRO";
			gridCentroVac.Columns[3].HeaderText = "NOMBRE CENTRO";
			gridCentroVac.Columns[4].HeaderText = "ID DEPARTAMENTO";
			gridCentroVac.Columns[5].HeaderText = "DEPARTAMENTO";
			gridCentroVac.Columns[6].HeaderText = "ID PROVINCIA";
			gridCentroVac.Columns[7].HeaderText = "PROVINCIA";
			gridCentroVac.Columns[8].HeaderText = "ID DISTRITO";
			gridCentroVac.Columns[9].HeaderText = "DISTRITO";
			gridCentroVac.Columns[10].HeaderText = "DIRECCIÓN";
			gridCentroVac.Columns[11].HeaderText = "TELEFONO";
			
			gridCentroVac.Columns[0].Visible = false;
			gridCentroVac.Columns[1].Visible = false;
			gridCentroVac.Columns[4].Visible = false;
			gridCentroVac.Columns[6].Visible = false;
			gridCentroVac.Columns[8].Visible = false;

			gridCentroVac.Columns[2].Width = 180;
			gridCentroVac.Columns[3].Width = 180;
			gridCentroVac.Columns[5].Width = 180;
			gridCentroVac.Columns[7].Width = 180;
			gridCentroVac.Columns[9].Width = 180;
			gridCentroVac.Columns[10].Width = 180;
			gridCentroVac.Columns[11].Width = 100;
			
			gridCentroVac.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(54, 71, 91);

			// Mostrar total de registros
			lblTotalCentros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridCentroVac.Rows.Count.ToString();

			// Campos a filtrar
			cboCamposFiltrar.Items.Add("Tipo de centro");
			cboCamposFiltrar.Items.Add("Nonmbre del centro de vacunación");
			cboCamposFiltrar.Items.Add("Departamento");
			cboCamposFiltrar.Items.Add("Provincia");
			cboCamposFiltrar.Items.Add("Distrito");
			cboCamposFiltrar.Items.Add("Dirección");
			cboCamposFiltrar.Text = "";
		}

        private void gridCentroVac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			// obtener datos del grid
			ecentro.idcentro = Convert.ToInt32(gridCentroVac.CurrentRow.Cells[0].Value);
			ecentro.idtipocentro = Convert.ToInt32(gridCentroVac.CurrentRow.Cells[1].Value);
			ecentro.nombrecentro = gridCentroVac.CurrentRow.Cells[3].Value.ToString();
			ecentro.iddepartamento = gridCentroVac.CurrentRow.Cells[4].Value.ToString();
			ecentro.idprovincia = gridCentroVac.CurrentRow.Cells[6].Value.ToString();
			ecentro.iddistrito = gridCentroVac.CurrentRow.Cells[8].Value.ToString();
			ecentro.direccion = gridCentroVac.CurrentRow.Cells[10].Value.ToString();
			ecentro.telefono = gridCentroVac.CurrentRow.Cells[11].Value.ToString();
		}

        private void btnModificar_Click(object sender, EventArgs e)
        {
			// Validar id
			if (ecentro.idcentro <= 0)
            {
				// Mostrar mensaje seleccione 
				Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Centro de vacunación", "Por favor seleccione un registro");
				infoSeleccione.ShowDialog();
			}
            else
            {
				// Mostrar formulario de actualización
				Mantenimientos.frmCentrovacActualizar centroActualizar = new Mantenimientos.frmCentrovacActualizar(ecentro);
				centroActualizar.ShowDialog();

				// Resetear id
				ecentro.idcentro = 0;

				// Actualizar grid
				actualizarDatosGRid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			// Resetear seleccion y ID
			gridCentroVac.ClearSelection();
			ecentro.idcentro = 0;
        }

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int totalRegistros = gridCentroVac.Rows.Count;
			if (totalRegistros > 0)
            {
				if (ecentro.idcentro >= 1)
                {
					// Preguntar
					Dialogo.frmAlerta confiEliminar = new Dialogo.frmAlerta("Centro de vacunación", "¿Estás seguro de eliminar el registro. se perderan los datos de forma permanente?");
                    if (confiEliminar.ShowDialog() == DialogResult.OK)
                    {
						// Capturar error de Eliminar
						String error = centrovac.eliminarCentrovac(ecentro.idcentro);

						// Mostrar alerta
						if (error != "")
						{
							Dialogo.frmAdvertencia noEliminado = new Dialogo.frmAdvertencia("Centro de vacunación", error);
							noEliminado.ShowDialog();
                        }
                        else
                        {
							// resetear id
							ecentro.idcentro = 0;

							// Mostrar mensaje
							Dialogo.frmInformacion infoEliminado = new Dialogo.frmInformacion("Centro de vacunación", "Registro eliminado correctamente.");
							infoEliminado.ShowDialog();

							// Actualizar datos
							actualizarDatosGRid();
						}
                    }
				}
                else
                {
					// Mensaje seleccione
					Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Centro de vacunación", "Por favor seleccione un registro de la lista.");
					infoSeleccione.ShowDialog();
				}
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
			// Campo
			String campo = "";

			if (cboCamposFiltrar.SelectedIndex == 0)
            {
				campo = "tipocentro";
            }
			else if (cboCamposFiltrar.SelectedIndex == 1)
            {
				campo = "nombrecentro";
			}
			else if (cboCamposFiltrar.SelectedIndex == 2)
            {
				campo = "departamento";
			}
			else if (cboCamposFiltrar.SelectedIndex == 3)
            {
				campo = "provincia";
			}
			else if (cboCamposFiltrar.SelectedIndex == 4)
            {
				campo = "distrito";
			}
			else if (cboCamposFiltrar.SelectedIndex == 5)
            {
				campo = "direccion";
			}

			// Filtrar datos
			if (campo == "")
            {
				// Mostrar mensaje
				Dialogo.frmAdvertencia infoSeleccione = new Dialogo.frmAdvertencia("Centro de vacunación", "Por favor seleccione un elemento de la lista");
				infoSeleccione.ShowDialog();
            }
            else
            {
				dvCentroVac.RowFilter = campo + " LIKE'" + txtFiltrar.Text + "%'";
			}

			// eliminar selección
			if (txtFiltrar.Text == "")
            {
				gridCentroVac.ClearSelection();
            }

			// Mostrar total de registros
			lblTotalCentros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridCentroVac.Rows.Count.ToString();
		}

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
			// Confimrar exportación
			Dialogo.frmConfirmar confiExportar = new Dialogo.frmConfirmar("Centro de vacunación", "¿Estás seguro de exportar los datos en formato excel?");
			if (confiExportar.ShowDialog() == DialogResult.OK)
			{
				// Exportar
				exportarDatosExecel(gridCentroVac);
			}
		}

        private void btnRegistrarTipoC_Click(object sender, EventArgs e)
        {
			// Mostrar formulario 
			Registrar.frmTipoCentro tipoCentroAgregar = new Registrar.frmTipoCentro();
			tipoCentroAgregar.ShowDialog();

			// Actualizar
			actualizarDatosTipoCentro();
        }

        private void btnModificarTipoC_Click(object sender, EventArgs e)
        {
			// Validar 
			int totalTipos = gridTipoCentro.Rows.Count;
			if (totalTipos > 0)
            {
				if (this.idtipocentro == 0)
                {
					// Mensaje
					Dialogo.frmInformacion infoSelecTipoCentro = new Dialogo.frmInformacion("Tipo de centro vacunación", "Por favor seleccione un registro");
					infoSelecTipoCentro.ShowDialog();
				}
                else
                {
					// Mostrar formulario
					Mantenimientos.frmTipoCentroActualizar tipoCentroActualizar = new Mantenimientos.frmTipoCentroActualizar(this.nomTipocentro, this.idtipocentro);
					tipoCentroActualizar.ShowDialog();

					// Resetear datos
					this.idtipocentro = 0;

					// actualizar datos
					actualizarDatosTipoCentro();
				}
            }
        }

        private void gridTipoCentro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			// Capturar los datos
			this.idtipocentro = Convert.ToInt32(gridTipoCentro.CurrentRow.Cells[0].Value);
			this.nomTipocentro = gridTipoCentro.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEliminarTipoC_Click(object sender, EventArgs e)
        {
			// Validar 
			int totalTipos = gridTipoCentro.Rows.Count;
			if (totalTipos > 0)
			{
				if (this.idtipocentro == 0)
				{
					// Mensaje
					Dialogo.frmInformacion infoSelecTipoCentro = new Dialogo.frmInformacion("Tipo de centro vacunación", "Por favor seleccione un registro");
					infoSelecTipoCentro.ShowDialog();
				}
				else
				{
					// Pregunta de confirmación
					Dialogo.frmAlerta confiEliminar = new Dialogo.frmAlerta("Tipo de centro vacunación", "¿Estás seguro de eliminar el registro?");
					if (confiEliminar.ShowDialog() == DialogResult.OK)
                    {
						// Eliminar y capturar el error
						String error = tipoCentro.eliminarTipoCentro(this.idtipocentro);

						// Mensaje de error
						if (error != "")
                        {
							Dialogo.frmAdvertencia infoError = new Dialogo.frmAdvertencia("Tipo de centro vacunación", error);
							infoError.ShowDialog();
                        }
                        else
                        {
							// Resetear datos
							this.idtipocentro = 0;

							Dialogo.frmInformacion infoEliminado = new Dialogo.frmInformacion("Tipo de centro vacunación", "Eliminado correctamente");
							infoEliminado.ShowDialog();

							// actualizar datos
							actualizarDatosTipoCentro();
						}
					}
				}
			}
		}

        private void btnCancelarTipoC_Click(object sender, EventArgs e)
        {
			// Resetaer id
			this.idtipocentro = 0;
			gridTipoCentro.ClearSelection();
        }
    }
}
