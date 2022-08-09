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
    public partial class frmAlerta : Form
    {
        public frmAlerta(String titulo, String texto)
        {
            InitializeComponent();
            lblTitulo.Text = titulo.Trim().ToUpper();
            lblTexto.Text = texto.Trim();
        }

        // Posiciones
        private int posicion = 0, posicionX, posicionY;

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.posicion == 1)
            {
                this.SetDesktopLocation(MousePosition.X - posicionX, MousePosition.Y - posicionY);
            }
        }

        private void pnlBarraTop_MouseUp(object sender, MouseEventArgs e)
        {
            // Resetear posicion
            this.posicion = 0;
        }

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Valores necesarios
            this.posicion = 1;
            this.posicionX = e.X;
            this.posicionY = e.Y;

            // Cambiar de color de fondo
            if (pnlDockFull.BackColor == Color.FromArgb(146, 35, 32))
            {
                pnlDockFull.BackColor = Color.FromArgb(146, 35, 32);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
