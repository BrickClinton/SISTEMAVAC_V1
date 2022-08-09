using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DESIGNER.MenuInicio
{
	/// <summary>
	/// Description of fromMenu.
	/// </summary>
	public partial class fromMenu : Form
	{
		public fromMenu()
		{
			InitializeComponent();
			iniciarOcultoSubmenu();
			iniciarAplicacion();
			mostrarSiderBarMenu();
		}

		// Instancia de la clase Form
		private Form formActivo = null;

		// Variables que representan laposicion del formulario y mouse
		private int posicion = 0, posicionX, posicionY;

		// Arrastrar formulario
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		// Método para iniciar oculto submenu
		private void iniciarOcultoSubmenu(){
        	pnlSubmenuCentrovac.Visible = false;
        	pnlSubmenuLaboratorio.Visible = false;
        	pnlSubmenuLote.Visible = false;
        	pnlSubmenuResponsable.Visible = false;
        	pnlSubmenuStockVac.Visible = false;
        	pnlSubmenuVacunacion.Visible = false;
        	pnlSubmenuPersonas.Visible = false;
			pnlSubmenuRol.Visible = false;
        }
        
        // Método para mostrar submenu
        private void mostrarSubemnu(Panel submenu){
        	// Comprovar visivilidad
        	if (submenu.Visible == false){
        		// Ocultar submenu visible
        		ocultarSubmenu();
        		
        		// Mostrar el nuevo submenu
        		submenu.Visible = true;
        	}
        	else{
        		// Si esta visible ocultarlo
        		submenu.Visible = false;
        	}
        }
        
        // Ocultar submenu
        private void ocultarSubmenu(){
        	// Comprobar el panel visible
        	if (pnlSubmenuCentrovac.Visible == true){
        		pnlSubmenuCentrovac.Visible = false;
        	}
        	if (pnlSubmenuLaboratorio.Visible == true){
        		pnlSubmenuLaboratorio.Visible = false;
        	}
        	if (pnlSubmenuLote.Visible == true){
        		pnlSubmenuLote.Visible = false;
        	}
        	if (pnlSubmenuResponsable.Visible == true){
        		pnlSubmenuResponsable.Visible = false;
        	}
        	if (pnlSubmenuStockVac.Visible == true){
        		pnlSubmenuStockVac.Visible = false;
        	}
        	if (pnlSubmenuVacunacion.Visible == true){
        		pnlSubmenuVacunacion.Visible = false;
        	}
        	if (pnlSubmenuPersonas.Visible == true){
        		pnlSubmenuPersonas.Visible = false;
        	}
			if (pnlSubmenuRol.Visible == true)
            {
				pnlSubmenuRol.Visible = false;
            }
        }
        
        // Este metodo permite abrir formulario dentro del panel
        private void abrirFormHija(Form formHija){
        	
        	// Si contiene un control ocultar
        	if (this.formActivo != null){
        		// Cerrar formulario activo
        		this.formActivo.Close();
        	}

			// Cerarr firmulario abierto
			cerrarFormHija();

			this.formActivo = formHija;					// La instancia almacena al objeto formHija
			formHija.TopLevel = false;					// Indicar que no es de nivel superior				
			formHija.FormBorderStyle = FormBorderStyle.None; // Quitar bordes del formulario
			formHija.Dock = DockStyle.Fill; 			// Rellenar todo el panel contenedor
			panelContenedor.Controls.Add(formHija);		// Agregando el formulario a la lista de controles del panel
			panelContenedor.Tag = formHija; 			// Asociar el formulario con el panel contenedor
			formHija.BringToFront();					// Traer al frente
			formHija.Show();							// Mostrar el formulario
        }
		
        // Este método permite cerrar los formularios que se muestran dentro del contenedor
        private void cerrarFormHija(){
        	// Si el panel tiene asociado almenos un control
        	if (this.panelContenedor.Controls.Count > 0){
        		// Comprobar si la instancia tipo Form(formActivo) contiene algun fomulario hijo
        		if (this.formActivo != null){
        			
        			// Eliminar los controles asociados
        			this.panelContenedor.Controls.RemoveAt(0);
        		}
        	}
        }

		// Método para mostrar menu de inicio
		private void mostrarSiderBarMenu()
        {
			// Instancia del formulario presentación
			formPresentacion siderBarMenu = new formPresentacion();

			// Si el panel contenedor tiene controles asociados eliminarlos
			if (panelContenedor.Controls.Count > 0)
            {
				// Eliminando controles asociados
				panelContenedor.Controls.RemoveAt(0);
			}

			// Mostrar presentación
			abrirFormHija(siderBarMenu);
		}
        
		// Método para mostrar ventanan de inicialización
		private void iniciarAplicacion()
        {
			// Si el panel contenedor tiene controles asociados eliminarlos
			if (panelContenedor.Controls.Count > 0)
			{
				// Eliminando controles asociados
				panelContenedor.Controls.RemoveAt(0);
			}

			// Instancia del formulario de inicialización
			MenuInicio.frmIniciarAplicacion iniciarApp = new frmIniciarAplicacion();
			iniciarApp.ShowDialog();


        }
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			// Formulario para salir
			MenuInicio.frmDespedirse salir = new frmDespedirse();
			salir.ShowDialog();

			// Cerrar actual formulario
			//this.Hide();
		}
		
		void BtnMaximizarClick(object sender, EventArgs e)
		{
			// Maximizar
			this.WindowState = FormWindowState.Maximized;
			
			// Ocultar icono de maximizar
			btnMaximizar.Visible = false;
			// Mostrar icono de restaurar
			btnRestaurar.Visible = true;
		}
		
		void BtnMinimizarClick(object sender, EventArgs e)
		{
			// Minimizar fomrulario
			this.WindowState = FormWindowState.Minimized;
			
		}
		
		void BtnRestaurarClick(object sender, EventArgs e)
		{
			// Restaurar formulrio 
			this.WindowState = FormWindowState.Normal;
			
			// Osultar el icono de restaurar
			btnRestaurar.Visible = false;
			// Mostrar Maximizar
			btnMaximizar.Visible = true;
		}
		
		void BarraMenuMouseDown(object sender, MouseEventArgs e)
		{
			// Valor del posicion
			this.posicion = 1;
			this.posicionX = e.X;
			this.posicionY = e.Y;
		}
		
		void BtnCentroVacClick(object sender, EventArgs e)
		{
			// Mostrar submenu
			mostrarSubemnu(pnlSubmenuCentrovac);
			
			// habilitar panel
			//pnlCentroVac.Visible = true;
		}

		void BtnInicioClick(object sender, EventArgs e)
		{
			// Cerrar formulario hijo
			cerrarFormHija();

			// Mostrar sider bar
			mostrarSiderBarMenu();

			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnLaboratorioClick(object sender, EventArgs e)
		{
			// Mostrar submenu
			mostrarSubemnu(pnlSubmenuLaboratorio);
		}
		
		void BtnLoteClick(object sender, EventArgs e)
		{
			// Mostrar submenu
			mostrarSubemnu(pnlSubmenuLote);
		}
		
		void BtnStockVacClick(object sender, EventArgs e)
		{
			// Mostrar submenu
			mostrarSubemnu(pnlSubmenuStockVac);
		}
		
		void BtnVacunacionClick(object sender, EventArgs e)
		{
			// Mostrar submenu
			mostrarSubemnu(pnlSubmenuVacunacion);
		}
		
		void BtnResponsableClick(object sender, EventArgs e)
		{
			// Mostrar submenu
			mostrarSubemnu(pnlSubmenuResponsable);
		}
		
		void BtnVacunadosClick(object sender, EventArgs e)
		{
			// Mostrar submenu
			mostrarSubemnu(pnlSubmenuPersonas);
		}
		
		void BtnListarLaboratorioClick(object sender, EventArgs e)
		{
			// Instancia formulario
			Reportes.frmLaboratorio laboratorioListar = new DESIGNER.Reportes.frmLaboratorio();
			abrirFormHija(laboratorioListar);
			
			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnRegistrarLaboratorioClick(object sender, EventArgs e)
		{
			// Instancia laboratorio regustrar tipo Form
			Registrar.frmLaboratorioRegistrar registrarLaboratorio = new Registrar.frmLaboratorioRegistrar();
			abrirFormHija(registrarLaboratorio);

			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnListarLoteClick(object sender, EventArgs e)
		{
			// Instancia
			Reportes.frmLote loteListar = new DESIGNER.Reportes.frmLote();
			abrirFormHija(loteListar);
			
			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnRegistrarLoteClick(object sender, EventArgs e)
		{
			// Instancia tipoForm
			Registrar.frmLotesRegistrar loteRegistrar = new Registrar.frmLotesRegistrar();
			abrirFormHija(loteRegistrar);

			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnListarCentrovacClick(object sender, EventArgs e)
		{
			// Instancia del formulario
			Reportes.frmCentro centroListar = new DESIGNER.Reportes.frmCentro();
			abrirFormHija(centroListar);
			
			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnRegistrarCentrovacClick(object sender, EventArgs e)
		{
			// Instancia Form
			Registrar.frmCentrovacRegistrar centroVacRegistrar = new Registrar.frmCentrovacRegistrar();
			abrirFormHija(centroVacRegistrar);

			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnListarStockClick(object sender, EventArgs e)
		{
			// Instancia reportes
			Reportes.frmStockVac stockVacListar = new DESIGNER.Reportes.frmStockVac();
			abrirFormHija(stockVacListar);
			
			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnRegistrarStockClick(object sender, EventArgs e)
		{
			// Instancia tipo Form
			Registrar.frmStockVacRegistrar stockVacRegistrar = new Registrar.frmStockVacRegistrar();
			abrirFormHija(stockVacRegistrar);

			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnListarVacunacionClick(object sender, EventArgs e)
		{
			//Instancia
			Reportes.frmVacunacion vacunacionListar = new DESIGNER.Reportes.frmVacunacion();
			abrirFormHija(vacunacionListar);
			
			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnRegistrarVacunacionClick(object sender, EventArgs e)
		{
			Registrar.frmVacunacion vacunacionRegistrar = new Registrar.frmVacunacion();
			abrirFormHija(vacunacionRegistrar);

			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnListarResponsableClick(object sender, EventArgs e)
		{
			// Instancia reportes
			Reportes.frmResponsable responsableListar = new DESIGNER.Reportes.frmResponsable();
			abrirFormHija(responsableListar);
			
			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnRegistrarResponsableClick(object sender, EventArgs e)
		{
			// Formlario para registrar responsables
			Registrar.frmResponsableRegistrar responsableRgistrar = new Registrar.frmResponsableRegistrar();
			abrirFormHija(responsableRgistrar);

			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnListarVacunadosClick(object sender, EventArgs e)
		{
			// instancia formulario
			Reportes.frmPersonaListar personaListar = new Reportes.frmPersonaListar();
			abrirFormHija(personaListar);

			// Ocultar submenu
			ocultarSubmenu();
		}
		
		void BtnRegistrarVacunadoClick(object sender, EventArgs e)
		{
			// Instancia
			Registrar.frmPersonaRegistrar personaRegistrar = new Registrar.frmPersonaRegistrar();
			abrirFormHija(personaRegistrar);

			// Ocultar submenu
			ocultarSubmenu();
		}

        void PctMenuDesplegableClick(object sender, EventArgs e)
		{
			// Condición para mostrar u ocultar
			if (pnlLeftMenu.Width == 250){

				pnlLeftMenu.Visible = false;
				pnlLeftMenu.Width = 70;

				lblTituloLogo.Visible = false;

				bfTOcultarSiderBar.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Mosaic;
				bfTOcultarSiderBar.Interval = 20;
				bfTOcultarSiderBar.Show(pnlLeftMenu);
			}
			else{

				pnlLeftMenu.Visible = false;
				pnlLeftMenu.Width = 250;

				lblTituloLogo.Visible = true;

				bfTMostrarSiderBar.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
				bfTMostrarSiderBar.Interval = 20;
				bfTMostrarSiderBar.Show(pnlLeftMenu);
			}
		}
		
		void FromMenuLoad(object sender, EventArgs e)
		{
			// Incicializar colores de fondo de los panel de la barra de opciones
			pnlCerrar.BackColor = Color.FromArgb(21, 48, 92);
			pnlMaxRes.BackColor = Color.FromArgb(21, 48, 92);
			pnlMInimizar.BackColor = Color.FromArgb(21, 48, 92);
		}
		
		void BtnCerrarMouseHover(object sender, EventArgs e)
		{
			pnlCerrar.BackColor = Color.FromArgb(94, 27, 26);
		}
		
		void BtnCerrarMouseLeave(object sender, EventArgs e)
		{
			pnlCerrar.BackColor = Color.FromArgb(21, 48, 92);
		}
		
		void BtnRestaurarMouseHover(object sender, EventArgs e)
		{
			pnlMaxRes.BackColor = Color.FromArgb(40, 68, 94);
		}
		
		void BtnRestaurarMouseLeave(object sender, EventArgs e)
		{
			pnlMaxRes.BackColor = Color.FromArgb(21, 48, 92);
		}
		
		void BtnMinimizarMouseHover(object sender, EventArgs e)
		{
			pnlMInimizar.BackColor = Color.FromArgb(40, 68, 94);
		}
		
		void BtnMinimizarMouseLeave(object sender, EventArgs e)
		{
			pnlMInimizar.BackColor = Color.FromArgb(21, 48, 92);
		}
		
		void BtnMaximizarMouseHover(object sender, EventArgs e)
		{
			pnlMaxRes.BackColor = Color.FromArgb(40, 68, 94);
		}
		
		void BtnMaximizarMouseLeave(object sender, EventArgs e)
		{
			pnlMaxRes.BackColor = Color.FromArgb(21, 48, 92);
		}
		
		void PnlCerrarMouseHover(object sender, EventArgs e)
		{
			pnlCerrar.BackColor = Color.FromArgb(94, 27, 26);
		}
		
		void PnlCerrarMouseLeave(object sender, EventArgs e)
		{
			pnlCerrar.BackColor = Color.FromArgb(21, 48, 92);
		}
		
		void PnlMaxResMouseHover(object sender, EventArgs e)
		{
			pnlMaxRes.BackColor = Color.FromArgb(40, 68, 94);
		}
		
		void PnlMaxResMouseLeave(object sender, EventArgs e)
		{
			pnlMaxRes.BackColor = Color.FromArgb(21, 48, 92);
		}
		
		void PnlMInimizarMouseHover(object sender, EventArgs e)
		{
			pnlMInimizar.BackColor = Color.FromArgb(40, 68, 94);
		}
		
		void PnlMInimizarMouseLeave(object sender, EventArgs e)
		{
			pnlMInimizar.BackColor = Color.FromArgb(21, 48, 92);
		}

        private void barraMenu_MouseMove(object sender, MouseEventArgs e)
        {
			// Ejecutado cuando la posicon sea 1
			if (this.posicion == 1)
            {
				this.SetDesktopLocation(MousePosition.X - this.posicionX, MousePosition.Y - this.posicionY);
            }
        }

        private void barraMenu_MouseUp(object sender, MouseEventArgs e)
        {
			// Resetear valor
			this.posicion = 0;
        }

        private void btnRol_Click(object sender, EventArgs e)
        {

			// Mostrar submenu
			mostrarSubemnu(pnlSubmenuRol);
        }

        private void cerrarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
			// Formulario para salir
			MenuInicio.frmDespedirse salir = new frmDespedirse();
			salir.ShowDialog();
		}

        private void menuDeInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
			// Cerrar formulario hijo
			cerrarFormHija();

			// Mostrar sider bar
			mostrarSiderBarMenu();
		}

        private void btnListarRoles_Click(object sender, EventArgs e)
        {
			// Formulario con los contenidos de reistros
			Reportes.frmListarRoles rolListar = new Reportes.frmListarRoles();
			abrirFormHija(rolListar);

			// Ocultar submenu
			ocultarSubmenu();
        }

        private void btnRegistrarRol_Click(object sender, EventArgs e)
        {
			// Formulario para registrar un nuevo rol
			Registrar.frmRolRegistrar rolRegistrar = new Registrar.frmRolRegistrar();
			abrirFormHija(rolRegistrar);

			// Ocultar submenu
			ocultarSubmenu();
		}
    }
}
