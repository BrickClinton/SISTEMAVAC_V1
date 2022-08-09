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
    public partial class frmStockVacActualizar : Form
    {
        // Instancia toda la logica de negocio BOL
        Centro centroVac = new Centro();
        Lote lote = new Lote();
        StockVac stockvac = new StockVac();
        EStockVac eStockvac = new EStockVac();

        public frmStockVacActualizar(EStockVac estockvac)
        {
            InitializeComponent();
            this.idlote = estockvac.idlote;
            this.idcentrovac = estockvac.idcentrovac;
            this.idstock = estockvac.idstockvac;
            txtFechaAsignada.Text = estockvac.fechaasignacion;
            txtCantidad.Text = estockvac.cantidad.ToString();
            txtFechaInicio.Text = estockvac.fechainicio;
            txtFechaFin.Text = estockvac.fechafin;
        }

        // Variables. posicion del mouse
        private int posicion = 0, posicionX, posicionY;
        // VARIABLES ID LOTE, ID CENTROVAC. ID STOCK
        private int idlote;
        private int idcentrovac;
        private int idstock = 0;

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Otorgando valores
            posicion = 1;
            posicionX = e.X;
            posicionY = e.Y;

            // color de fondo
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

        private void frmStockVacActualizar_Load(object sender, EventArgs e)
        {
            // CENTRO DE VACUNACIONES
            cboCentroVacs.DataSource = centroVac.listarCentros();
            cboCentroVacs.DisplayMember = "nombrecentro";
            cboCentroVacs.ValueMember = "idcentrovac";

            // Seleccionar por su id
            cboCentroVacs.SelectedValue = this.idcentrovac;

            // LOTES
            cboLotes.DataSource = lote.listarLotes();
            cboLotes.DisplayMember = "idlote";
            cboLotes.ValueMember = "idlote";

            // Seleccionar por su id
            cboLotes.SelectedValue = this.idlote;

            cboLotes.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar id
            if (this.idstock > 0)
            {
                // Validar datos
                if (cboCentroVacs.Text == "" || cboLotes.Text == "" || txtFechaAsignada.Text == "" || txtCantidad.Text == "" || txtFechaInicio.Text == "" || txtFechaFin.Text == "")
                {
                    // MOstrar mensaje. complete
                    Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Stock de vacunas", "Por favor complete los datos");
                    infoComplete.ShowDialog();
                }
                else
                {
                    // Pregunta de confirmación
                    Dialogo.frmConfirmar confiActualizar = new Dialogo.frmConfirmar("Stock de vacunas", "¿Estás seguro de actualizar los datos del registro?");
                    if (confiActualizar.ShowDialog() == DialogResult.OK)
                    {
                        // Obteniendo los valores
                        eStockvac.idstockvac = this.idstock;
                        eStockvac.idcentrovac = Convert.ToInt32(cboCentroVacs.SelectedValue);
                        eStockvac.idlote = Convert.ToInt32(cboLotes.SelectedValue);
                        eStockvac.fechaasignacion = txtFechaAsignada.Text;
                        eStockvac.cantidad = Convert.ToInt32(txtCantidad.Text);
                        eStockvac.fechainicio = txtFechaInicio.Text;
                        eStockvac.fechafin = txtFechaFin.Text;

                        // Actualizar
                        stockvac.actualizarStockVacunas(eStockvac);

                        // Mensaje
                        Dialogo.frmInformacion infoActualizado = new Dialogo.frmInformacion("Stock de vacunas", "Registro actualizado correctamente.");
                        infoActualizado.ShowDialog();

                        // Cerrar
                        this.Close();
                    }
                }
            }
        }

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            // Ejecutar
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
