
namespace DESIGNER.Registrar
{
    partial class frmRolRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRolRegistrar));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFondoControles = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRegistrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bfGrupoTexto = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtNomRol = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlFondoControles.SuspendLayout();
            this.bfGrupoTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.lblTitulo.Location = new System.Drawing.Point(103, 77);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(519, 47);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "REGISTRAR NUEVO ROL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFondoControles
            // 
            this.pnlFondoControles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.pnlFondoControles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFondoControles.BackgroundImage")));
            this.pnlFondoControles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFondoControles.BorderColor = System.Drawing.Color.Transparent;
            this.pnlFondoControles.BorderRadius = 5;
            this.pnlFondoControles.BorderThickness = 1;
            this.pnlFondoControles.Controls.Add(this.btnCancelar);
            this.pnlFondoControles.Controls.Add(this.btnRegistrar);
            this.pnlFondoControles.Controls.Add(this.bfGrupoTexto);
            this.pnlFondoControles.Location = new System.Drawing.Point(111, 171);
            this.pnlFondoControles.Name = "pnlFondoControles";
            this.pnlFondoControles.ShowBorders = true;
            this.pnlFondoControles.Size = new System.Drawing.Size(728, 291);
            this.pnlFondoControles.TabIndex = 31;
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
            this.btnCancelar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.ButtonText = "Cancelar proceso";
            this.btnCancelar.ButtonTextMarginLeft = 0;
            this.btnCancelar.ColorContrastOnClick = 45;
            this.btnCancelar.ColorContrastOnHover = 45;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancelar.CustomizableEdges = borderEdges1;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCancelar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancelar.IconMarginLeft = 11;
            this.btnCancelar.IconPadding = 10;
            this.btnCancelar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCancelar.IdleBorderRadius = 3;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnCancelar.IdleIconLeftImage = null;
            this.btnCancelar.IdleIconRightImage = null;
            this.btnCancelar.IndicateFocus = true;
            this.btnCancelar.Location = new System.Drawing.Point(377, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.OnDisabledState.BorderRadius = 3;
            this.btnCancelar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnDisabledState.BorderThickness = 1;
            this.btnCancelar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.OnDisabledState.IconLeftImage = null;
            this.btnCancelar.OnDisabledState.IconRightImage = null;
            this.btnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.onHoverState.BorderRadius = 3;
            this.btnCancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.onHoverState.BorderThickness = 1;
            this.btnCancelar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
            this.btnCancelar.onHoverState.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.onHoverState.IconLeftImage = null;
            this.btnCancelar.onHoverState.IconRightImage = null;
            this.btnCancelar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCancelar.OnIdleState.BorderRadius = 3;
            this.btnCancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnIdleState.BorderThickness = 1;
            this.btnCancelar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnCancelar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnCancelar.OnIdleState.IconLeftImage = null;
            this.btnCancelar.OnIdleState.IconRightImage = null;
            this.btnCancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.OnPressedState.BorderRadius = 3;
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AllowAnimations = true;
            this.btnRegistrar.AllowMouseEffects = true;
            this.btnRegistrar.AllowToggling = false;
            this.btnRegistrar.AnimationSpeed = 200;
            this.btnRegistrar.AutoGenerateColors = false;
            this.btnRegistrar.AutoRoundBorders = false;
            this.btnRegistrar.AutoSizeLeftIcon = true;
            this.btnRegistrar.AutoSizeRightIcon = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.ButtonText = "Registrar";
            this.btnRegistrar.ButtonTextMarginLeft = 0;
            this.btnRegistrar.ColorContrastOnClick = 45;
            this.btnRegistrar.ColorContrastOnHover = 45;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRegistrar.CustomizableEdges = borderEdges2;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegistrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnRegistrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistrar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegistrar.IconMarginLeft = 11;
            this.btnRegistrar.IconPadding = 10;
            this.btnRegistrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegistrar.IconSize = 25;
            this.btnRegistrar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnRegistrar.IdleBorderRadius = 3;
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnRegistrar.IdleIconLeftImage = null;
            this.btnRegistrar.IdleIconRightImage = null;
            this.btnRegistrar.IndicateFocus = true;
            this.btnRegistrar.Location = new System.Drawing.Point(550, 225);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.OnDisabledState.BorderRadius = 3;
            this.btnRegistrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.OnDisabledState.BorderThickness = 1;
            this.btnRegistrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegistrar.OnDisabledState.IconLeftImage = null;
            this.btnRegistrar.OnDisabledState.IconRightImage = null;
            this.btnRegistrar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
            this.btnRegistrar.onHoverState.BorderRadius = 3;
            this.btnRegistrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.onHoverState.BorderThickness = 1;
            this.btnRegistrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(108)))));
            this.btnRegistrar.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.btnRegistrar.onHoverState.IconLeftImage = null;
            this.btnRegistrar.onHoverState.IconRightImage = null;
            this.btnRegistrar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnRegistrar.OnIdleState.BorderRadius = 3;
            this.btnRegistrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.OnIdleState.BorderThickness = 1;
            this.btnRegistrar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnRegistrar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnRegistrar.OnIdleState.IconLeftImage = null;
            this.btnRegistrar.OnIdleState.IconRightImage = null;
            this.btnRegistrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegistrar.OnPressedState.BorderRadius = 3;
            this.btnRegistrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.OnPressedState.BorderThickness = 1;
            this.btnRegistrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegistrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnPressedState.IconLeftImage = null;
            this.btnRegistrar.OnPressedState.IconRightImage = null;
            this.btnRegistrar.Size = new System.Drawing.Size(150, 39);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.TextMarginLeft = 0;
            this.btnRegistrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegistrar.UseDefaultRadiusAndThickness = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // bfGrupoTexto
            // 
            this.bfGrupoTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.bfGrupoTexto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bfGrupoTexto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.bfGrupoTexto.BorderRadius = 2;
            this.bfGrupoTexto.BorderThickness = 1;
            this.bfGrupoTexto.Controls.Add(this.bunifuLabel1);
            this.bfGrupoTexto.Controls.Add(this.txtNomRol);
            this.bfGrupoTexto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfGrupoTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.bfGrupoTexto.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bfGrupoTexto.LabelIndent = 10;
            this.bfGrupoTexto.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bfGrupoTexto.Location = new System.Drawing.Point(29, 19);
            this.bfGrupoTexto.Name = "bfGrupoTexto";
            this.bfGrupoTexto.Size = new System.Drawing.Size(671, 179);
            this.bfGrupoTexto.TabIndex = 0;
            this.bfGrupoTexto.TabStop = false;
            this.bfGrupoTexto.Text = "Complete los datos";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(47, 58);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(246, 25);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.TabStop = false;
            this.bunifuLabel1.Text = "NOMBRE DEL ROL:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtNomRol
            // 
            this.txtNomRol.AcceptsReturn = false;
            this.txtNomRol.AcceptsTab = false;
            this.txtNomRol.AnimationSpeed = 200;
            this.txtNomRol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomRol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.txtNomRol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNomRol.BackgroundImage")));
            this.txtNomRol.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNomRol.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNomRol.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtNomRol.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(159)))), ((int)(((byte)(165)))));
            this.txtNomRol.BorderRadius = 3;
            this.txtNomRol.BorderThickness = 1;
            this.txtNomRol.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomRol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomRol.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomRol.DefaultText = "";
            this.txtNomRol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.txtNomRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.txtNomRol.HideSelection = true;
            this.txtNomRol.IconLeft = null;
            this.txtNomRol.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomRol.IconPadding = 10;
            this.txtNomRol.IconRight = null;
            this.txtNomRol.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomRol.Lines = new string[0];
            this.txtNomRol.Location = new System.Drawing.Point(47, 82);
            this.txtNomRol.MaxLength = 70;
            this.txtNomRol.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNomRol.Modified = false;
            this.txtNomRol.Multiline = false;
            this.txtNomRol.Name = "txtNomRol";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            stateProperties1.ForeColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.SteelBlue;
            this.txtNomRol.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.IndianRed;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNomRol.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(189)))), ((int)(((byte)(202)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.txtNomRol.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(159)))), ((int)(((byte)(165)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNomRol.OnIdleState = stateProperties4;
            this.txtNomRol.Padding = new System.Windows.Forms.Padding(1);
            this.txtNomRol.PasswordChar = '\0';
            this.txtNomRol.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.txtNomRol.PlaceholderText = "Escriba aquí.";
            this.txtNomRol.ReadOnly = false;
            this.txtNomRol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomRol.SelectedText = "";
            this.txtNomRol.SelectionLength = 0;
            this.txtNomRol.SelectionStart = 0;
            this.txtNomRol.ShortcutsEnabled = true;
            this.txtNomRol.Size = new System.Drawing.Size(589, 34);
            this.txtNomRol.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNomRol.TabIndex = 0;
            this.txtNomRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomRol.TextMarginBottom = 0;
            this.txtNomRol.TextMarginLeft = 3;
            this.txtNomRol.TextMarginTop = 0;
            this.txtNomRol.TextPlaceholder = "Escriba aquí.";
            this.txtNomRol.UseSystemPasswordChar = false;
            this.txtNomRol.WordWrap = true;
            // 
            // frmRolRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(950, 631);
            this.Controls.Add(this.pnlFondoControles);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRolRegistrar";
            this.Text = "frmRolRegistrar";
            this.Load += new System.EventHandler(this.frmRolRegistrar_Load);
            this.pnlFondoControles.ResumeLayout(false);
            this.bfGrupoTexto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.UI.WinForms.BunifuPanel pnlFondoControles;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegistrar;
        private Bunifu.UI.WinForms.BunifuGroupBox bfGrupoTexto;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtNomRol;
    }
}