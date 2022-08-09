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
using ENTITIES;

namespace DESIGNER.Mantenimientos
{
    public partial class frmPersonaActualizar : Form
    {
        // Instancias
        Persona persona = new Persona();
        EPersona ePersona = new EPersona();

        public frmPersonaActualizar(EPersona epersona)
        {
            InitializeComponent();
            this.idpersona = epersona.idpersona;
            this.tipodocumento = epersona.tipodocumento;
            txtApellidos.Text = epersona.apellidos;
            txtNombres.Text = epersona.nombres;
            txtNroDocumento.Text = epersona.nrodocumento;
            txtTelefono.Text = epersona.telefono;

            if (this.tipodocumento == "DNI")
            {
                ckCarnet.Checked = false;
                ckDni.Checked = true;
            }
            else if (this.tipodocumento == "CEX")
            {
                ckDni.Checked = false;
                ckCarnet.Checked = true;
            }
        }

        // Variables globales
        private int idpersona;
        private String tipodocumento = "";

        // Valor de la posiciones del mouse
        private int posicion = 0, posicionX, posicionY;

        private void ckDni_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (ckDni.Checked == true)
            {
                ckCarnet.Checked = false;
                tipodocumento = "DNI";
            }
        }

        private void ckCarnet_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (ckCarnet.Checked == true)
            {
                ckDni.Checked = false;
                tipodocumento = "CEX";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (this.idpersona == 0 || this.tipodocumento == "" || txtApellidos.Text == "" || txtNombres.Text == "" || txtNroDocumento.Text == "" || txtTelefono.Text == "")
            {
                // Información completar
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Persona", "Por favor complete los datos");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiActualizar = new Dialogo.frmConfirmar("Persona", "¿Estás seguro de actualizar los datos?");
                if (confiActualizar.ShowDialog() == DialogResult.OK)
                {
                    // Obtener datos
                    ePersona.idpersona = this.idpersona;
                    ePersona.apellidos = txtApellidos.Text.Trim();
                    ePersona.nombres = txtNombres.Text.Trim();
                    ePersona.tipodocumento = this.tipodocumento;
                    ePersona.nrodocumento = txtNroDocumento.Text;
                    ePersona.telefono = txtTelefono.Text;

                    // Actualizar
                    persona.actualizarPersona(ePersona);

                    // Resetear
                    this.idpersona = 0;

                    // Mostrar mensaje
                    Dialogo.frmConfirmar infoActualizado = new Dialogo.frmConfirmar("Persona", "Datos actualizados correctamente.");
                    infoActualizado.ShowDialog();

                    // Cerrar
                    this.Close();
                }
            }
        }

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // otorgando valores
            posicion = 1;
            posicionX = e.X;
            posicionY = e.Y;

            // color de fondo
            if (pnlDockFull.BackColor == Color.FromArgb(27, 39, 54))
            {
                pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
            }
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
            // Color azul oscuro
            pnlDockFull.BackColor = Color.FromArgb(27, 39, 54);
        }

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            // ejecutar acción
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
    }
}
