
namespace DESIGNER.MenuInicio
{
    partial class frmNavegadorWEb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavegadorWEb));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.wbNavegarInternet = new System.Windows.Forms.WebBrowser();
            this.pnlBarraOpciones = new System.Windows.Forms.Panel();
            this.txtUrlBuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlBarraOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbNavegarInternet
            // 
            this.wbNavegarInternet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbNavegarInternet.Location = new System.Drawing.Point(0, 64);
            this.wbNavegarInternet.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNavegarInternet.Name = "wbNavegarInternet";
            this.wbNavegarInternet.ScriptErrorsSuppressed = true;
            this.wbNavegarInternet.Size = new System.Drawing.Size(877, 386);
            this.wbNavegarInternet.TabIndex = 0;
            this.wbNavegarInternet.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // pnlBarraOpciones
            // 
            this.pnlBarraOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(94)))), ((int)(((byte)(144)))));
            this.pnlBarraOpciones.Controls.Add(this.txtUrlBuscar);
            this.pnlBarraOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraOpciones.Name = "pnlBarraOpciones";
            this.pnlBarraOpciones.Size = new System.Drawing.Size(877, 64);
            this.pnlBarraOpciones.TabIndex = 1;
            // 
            // txtUrlBuscar
            // 
            this.txtUrlBuscar.AcceptsReturn = false;
            this.txtUrlBuscar.AcceptsTab = false;
            this.txtUrlBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlBuscar.AnimationSpeed = 200;
            this.txtUrlBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUrlBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUrlBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtUrlBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUrlBuscar.BackgroundImage")));
            this.txtUrlBuscar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUrlBuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUrlBuscar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUrlBuscar.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUrlBuscar.BorderRadius = 1;
            this.txtUrlBuscar.BorderThickness = 1;
            this.txtUrlBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUrlBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrlBuscar.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlBuscar.DefaultText = "";
            this.txtUrlBuscar.FillColor = System.Drawing.Color.White;
            this.txtUrlBuscar.HideSelection = true;
            this.txtUrlBuscar.IconLeft = null;
            this.txtUrlBuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrlBuscar.IconPadding = 10;
            this.txtUrlBuscar.IconRight = null;
            this.txtUrlBuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrlBuscar.Lines = new string[0];
            this.txtUrlBuscar.Location = new System.Drawing.Point(547, 12);
            this.txtUrlBuscar.MaxLength = 32767;
            this.txtUrlBuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUrlBuscar.Modified = false;
            this.txtUrlBuscar.Multiline = false;
            this.txtUrlBuscar.Name = "txtUrlBuscar";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrlBuscar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUrlBuscar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrlBuscar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrlBuscar.OnIdleState = stateProperties4;
            this.txtUrlBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.txtUrlBuscar.PasswordChar = '\0';
            this.txtUrlBuscar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUrlBuscar.PlaceholderText = "URL:";
            this.txtUrlBuscar.ReadOnly = false;
            this.txtUrlBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrlBuscar.SelectedText = "";
            this.txtUrlBuscar.SelectionLength = 0;
            this.txtUrlBuscar.SelectionStart = 0;
            this.txtUrlBuscar.ShortcutsEnabled = true;
            this.txtUrlBuscar.Size = new System.Drawing.Size(306, 38);
            this.txtUrlBuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUrlBuscar.TabIndex = 0;
            this.txtUrlBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUrlBuscar.TextMarginBottom = 0;
            this.txtUrlBuscar.TextMarginLeft = 3;
            this.txtUrlBuscar.TextMarginTop = 0;
            this.txtUrlBuscar.TextPlaceholder = "URL:";
            this.txtUrlBuscar.UseSystemPasswordChar = false;
            this.txtUrlBuscar.WordWrap = true;
            this.txtUrlBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrlBuscar_KeyPress);
            // 
            // frmNavegadorWEb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.wbNavegarInternet);
            this.Controls.Add(this.pnlBarraOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNavegadorWEb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNavegadorWEb";
            this.pnlBarraOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbNavegarInternet;
        private System.Windows.Forms.Panel pnlBarraOpciones;
        private Bunifu.UI.WinForms.BunifuTextBox txtUrlBuscar;
    }
}