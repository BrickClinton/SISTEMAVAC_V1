
namespace DESIGNER.MenuInicio
{
    partial class frmIniciarAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciarAplicacion));
            this.pnlDockFull = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pctLogoUsuario = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblCargando = new System.Windows.Forms.Label();
            this.progressBarCirculo = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMostrarTexto = new Bunifu.UI.WinForms.BunifuLabel();
            this.progressBarLineal = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.tmProgresBarCircle = new System.Windows.Forms.Timer(this.components);
            this.tmProgressBarLine = new System.Windows.Forms.Timer(this.components);
            this.pnlDockFull.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDockFull
            // 
            this.pnlDockFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.pnlDockFull.Controls.Add(this.pnlContenedor);
            this.pnlDockFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDockFull.Location = new System.Drawing.Point(0, 0);
            this.pnlDockFull.Name = "pnlDockFull";
            this.pnlDockFull.Padding = new System.Windows.Forms.Padding(2);
            this.pnlDockFull.Size = new System.Drawing.Size(796, 464);
            this.pnlDockFull.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.pnlContenedor.Controls.Add(this.pctLogoUsuario);
            this.pnlContenedor.Controls.Add(this.lblCargando);
            this.pnlContenedor.Controls.Add(this.progressBarCirculo);
            this.pnlContenedor.Controls.Add(this.lblSaludo);
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.lblMostrarTexto);
            this.pnlContenedor.Controls.Add(this.progressBarLineal);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(2, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(792, 460);
            this.pnlContenedor.TabIndex = 0;
            // 
            // pctLogoUsuario
            // 
            this.pctLogoUsuario.AllowFocused = false;
            this.pctLogoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctLogoUsuario.AutoSizeHeight = true;
            this.pctLogoUsuario.BorderRadius = 57;
            this.pctLogoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctLogoUsuario.Image")));
            this.pctLogoUsuario.IsCircle = true;
            this.pctLogoUsuario.Location = new System.Drawing.Point(584, 66);
            this.pctLogoUsuario.Name = "pctLogoUsuario";
            this.pctLogoUsuario.Size = new System.Drawing.Size(114, 114);
            this.pctLogoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoUsuario.TabIndex = 28;
            this.pctLogoUsuario.TabStop = false;
            this.pctLogoUsuario.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblCargando
            // 
            this.lblCargando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargando.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.lblCargando.Location = new System.Drawing.Point(437, 354);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(278, 63);
            this.lblCargando.TabIndex = 24;
            this.lblCargando.Text = "Por favor espere...";
            this.lblCargando.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarCirculo
            // 
            this.progressBarCirculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarCirculo.Animated = true;
            this.progressBarCirculo.AnimationInterval = 2;
            this.progressBarCirculo.AnimationSpeed = 1;
            this.progressBarCirculo.BackColor = System.Drawing.Color.Transparent;
            this.progressBarCirculo.CircleMargin = 10;
            this.progressBarCirculo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarCirculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.progressBarCirculo.IsPercentage = false;
            this.progressBarCirculo.LineProgressThickness = 16;
            this.progressBarCirculo.LineThickness = 16;
            this.progressBarCirculo.Location = new System.Drawing.Point(565, 48);
            this.progressBarCirculo.Name = "progressBarCirculo";
            this.progressBarCirculo.ProgressAnimationSpeed = 200;
            this.progressBarCirculo.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.progressBarCirculo.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.progressBarCirculo.ProgressColor2 = System.Drawing.Color.Maroon;
            this.progressBarCirculo.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Flat;
            this.progressBarCirculo.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.progressBarCirculo.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Flat;
            this.progressBarCirculo.SecondaryFont = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarCirculo.Size = new System.Drawing.Size(150, 150);
            this.progressBarCirculo.SubScriptColor = System.Drawing.Color.Silver;
            this.progressBarCirculo.SubScriptMargin = new System.Windows.Forms.Padding(0, -15, 0, 0);
            this.progressBarCirculo.SubScriptText = "";
            this.progressBarCirculo.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(111)))), ((int)(((byte)(193)))));
            this.progressBarCirculo.SuperScriptMargin = new System.Windows.Forms.Padding(12, 46, 0, 0);
            this.progressBarCirculo.SuperScriptText = "%";
            this.progressBarCirculo.TabIndex = 25;
            this.progressBarCirculo.Text = "30";
            this.progressBarCirculo.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.progressBarCirculo.Value = 30;
            this.progressBarCirculo.ValueByTransition = 30;
            this.progressBarCirculo.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // lblSaludo
            // 
            this.lblSaludo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.lblSaludo.Location = new System.Drawing.Point(38, 61);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(415, 84);
            this.lblSaludo.TabIndex = 22;
            this.lblSaludo.Text = "Bienvenido";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(48, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 68);
            this.label1.TabIndex = 27;
            this.label1.Text = "Estimado usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMostrarTexto
            // 
            this.lblMostrarTexto.AllowParentOverrides = false;
            this.lblMostrarTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMostrarTexto.AutoEllipsis = false;
            this.lblMostrarTexto.AutoSize = false;
            this.lblMostrarTexto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMostrarTexto.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblMostrarTexto.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(151)))), ((int)(((byte)(191)))));
            this.lblMostrarTexto.Location = new System.Drawing.Point(53, 234);
            this.lblMostrarTexto.Name = "lblMostrarTexto";
            this.lblMostrarTexto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMostrarTexto.Size = new System.Drawing.Size(662, 183);
            this.lblMostrarTexto.TabIndex = 26;
            this.lblMostrarTexto.Text = "Cargando...";
            this.lblMostrarTexto.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblMostrarTexto.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // progressBarLineal
            // 
            this.progressBarLineal.AllowAnimations = false;
            this.progressBarLineal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarLineal.Animation = 0;
            this.progressBarLineal.AnimationSpeed = 220;
            this.progressBarLineal.AnimationStep = 10;
            this.progressBarLineal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.progressBarLineal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarLineal.BackgroundImage")));
            this.progressBarLineal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.progressBarLineal.BorderRadius = 6;
            this.progressBarLineal.BorderThickness = 1;
            this.progressBarLineal.Location = new System.Drawing.Point(55, 200);
            this.progressBarLineal.Maximum = 700;
            this.progressBarLineal.MaximumValue = 700;
            this.progressBarLineal.Minimum = 0;
            this.progressBarLineal.MinimumValue = 0;
            this.progressBarLineal.Name = "progressBarLineal";
            this.progressBarLineal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressBarLineal.ProgressBackColor = System.Drawing.Color.PaleTurquoise;
            this.progressBarLineal.ProgressColorLeft = System.Drawing.Color.SteelBlue;
            this.progressBarLineal.ProgressColorRight = System.Drawing.Color.SteelBlue;
            this.progressBarLineal.Size = new System.Drawing.Size(416, 21);
            this.progressBarLineal.TabIndex = 23;
            this.progressBarLineal.Value = 30;
            this.progressBarLineal.ValueByTransition = 30;
            // 
            // tmProgresBarCircle
            // 
            this.tmProgresBarCircle.Enabled = true;
            this.tmProgresBarCircle.Interval = 140;
            this.tmProgresBarCircle.Tick += new System.EventHandler(this.tmProgresBarCircle_Tick);
            // 
            // tmProgressBarLine
            // 
            this.tmProgressBarLine.Enabled = true;
            this.tmProgressBarLine.Interval = 10;
            this.tmProgressBarLine.Tick += new System.EventHandler(this.tmProgressBarLine_Tick);
            // 
            // frmIniciarAplicacion
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(796, 464);
            this.Controls.Add(this.pnlDockFull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIniciarAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIniciarAplicacion";
            this.pnlDockFull.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDockFull;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Label lblSaludo;
        private Bunifu.UI.WinForms.BunifuProgressBar progressBarLineal;
        private Bunifu.UI.WinForms.BunifuCircleProgress progressBarCirculo;
        private Bunifu.UI.WinForms.BunifuLabel lblMostrarTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmProgresBarCircle;
        private System.Windows.Forms.Timer tmProgressBarLine;
        private Bunifu.UI.WinForms.BunifuPictureBox pctLogoUsuario;
    }
}