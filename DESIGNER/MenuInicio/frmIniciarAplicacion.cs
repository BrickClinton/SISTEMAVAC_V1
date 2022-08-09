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
    public partial class frmIniciarAplicacion : Form
    {
        public frmIniciarAplicacion()
        {
            InitializeComponent();
            progressBarCirculo.Value = 0;
            progressBarLineal.Value = 0;
            lblMostrarTexto.Text = ">> ";
        }

        // Variable
        private String cadenaTexto = "Linus Benedict Torvalds (born December 28, 1969 in Helsinki, Finland) is aFinnish software engineer best known for initiating the development of Linux.He now acts as the project’s coordinator (or Benevolent Dictator for Life).Linus was inspired by Minix (a kernel and operating system developed byAndrew Tanenbaum) to develop a capable UNIX-like operating system thatcould be run on a PC. Linux now also runs on many other architectures" +
                                     " Torvalds was born in Helsinki, the capital of Finland, as the son of jour-nalists Anna and Nils, and the grandson of poet Ole Torvalds. His familybelongs to the Swedish-speaking minority (roughly 6%) of Finland’s popu-lation.";

        private void tmProgresBarCircle_Tick(object sender, EventArgs e)
        {
            // Aumentar valor en 1
            progressBarCirculo.Value += 1;

            // Textocargando
            if (progressBarCirculo.Value % 3 == 0)
            {
                lblCargando.Text = "Por favor espere...";

            }
            else
            {
                lblCargando.Text = "Por favor espere.";
            }

            // Desactivar timer del circle
            if (progressBarCirculo.Value == 100)
            {
                // Desactivar 
                tmProgresBarCircle.Enabled = false;

                // Abrir Aplicación
            }

        }

        private void tmProgressBarLine_Tick(object sender, EventArgs e)
        {
            // Aumentar en 1
            progressBarLineal.Value += 1;

            // Aumentar una posición de la cadena de texto y mostrarlo en el label
            lblMostrarTexto.Text += cadenaTexto[progressBarLineal.Value];
            //lblMostrarTexto.Text = cadenaTexto.Length.ToString();

            // Si el tmCirlce esta descativada, desactivar el tmLineal
            if (tmProgresBarCircle.Enabled == false)
            {
                // Desactivar timer
                tmProgressBarLine.Enabled = false;

                // Abrir Aplicación

                // Cerrar ventana actual
                this.Close();
            }

            // Desactivar al llegar a 600
            if (progressBarLineal.Value == 700)
            {
                // Desactivar timer
                tmProgressBarLine.Enabled = false;

                // Abrir Aplicación

                // Cerrar ventana actual
                this.Close();
            }
        }
    }
}
