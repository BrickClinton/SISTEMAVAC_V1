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
    public partial class frmLaboratorioRegistrar : Form
    {
        // Instancia de toda la logica de negocio(BOL)
        Laboratorio laboratorio = new Laboratorio();

        public frmLaboratorioRegistrar()
        {
            InitializeComponent();
            txtNomLaboratorio.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar datos de los texBox
            if (txtNomLaboratorio.Text == "" || txtPais.Text == "")
            {
                // Mostrar información (debe completar las cajas de texto)
                Dialogo.frmInformacion informarDatosIncompleto = new Dialogo.frmInformacion("Aviso", "Por favor complete los dos cuadros de texto.");
                informarDatosIncompleto.ShowDialog();
            }
            else
            {
                // Preguntar para confirmar registro
                Dialogo.frmConfirmar confirmarRegistro = new Dialogo.frmConfirmar("Confirmar", "¿Estás seguro de guardar un nuevo registro de laboratorio?");
                if (confirmarRegistro.ShowDialog() == DialogResult.OK)
                {
                    String nomLaboratorio = txtNomLaboratorio.Text.Trim();
                    String pais = txtPais.Text.Trim();

                    // Proceder a registrar los datos
                    laboratorio.registrarLaboratorio(nomLaboratorio, pais);

                    // Resetar las cajas de textos
                    txtNomLaboratorio.Text = null;
                    txtPais.Text = null;

                    // Seleccionar la primera caja de texto
                    txtNomLaboratorio.PlaceholderText = "";
                    txtNomLaboratorio.Focus();

                    // informar que el registro se realizo correctamente
                    Dialogo.frmInformacion informarDatosGuardado = new Dialogo.frmInformacion("Registro", "Guardado correctamente en la Base de Datos.");
                    informarDatosGuardado.ShowDialog();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Restear las cajas de textos
            txtNomLaboratorio.Text = null;
            txtPais.Text = null;
            txtNomLaboratorio.PlaceholderText = "";
            txtNomLaboratorio.Focus();
        }

        private void frmLaboratorioRegistrar_Load(object sender, EventArgs e)
        {
            // Selección automatica
            txtNomLaboratorio.Focus();
        }
    }
}
