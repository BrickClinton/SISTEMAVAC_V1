using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.MenuInicio
{
    public partial class frmDespedirse : Form
    {
        // Método constructor
        public frmDespedirse()
        {
            // Método inicializador
            InitializeComponent();
            progressBarSalir.Value = 0;
        }

        private void frmDespedirse_Load(object sender, EventArgs e)
        {
            
        }

        private void tmSalir_Tick(object sender, EventArgs e)
        {
            progressBarSalir.Value += 2;

            // Mostrar texto cargando
            if (progressBarSalir.Value % 3 == 0)
            {
                lblCargando.Text = "Cerrando Seción...";
            }
            else
            {
                lblCargando.Text = "Cerrando Seción.";
            }

            // Cargado al 96 porciento
            if (progressBarSalir.Value == 96)
            {
                lblCargando.Visible = false;
                lblSaludo.Visible = true;
            }

            // Carga al 100 porciento
            if (progressBarSalir.Value == 100)
            {
                // Cerrar aplicación
                progressBarSalir.Enabled = false;
                Application.Exit();
            }
        }
    }
}
