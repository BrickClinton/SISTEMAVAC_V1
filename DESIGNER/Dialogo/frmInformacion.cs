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
    public partial class frmInformacion : Form
    {
        public frmInformacion(String titulo, String texto)
        {
            InitializeComponent();
            lblTitulo.Text = titulo.Trim().ToUpper();
            lblTexto.Text = texto.Trim();
        }

        // Posiciones del formulario
        private int posicion = 0, posicionX, posicionY;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Dando Valores
            this.posicion = 1;
            this.posicionX = e.X;
            this.posicionY = e.Y;
        }

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.posicion == 1)
            {
                this.SetDesktopLocation(MousePosition.X - posicionX, MousePosition.Y - posicionY);
            }
        }

        private void pnlBarraTop_MouseUp(object sender, MouseEventArgs e)
        {
            // Resetear valor
            this.posicion = 0;
        }
    }
}
