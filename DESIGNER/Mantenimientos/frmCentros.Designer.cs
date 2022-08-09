/*
 * Creado por SharpDevelop.
 * Usuario: Clinton
 * Fecha: 19/05/2021
 * Hora: 16:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace DESIGNER.Mantenimientos
{
	partial class frmCentros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cboDistritos = new System.Windows.Forms.ComboBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNombreCentro = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboProvincias = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cboDepartamentos = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboTipoCentro = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gridCentroVac = new System.Windows.Forms.DataGridView();
			this.menuNav = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.laboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vacunaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.responsablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.cerrarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.btnDialog = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCentroVac)).BeginInit();
			this.menuNav.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTelefono);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cboDistritos);
			this.groupBox1.Controls.Add(this.txtDireccion);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtNombreCentro);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cboProvincias);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cboDepartamentos);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cboTipoCentro);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(34, 118);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(327, 479);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos generales";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(47, 417);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(221, 23);
			this.txtTelefono.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(47, 401);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(175, 29);
			this.label7.TabIndex = 2;
			this.label7.Text = "Telefono";
			// 
			// cboDistritos
			// 
			this.cboDistritos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboDistritos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboDistritos.DisplayMember = "0";
			this.cboDistritos.FormattingEnabled = true;
			this.cboDistritos.Location = new System.Drawing.Point(47, 240);
			this.cboDistritos.Name = "cboDistritos";
			this.cboDistritos.Size = new System.Drawing.Size(221, 24);
			this.cboDistritos.TabIndex = 3;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(47, 357);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(221, 23);
			this.txtDireccion.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(47, 339);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 29);
			this.label6.TabIndex = 1;
			this.label6.Text = "Dirección";
			// 
			// txtNombreCentro
			// 
			this.txtNombreCentro.Location = new System.Drawing.Point(47, 298);
			this.txtNombreCentro.Name = "txtNombreCentro";
			this.txtNombreCentro.Size = new System.Drawing.Size(221, 23);
			this.txtNombreCentro.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(47, 225);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Distritos";
			// 
			// cboProvincias
			// 
			this.cboProvincias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboProvincias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboProvincias.DisplayMember = "0";
			this.cboProvincias.FormattingEnabled = true;
			this.cboProvincias.Location = new System.Drawing.Point(47, 180);
			this.cboProvincias.Name = "cboProvincias";
			this.cboProvincias.Size = new System.Drawing.Size(221, 24);
			this.cboProvincias.TabIndex = 2;
			this.cboProvincias.SelectedIndexChanged += new System.EventHandler(this.CboProvinciasSelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(47, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Provincias";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(47, 282);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(221, 29);
			this.label5.TabIndex = 0;
			this.label5.Text = "Nombre del centro de vacunación";
			// 
			// cboDepartamentos
			// 
			this.cboDepartamentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboDepartamentos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboDepartamentos.DisplayMember = "0";
			this.cboDepartamentos.FormattingEnabled = true;
			this.cboDepartamentos.Location = new System.Drawing.Point(47, 121);
			this.cboDepartamentos.Name = "cboDepartamentos";
			this.cboDepartamentos.Size = new System.Drawing.Size(221, 24);
			this.cboDepartamentos.TabIndex = 1;
			this.cboDepartamentos.Tag = "";
			this.cboDepartamentos.SelectedIndexChanged += new System.EventHandler(this.CboDepartamentosSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(47, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Departamentos";
			// 
			// cboTipoCentro
			// 
			this.cboTipoCentro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboTipoCentro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboTipoCentro.FormattingEnabled = true;
			this.cboTipoCentro.Location = new System.Drawing.Point(47, 63);
			this.cboTipoCentro.Name = "cboTipoCentro";
			this.cboTipoCentro.Size = new System.Drawing.Size(221, 24);
			this.cboTipoCentro.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(47, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Indicar el tipo de centro";
			// 
			// gridCentroVac
			// 
			this.gridCentroVac.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.gridCentroVac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCentroVac.Location = new System.Drawing.Point(379, 118);
			this.gridCentroVac.Name = "gridCentroVac";
			this.gridCentroVac.ReadOnly = true;
			this.gridCentroVac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridCentroVac.Size = new System.Drawing.Size(640, 479);
			this.gridCentroVac.TabIndex = 4;
			// 
			// menuNav
			// 
			this.menuNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.laboratoriosToolStripMenuItem,
									this.lotesToolStripMenuItem,
									this.vacunaciónToolStripMenuItem,
									this.responsablesToolStripMenuItem,
									this.toolStripMenuItem1,
									this.cerrarAplicaciónToolStripMenuItem});
			this.menuNav.Name = "menuNav";
			this.menuNav.Size = new System.Drawing.Size(164, 120);
			// 
			// laboratoriosToolStripMenuItem
			// 
			this.laboratoriosToolStripMenuItem.Name = "laboratoriosToolStripMenuItem";
			this.laboratoriosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.laboratoriosToolStripMenuItem.Text = "Laboratorios";
			// 
			// lotesToolStripMenuItem
			// 
			this.lotesToolStripMenuItem.Name = "lotesToolStripMenuItem";
			this.lotesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.lotesToolStripMenuItem.Text = "Lotes";
			// 
			// vacunaciónToolStripMenuItem
			// 
			this.vacunaciónToolStripMenuItem.Name = "vacunaciónToolStripMenuItem";
			this.vacunaciónToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.vacunaciónToolStripMenuItem.Text = "Vacunación";
			// 
			// responsablesToolStripMenuItem
			// 
			this.responsablesToolStripMenuItem.Name = "responsablesToolStripMenuItem";
			this.responsablesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.responsablesToolStripMenuItem.Text = "Responsables";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
			// 
			// cerrarAplicaciónToolStripMenuItem
			// 
			this.cerrarAplicaciónToolStripMenuItem.Name = "cerrarAplicaciónToolStripMenuItem";
			this.cerrarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.cerrarAplicaciónToolStripMenuItem.Text = "Cerrar aplicación";
			this.cerrarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.CerrarAplicaciónToolStripMenuItemClick);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.Color.Green;
			this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnRegistrar.Location = new System.Drawing.Point(81, 616);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(221, 35);
			this.btnRegistrar.TabIndex = 1;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Blue;
			this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnModificar.Location = new System.Drawing.Point(379, 616);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(202, 35);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
			this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnEliminar.Location = new System.Drawing.Point(806, 616);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(213, 35);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Green;
			this.label8.Location = new System.Drawing.Point(476, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(450, 41);
			this.label8.TabIndex = 5;
			this.label8.Text = "CENTROS DE VACUNACIONES";
			// 
			// btnDialog
			// 
			this.btnDialog.Location = new System.Drawing.Point(613, 616);
			this.btnDialog.Name = "btnDialog";
			this.btnDialog.Size = new System.Drawing.Size(144, 35);
			this.btnDialog.TabIndex = 6;
			this.btnDialog.Text = "Mostrar dialogo";
			this.btnDialog.UseVisualStyleBackColor = true;
			this.btnDialog.Click += new System.EventHandler(this.BtnDialogClick);
			// 
			// frmCentros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1050, 688);
			this.ContextMenuStrip = this.menuNav;
			this.Controls.Add(this.btnDialog);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.gridCentroVac);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmCentros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Centros de vacunación";
			this.Load += new System.EventHandler(this.FrmCentrosLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCentroVac)).EndInit();
			this.menuNav.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnDialog;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.ToolStripMenuItem cerrarAplicaciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem responsablesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vacunaciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lotesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem laboratoriosToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip menuNav;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNombreCentro;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.DataGridView gridCentroVac;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboDepartamentos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboProvincias;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboDistritos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboTipoCentro;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
