
namespace DESIGNER.MenuInicio
{
    partial class frmDespedirse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespedirse));
            this.lblSaludo = new System.Windows.Forms.Label();
            this.progressBarSalir = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.tmSalir = new System.Windows.Forms.Timer(this.components);
            this.lblCargando = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDockFull = new System.Windows.Forms.Panel();
            this.pnlContenedor.SuspendLayout();
            this.pnlDockFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.lblSaludo.Location = new System.Drawing.Point(46, 76);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(538, 73);
            this.lblSaludo.TabIndex = 19;
            this.lblSaludo.Text = "Hasta pronto...";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarSalir
            // 
            this.progressBarSalir.AllowAnimations = false;
            this.progressBarSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarSalir.Animation = 0;
            this.progressBarSalir.AnimationSpeed = 220;
            this.progressBarSalir.AnimationStep = 10;
            this.progressBarSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.progressBarSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarSalir.BackgroundImage")));
            this.progressBarSalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.progressBarSalir.BorderRadius = 9;
            this.progressBarSalir.BorderThickness = 1;
            this.progressBarSalir.Location = new System.Drawing.Point(57, 164);
            this.progressBarSalir.Maximum = 100;
            this.progressBarSalir.MaximumValue = 100;
            this.progressBarSalir.Minimum = 0;
            this.progressBarSalir.MinimumValue = 0;
            this.progressBarSalir.Name = "progressBarSalir";
            this.progressBarSalir.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressBarSalir.ProgressBackColor = System.Drawing.Color.PaleTurquoise;
            this.progressBarSalir.ProgressColorLeft = System.Drawing.Color.SteelBlue;
            this.progressBarSalir.ProgressColorRight = System.Drawing.Color.SteelBlue;
            this.progressBarSalir.Size = new System.Drawing.Size(653, 34);
            this.progressBarSalir.TabIndex = 20;
            this.progressBarSalir.Value = 50;
            this.progressBarSalir.ValueByTransition = 50;
            // 
            // tmSalir
            // 
            this.tmSalir.Enabled = true;
            this.tmSalir.Interval = 80;
            this.tmSalir.Tick += new System.EventHandler(this.tmSalir_Tick);
            // 
            // lblCargando
            // 
            this.lblCargando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargando.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.lblCargando.Location = new System.Drawing.Point(449, 201);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(261, 47);
            this.lblCargando.TabIndex = 21;
            this.lblCargando.Text = "Cerrando Seción...";
            this.lblCargando.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.lblCargando);
            this.pnlContenedor.Controls.Add(this.lblSaludo);
            this.pnlContenedor.Controls.Add(this.progressBarSalir);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(2, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(762, 446);
            this.pnlContenedor.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(351, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 73);
            this.label1.TabIndex = 22;
            this.label1.Text = "Gracias por su visita.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDockFull
            // 
            this.pnlDockFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.pnlDockFull.Controls.Add(this.pnlContenedor);
            this.pnlDockFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDockFull.Location = new System.Drawing.Point(0, 0);
            this.pnlDockFull.Name = "pnlDockFull";
            this.pnlDockFull.Padding = new System.Windows.Forms.Padding(2);
            this.pnlDockFull.Size = new System.Drawing.Size(766, 450);
            this.pnlDockFull.TabIndex = 23;
            // 
            // frmDespedirse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.pnlDockFull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDespedirse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDespedirse";
            this.Load += new System.EventHandler(this.frmDespedirse_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlDockFull.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private Bunifu.UI.WinForms.BunifuProgressBar progressBarSalir;
        private System.Windows.Forms.Timer tmSalir;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlDockFull;
        private System.Windows.Forms.Label label1;
    }
}