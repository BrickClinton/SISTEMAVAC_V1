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

namespace DESIGNER.Reportes
{
    public partial class frmListarRoles : Form
    {
        // Logica de negocio
        Rol rol = new Rol();
        DataTable tablaRol = new DataTable();
        DataView dvRol;

        public frmListarRoles()
        {
            InitializeComponent();
        }

        // variables globales
        private int idrol;
        private String nombrerol;

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

        // Método actuliza el grid
        private void actualizarDatosGrid()
        {
            // Mostrar los datos del método listar en el grid
            gridRoles.DataSource = rol.listarRoles();
            gridRoles.Refresh();
            gridRoles.ClearSelection();
        }

        private void frmListarRoles_Load(object sender, EventArgs e)
        {
            // La tabla toma los datos del método
            tablaRol = rol.listarRoles();

            // El grid toma los datos de la tabla
            gridRoles.DataSource = tablaRol;

            // El dada view se asocia con la tabla
            dvRol = tablaRol.DefaultView;

            gridRoles.Columns[0].HeaderText = "ID ROL";
            gridRoles.Columns[1].HeaderText = "NOMBRE DEL ROL";

            gridRoles.ClearSelection();

            // Total de registros encontrados
            lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridRoles.Rows.Count.ToString();
        }

        private void gridRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener datos
            this.idrol = Convert.ToInt32(gridRoles.CurrentRow.Cells[0].Value);
            this.nombrerol = gridRoles.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Resetear datos
            gridRoles.ClearSelection();
            this.idrol = 0;
            this.nombrerol = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Total registros
            int totalRegistros = gridRoles.Rows.Count;

            if (totalRegistros > 0)
            {
                if (this.idrol <= 0)
                {
                    // Info seleccione
                    Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Rol", "Por favor seleccione un registro.");
                    infoSeleccione.ShowDialog();
                }
                else
                {
                    // Abrir formularios
                    Mantenimientos.frmRolActualizar rolActualizar = new Mantenimientos.frmRolActualizar(this.idrol, this.nombrerol);
                    rolActualizar.ShowDialog();

                    // resetear datos
                    this.idrol = 0;

                    // Actualizar grid
                    actualizarDatosGrid();
                    
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Total registros
            int totalRegistros = gridRoles.Rows.Count;

            if (totalRegistros > 0)
            {
                if (this.idrol <= 0)
                {
                    // Info seleccione
                    Dialogo.frmInformacion infoSeleccione = new Dialogo.frmInformacion("Rol", "Por favor seleccione un registro.");
                    infoSeleccione.ShowDialog();
                }
                else
                {
                    // Preguntar eliminar?
                    Dialogo.frmAlerta confiEliminar = new Dialogo.frmAlerta("Rol", "¿Estás seguro de eliminar el rol?");
                    if (confiEliminar.ShowDialog() == DialogResult.OK)
                    {
                        // Capturar error al intentar Eliminar
                        String error = rol.eliminarRol(this.idrol);

                        // Mostrar alerta
                        if (error != "")
                        {
                            Dialogo.frmAdvertencia noEliminado = new Dialogo.frmAdvertencia("Rol", error);
                            noEliminado.ShowDialog();
                        }
                        else
                        {
                            // resetear datos
                            this.idrol = 0;

                            // Mensaje eliminado
                            Dialogo.frmInformacion infoEliminado = new Dialogo.frmInformacion("Rol", "Rol eliminado correctamnete");
                            infoEliminado.ShowDialog();

                            // Actualizar grid
                            actualizarDatosGrid();
                        }
                    }
                }
            }
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
            // Confimrar exportación
            Dialogo.frmConfirmar confiExportar = new Dialogo.frmConfirmar("Rol", "¿Estás seguro de exportar los datos en formato excel?");
            if (confiExportar.ShowDialog() == DialogResult.OK)
            {
                // Exportar
                exportarDatosExecel(gridRoles);
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            // Filtrar
            dvRol.RowFilter = "rol" + " LIKE'" + txtFiltrar.Text + "%'";

            // Limpiar selección
            if (txtFiltrar.Text == "")
            {
                gridRoles.ClearSelection();
            }

            // Total de registros encontrados
            lblTotalRegistros.Text = "TOTAL DE REGISTROS ENCONTRADOS: " + gridRoles.Rows.Count.ToString();
        }
    }
}
