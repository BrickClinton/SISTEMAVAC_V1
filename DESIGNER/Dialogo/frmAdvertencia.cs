using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Dialogo
{
    public partial class frmAdvertencia : Form
    {
        public frmAdvertencia(String titulo, String texto)
        {
            InitializeComponent();
            lblTitulo.Text = titulo.Trim().ToUpper();
            lblTexto.Text = texto.Trim();
        }

        // Posicion
        private int posicion = 0, posicionX, posicionY;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // cerar
            this.Close();
        }

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Valores
            this.posicion = 1;
            this.posicionX = e.X;
            this.posicionY = e.Y;
        }

        private void frmAdvertencia_MouseHover(object sender, EventArgs e)
        {
            // Sobre el formulario
            pnlDockFull.Visible = false;
        }

        private void frmAdvertencia_MouseLeave(object sender, EventArgs e)
        {
            // Al salir de la posicion
            pnlDockFull.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            // Maximizar
            //this.WindowState = FormWindowState.Maximized;
            frmAdvertencia.ActiveForm.Size = new Size(800, 400);

            // Ocultar btnMaximizar
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            // Restaurar
            //this.WindowState = FormWindowState.Normal;
            frmAdvertencia.ActiveForm.Size = new Size(683, 306);

            // ocultar boton
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            //
            if (posicion == 1)
            {
                this.SetDesktopLocation(MousePosition.X - this.posicionX, MousePosition.Y - this.posicionY);
            }
        }

        private void pnlBarraTop_MouseUp(object sender, MouseEventArgs e)
        {
            // Restaurar
            this.posicion = 0;
        }
    }
}
