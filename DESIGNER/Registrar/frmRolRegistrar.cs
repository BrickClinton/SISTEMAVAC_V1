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
    public partial class frmRolRegistrar : Form
    {
        // Logica de negocio
        Rol rol = new Rol();

        public frmRolRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar datos de las cajas de texto
            if (txtNomRol.Text == "")
            {
                // Mostrar mensaje. debe completar la caja
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Rol", "Por favor complete el cuadro de texto.");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiRegistrar = new Dialogo.frmConfirmar("Rol", "¿Estás seguro de guardar el nuevo rol?");
                if (confiRegistrar.ShowDialog() == DialogResult.OK)
                {
                    // Proceder a guardar 
                    rol.registrarRol(txtNomRol.Text.Trim());

                    // Resetear 
                    txtNomRol.Text = "";

                    // Mostrar mensaje de confirmación
                    Dialogo.frmInformacion infoGuardado = new Dialogo.frmInformacion("Rol", "Rol registrado correctamente.");
                    infoGuardado.ShowDialog();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Resetear caja de texto
            txtNomRol.Text = "";
            txtNomRol.Focus();
        }

        private void frmRolRegistrar_Load(object sender, EventArgs e)
        {
            // Seleccionar
            txtNomRol.Focus();
        }
    }
}
