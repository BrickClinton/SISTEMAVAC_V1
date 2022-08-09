
namespace DESIGNER.Dialogo
{
    partial class frmConfirmar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmar));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlBarraTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblTexto = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAceptar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pctLogoPregunta = new System.Windows.Forms.PictureBox();
            this.pnlBarraTop.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTop
            // 
            this.pnlBarraTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.pnlBarraTop.Controls.Add(this.btnCerrar);
            this.pnlBarraTop.Controls.Add(this.lblTitulo);
            this.pnlBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTop.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTop.Name = "pnlBarraTop";
            this.pnlBarraTop.Size = new System.Drawing.Size(683, 38);
            this.pnlBarraTop.TabIndex = 0;
            this.pnlBarraTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTop_MouseDown);
            this.pnlBarraTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTop_MouseMove);
            this.pnlBarraTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTop_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AllowAnimations = true;
            this.btnCerrar.AllowMouseEffects = true;
            this.btnCerrar.AllowToggling = false;
            this.btnCerrar.AnimationSpeed = 200;
            this.btnCerrar.AutoGenerateColors = false;
            this.btnCerrar.AutoRoundBorders = false;
            this.btnCerrar.AutoSizeLeftIcon = true;
            this.btnCerrar.AutoSizeRightIcon = true;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.ButtonText = "";
            this.btnCerrar.ButtonTextMarginLeft = 0;
            this.btnCerrar.ColorContrastOnClick = 45;
            this.btnCerrar.ColorContrastOnHover = 45;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCerrar.CustomizableEdges = borderEdges1;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconLeftPadding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.btnCerrar.IconMarginLeft = 11;
            this.btnCerrar.IconPadding = 12;
            this.btnCerrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnCerrar.IdleBorderRadius = 1;
            this.btnCerrar.IdleBorderThickness = 1;
            this.btnCerrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.btnCerrar.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.IdleIconLeftImage")));
            this.btnCerrar.IdleIconRightImage = null;
            this.btnCerrar.IndicateFocus = false;
            this.btnCerrar.Location = new System.Drawing.Point(639, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.OnDisabledState.BorderRadius = 1;
            this.btnCerrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnDisabledState.BorderThickness = 1;
            this.btnCerrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCerrar.OnDisabledState.IconLeftImage = null;
            this.btnCerrar.OnDisabledState.IconRightImage = null;
            this.btnCerrar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.onHoverState.BorderRadius = 1;
            this.btnCerrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.onHoverState.BorderThickness = 1;
            this.btnCerrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.onHoverState.IconLeftImage = null;
            this.btnCerrar.onHoverState.IconRightImage = null;
            this.btnCerrar.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnCerrar.OnIdleState.BorderRadius = 1;
            this.btnCerrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnIdleState.BorderThickness = 1;
            this.btnCerrar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.btnCerrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.OnIdleState.IconLeftImage")));
            this.btnCerrar.OnIdleState.IconRightImage = null;
            this.btnCerrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCerrar.OnPressedState.BorderRadius = 1;
            this.btnCerrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnPressedState.BorderThickness = 1;
            this.btnCerrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnPressedState.IconLeftImage = null;
            this.btnCerrar.OnPressedState.IconRightImage = null;
            this.btnCerrar.Size = new System.Drawing.Size(44, 38);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.TextMarginLeft = 0;
            this.btnCerrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCerrar.UseDefaultRadiusAndThickness = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(386, 38);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "TITULO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.pnlContenedor.Controls.Add(this.lblTexto);
            this.pnlContenedor.Controls.Add(this.btnCancelar);
            this.pnlContenedor.Controls.Add(this.btnAceptar);
            this.pnlContenedor.Controls.Add(this.pctLogoPregunta);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 38);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(683, 268);
            this.pnlContenedor.TabIndex = 1;
            // 
            // lblTexto
            // 
            this.lblTexto.AllowParentOverrides = false;
            this.lblTexto.AutoEllipsis = false;
            this.lblTexto.AutoSize = false;
            this.lblTexto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTexto.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTexto.Location = new System.Drawing.Point(25, 23);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTexto.Size = new System.Drawing.Size(466, 164);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.Text = "¿Preguntar opciones?";
            this.lblTexto.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTexto.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AllowAnimations = true;
            this.btnCancelar.AllowMouseEffects = true;
            this.btnCancelar.AllowToggling = false;
            this.btnCancelar.AnimationSpeed = 200;
            this.btnCancelar.AutoGenerateColors = false;
            this.btnCancelar.AutoRoundBorders = false;
            this.btnCancelar.AutoSizeLeftIcon = true;
            this.btnCancelar.AutoSizeRightIcon = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.ButtonTextMarginLeft = 0;
            this.btnCancelar.ColorContrastOnClick = 45;
            this.btnCancelar.ColorContrastOnHover = 45;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCancelar.CustomizableEdges = borderEdges2;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancelar.IconMarginLeft = 11;
            this.btnCancelar.IconPadding = 10;
            this.btnCancelar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.IdleBorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.IdleBorderRadius = 1;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.btnCancelar.IdleIconLeftImage = null;
            this.btnCancelar.IdleIconRightImage = null;
            this.btnCancelar.IndicateFocus = false;
            this.btnCancelar.Location = new System.Drawing.Point(341, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.OnDisabledState.BorderRadius = 1;
            this.btnCancelar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnDisabledState.BorderThickness = 1;
            this.btnCancelar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.OnDisabledState.IconLeftImage = null;
            this.btnCancelar.OnDisabledState.IconRightImage = null;
            this.btnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.onHoverState.BorderRadius = 1;
            this.btnCancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.onHoverState.BorderThickness = 1;
            this.btnCancelar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(98)))));
            this.btnCancelar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.onHoverState.IconLeftImage = null;
            this.btnCancelar.onHoverState.IconRightImage = null;
            this.btnCancelar.OnIdleState.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.OnIdleState.BorderRadius = 1;
            this.btnCancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnIdleState.BorderThickness = 1;
            this.btnCancelar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.btnCancelar.OnIdleState.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.OnIdleState.IconLeftImage = null;
            this.btnCancelar.OnIdleState.IconRightImage = null;
            this.btnCancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.OnPressedState.BorderRadius = 1;
            this.btnCancelar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnPressedState.BorderThickness = 1;
            this.btnCancelar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnPressedState.IconLeftImage = null;
            this.btnCancelar.OnPressedState.IconRightImage = null;
            this.btnCancelar.Size = new System.Drawing.Size(150, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.TextMarginLeft = 0;
            this.btnCancelar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancelar.UseDefaultRadiusAndThickness = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AllowAnimations = true;
            this.btnAceptar.AllowMouseEffects = true;
            this.btnAceptar.AllowToggling = false;
            this.btnAceptar.AnimationSpeed = 200;
            this.btnAceptar.AutoGenerateColors = false;
            this.btnAceptar.AutoRoundBorders = false;
            this.btnAceptar.AutoSizeLeftIcon = true;
            this.btnAceptar.AutoSizeRightIcon = true;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.ButtonText = "Aceptar";
            this.btnAceptar.ButtonTextMarginLeft = 0;
            this.btnAceptar.ColorContrastOnClick = 45;
            this.btnAceptar.ColorContrastOnHover = 45;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAceptar.CustomizableEdges = borderEdges3;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAceptar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAceptar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAceptar.IconMarginLeft = 11;
            this.btnAceptar.IconPadding = 10;
            this.btnAceptar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAceptar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAceptar.IconSize = 25;
            this.btnAceptar.IdleBorderColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.IdleBorderRadius = 1;
            this.btnAceptar.IdleBorderThickness = 1;
            this.btnAceptar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAceptar.IdleIconLeftImage = null;
            this.btnAceptar.IdleIconRightImage = null;
            this.btnAceptar.IndicateFocus = true;
            this.btnAceptar.Location = new System.Drawing.Point(497, 205);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.OnDisabledState.BorderRadius = 1;
            this.btnAceptar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.OnDisabledState.BorderThickness = 1;
            this.btnAceptar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAceptar.OnDisabledState.IconLeftImage = null;
            this.btnAceptar.OnDisabledState.IconRightImage = null;
            this.btnAceptar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAceptar.onHoverState.BorderRadius = 1;
            this.btnAceptar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.onHoverState.BorderThickness = 1;
            this.btnAceptar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(98)))));
            this.btnAceptar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.onHoverState.IconLeftImage = null;
            this.btnAceptar.onHoverState.IconRightImage = null;
            this.btnAceptar.OnIdleState.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.OnIdleState.BorderRadius = 1;
            this.btnAceptar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.OnIdleState.BorderThickness = 1;
            this.btnAceptar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAceptar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.OnIdleState.IconLeftImage = null;
            this.btnAceptar.OnIdleState.IconRightImage = null;
            this.btnAceptar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAceptar.OnPressedState.BorderRadius = 1;
            this.btnAceptar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAceptar.OnPressedState.BorderThickness = 1;
            this.btnAceptar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAceptar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.OnPressedState.IconLeftImage = null;
            this.btnAceptar.OnPressedState.IconRightImage = null;
            this.btnAceptar.Size = new System.Drawing.Size(150, 39);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAceptar.TextMarginLeft = 0;
            this.btnAceptar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAceptar.UseDefaultRadiusAndThickness = true;
            // 
            // pctLogoPregunta
            // 
            this.pctLogoPregunta.Image = ((System.Drawing.Image)(resources.GetObject("pctLogoPregunta.Image")));
            this.pctLogoPregunta.Location = new System.Drawing.Point(500, 37);
            this.pctLogoPregunta.Name = "pctLogoPregunta";
            this.pctLogoPregunta.Size = new System.Drawing.Size(147, 116);
            this.pctLogoPregunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoPregunta.TabIndex = 0;
            this.pctLogoPregunta.TabStop = false;
            // 
            // frmConfirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 306);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBarraTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirmar";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirmar";
            this.Load += new System.EventHandler(this.frmConfirmar_Load);
            this.pnlBarraTop.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoPregunta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTop;
        private System.Windows.Forms.Panel pnlContenedor;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAceptar;
        private System.Windows.Forms.PictureBox pctLogoPregunta;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelar;
        private Bunifu.UI.WinForms.BunifuLabel lblTexto;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCerrar;
    }
}