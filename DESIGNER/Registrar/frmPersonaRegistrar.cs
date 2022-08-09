using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// libreria personal
using BOL;
using ENTITIES;

namespace DESIGNER.Registrar
{
    public partial class frmPersonaRegistrar : Form
    {
        // Instancias de las clases BOL, EnTITIES
        Persona persona = new Persona();
        EPersona ePersona = new EPersona();

        public frmPersonaRegistrar()
        {
            InitializeComponent();
        }

        // Variable tipo de documento
        private String tipodocumento = "";

        // Método que resetea los controles
        private void resetearControles()
        {
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtNroDocumento.Text = "";
            txtTelefono.Text = "";
            this.tipodocumento = "";

            if (ckDni.Checked == true)
            {
                ckDni.Checked = false;
            }
            else if (ckCarnet.Checked == true)
            {
                ckCarnet.Checked = false;
            }

            txtApellidos.Focus();
        }

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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // validar datos
            if (txtApellidos.Text == "" || txtNombres.Text == "" || this.tipodocumento == ""|| txtNroDocumento.Text == "")
            {
                // Debe completar
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Persona", "Por favor complete todos los campos");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiRegistrar = new Dialogo.frmConfirmar("Persona", "¿Estás seguro de guardar los datos?");
                if (confiRegistrar.ShowDialog() == DialogResult.OK)
                {
                    // Proceder a guardar los datos
                    ePersona.apellidos = txtApellidos.Text.Trim();
                    ePersona.nombres = txtNombres.Text.Trim();
                    ePersona.tipodocumento = tipodocumento;
                    ePersona.nrodocumento = txtNroDocumento.Text;
                    ePersona.telefono = txtTelefono.Text;

                    // Registrar y capturar error
                    String error = persona.registrarPersona(ePersona);

                    // Mostrar el error
                    if (error != "")
                    {
                        // Mostrar error 
                        Dialogo.frmAdvertencia advertErrorRegistrar = new Dialogo.frmAdvertencia("", error);
                        advertErrorRegistrar.ShowDialog();
                    }
                    else
                    {
                        // Resetear controles
                        resetearControles();

                        // Mostrar mensaje de confirmación
                        Dialogo.frmInformacion infoRegistrado = new Dialogo.frmInformacion("Persona", "Datos guardado en la base de datos.");
                        infoRegistrado.ShowDialog();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Resetear controles
            resetearControles();
        }

        private void frmPersonaRegistrar_Load(object sender, EventArgs e)
        {
            // Seleccionar
            txtApellidos.Focus();
        }
    }
}
