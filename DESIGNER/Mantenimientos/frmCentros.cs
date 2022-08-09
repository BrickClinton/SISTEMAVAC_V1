using System;
using System.Drawing;
using System.Windows.Forms;

// Libreria basada en mi propio proyecto
using BOL;
using ENTITIES;

namespace DESIGNER.Mantenimientos
{
	/// <summary>
	/// Description of frmCentros.
	/// </summary>
	public partial class frmCentros : Form
	{
		// Instancias de las clase que se encuentran dentro de (BOL)
		TipoCentroVacunacion tipocv = new TipoCentroVacunacion();
		Centro centrovac = new Centro();
		ECentro ecentro = new ECentro();
		Ubigeo ubigeo = new Ubigeo();
		
		// Mostrar registros de los centros de vacunación en e dataGrid
		public void actualizarDatos(){
			// El dataGridView toma los datos del método listar
			gridCentroVac.DataSource = centrovac.listarCentros();
			// Refrescar los datos del DataGrid
			gridCentroVac.Refresh();
			
			// Ocultar columna
			gridCentroVac.Columns[0].Visible = false;
			
			// Cambiar texto de la cabecera
			gridCentroVac.Columns[1].HeaderText = "Tipo de centro";
		}
		
		public frmCentros()
		{
			InitializeComponent();
		}
		
		void FrmCentrosLoad(object sender, EventArgs e)
		{
			// Mostrar los centros en el DataGRidView
			actualizarDatos();
			
			
			//Cargamos los datos de los tipos de centros de atención
			cboTipoCentro.DataSource = tipocv.listarTipoCentroVacunacion();	//Asocia el control a un origen de datos
			cboTipoCentro.DisplayMember = "tipocentro"; 					// Valor que se mostrará en el control desplegable
			cboTipoCentro.ValueMember = "idtipocentro";						//Valor que se guardará (FK) durante el proceso
			
			// Limpiar el control desplegable tipocentro
			cboTipoCentro.Text = "";
			
			// Cargar departamentos a iniciar el formulario
			cboDepartamentos.DataSource = ubigeo.listarDepaetamentos();
			cboDepartamentos.DisplayMember = "nombredepartamento";
			cboDepartamentos.ValueMember = "iddepartamento";
			
			// Limpiar el control desplegable departamentos
			cboDepartamentos.Text = "";
		}
		
		void CboDepartamentosSelectedIndexChanged(object sender, EventArgs e)
		{
			// Id del pk
			String iddepartamento = cboDepartamentos.SelectedValue.ToString();
			
			// Mètodo listar provincias
			cboProvincias.DataSource = ubigeo.listarProvincias(iddepartamento);
			cboProvincias.DisplayMember = "nombreprovincia";
			cboProvincias.ValueMember = "idprovincia";
			
			// Limpiar el control desplegable
			cboProvincias.Text = "";
		}
		
		void CboProvinciasSelectedIndexChanged(object sender, EventArgs e)
		{
			// Id de la provincia
			String idprovincia = cboProvincias.SelectedValue.ToString();
			
			// Filtrar por provincias
			cboDistritos.DataSource = ubigeo.listarDistritos(idprovincia);
			cboDistritos.DisplayMember = "nombredistrito";
			cboDistritos.ValueMember = "iddistrito";
			
			// Limpiar el control desplegable
			cboDistritos.Text = "";
		}
		
		void CerrarAplicaciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			// Cerrar app
			Application.Exit();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			// Total de datos que muestra el grid
			int totalFilas = gridCentroVac.Rows.Count;
			
			// Solo si el registro es mayor a 0
			if (totalFilas > 0){
				// Pregunta de confirmación
				if (MessageBox.Show("¿Estás seguro de elimimar el registro?", "Centro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
					// Obteniendo el id del registro
					int idcentrovac = Convert.ToInt32(gridCentroVac.CurrentRow.Cells[0].Value);
					
					// Procede a aliminar
					centrovac.eliminarCentrovac(idcentrovac);
					
					// Actualizar datos del grid
					actualizarDatos();
				}
			}
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
	
			// Instancia el objeto dialogo
			
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
					
			// Validando los datos
			if (cboTipoCentro.Text == "" || cboDistritos.Text == "" || txtNombreCentro.Text == "" || txtDireccion.Text == ""){
				// Mensaje de alerta
				MessageBox.Show("Porfavor complete todos los datos requeridos", "Centro de vacunación", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else{
				// Existen datos
				// Confirmar regitro
				if (MessageBox.Show("¿Está seguro de guardar los datos?", "Centro de vacunación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
					// Capturando datos de las cajas de texto
					int idtipocentro = Convert.ToInt32(cboTipoCentro.SelectedValue.ToString());
					String iddistrito = cboDistritos.SelectedValue.ToString();
					String nombrecentro = txtNombreCentro.Text;
					String direccion = txtDireccion.Text;
					String telefono = txtTelefono.Text;
					
					// Asignando al objeto
					ecentro.idtipocentro = idtipocentro;
					ecentro.iddistrito = iddistrito;
					ecentro.nombrecentro = nombrecentro;
					ecentro.direccion = direccion;
					ecentro.telefono = telefono;
					
					// Con el método registrar procedemoa a enviar los datos al servidor
					centrovac.registrarCentro(ecentro);
					
					// Actualizar datos del gri
					actualizarDatos();
				}
	
			}
		}
		
		void BtnDialogClick(object sender, EventArgs e)
		{
			
		}
	}
}
