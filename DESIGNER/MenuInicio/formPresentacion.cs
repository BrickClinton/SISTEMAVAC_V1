using System;
using System.Drawing;
using System.Windows.Forms;

namespace DESIGNER.MenuInicio
{
	/// <summary>
	/// Description of formPresentacion.
	/// </summary>
	public partial class formPresentacion : Form
	{
		public formPresentacion()
		{

			InitializeComponent();
		}

		// Instancia tipo Form
		private Form formActivo = null;

		// Método que permite abrir un formulario dentro del panel contenedor
		private void abrirFormHija(Form formHija)
		{

			// Si contiene un control ocultar
			if (this.formActivo != null)
			{
				// Cerrar formulario activo
				this.formActivo.Close();
			}

			pnlBarraMenuTop.Visible = false;                // Ocultar menu de iconos que se muestra al iniciar
			this.formActivo = formHija;                 // La instancia almacena al objeto formHija
			formHija.TopLevel = false;                  // Indicar que no es de nivel superior				
			formHija.FormBorderStyle = FormBorderStyle.None; // Quitar bordes del formulario
			formHija.Dock = DockStyle.Fill;             // Rellenar todo el panel contenedor
			pnlContenedor.Controls.Add(formHija);     // Agregando el formulario a la lista de controles del panel
			pnlContenedor.Tag = formHija;             // Asociar el formulario con el panel contenedor
			formHija.BringToFront();                    // Traer al frente
			formHija.Show();                            // Mostrar el formulario
		}

		// Método que permite cerrar formularios que son visualizados dentro del panel contenedor
		private void cerrarFormHija()
		{
			// Si el panel tiene asociado almenos un control
			if (this.pnlContenedor.Controls.Count > 0)
			{
				// Comprobar si la instancia tipo Form(formActivo) contiene algun fomulario hijo
				if (this.formActivo != null)
				{
					// Eliminar los controles asociados
					this.pnlContenedor.Controls.RemoveAt(0);
				}
			}
		}

		// Mostrar / ocultar
		private void pctMaxResSider_Click(object sender, EventArgs e)
        {
			// Menu de opciones
			if (bfSideBarMenu.Height >= 587)
            {
				bfSideBarMenu.Visible = false;
				pnlBarraMenuTop.Height = 70;
				bfSideBarMenu.Height = 60;

				pnlHoraFecha.Visible = true;
				bfTOcultarSiderBar.Show(bfSideBarMenu);
            }
            else
            {
				bfSideBarMenu.Visible = false;
				pnlBarraMenuTop.Height = 607;
				//pnlBarraMenuTop.Width = 874;
				bfSideBarMenu.Height = 587;
				//bfSideBarMenu.Width = 854;

				pnlHoraFecha.Visible = false;
				bfTMostrarSiderBar.Show(bfSideBarMenu);
			}
		}

        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
			lblHora.Text = DateTime.Now.ToLongTimeString();
			lblHoraLong.Text = DateTime.Now.ToLongTimeString();

			lblFecha.Text = DateTime.Now.ToLongDateString();
			lblFechaLong.Text = DateTime.Now.ToLongDateString();
		}

        private void pctMusic_Click(object sender, EventArgs e)
        {
			// Abrir programa externo
			//System.Diagnostics.Process.Start(@"C:\Users\cueva\OneDrive\Documentos\SharpDevelop Projects\Reproductor Player mp3\DESIGNER\bin\Debug\DESIGNER.exe");
        }

        private void pctMostrorFull_Click(object sender, EventArgs e)
        {
			// Mostrar inicialización
			Graficos.frmGrafico1 g1 = new Graficos.frmGrafico1();
			g1.ShowDialog();

        }

        private void pctConfiguracion_Click(object sender, EventArgs e)
        {
			// Mensaje de prueba 2
			Dialogo.frmAdvertencia advertencia = new Dialogo.frmAdvertencia("Title", "Hello. good nigth...");
			advertencia.ShowDialog();
        }

        private void bunifuPictureBox9_Click(object sender, EventArgs e)
        {
			// Abrir navegador
			MenuInicio.frmNavegadorWEb navegador = new frmNavegadorWEb();
			abrirFormHija(navegador);
        }
    }
}
