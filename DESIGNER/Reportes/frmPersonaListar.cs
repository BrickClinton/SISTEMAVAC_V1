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

// Libreria personal
using BOL;
using ENTITIES;

namespace DESIGNER.Reportes
{
    public partial class frmPersonaListar : Form
    {
        // Logica de negocio
        Persona persona = new Persona();
        EPersona epersona = new EPersona();

        DataTable tablaPersona = new DataTable();
        DataView dvPersona;

        // Método actualizar datos grid
        private void actualizarDatosGrid()
        {
            // Tabla toma los datos del método
            tablaPersona = persona.listarPersonas();

            // El grid Toma los datos de la tabla
            gridPersonas.DataSource = tablaPersona;
            gridPersonas.ClearSelection();
        }

        public frmPersonaListar()
        {
            InitializeComponent();
        }

        // Método utilizado para exportar datos en formato excel
        public void exportarDatosExecel(DataGridView datos)
        {
            // Instancia de la clase aplicación
            Microsoft.Office.Interop.Excel.Application exportaExcel = new Microsoft.Office.Interop.Excel.Application();

            // Indicar que creareamos un nuevo libro
            exportaExcel.Application.Workbooks.Add(true);

            // Leer las columnas
            int indexColumn = 0;

            // Recorrer el dataGrid
            foreach (DataGridViewColumn columna in datos.Columns)
            {
                // Aumentar indice
                indexColumn++;

                // leer nombres de todas las columnas
                exportaExcel.Cells[1, indexColumn] = columna.Name;
            }

            // Leer las filas
            int indexFila = 0;
            foreach (DataGridViewRow fila in datos.Rows)
            {
                // Aumentar en 1
                indexFila++;
                indexColumn = 0;

                foreach (DataGridViewColumn columna in datos.Columns)
                {
                    // Aumentar
                    indexColumn++;
                    exportaExcel.Cells[indexFila + 1, indexColumn] = fila.Cells[columna.Name].Value;
                }

            }

            exportaExcel.Visible = true;
        }

        private void frmPersonaListar_Load(object sender, EventArgs e)
        {
            // Tabla toma los datos del método
            tablaPersona = persona.listarPersonas();

            // El grid Toma los datos de la tabla
            gridPersonas.DataSource = tablaPersona;

            // El dvLote se enlaza con el objeto tabla
            dvPersona = tablaPersona.DefaultView;

            gridPersonas.Columns[0].Visible = false;

            gridPersonas.Columns[0].HeaderText = "ID";
            gridPersonas.Columns[1].HeaderText = "APELLIDOS";
            gridPersonas.Columns[2].HeaderText = "NOMBRES";
            gridPersonas.Columns[3].HeaderText = "TIPO DOCUMENTO";
            gridPersonas.Columns[4].HeaderText = "N° DOCUMENTO";
            gridPersonas.Columns[5].HeaderText = "TELEFONO";

            // Total de registros
            lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridPersonas.Rows.Count.ToString();

            // Combo filtrar
            cboCamposFiltrar.Items.Add("Apellidos");
            cboCamposFiltrar.Items.Add("Nombres");
            cboCamposFiltrar.Items.Add("Tipo de docuemnto");
            cboCamposFiltrar.Items.Add("número de documento");
            cboCamposFiltrar.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int totalRegistros = gridPersonas.Rows.Count;
            if (totalRegistros > 0)
            {
                if (epersona.idpersona < 1)
                {
                    // Mensajje seleccione
                    Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Persona", "Por favor seleccione un registro");
                    infoSeleccione.ShowDialog();
                }
                else
                {
                    // Abrir formulario
                    Mantenimientos.frmPersonaActualizar personaActualizar = new Mantenimientos.frmPersonaActualizar(epersona);
                    personaActualizar.ShowDialog();

                    // Recetear datos
                    epersona.idpersona = 0;

                    // Actualizar datos
                    actualizarDatosGrid();
                }
            }
        }

        private void gridPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obteniendo los valores
            epersona.idpersona = Convert.ToInt32(gridPersonas.CurrentRow.Cells[0].Value);
            epersona.apellidos = gridPersonas.CurrentRow.Cells[1].Value.ToString();
            epersona.nombres = gridPersonas.CurrentRow.Cells[2].Value.ToString();
            epersona.tipodocumento = gridPersonas.CurrentRow.Cells[3].Value.ToString();
            epersona.nrodocumento = gridPersonas.CurrentRow.Cells[4].Value.ToString();
            epersona.telefono = gridPersonas.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Resetear valores
            gridPersonas.ClearSelection();
            epersona.idpersona = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int totalRegistros = gridPersonas.Rows.Count;
            if (totalRegistros > 0)
            {
                if (epersona.idpersona < 1)
                {
                    // Mensajje seleccione
                    Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Persona", "Por favor seleccione un registro");
                    infoSeleccione.ShowDialog();
                }
                else
                {
                    // Preguntar para eliminar
                    Dialogo.frmAlerta confiEliminar = new Dialogo.frmAlerta("Persona", "¿Estás seguro de eliminar el registro seleccionado?");
                    if (confiEliminar.ShowDialog() == DialogResult.OK)
                    {
                        // Capturar error al intentar Eliminar
                        String error = persona.eliminarPerosna(epersona.idpersona);

                        // Mostrar alerta
                        if (error != "")
                        {
                            Dialogo.frmAdvertencia noEliminado = new Dialogo.frmAdvertencia("Persona", error);
                            noEliminado.ShowDialog();
                        }
                        else
                        {
                            // Recetear datos
                            epersona.idpersona = 0;

                            // Mostrar mensaje eliminadp
                            Dialogo.frmInformacion infoEliminado = new Dialogo.frmInformacion("Persona", "Registro eliminado correctamente.");
                            infoEliminado.ShowDialog();

                            // Actualizar datos
                            actualizarDatosGrid();
                        }
                    }
                }
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
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
            else if(cboCamposFiltrar.SelectedIndex == 2)
            {
                campo = "tipodocumento";
            }
            else if (cboCamposFiltrar.SelectedIndex == 3)
            {
                campo = "nrodocumento";
            }

            // Filtrar d
            if (campo != "")
            {
                dvPersona.RowFilter = campo + " LIKE'" + txtFiltrar.Text + "%'";
            }
            else
            {
                // Mostrar alerta
                Dialogo.frmAdvertencia alertSeleccione = new Dialogo.frmAdvertencia("Laboratorio", "Por favor seleccione un elemento de la lista");
                alertSeleccione.ShowDialog();
            }
            

            // Limpiar
            if (txtFiltrar.Text == "")
            {
                gridPersonas.ClearSelection();
            }

            // Total de registros
            lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridPersonas.Rows.Count.ToString();
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
            // Confimrar exportación
            Dialogo.frmConfirmar confiExportar = new Dialogo.frmConfirmar("Persona", "¿Estás seguro de exportar los datos en formato excel?");
            if (confiExportar.ShowDialog() == DialogResult.OK)
            {
                // Exportar
                exportarDatosExecel(gridPersonas);
            }
        }
    }
}
