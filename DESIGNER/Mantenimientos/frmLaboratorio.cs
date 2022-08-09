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
    public partial class frmLaboratorio : Form
    {
        // Logica de negocio
        Laboratorio laboratorio = new Laboratorio();

        public frmLaboratorio(int idlaboratorio, String laboratorio, String pais)
        {
            InitializeComponent();
            this.idlaboratorio = idlaboratorio;
            txtNomLaboratorio.Text = laboratorio;
            txtPais.Text = pais;
        }
        // Variable de alcanse global
        private int idlaboratorio = -1;

        // Posicion del mouse
        private int posicion = 0, posicionX, posicionY;

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Valores de las variables
            posicion = 1;
            posicionX = e.X;
            posicionY = e.Y;

            // Cambiar color del panel si esta en azul oscuro
            if (pnlDockFull.BackColor == Color.FromArgb(27, 39, 54))
            {
                pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
            }
        }

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            // Mover
            if (posicion == 1)
            {
                this.SetDesktopLocation(MousePosition.X - posicionX, MousePosition.Y - posicionY);
            }
        }

        private void pnlBarraTop_MouseUp(object sender, MouseEventArgs e)
        {
            // Resetear valor
            posicion = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar app actual
            this.Close();
        }

        private void pnlBarraTop_MouseHover(object sender, EventArgs e)
        {
            // Color celeste
            pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
            
        }

        private void pnlBarraTop_MouseLeave(object sender, EventArgs e)
        {
            // Color azul
            pnlDockFull.BackColor = Color.FromArgb(27, 39, 54);
        }

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (this.idlaboratorio == -1 || txtNomLaboratorio.Text == "" || txtPais.Text == "")
            {
                // Advertencia
                Dialogo.frmAdvertencia advertComplete = new Dialogo.frmAdvertencia("Laboratorio", "Debe completar los datos");
                advertComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiRegistrar = new Dialogo.frmConfirmar("Laboratorio", "¿Estás seguro de actualizar los datos?");
                if (confiRegistrar.ShowDialog() == DialogResult.OK)
                {
                    String nomLaboratorio = txtNomLaboratorio.Text.Trim();
                    String pais = txtPais.Text.Trim();

                    // proceder a actualizar
                    laboratorio.actualizarLaboratorio(nomLaboratorio, pais, idlaboratorio);

                    // Resetear datos

                    // Mostrar infoActualizado
                    Dialogo.frmInformacion infoActualizado = new Dialogo.frmInformacion("Laboratorio", "Datos actualizados correctamente.");
                    infoActualizado.ShowDialog();

                    // Cerrar ventana
                    this.Close();
                }
            }
        }
    }
}
