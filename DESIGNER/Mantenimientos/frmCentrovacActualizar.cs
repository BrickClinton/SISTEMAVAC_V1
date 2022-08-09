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
    public partial class frmCentrovacActualizar : Form
    {
        // Instancias(Logica)
        TipoCentroVacunacion tipoCentro = new TipoCentroVacunacion();
        Centro centrovac = new Centro();
        ECentro eCentro = new ECentro();
        Ubigeo ubigeo = new Ubigeo();

        public frmCentrovacActualizar(ECentro eCentrovac)
        {
            InitializeComponent();
            this.idcentrovac = eCentrovac.idcentro;
            this.idtipocentro = eCentrovac.idtipocentro;
            this.iddepartamento = eCentrovac.iddepartamento;
            this.idprovincia = eCentrovac.idprovincia;
            this.iddistrito = eCentrovac.iddistrito;
            txtNombreCentro.Text = eCentrovac.nombrecentro;
            txtDireccion.Text = eCentrovac.direccion;
            txtTelefono.Text = eCentrovac.telefono;

            // Color celeste
            pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
        }

        // idcentrovac
        private int idcentrovac = 0;
        private int idtipocentro = 0;
        private String iddepartamento;
        private String idprovincia;
        private String iddistrito;

        // posicones del mouse
        private int posicion = 0, posicionX, posicionY;

        private void pnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            // Otorgando valores 
            posicion = 1;
            posicionX = e.X;
            posicionY = e.Y;

            // Cambiar color del panel si esta en azul oscuro
            if (pnlDockFull.BackColor == Color.FromArgb(27, 39, 54))
            {
                pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar
            this.Close();
        }

        private void pnlBarraTop_MouseHover(object sender, EventArgs e)
        {
            // Color celeste
            pnlDockFull.BackColor = Color.FromArgb(102, 162, 164);
        }

        private void pnlBarraTop_MouseLeave(object sender, EventArgs e)
        {
            // Color azul
            pnlDockFull.BackColor = Color.FromArgb(27, 39, 54);
        }

        private void frmCentrovacActualizar_Load(object sender, EventArgs e)
        {
            // cmbo tipo de centro
            cboTipoCentro.DataSource = tipoCentro.listarTipoCentroVacunacion();
            cboTipoCentro.DisplayMember = "tipocentro";
            cboTipoCentro.ValueMember = "idtipocentro";

            // Filtrar por id
            cboTipoCentro.SelectedValue = this.idtipocentro;

            // combo departamentos
            cboDepartamentos.DataSource = ubigeo.listarDepaetamentos();
            cboDepartamentos.DisplayMember = "departamento";
            cboDepartamentos.ValueMember = "iddepartamento";

            // Filtrar departamneto por su ID
            cboDepartamentos.SelectedValue = this.iddepartamento;

            // Mètodo listar provincias
            cboProvincias.DataSource = ubigeo.listarProvincias(iddepartamento);
            cboProvincias.DisplayMember = "provincia";
            cboProvincias.ValueMember = "idprovincia";

            // Filtrar por su id
            cboProvincias.SelectedValue = this.idprovincia;

            // Filtrar por provincias
            cboDistritos.DataSource = ubigeo.listarDistritos(idprovincia);
            cboDistritos.DisplayMember = "distrito";
            cboDistritos.ValueMember = "iddistrito";

            // LFiltrar por su ID
            cboDistritos.SelectedValue = this.iddistrito;

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar los datos
            if (cboTipoCentro.Text == "" || cboDistritos.Text == "" || txtDireccion.Text == "" || txtNombreCentro.Text == "")
            {
                // Mostrar mensaje. complete
                Dialogo.frmInformacion infoComplete = new Dialogo.frmInformacion("Centro de vacunación", "Por favor complete los campos");
                infoComplete.ShowDialog();
            }
            else
            {
                // Pregunta de confirmación
                Dialogo.frmConfirmar confiActualizar = new Dialogo.frmConfirmar("Centro de vacunación", "¿Estás seguro de actualizar los datos?");
                if (confiActualizar.ShowDialog() == DialogResult.OK)
                {
                    // Proceder actualizar
                    eCentro.iddistrito = cboDistritos.SelectedValue.ToString();
                    eCentro.idtipocentro = Convert.ToInt32(cboTipoCentro.SelectedValue);
                    eCentro.nombrecentro = txtNombreCentro.Text.Trim();
                    eCentro.direccion = txtDireccion.Text.Trim();
                    eCentro.telefono = txtTelefono.Text.Trim();
                    eCentro.idcentro = this.idcentrovac;

                    // Actualizar
                    centrovac.actualizarCentro(eCentro);

                    // Mensaje actualizado
                    Dialogo.frmInformacion infoActualizado = new Dialogo.frmInformacion("Centro de vacunación", "Datos actualizados correctamente");
                    infoActualizado.ShowDialog();

                    // Cerrar actual
                    this.Close();
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
            // resetear
            this.posicion = 0;
        }
    }
}
