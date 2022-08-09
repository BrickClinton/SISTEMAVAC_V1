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
    public partial class frmNavegadorWEb : Form
    {
        public frmNavegadorWEb()
        {
            InitializeComponent();
        }

        private void txtUrlBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cuando pulse enter
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            { 
                try
                {
                    wbNavegarInternet.Navigate(txtUrlBuscar.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
