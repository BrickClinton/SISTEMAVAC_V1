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
    public partial class frmCentrovacRegistrar : Form
    {
        // Instancias(Logica)
        TipoCentroVacunacion tipoCentro = new TipoCentroVacunacion();
        Centro centrovac = new Centro();
        ECentro ecentro = new ECentro();
        Ubigeo ubigeo = new Ubigeo();

        public frmCentrovacRegistrar()
        {
            InitializeComponent();
        }

        // Resetear controles
        private void resetearControles()
        {
            cboTipoCentro.Text = "";
            cboDepartamentos.Text = "";
            cboProvincias.Text = "";
            cboDistritos.Text = "";
            txtNombreCentro.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

            cboTipoCentro.Focus();
        }

        private void frmCentrovacRegistrar_Load(object sender, EventArgs e)
        {
            //Cargamos los datos de los tipos de centros de atención en el comboBox
            cboTipoCentro.DataSource = tipoCentro.listarTipoCentroVacunacion(); //Asocia el control a un origen de datos
            cboTipoCentro.DisplayMember = "tipocentro";                     // Valor que se mostrará en el control desplegable
            cboTipoCentro.ValueMember = "idtipocentro";                     //Valor que se guardará (FK) durante el proceso

            // Limpiar el control desplegable tipocentro
            cboTipoCentro.Text = "";

            // Cargar los departamentos al iniciar el formulario
            cboDepartamentos.DataSource = ubigeo.listarDepaetamentos();
            cboDepartamentos.DisplayMember = "departamento";
            cboDepartamentos.ValueMember = "iddepartamento";

            // Limpiar el control desplegable departamentos
            cboDepartamentos.Text = "Seleccione";

            // Seleccionar
            cboTipoCentro.Focus();
        }

        private void cboDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // IObtener el ID del departamento seleccionado
            String iddepartamento = cboDepartamentos.SelectedValue.ToString();

            // Mètodo listar provincias
            cboProvincias.DataSource = ubigeo.listarProvincias(iddepartamento);
            cboProvincias.DisplayMember = "provincia";
            cboProvincias.ValueMember = "idprovincia";

            // Limpiar el control desplegable
            cboProvincias.Text = "Seleccione";
        }

        private void cboProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener Id de la provincia
            String idprovincia = cboProvincias.SelectedValue.ToString();

            // Filtrar por provincias
            cboDistritos.DataSource = ubigeo.listarDistritos(idprovincia);
            cboDistritos.DisplayMember = "distrito";
            cboDistritos.ValueMember = "iddistrito";

            // Limpiar el control desplegable
            cboDistritos.Text = "Seleccione";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar datos
            // Validando los datos
            if (cboTipoCentro.Text == "" || cboDistritos.Text == "" || txtNombreCentro.Text == "" || txtDireccion.Text == "")
            {
                // Mensaje de alerta
                Dialogo.frmInformacion informCompletar = new Dialogo.frmInformacion("Aviso", "Porfavor complete todos los datos requeridos");
                informCompletar.ShowDialog();
            }
            else
            {
                // Existen datos
                // Confirmar regitro
                Dialogo.frmConfirmar confirmaRegistrar = new Dialogo.frmConfirmar("Centro de vacunación", "¿Está seguro de guardar los datos?");
                if (confirmaRegistrar.ShowDialog() == DialogResult.OK)
                {
                    // Capturando datos de las cajas de texto
                    int idtipocentro = Convert.ToInt32(cboTipoCentro.SelectedValue.ToString());
                    String iddistrito = cboDistritos.SelectedValue.ToString();
                    String nombrecentro = txtNombreCentro.Text.Trim();
                    String direccion = txtDireccion.Text.Trim();
                    String telefono = txtTelefono.Text;

                    // Asignando al objeto
                    ecentro.idtipocentro = idtipocentro;
                    ecentro.iddistrito = iddistrito;
                    ecentro.nombrecentro = nombrecentro;
                    ecentro.direccion = direccion;
                    ecentro.telefono = telefono;

                    // Con el método registrar procedemoa a enviar los datos al servidor
                    centrovac.registrarCentro(ecentro);

                    // Resetear los controles
                    resetearControles();

                    // Mostrar avisoGuardado correcto
                    Dialogo.frmInformacion infoGuardado = new Dialogo.frmInformacion("Centro de vacunación", "Datos guardado en la nase de datos.");
                    infoGuardado.ShowDialog();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Resetear controles
            resetearControles();
        }
    }
}
