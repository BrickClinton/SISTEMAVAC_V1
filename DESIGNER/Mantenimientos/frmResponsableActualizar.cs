using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Libreira basado en mi propio proyecto
using BOL;
using ENTITIES;

namespace DESIGNER.Mantenimientos
{
    public partial class frmResponsableActualizar : Form
    {
        // Objetos que representan la logica de negocio
        DataTable tablaPersona = new DataTable();
        DataView dvPersona;
        Persona persona = new Persona();
        Centro centrovac = new Centro();
        Rol rol = new Rol();
        Responsable responsable = new Responsable();
        EResponsable eResponsable = new EResponsable();

        public frmResponsableActualizar(EResponsable eresponsable)
        {
            InitializeComponent();
            this.idcentrovac = eresponsable.idcentrovac;
            this.idpersona = eresponsable.idpersona;
            this.lblPerosnaSeleccionado.Text = eresponsable.persona.ToUpper();
            this.idrol = eresponsable.idrol;
            this.idresponsable = eresponsable.idresponsable;
            txtFechaAlta.Text = eresponsable.fechalta;
            txtFechaBaja.Text = eresponsable.fechabaja;
            
        }

        //Varibles. posicion del mouse
        private int posicion = 0, posicionX, posicionY;
        private int idresponsable;
        private int idcentrovac;
        private int idpersona;
        private int idrol;

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
            // Cerrar
            this.Close();
        }

        private void frmResponsableActualizar_Load(object sender, EventArgs e)
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
            gridPersonas.Columns[5].Visible = false;

            gridPersonas.Columns[1].Visible = false;
            gridPersonas.Columns[2].Visible = false;
            gridPersonas.Columns[4].Visible = false;
            
            gridPersonas.ClearSelection();
            lblTotalRegistros.Text = "TOTAL DE REGISTROS: " + gridPersonas.Rows.Count.ToString();


            // Cargar datos en los comboBox
            // Centros de vacunaciones
            cboCentroVac.DataSource = centrovac.listarCentros();
            cboCentroVac.DisplayMember = "nombrecentro";
            cboCentroVac.ValueMember = "idcentrovac";

            // SEleccionar por su id
            cboCentroVac.SelectedValue = this.idcentrovac;

            // Roles
            cboRoles.DataSource = rol.listarRoles();
            cboRoles.DisplayMember = "rol";
            cboRoles.ValueMember = "idrol";

            // SEleccionar por su id
            cboRoles.SelectedValue = this.idrol;

            // Seleccionar control
            cboCentroVac.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (this.idresponsable == 0 || cboCentroVac.Text == "" || cboRoles.Text == "" || txtFechaAlta.Text == "")
            {
                // Mostrar mensaje
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Responsable", "Por favor complete los datos");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiActualizar = new Dialogo.frmConfirmar("Responsable", "¿Estás seguro de actualizar los datos?");
                if (confiActualizar.ShowDialog() == DialogResult.OK)
                {
                    // capturar lso datos
                    eResponsable.idresponsable = this.idresponsable;
                    eResponsable.idcentrovac = Convert.ToInt32(cboCentroVac.SelectedValue);
                    eResponsable.idrol = Convert.ToInt32(cboRoles.SelectedValue);
                    eResponsable.idpersona = this.idpersona;
                    eResponsable.fechalta = txtFechaAlta.Text;
                    eResponsable.fechabaja = txtFechaBaja.Text;

                    // Actualizar
                    responsable.actualizarResponsable(eResponsable);

                    // Mostrar mensaje
                    Dialogo.frmInformacion infoActualizado = new Dialogo.frmInformacion("Responsable", "Datos actualizados correctamente.");
                    infoActualizado.ShowDialog();

                    // cerrar 
                    this.Close();
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

        private void txtFiltrarDni_KeyUp(object sender, KeyEventArgs e)
        {
            // Filtrar
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtrar
            dvPersona.RowFilter = "nrodocumento" + " LIKE'" + txtFiltrarDni.Text + "%'";

            // Cuando el textBox este vacio
            if (txtFiltrarDni.Text == "")
            {
                gridPersonas.ClearSelection();
            }

            if (gridPersonas.Rows.Count == 0)
            {
                Dialogo.frmAdvertencia noCoincidencia = new Dialogo.frmAdvertencia("Responsable", "No encontramos coincidencia. No existe en la base de datos!");
                noCoincidencia.ShowDialog();
            }

            // Mostrar información en el grid
            gridPersonas.Columns[0].Visible = false;
            gridPersonas.Columns[1].Visible = true;
            gridPersonas.Columns[2].Visible = true;
            gridPersonas.Columns[4].Visible = true;

            // Total de registros encontrados
            lblTotalRegistros.Text = "TOTAL DE REGISTROS: " + gridPersonas.Rows.Count.ToString();
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
