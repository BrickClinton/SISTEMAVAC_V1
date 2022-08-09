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

namespace DESIGNER.Registrar
{
    public partial class frmVacunacion : Form
    {
        // Instancia de objetos
        DataTable tablaPersona = new DataTable();
        DataView dvPersona;

        Persona persona = new Persona();
        Responsable responsable = new Responsable();
        Centro centroVac = new Centro();
        StockVac stockVac = new StockVac();
        Vacunacion vacunacion = new Vacunacion();
        EVacunacion eVacunacion = new EVacunacion();

        public frmVacunacion()
        {
            InitializeComponent();
        }

        // Variable de alcanse global
        private int idatendido = 0;

        // Método que resetea todos los campos del formulario
        private void resetearControles()
        {
            this.idatendido = 0;
            cboCamposFiltrarAtendido.Text = "";
            cboResponsables.Text = "";
            cboStockVacunas.Text = "";
            gridPersonaAtendido.ClearSelection();

            cboCamposFiltrarAtendido.Focus();
        }

        // Filtrar registro
        private void filtrarRegistroAtendido()
        {
            String campo = "";
            if (cboCamposFiltrarAtendido.SelectedIndex == 0)
            {
                campo = "apellidos";
            }
            else if (cboCamposFiltrarAtendido.SelectedIndex == 1)
            {
                campo = "nombres";
            }
            else if (cboCamposFiltrarAtendido.SelectedIndex == 2)
            {
                campo = "nrodocumento";
            }

            if (campo != "")
            {
                // Filtrar
                dvPersona.RowFilter = campo + " LIKE'" + txtFiltrarAtendido.Text + "%'";
            }
            else
            {
                Dialogo.frmAdvertencia seleccione = new Dialogo.frmAdvertencia("Responsable", "Seleccione un elemento de la lista FILTRAR POR");
                seleccione.ShowDialog();
            }

            // Cuando el textBox este vacio
            if (txtFiltrarAtendido.Text == "")
            {
                gridPersonaAtendido.ClearSelection();
            }

            // Total de registros encontrados
            lblTotalPersona.Text = "TOTAL DE REGISTROS: " + gridPersonaAtendido.Rows.Count.ToString();

            if (gridPersonaAtendido.Rows.Count == 0)
            {
                Dialogo.frmAdvertencia noCoincidencia = new Dialogo.frmAdvertencia("Responsable", "No encontramos coincidencia. No existe en la base de datos!");
                noCoincidencia.ShowDialog();
            }
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

        private void frmVacunacion_Load(object sender, EventArgs e)
        {
            // Cargar datos en los dataGrid
            // Personas
            tablaPersona = persona.listarPersonas();

            gridPersonaAtendido.DataSource = tablaPersona;

            dvPersona = tablaPersona.DefaultView;

            gridPersonaAtendido.Columns[0].HeaderText = "ID";
            gridPersonaAtendido.Columns[1].HeaderText = "APELLIDOS";
            gridPersonaAtendido.Columns[2].HeaderText = "NOMBRES";
            gridPersonaAtendido.Columns[3].HeaderText = "TIPO DOC";
            gridPersonaAtendido.Columns[4].HeaderText = "N° DOCUMENTO";
            gridPersonaAtendido.Columns[5].HeaderText = "TELEFONO";

            gridPersonaAtendido.Columns[0].Visible = false;
            gridPersonaAtendido.Columns[3].Visible = false;
            gridPersonaAtendido.Columns[5].Visible = false;

            gridPersonaAtendido.ClearSelection();

            // Total de registros encontrados
            lblTotalPersona.Text = "TOTAL DE REGISTROS: " + gridPersonaAtendido.Rows.Count.ToString();

            // Cargar datos en los comboBox
            // Centros de vacunaciones
            cboCentroVac.DataSource = centroVac.listarCentros();
            cboCentroVac.DisplayMember = "nombrecentro";
            cboCentroVac.ValueMember = "idcentrovac";
            cboCentroVac.Text = "";
            
            // Listas de stock de Vacunas
            cboStockVacunas.DataSource = stockVac.listarStockVacunas();
            cboStockVacunas.DisplayMember = "idstockvac";
            cboStockVacunas.ValueMember = "idstockvac";
            cboStockVacunas.Text = "";

            // Campos a fltrar
            cboCamposFiltrarAtendido.Items.Add("Apellidos");
            cboCamposFiltrarAtendido.Items.Add("Nombres");
            cboCamposFiltrarAtendido.Items.Add("N° de documento");
            cboCamposFiltrarAtendido.Text = "";

            // Seleccionar
            cboCamposFiltrarAtendido.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtrar personas por el campo indicado
            filtrarRegistroAtendido();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar los datos
            if (idatendido == 0 || cboResponsables.Text == "" || cboStockVacunas.Text == "")
            {
                // Mostrar informacion. debe compeltar el formulario
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Vacunación", "Por favor complete los campos");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiRegistrar = new Dialogo.frmConfirmar("Vacunación", "¿Estás seguro de guardar los datos?");
                if (confiRegistrar.ShowDialog() == DialogResult.OK)
                {
                    // Proceder a guardar
                    eVacunacion.idatendido = idatendido;
                    eVacunacion.idresponsable = Convert.ToInt32(cboResponsables.SelectedValue);
                    eVacunacion.idstockvac = Convert.ToInt32(cboStockVacunas.SelectedValue);

                    // Registrar
                    vacunacion.registrarVacunacion(eVacunacion);

                    // Resetear
                    resetearControles();

                    // Mensaje confirmar registro
                    Dialogo.frmInformacion infoRegistrado = new Dialogo.frmInformacion("Vacunación", "Datos guardado en la base de datos.");
                    infoRegistrado.ShowDialog();           
                }
            }
            
        }

        private void gridPersonaAtendido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Valor del idatendido
            this.idatendido = Convert.ToInt32(gridPersonaAtendido.CurrentRow.Cells[0].Value);
        }

        private void txtFiltrarAtendido_KeyUp(object sender, KeyEventArgs e)
        {
            // Filtrar
            filtrarRegistroAtendido();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // resetear
            cboCentroVac.Text = "";
            cboResponsables.Text = "";
            cboStockVacunas.Text = "";
            txtFiltrarAtendido.Text = "";

            // Restaurar datos del grid atendido
            if (cboCamposFiltrarAtendido.SelectedIndex == 0 || cboCamposFiltrarAtendido.SelectedIndex == 1 || cboCamposFiltrarAtendido.SelectedIndex == 2)
            {
                filtrarRegistroAtendido();
            }
        }

        private void btnFiltrarResponsable_Click(object sender, EventArgs e)
        {
            // Filtrar por el id de centro de vacunación indicado
            int idcentro = Convert.ToInt32(cboCentroVac.SelectedValue);

            // Solo se ejecutará cuando haya un elemento seleccionado
            if (cboCentroVac.Text != "")
            {
                filtrarResponsableCentro(idcentro);
            }
            else
            {
                // Mostrar mensaje de dialogo
                Dialogo.frmInformacion infoSeleccioneCentro = new Dialogo.frmInformacion("Vacunación", "Por favor seleccione un elemento de la lista.");
                infoSeleccioneCentro.ShowDialog();
            }
        }
    }
}
