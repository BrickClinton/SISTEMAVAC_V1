using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// LIbreria personal
using BOL;
using ENTITIES;

namespace DESIGNER.Mantenimientos
{
    public partial class frmLoteActualizar : Form
    {
        // Instancias 
        Laboratorio laboratorio = new Laboratorio();
        Lote lote = new Lote();
        ELote eLote = new ELote();
        DataTable tablaLaboratorio = new DataTable();
        DataView dvLaboratorio;

        public frmLoteActualizar(ELote eLote)
        {
            InitializeComponent();
            // Datos mostrados en las cajas
            this.idlote = eLote.idlote;
            this.idlaboratorio = eLote.idlaboratorio;
            txtFechaEntrada.Text = eLote.fechaentrada;
            txtCantidad.Text = eLote.cantidad.ToString();

            

            // Color de fondo celeste
            pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
        }

        // Id lote global
        private int idlote = 0;
        private int idlaboratorio = 0;

        // Posiciones del mouse
        private int posicion = 0, posicionX, posicionY;

        private void frmLoteActualizar_Load(object sender, EventArgs e)
        {
            // Cargar datos laboratorios
            cboLaboratorios.DataSource = laboratorio.listarLaboratorios();
            cboLaboratorios.DisplayMember = "laboratorio";
            cboLaboratorios.ValueMember = "idlaboratorio";
            //cboLaboratorios.Text = "";

            // Filtrar por su ID
            cboLaboratorios.SelectedValue = this.idlaboratorio;
        }

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Valores de las variabkes
            this.posicion = 1;
            this.posicionX = e.X;
            this.posicionY = e.Y;

            // Cambiar color del panel si esta en azul oscuro
            if (pnlDockFull.BackColor == Color.FromArgb(27, 39, 54))
            {
                pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar formulario
            this.Close();
        }

        private void pnlBarraTop_MouseHover(object sender, EventArgs e)
        {
            // Color de fondo celeste
            pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
        }

        private void pnlBarraTop_MouseLeave(object sender, EventArgs e)
        {
            // color azul oscuro
            pnlDockFull.BackColor = Color.FromArgb(27, 39, 54);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar datos 
            if (cboLaboratorios.Text == "" || txtFechaEntrada.Text == "" || txtCantidad.Text == "")
            {
                // Mostrar mensaje. complete
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Lote", "Por favor complete los campos");
                infoComplete.ShowDialog();
            }
            else
            {
                // pregunta de confimración
                Dialogo.frmConfirmar confiActualizar = new Dialogo.frmConfirmar("Lote", "¿Estás seguro de actualizar los datos?");
                if (confiActualizar.ShowDialog() == DialogResult.OK)
                {
                    // Proceder a actualizar los datos
                    eLote.idlote = this.idlote;
                    eLote.idlaboratorio = Convert.ToInt32(cboLaboratorios.SelectedValue);
                    eLote.fechaentrada = txtFechaEntrada.Text;
                    eLote.cantidad = Convert.ToInt32(txtCantidad.Text.Trim());

                    // Actualizar
                    lote.metodosCUD("actualizar", eLote);

                    // Mostrar mensaje actualizado
                    Dialogo.frmInformacion infoActualizado = new Dialogo.frmInformacion("Lote", "Datos actualizados correctamente.");
                    infoActualizado.ShowDialog();

                    // Cerrar ventana
                    this.Close();
                } 
            }
        }

        private void pnlBarraTop_MouseMove(object sender, MouseEventArgs e)
        {
            // Ejecutar cuando el valor de posicion es 1
            if (this.posicion == 1)
            {
                this.SetDesktopLocation(MousePosition.X - this.posicionX, MousePosition.Y - this.posicionY);
            }
        }

        private void pnlBarraTop_MouseUp(object sender, MouseEventArgs e)
        {
            // Resetear valor de las variables
            this.posicion = 0;
        }
    }
}
