using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Libreiria personal
using BOL;
using ENTITIES;

namespace DESIGNER.Registrar
{
    public partial class frmStockVacRegistrar : Form
    {
        // Instancia toda la logica d enegocio
        Centro centroVac = new Centro();
        Lote lote = new Lote();
        StockVac stockvac = new StockVac();
        EStockVac eStockvac = new EStockVac();
        

        public frmStockVacRegistrar()
        {
            InitializeComponent();
        }

        // Resetear controles
        private void resetearControles()
        {
            cboCentroVacs.Text = "";
            cboLotes.Text = "";
            txtCantidad.Text = "";
            txtFechaAsignada.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";

            cboLotes.Focus();
        }

        private void frmStockVacRegistrar_Load(object sender, EventArgs e)
        {
            // Cargar datos a las listas cboBox
            // CENTRO DE VACUNACIONES
            cboCentroVacs.DataSource = centroVac.listarCentros();
            cboCentroVacs.DisplayMember = "nombrecentro";
            cboCentroVacs.ValueMember = "idcentrovac";
            cboCentroVacs.Text = "";

            // LOTES
            cboLotes.DataSource = lote.listarLotes();
            cboLotes.DisplayMember = "idlote";
            cboLotes.ValueMember = "idlote";
            cboLotes.Text = "";

            cboLotes.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (cboCentroVacs.Text == "" || cboLotes.Text == "" || txtCantidad.Text == "" || txtFechaAsignada.Text == "" || txtFechaInicio.Text == "" || txtFechaFin.Text == "")
            {
                // Mostrar mensaje. debe completar
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Stock de vacunas", "Por favor complete los campos");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de Confirmación. para prceder a guardar los datos
                Dialogo.frmConfirmar confiRegistrar = new Dialogo.frmConfirmar("Stock de vacunas", "¿Estás seguro de proceder a guardar lso datos?");
                if (confiRegistrar.ShowDialog() == DialogResult.OK)
                {
                    // Proceder a guadar
                    eStockvac.idlote = Convert.ToInt32(cboLotes.SelectedValue.ToString());
                    eStockvac.idcentrovac = Convert.ToInt32(cboCentroVacs.SelectedValue.ToString());
                    eStockvac.fechaasignacion = txtFechaAsignada.Text.Trim();
                    eStockvac.fechainicio = txtFechaInicio.Text.Trim();
                    eStockvac.fechafin = txtFechaFin.Text.Trim();
                    eStockvac.cantidad = Convert.ToInt32(txtCantidad.Text);

                    // Registrar
                    stockvac.registrarStockVacunas(eStockvac);

                    // Resetear controles
                    resetearControles();

                    // Confirmar registro
                    Dialogo.frmInformacion infoRegistrado = new Dialogo.frmInformacion("Stock de vacunas", "Datos registrado correctamente.");
                    infoRegistrado.ShowDialog();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Resetear cajas de textos
            resetearControles();
        }
    }
}
