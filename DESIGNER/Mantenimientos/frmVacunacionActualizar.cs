using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class frmVacunacionActualizar : Form
    {
        // Instancias
        Persona persona = new Persona();
        Responsable responsable = new Responsable();
        Centro centroVac = new Centro();
        StockVac stockVac = new StockVac();
        Vacunacion vacunacion = new Vacunacion();
        EVacunacion eVacunacion = new EVacunacion();
        DataTable tablaPersonaAtendido = new DataTable();
        DataView dvPersonaAtendido;

        public frmVacunacionActualizar(EVacunacion evacunacion)
        {
            InitializeComponent();
            this.idatendido = evacunacion.idatendido;
            this.lblPerosnaAtendido.Text = evacunacion.atendido.ToUpper();
            this.idvacunacion = evacunacion.idvacunacion;
            this.idstock = evacunacion.idstockvac;
            this.idresponsable = evacunacion.idresponsable;
            this.idcentro = evacunacion.idcentro;
            txtFechaHoraVac.Text = evacunacion.fechahoravac;

        }

        //Varibles. posicion del mouse
        private int posicion = 0, posicionX, posicionY;
        private int idvacunacion;
        private int idstock;
        private int idcentro;
        private int idresponsable;
        private int idatendido;

        // Capturar solo una parte de la cadena te texto (indicar el texto, cantidad de caracter)
        private String obtenerStringRecortado(String texto, int cantidadCaracter)
        {
            String textoObtenido = "";

            for (int i = 0; i < cantidadCaracter; i++)
            {
                textoObtenido += texto[i];
            }

            return textoObtenido;
        }

        // Mostrar cboResponsables filtrado por centro
        private void filtrarResponsableCentro(int idcentro)
        {
            // Responsables
            cboResponsables.DataSource = responsable.listarPorCentro(idcentro);
            cboResponsables.DisplayMember = "responsable";
            cboResponsables.ValueMember = "idresponsable";
            cboResponsables.Text = "";

            // Mostrar el total de registros encontrados
            lblTotalResponsables.Text = Convert.ToString(cboResponsables.Items.Count);

            // Color del label, estilo negrita.
            if (cboResponsables.Items.Count == 0)
            {
                lblTotalResponsables.ForeColor = Color.Gray;
                lblTotalResponsables.Font = new Font(lblTotalResponsables.Font, FontStyle.Regular);
            }
            else
            {
                lblTotalResponsables.ForeColor = Color.Black;
                lblTotalResponsables.Font = new Font(lblTotalResponsables.Font, FontStyle.Bold);
            }
        }

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Otorgando valores
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
            // Cerar formulario actual
            this.Close();
        }

        private void frmVacunacionActualizar_Load(object sender, EventArgs e)
        {
            // La tabla toma los datos del método
            tablaPersonaAtendido = persona.listarPersonas();

            // El grid toma los datos de la tabla
            gridPersonaAtendido.DataSource = tablaPersonaAtendido;

            // El dada view se asocia con la tabla
            dvPersonaAtendido = tablaPersonaAtendido.DefaultView;

            gridPersonaAtendido.Columns[0].HeaderText = "ID";
            gridPersonaAtendido.Columns[1].HeaderText = "APELLIDOS";
            gridPersonaAtendido.Columns[2].HeaderText = "NOMBRES";
            gridPersonaAtendido.Columns[3].HeaderText = "TIPO DOC";
            gridPersonaAtendido.Columns[4].HeaderText = "DOCUMENTO";
            gridPersonaAtendido.Columns[5].HeaderText = "TELEFONO";

            gridPersonaAtendido.Columns[0].Visible = false;
            gridPersonaAtendido.Columns[3].Visible = false;
            gridPersonaAtendido.Columns[5].Visible = false;

            gridPersonaAtendido.Columns[1].Visible = false;
            gridPersonaAtendido.Columns[2].Visible = false;
            gridPersonaAtendido.Columns[4].Visible = false;

            gridPersonaAtendido.ClearSelection();

            // Total de registros encontrados
            lblTotalPersona.Text = "TOTAL DE REGISTROS: " + gridPersonaAtendido.Rows.Count.ToString();

            // Cargar datos en los comboBox
            // Centros de vacunaciones
            cboCentroVac.DataSource = centroVac.listarCentros();
            cboCentroVac.DisplayMember = "nombrecentro";
            cboCentroVac.ValueMember = "idcentrovac";
            // Seleccionar
            cboCentroVac.SelectedValue = this.idcentro;

            // Listas de stock de Vacunas
            cboStockVacunas.DataSource = stockVac.listarStockVacunas();
            cboStockVacunas.DisplayMember = "idstockvac";
            cboStockVacunas.ValueMember = "idstockvac";
            // Seleccionar stock
            cboStockVacunas.SelectedValue = this.idstock;
            
            // Responsables
            cboResponsables.DataSource = responsable.listarPorCentro(this.idcentro);
            cboResponsables.DisplayMember = "responsable";
            cboResponsables.ValueMember = "idresponsable";
            // Seleccionar responsable
            cboResponsables.SelectedValue = this.idresponsable;

            // Mostrar el total de registros encontrados en el combo Responsables
            lblTotalResponsables.Text = Convert.ToString(cboResponsables.Items.Count);
        }

        private void cboCentroVac_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el id
            //String idcentro = cboCentroVac.SelectedValue.ToString();
            //filtrarResponsableCentro(idcentro);

            // Responsables
            /*
            cboResponsables.DataSource = responsable.listarPorCentro(idcentro);
            cboResponsables.DisplayMember = "responsable";
            cboResponsables.ValueMember = "idresponsable";
            cboResponsables.Text = "";
            */

        }

        private void btnFiltrarResponsable_Click(object sender, EventArgs e)
        {
            // Mostrar responsables en el comboBox
            int idcentro = Convert.ToInt32(cboCentroVac.SelectedValue);
            filtrarResponsableCentro(idcentro);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (this.idvacunacion == 0 || cboResponsables.Text == "" || cboStockVacunas.Text == "" || txtFechaHoraVac.Text == "")
            {
                // Mostrar mensaje complete
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Vacunación", "Por favor complete los dtos");
                infoComplete.ShowDialog();
            }
            else
            {
                // Preguntar actualizar
                Dialogo.frmConfirmar confiActualizar = new Dialogo.frmConfirmar("Vacunación", "¿Estás seguro de actualizar los datos?");
                if (confiActualizar.ShowDialog() == DialogResult.OK)
                {
                    // Capturar los datos
                    eVacunacion.idvacunacion = this.idvacunacion;
                    eVacunacion.idatendido = this.idatendido;
                    eVacunacion.idresponsable = Convert.ToInt32(cboResponsables.SelectedValue);
                    eVacunacion.idstockvac = Convert.ToInt32(cboStockVacunas.SelectedValue);
                    eVacunacion.fechahoravac = obtenerStringRecortado(txtFechaHoraVac.Text, 19);

                    // Actualizar
                    vacunacion.actualizarVacunacion(eVacunacion);

                    // Mensaje actualizado
                    Dialogo.frmInformacion infoActualizado = new Dialogo.frmInformacion("Vacunación", "Datos actualziado correctamente.");
                    infoActualizado.ShowDialog();

                    // Cerrar
                    this.Close();
                }
            }
        }

        private void gridPersonaAtendido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String apellidos;
            String nombres;

            // Capturar id persona vacunada
            this.idatendido = Convert.ToInt32(gridPersonaAtendido.CurrentRow.Cells[0].Value);

            apellidos = gridPersonaAtendido.CurrentRow.Cells[1].Value.ToString();
            nombres = gridPersonaAtendido.CurrentRow.Cells[2].Value.ToString();

            // Mostrar en el label
            lblPerosnaAtendido.Text = apellidos.ToUpper() + " " + nombres.ToUpper();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtrar
            dvPersonaAtendido.RowFilter = "nrodocumento" + " LIKE'" + txtFiltrarAtendido.Text + "%'";

            // Cuando el textBox este vacio
            if (txtFiltrarAtendido.Text == "")
            {
                gridPersonaAtendido.ClearSelection();
            }

            if (gridPersonaAtendido.Rows.Count == 0)
            {
                Dialogo.frmAdvertencia noCoincidencia = new Dialogo.frmAdvertencia("Responsable", "No encontramos coincidencia. No existe en la base de datos!");
                noCoincidencia.ShowDialog();
            }

            // Mostrar información en el grid
            gridPersonaAtendido.Columns[0].Visible = false;
            gridPersonaAtendido.Columns[1].Visible = true;
            gridPersonaAtendido.Columns[2].Visible = true;
            gridPersonaAtendido.Columns[4].Visible = true;

            // Total de registros encontrados
            lblTotalPersona.Text = "TOTAL DE REGISTROS: " + gridPersonaAtendido.Rows.Count.ToString();
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
