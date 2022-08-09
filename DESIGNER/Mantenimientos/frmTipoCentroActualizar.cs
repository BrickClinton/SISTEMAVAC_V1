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

namespace DESIGNER.Mantenimientos
{
    public partial class frmTipoCentroActualizar : Form
    {
        // Logica de negocio
        TipoCentroVacunacion tipoCentro = new TipoCentroVacunacion();

        public frmTipoCentroActualizar(String tipocentro, int idtipocentro)
        {
            InitializeComponent();
            txtTipoCentro.Text = tipocentro;
            this.idtipocentro = idtipocentro;
        }

        // Variable global
        private int idtipocentro;

        //Varibles. posicion del mouse
        private int posicion = 0, posicionX, posicionY;

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (txtTipoCentro.Text == "" || this.idtipocentro <= 0)
            {
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Tipo de centro vacunación", "Por favor complete el dato");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiActualizar = new Dialogo.frmConfirmar("Tipo de centro vacunación", "¿Estás seguro de actualizar el tipo de centro de vacunación?");
                if (confiActualizar.ShowDialog() == DialogResult.OK)
                {
                    // Proceder actualizar
                    tipoCentro.actualizarTipoCentro(txtTipoCentro.Text.Trim(), this.idtipocentro);

                    // Mensaje actualizado
                    Dialogo.frmInformacion infoActualizado = new Dialogo.frmInformacion("Tipo de centro vacunación", "Tipo de centro de vacunación actualizado");

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
