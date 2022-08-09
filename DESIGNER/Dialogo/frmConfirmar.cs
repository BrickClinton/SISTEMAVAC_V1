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
    public partial class frmConfirmar : Form
    {
        public frmConfirmar(String titulo, String texto)
        {
            InitializeComponent();
            lblTitulo.Text = titulo.ToUpper().Trim();
            lblTexto.Text = texto.Trim();
        }

        // Variables posicion del mouse
        private int posicion = 0, posicionX, posicionY;

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.posicion == 1)
            {
                this.SetDesktopLocation(MousePosition.X - this.posicionX, MousePosition.Y - this.posicionY);
            }
        }

        private void pnlBarraTop_MouseUp(object sender, MouseEventArgs e)
        {
            this.posicion = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfirmar_Load(object sender, EventArgs e)
        {

            btnAceptar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
        }

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            this.posicion = 1;
            this.posicionX = e.X;
            this.posicionY = e.Y;
        }


    }
}
