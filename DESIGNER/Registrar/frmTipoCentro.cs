using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Libreria personal
using BOL;

namespace DESIGNER.Registrar
{
    public partial class frmTipoCentro : Form
    {
        // Logica
        TipoCentroVacunacion tipoCentro = new TipoCentroVacunacion();

        public frmTipoCentro()
        {
            InitializeComponent();
        }

        //Varibles. posicion del mouse
        private int posicion = 0, posicionX, posicionY;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // validar dato
            if (txtTipoCentro.Text == "")
            {
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Tipo de centro vacunación", "Por favor complete el dato");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiRegistrar = new Dialogo.frmConfirmar("Tipo de centro vacunación", "¿Estás seguro de agregar el nuevo tipo de centro?");
                if (confiRegistrar.ShowDialog() == DialogResult.OK)
                {
                    // Proceder a registrar
                    tipoCentro.registrarTipoCentro(txtTipoCentro.Text.Trim());

                    // cerrar formulario
                    this.Close();
                }
            }
        }

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Otorgando valores
            this.posicion = 1;
            this.posicionX = e.X;
            this.posicionY = e.Y;

            // Cambiar color del panel si esta en azul oscuro
            if (pnlDockFull.BackColor == Color.FromArgb(27, 39, 54))
            {
                pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
            }
        }

        private void pnlBarraTop_MouseHover(object sender, EventArgs e)
        {
            // Color celeste
            pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
        }

        private void pnlBarraTop_MouseLeave(object sender, EventArgs e)
        {
            // Color azul oscuro
            pnlDockFull.BackColor = Color.FromArgb(27, 39, 54);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Resetear caja de texto
            txtTipoCentro.Text = "";
        }

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            // Ejecutar 
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
