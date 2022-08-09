using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

// Libreira basado en mi propio proyecto
using BOL;
using ENTITIES;

namespace DESIGNER.Registrar
{
    public partial class frmResponsableRegistrar : Form
    {
        // Objetos que representan la logica de negocio
        DataTable tablaPersona = new DataTable();
        DataView dvPersona;
        Persona persona = new Persona();
        Centro centrovac = new Centro();
        Rol rol = new Rol();
        Responsable responsable = new Responsable();
        EResponsable eResponsable = new EResponsable();

        public frmResponsableRegistrar()
        {
            InitializeComponent();
        }

        // variable global
        private int idpersona = 0;

        // Método para resetear los controles
        private void resetearControles()
        {
            this.idpersona = 0;
            cboCentroVac.Text = "";
            cboRoles.Text = "";
            txtFiltrar.Text = "";

            gridPersonas.ClearSelection();
            cboCentroVac.Focus();
        }

        // Método filtrar datos
        private void filtrarPersonaCampo()
        {
            // Campo
            String campo = "";
            if (cboCamposFiltrar.SelectedIndex == 0)
            {
                campo = "apellidos";
            }
            else if (cboCamposFiltrar.SelectedIndex == 1)
            {
                campo = "nombres";
            }
            else if (cboCamposFiltrar.SelectedIndex == 2)
            {
                campo = "nrodocumento";
            }

            // Filtrar
            if (campo != "")
            {
                dvPersona.RowFilter = campo + " LIKE'" + txtFiltrar.Text + "%'";
            }
            else
            {
                // Mostrar alerta
                Dialogo.frmAdvertencia alertSeleccione = new Dialogo.frmAdvertencia("Responsable", "Debe seleccionar un elemento de la lista FILTRAR PERSONA POR");
                alertSeleccione.ShowDialog();
            }

            // Total de registros encontrados
            lblTotalRegistros.Text = "TOTAL DE REGISTROS: " + gridPersonas.Rows.Count.ToString();

            // Cuando el textBox este vacio
            if (txtFiltrar.Text == "")
            {
                gridPersonas.ClearSelection();
            }
        }

        private void frmResponsableRegistrar_Load(object sender, EventArgs e)
        {
            // DATOS DEL GRID VIEW
            // Tabla toma los datos del método
            tablaPersona = persona.listarPersonas();

            // El grid Toma los datos de la tabla
            gridPersonas.DataSource = tablaPersona;

            // El dvLote se enlaza con el objeto tabla
            dvPersona = tablaPersona.DefaultView;

            gridPersonas.Columns[0].HeaderText = "ID";
            gridPersonas.Columns[1].HeaderText = "APELLIDOS";
            gridPersonas.Columns[2].HeaderText = "NOMBRES";
            gridPersonas.Columns[3].HeaderText = "TIPO DOCUMENTO";
            gridPersonas.Columns[4].HeaderText = "DOCUMENTO";
            gridPersonas.Columns[5].HeaderText = "TELEFONO";

            gridPersonas.Columns[0].Visible = false;
            gridPersonas.Columns[3].Visible = false;

            lblTotalRegistros.Text = "TOTAL DE REGISTROS: " + gridPersonas.Rows.Count.ToString();
            
            // Cargar datos en los comboBox
            // Centros de vacunaciones
            cboCentroVac.DataSource = centrovac.listarCentros();
            cboCentroVac.DisplayMember = "nombrecentro";
            cboCentroVac.ValueMember = "idcentrovac";
            cboCentroVac.Text = "";

            // Roles
            cboRoles.DataSource = rol.listarRoles();
            cboRoles.DisplayMember = "rol";
            cboRoles.ValueMember = "idrol";
            cboRoles.Text = "";

            // Combo Campos a filtrar
            cboCamposFiltrar.Items.Add("Apellidos");
            cboCamposFiltrar.Items.Add("Nombres");
            cboCamposFiltrar.Items.Add("Documento");
            cboCamposFiltrar.Text = "";

            // SEleccionar
            //cboCentroVac.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // resetear controles
            resetearControles();

            // Solo se ejecuta cuando haya un elemento seleccionado
            if (cboCamposFiltrar.Text != "")
            {
                filtrarPersonaCampo();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar datos de las listas y del grid
            if (cboCentroVac.Text == "" || cboRoles.Text == "" || this.idpersona == 0)
            {
                // Mostrar aviso. debe completar
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Responsable", "Por favor complete los datos.");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiRegistrar = new Dialogo.frmConfirmar("Responsable", "¿Estás seguro de guardar los datos?");
                if (confiRegistrar.ShowDialog() == DialogResult.OK)
                {
                    // Proceder a registrar
                    eResponsable.idcentrovac = Convert.ToInt32(cboCentroVac.SelectedValue);
                    eResponsable.idrol = Convert.ToInt32(cboRoles.SelectedValue);
                    eResponsable.idpersona = this.idpersona;
                    eResponsable.fechalta = "";
                    eResponsable.fechabaja = "";

                    // registrar
                    responsable.registrarResponsable(eResponsable);

                    // Resetear
                    resetearControles();

                    // Mostrar mensaje 
                    Dialogo.frmInformacion infoGuardado = new Dialogo.frmInformacion("Responsable", "Datos guardado correctamente.");
                    infoGuardado.ShowDialog();
                }
            }
        }

        private void gridPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String apellidos;
            String nombres;

            // Obtener el id
            this.idpersona = Convert.ToInt32(gridPersonas.CurrentRow.Cells[0].Value);
            apellidos = gridPersonas.CurrentRow.Cells[1].Value.ToString();
            nombres = gridPersonas.CurrentRow.Cells[2].Value.ToString();

            // Mostrar en el label
            lblPerosnaSeleccionado.Text = apellidos.ToUpper() + " " + nombres.ToUpper();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtrar datos
            filtrarPersonaCampo();
        }
    }
}
