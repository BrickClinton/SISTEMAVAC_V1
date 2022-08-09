
namespace DESIGNER.Registrar
{
    partial class frmResponsableRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponsableRegistrar));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFondoControles = new Bunifu.UI.WinForms.BunifuPanel();
            this.bfGrupoTexto = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPerosnaSeleccionado = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnBuscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtFiltrar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.gridPersonas = new System.Windows.Forms.DataGridView();
            this.lblTotalRegistros = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnRegistrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.cboCentroVac = new System.Windows.Forms.ComboBox();
            this.cboCamposFiltrar = new System.Windows.Forms.ComboBox();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlFondoControles.SuspendLayout();
            this.bfGrupoTexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonas)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.lblTitulo.Location = new System.Drawing.Point(31, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(519, 47);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "REGISTRAR RESPONSABLES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFondoControles
            // 
            this.pnlFondoControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFondoControles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.pnlFondoControles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFondoControles.BackgroundImage")));
            this.pnlFondoControles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFondoControles.BorderColor = System.Drawing.Color.Transparent;
            this.pnlFondoControles.BorderRadius = 8;
            this.pnlFondoControles.BorderThickness = 1;
            this.pnlFondoControles.Controls.Add(this.bfGrupoTexto);
            this.pnlFondoControles.Controls.Add(this.btnRegistrar);
            this.pnlFondoControles.Controls.Add(this.btnCancelar);
            this.pnlFondoControles.Controls.Add(this.bunifuGroupBox1);
            this.pnlFondoControles.Location = new System.Drawing.Point(39, 98);
            this.pnlFondoControles.Name = "pnlFondoControles";
            this.pnlFondoControles.ShowBorders = true;
            this.pnlFondoControles.Size = new System.Drawing.Size(876, 435);
            this.pnlFondoControles.TabIndex = 29;
            // 
            // bfGrupoTexto
            // 
            this.bfGrupoTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bfGrupoTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.bfGrupoTexto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bfGrupoTexto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.bfGrupoTexto.BorderRadius = 2;
            this.bfGrupoTexto.BorderThickness = 1;
            this.bfGrupoTexto.Controls.Add(this.bunifuLabel11);
            this.bfGrupoTexto.Controls.Add(this.lblPerosnaSeleccionado);
            this.bfGrupoTexto.Controls.Add(this.btnBuscar);
            this.bfGrupoTexto.Controls.Add(this.txtFiltrar);
            this.bfGrupoTexto.Controls.Add(this.gridPersonas);
            this.bfGrupoTexto.Controls.Add(this.lblTotalRegistros);
            this.bfGrupoTexto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfGrupoTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.bfGrupoTexto.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bfGrupoTexto.LabelIndent = 10;
            this.bfGrupoTexto.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bfGrupoTexto.Location = new System.Drawing.Point(372, 14);
            this.bfGrupoTexto.Name = "bfGrupoTexto";
            this.bfGrupoTexto.Size = new System.Drawing.Size(485, 338);
            this.bfGrupoTexto.TabIndex = 1;
            this.bfGrupoTexto.TabStop = false;
            this.bfGrupoTexto.Text = "Personas registradas";
            // 
            // bunifuLabel11
            // 
            this.bunifuLabel11.AllowParentOverrides = false;
            this.bunifuLabel11.AutoEllipsis = false;
            this.bunifuLabel11.AutoSize = false;
            this.bunifuLabel11.CursorType = null;
            this.bunifuLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuLabel11.Location = new System.Drawing.Point(22, 294);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(130, 25);
            this.bunifuLabel11.TabIndex = 36;
            this.bunifuLabel11.TabStop = false;
            this.bunifuLabel11.Text = "SELECCIONADO:";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPerosnaSeleccionado
            // 
            this.lblPerosnaSeleccionado.AllowParentOverrides = false;
            this.lblPerosnaSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerosnaSeleccionado.AutoEllipsis = false;
            this.lblPerosnaSeleccionado.AutoSize = false;
            this.lblPerosnaSeleccionado.CursorType = null;
            this.lblPerosnaSeleccionado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerosnaSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblPerosnaSeleccionado.Location = new System.Drawing.Point(153, 294);
            this.lblPerosnaSeleccionado.Name = "lblPerosnaSeleccionado";
            this.lblPerosnaSeleccionado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPerosnaSeleccionado.Size = new System.Drawing.Size(312, 25);
            this.lblPerosnaSeleccionado.TabIndex = 35;
            this.lblPerosnaSeleccionado.TabStop = false;
            this.lblPerosnaSeleccionado.Text = "...";
            this.lblPerosnaSeleccionado.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPerosnaSeleccionado.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowAnimations = true;
            this.btnBuscar.AllowMouseEffects = true;
            this.btnBuscar.AllowToggling = false;
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AnimationSpeed = 200;
            this.btnBuscar.AutoGenerateColors = false;
            this.btnBuscar.AutoRoundBorders = false;
            this.btnBuscar.AutoSizeLeftIcon = true;
            this.btnBuscar.AutoSizeRightIcon = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.ButtonText = "";
            this.btnBuscar.ButtonTextMarginLeft = 0;
            this.btnBuscar.ColorContrastOnClick = 45;
            this.btnBuscar.ColorContrastOnHover = 45;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnBuscar.CustomizableEdges = borderEdges1;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnBuscar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.IconLeftPadding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnBuscar.IconMarginLeft = 11;
            this.btnBuscar.IconPadding = 5;
            this.btnBuscar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnBuscar.IdleBorderRadius = 3;
            this.btnBuscar.IdleBorderThickness = 1;
            this.btnBuscar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnBuscar.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.IdleIconLeftImage")));
            this.btnBuscar.IdleIconRightImage = null;
            this.btnBuscar.IndicateFocus = true;
            this.btnBuscar.Location = new System.Drawing.Point(427, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.OnDisabledState.BorderRadius = 3;
            this.btnBuscar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.OnDisabledState.BorderThickness = 1;
            this.btnBuscar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.OnDisabledState.IconLeftImage = null;
            this.btnBuscar.OnDisabledState.IconRightImage = null;
            this.btnBuscar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBuscar.onHoverState.BorderRadius = 3;
            this.btnBuscar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.onHoverState.BorderThickness = 1;
            this.btnBuscar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
            this.btnBuscar.onHoverState.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscar.onHoverState.IconLeftImage = null;
            this.btnBuscar.onHoverState.IconRightImage = null;
            this.btnBuscar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnBuscar.OnIdleState.BorderRadius = 3;
            this.btnBuscar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.OnIdleState.BorderThickness = 1;
            this.btnBuscar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnBuscar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnBuscar.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.OnIdleState.IconLeftImage")));
            this.btnBuscar.OnIdleState.IconRightImage = null;
            this.btnBuscar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBuscar.OnPressedState.BorderRadius = 3;
            this.btnBuscar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.OnPressedState.BorderThickness = 1;
            this.btnBuscar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBuscar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnPressedState.IconLeftImage = null;
            this.btnBuscar.OnPressedState.IconRightImage = null;
            this.btnBuscar.Size = new System.Drawing.Size(38, 33);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.TextMarginLeft = 0;
            this.btnBuscar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscar.UseDefaultRadiusAndThickness = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.AcceptsReturn = false;
            this.txtFiltrar.AcceptsTab = false;
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.AnimationSpeed = 200;
            this.txtFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.txtFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFiltrar.BackgroundImage")));
            this.txtFiltrar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFiltrar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFiltrar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFiltrar.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFiltrar.BorderRadius = 2;
            this.txtFiltrar.BorderThickness = 1;
            this.txtFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFiltrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrar.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.DefaultText = "";
            this.txtFiltrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.txtFiltrar.ForeColor = System.Drawing.Color.Silver;
            this.txtFiltrar.HideSelection = true;
            this.txtFiltrar.IconLeft = null;
            this.txtFiltrar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrar.IconPadding = 5;
            this.txtFiltrar.IconRight = null;
            this.txtFiltrar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrar.Lines = new string[0];
            this.txtFiltrar.Location = new System.Drawing.Point(22, 26);
            this.txtFiltrar.MaxLength = 20;
            this.txtFiltrar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFiltrar.Modified = false;
            this.txtFiltrar.Multiline = false;
            this.txtFiltrar.Name = "txtFiltrar";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltrar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFiltrar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltrar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            stateProperties4.ForeColor = System.Drawing.Color.Silver;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltrar.OnIdleState = stateProperties4;
            this.txtFiltrar.Padding = new System.Windows.Forms.Padding(3);
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFiltrar.PlaceholderText = "Escriba aquí...";
            this.txtFiltrar.ReadOnly = false;
            this.txtFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.SelectionLength = 0;
            this.txtFiltrar.SelectionStart = 0;
            this.txtFiltrar.ShortcutsEnabled = true;
            this.txtFiltrar.Size = new System.Drawing.Size(408, 40);
            this.txtFiltrar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFiltrar.TabIndex = 0;
            this.txtFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiltrar.TextMarginBottom = 0;
            this.txtFiltrar.TextMarginLeft = 3;
            this.txtFiltrar.TextMarginTop = 0;
            this.txtFiltrar.TextPlaceholder = "Escriba aquí...";
            this.txtFiltrar.UseSystemPasswordChar = false;
            this.txtFiltrar.WordWrap = true;
            // 
            // gridPersonas
            // 
            this.gridPersonas.AllowUserToAddRows = false;
            this.gridPersonas.AllowUserToDeleteRows = false;
            this.gridPersonas.AllowUserToResizeColumns = false;
            this.gridPersonas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.gridPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPersonas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.gridPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPersonas.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPersonas.EnableHeadersVisualStyles = false;
            this.gridPersonas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridPersonas.Location = new System.Drawing.Point(22, 66);
            this.gridPersonas.MultiSelect = false;
            this.gridPersonas.Name = "gridPersonas";
            this.gridPersonas.ReadOnly = true;
            this.gridPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPersonas.RowHeadersVisible = false;
            this.gridPersonas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridPersonas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonas.Size = new System.Drawing.Size(443, 193);
            this.gridPersonas.TabIndex = 1;
            this.gridPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPersonas_CellClick);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AllowParentOverrides = false;
            this.lblTotalRegistros.AutoEllipsis = false;
            this.lblTotalRegistros.AutoSize = false;
            this.lblTotalRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.lblTotalRegistros.CursorType = null;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(129)))));
            this.lblTotalRegistros.Location = new System.Drawing.Point(22, 265);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalRegistros.Size = new System.Drawing.Size(246, 23);
            this.lblTotalRegistros.TabIndex = 29;
            this.lblTotalRegistros.TabStop = false;
            this.lblTotalRegistros.Text = "TOTAL DE REGISTROS: 0";
            this.lblTotalRegistros.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalRegistros.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AllowAnimations = true;
            this.btnRegistrar.AllowMouseEffects = true;
            this.btnRegistrar.AllowToggling = false;
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
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
            this.btnRegistrar.Location = new System.Drawing.Point(707, 374);
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
            this.btnRegistrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(98)))));
            this.btnRegistrar.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.btnRegistrar.onHoverState.IconLeftImage = null;
            this.btnRegistrar.onHoverState.IconRightImage = null;
            this.btnRegistrar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(115)))), ((int)(((byte)(149)))));
            this.btnRegistrar.OnIdleState.BorderRadius = 3;
            this.btnRegistrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistrar.OnIdleState.BorderThickness = 1;
            this.btnRegistrar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(45)))));
            this.btnRegistrar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
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
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.TextMarginLeft = 0;
            this.btnRegistrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegistrar.UseDefaultRadiusAndThickness = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AllowAnimations = true;
            this.btnCancelar.AllowMouseEffects = true;
            this.btnCancelar.AllowToggling = false;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnCancelar.CustomizableEdges = borderEdges3;
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
            this.btnCancelar.Location = new System.Drawing.Point(537, 374);
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
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.TextMarginLeft = 0;
            this.btnCancelar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancelar.UseDefaultRadiusAndThickness = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.bunifuGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuGroupBox1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuGroupBox1.BorderRadius = 2;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.cboCentroVac);
            this.bunifuGroupBox1.Controls.Add(this.cboCamposFiltrar);
            this.bunifuGroupBox1.Controls.Add(this.cboRoles);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel7);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel6);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel5);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(20, 14);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(346, 338);
            this.bunifuGroupBox1.TabIndex = 0;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Seleccione un elemento";
            // 
            // cboCentroVac
            // 
            this.cboCentroVac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCentroVac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCentroVac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCentroVac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.cboCentroVac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCentroVac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCentroVac.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cboCentroVac.FormattingEnabled = true;
            this.cboCentroVac.Location = new System.Drawing.Point(20, 66);
            this.cboCentroVac.Name = "cboCentroVac";
            this.cboCentroVac.Size = new System.Drawing.Size(309, 29);
            this.cboCentroVac.TabIndex = 0;
            // 
            // cboCamposFiltrar
            // 
            this.cboCamposFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCamposFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCamposFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCamposFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.cboCamposFiltrar.DisplayMember = "0";
            this.cboCamposFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCamposFiltrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamposFiltrar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cboCamposFiltrar.FormattingEnabled = true;
            this.cboCamposFiltrar.Location = new System.Drawing.Point(20, 207);
            this.cboCamposFiltrar.Name = "cboCamposFiltrar";
            this.cboCamposFiltrar.Size = new System.Drawing.Size(309, 29);
            this.cboCamposFiltrar.TabIndex = 2;
            this.cboCamposFiltrar.Tag = "";
            // 
            // cboRoles
            // 
            this.cboRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRoles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.cboRoles.DisplayMember = "0";
            this.cboRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoles.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(20, 134);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(309, 29);
            this.cboRoles.TabIndex = 1;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.AutoSize = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuLabel7.Location = new System.Drawing.Point(20, 42);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(253, 25);
            this.bunifuLabel7.TabIndex = 0;
            this.bunifuLabel7.TabStop = false;
            this.bunifuLabel7.Text = "CENTRO DE VACUNACIONES";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.AutoSize = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuLabel6.Location = new System.Drawing.Point(20, 111);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(246, 25);
            this.bunifuLabel6.TabIndex = 2;
            this.bunifuLabel6.TabStop = false;
            this.bunifuLabel6.Text = "ROLES";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.AutoSize = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuLabel5.Location = new System.Drawing.Point(20, 183);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(246, 25);
            this.bunifuLabel5.TabIndex = 1;
            this.bunifuLabel5.TabStop = false;
            this.bunifuLabel5.Text = "FILTRAR PERSONAS POR";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmResponsableRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(950, 631);
            this.Controls.Add(this.pnlFondoControles);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResponsableRegistrar";
            this.Text = "frmResponsableRegistrar";
            this.Load += new System.EventHandler(this.frmResponsableRegistrar_Load);
            this.pnlFondoControles.ResumeLayout(false);
            this.bfGrupoTexto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonas)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.UI.WinForms.BunifuPanel pnlFondoControles;
        private Bunifu.UI.WinForms.BunifuGroupBox bfGrupoTexto;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegistrar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelar;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.ComboBox cboCentroVac;
        private System.Windows.Forms.ComboBox cboCamposFiltrar;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.ComboBox cboRoles;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private System.Windows.Forms.DataGridView gridPersonas;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalRegistros;
        private Bunifu.UI.WinForms.BunifuTextBox txtFiltrar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuscar;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuLabel lblPerosnaSeleccionado;
    }
}