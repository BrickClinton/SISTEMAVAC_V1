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

namespace DESIGNER.Registrar
{
    public partial class frmLotesRegistrar : Form
    {
        // Instancia de todo la logica de negocio
        Lote lote = new Lote();
        ELote elote = new ELote();
        Laboratorio laboratorio = new Laboratorio();

        // Instancia de datable dataView
        DataTable tablaLaboratorio = new DataTable();
        DataView dvLaboratorio;

        public frmLotesRegistrar()
        {
            InitializeComponent();
        }

        // idlaboratorio
        private int idlaboratorio = 0;

        // Método para Resetear controles
        private void resetearControles()
        {
            // Resetear todo loscontroles
            gridLaboratorio.ClearSelection();
            this.idlaboratorio = 0;
            txtNomLaboratorio.Text = null;
            txtFechaEntrada.Text = null;
            txtCantidad.Text = null;

            txtFiltrarLaboratorio.Focus();
        }

        private void frmLotesRegistrar_Load(object sender, EventArgs e)
        {
            // Tabla toma los datos del método
            tablaLaboratorio = laboratorio.listarLaboratorios();

            // El grid Toma los datos de la tabla
            gridLaboratorio.DataSource = tablaLaboratorio;

            // El dvLote se enlaza con el objeto tabla
            dvLaboratorio = tablaLaboratorio.DefaultView;

            gridLaboratorio.Columns[0].Visible = false;
            gridLaboratorio.Columns[2].Visible = false;

            gridLaboratorio.Columns[1].Width = 370;
            gridLaboratorio.Columns[1].HeaderText = "LABORATORIO";

            gridLaboratorio.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(55, 69, 93);
            gridLaboratorio.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(218, 221, 245);
            gridLaboratorio.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            gridLaboratorio.ClearSelection();

            lblTotalLaboratorio.Text = "TOTAL DE REGISTROS: " + gridLaboratorio.Rows.Count.ToString();

            // SEleccionar
            txtFiltrarLaboratorio.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Resetear todo loscontroles
            resetearControles();
        }

        private void gridLaboratorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalRegistro = gridLaboratorio.Rows.Count;
            if (totalRegistro > 0)
            {
                this.idlaboratorio = Convert.ToInt32(gridLaboratorio.CurrentRow.Cells[0].Value);
                txtNomLaboratorio.Text = gridLaboratorio.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void bunifuTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // Filtrar
            dvLaboratorio.RowFilter = "laboratorio LIKE'" + txtFiltrarLaboratorio.Text + "%'";

            // Contar registros
            lblTotalLaboratorio.Text = "TOTAL DE REGISTROS: " + gridLaboratorio.Rows.Count.ToString();

            // Limpiar selección
            if (txtFiltrarLaboratorio.Text == "")
            {
                gridLaboratorio.ClearSelection();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar todos los campos
            if (txtNomLaboratorio.Text == "" || txtFechaEntrada.Text == "" || txtCantidad.Text == "" || this.idlaboratorio == 0)
            {
                // Mostrar información
                Dialogo.frmInformacion inforCompletar = new Dialogo.frmInformacion("Información", "Por favor complete todos los campos");
                inforCompletar.ShowDialog();
            }
            else
            {
                // Confirmar para proceder
                Dialogo.frmConfirmar confiRegistro = new Dialogo.frmConfirmar("Confirmar","¿Estás seguro de guardar el registro?");
                if (confiRegistro.ShowDialog() == DialogResult.OK)
                {
                    // Proceder a guardar el registro
                    elote.idlaboratorio = this.idlaboratorio;
                    elote.fechaentrada = txtFechaEntrada.Text.Trim();
                    elote.cantidad = Convert.ToInt32(txtCantidad.Text.Trim());

                    // Método reistrar
                    lote.metodosCUD("registrar", elote);

                    // Resetear controles
                    resetearControles();

                    // Mostrar información
                    Dialogo.frmInformacion inforRegistrado = new Dialogo.frmInformacion("Registrado", "Datos guardado con éxito.");
                    inforRegistrado.ShowDialog();
                }
            }
        }
    }
}
