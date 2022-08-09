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
    public partial class frmRolActualizar : Form
    {
        // Instancias
        Rol rol = new Rol();

        public frmRolActualizar(int idrol, String rol)
        {
            InitializeComponent();
            this.idrol = idrol;
            txtNomRol.Text = rol;
        }

        // Varibles
        private int posicion = 0, posicionX, posicionY;
        private int idrol;

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Otorgando valores}
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (this.idrol == 0 || txtNomRol.Text == "")
            {
                // Mostrar mensaje
                Dialogo.frmInformacion infoComplete= new Dialogo.frmInformacion("Rol", "Por favor complete los campos");
                infoComplete.ShowDialog();
            }
            else
            {
                // Preguntar actualizar
                Dialogo.frmConfirmar confiActualizar = new Dialogo.frmConfirmar("Rol", "¿Estás seguro de actualizar el rol?");
                if (confiActualizar.ShowDialog() == DialogResult.OK)
                {
                    // proceder
                    rol.actualizarRol(txtNomRol.Text.Trim(), this.idrol);

                    // Mostrar mensaje
                    // Mostrar mensaje
                    Dialogo.frmInformacion infoActualizado = new Dialogo.frmInformacion("Rol", "Rol actualizado correctamente");
                    infoActualizado.ShowDialog();

                    // cerrar
                    this.Close();
                }
            }
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
