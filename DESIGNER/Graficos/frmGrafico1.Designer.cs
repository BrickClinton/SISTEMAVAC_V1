
namespace DESIGNER.Graficos
{
    partial class frmGrafico1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafico1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCerrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.pnlContenedor.Controls.Add(this.btnCerrar);
            this.pnlContenedor.Controls.Add(this.chart2);
            this.pnlContenedor.Controls.Add(this.chart1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(901, 564);
            this.pnlContenedor.TabIndex = 0;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Silver;
            this.chart2.BorderlineColor = System.Drawing.Color.Maroon;
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(431, 138);
            this.chart2.Name = "chart2";
            series1.BackImageTransparentColor = System.Drawing.Color.Gray;
            series1.BackSecondaryColor = System.Drawing.Color.SpringGreen;
            series1.BorderColor = System.Drawing.Color.Teal;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.MediumSeaGreen;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelAngle = 1;
            series1.LabelBackColor = System.Drawing.Color.Silver;
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Gray;
            series1.MarkerColor = System.Drawing.Color.LightSeaGreen;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ShadowColor = System.Drawing.Color.Maroon;
            series1.YValuesPerPoint = 4;
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(390, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.chart1.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea2.BackColor = System.Drawing.Color.MediumSeaGreen;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.chart2.Annotations;
            legend2.BackColor = System.Drawing.Color.Gray;
            legend2.BorderColor = System.Drawing.Color.Green;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(36, 138);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series2.BackSecondaryColor = System.Drawing.Color.LightCoral;
            series2.BorderColor = System.Drawing.Color.Maroon;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.RosyBrown;
            series2.LabelBorderColor = System.Drawing.Color.Tan;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(280, 272);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            this.btnCerrar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.ButtonText = "Cerrar";
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
            this.btnCerrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCerrar.IconMarginLeft = 11;
            this.btnCerrar.IconPadding = 10;
            this.btnCerrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.IdleBorderRadius = 1;
            this.btnCerrar.IdleBorderThickness = 1;
            this.btnCerrar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.IdleIconLeftImage = null;
            this.btnCerrar.IdleIconRightImage = null;
            this.btnCerrar.IndicateFocus = false;
            this.btnCerrar.Location = new System.Drawing.Point(706, 22);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.OnDisabledState.BorderRadius = 1;
            this.btnCerrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnDisabledState.BorderThickness = 1;
            this.btnCerrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCerrar.OnDisabledState.IconLeftImage = null;
            this.btnCerrar.OnDisabledState.IconRightImage = null;
            this.btnCerrar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCerrar.onHoverState.BorderRadius = 1;
            this.btnCerrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.onHoverState.BorderThickness = 1;
            this.btnCerrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCerrar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.onHoverState.IconLeftImage = null;
            this.btnCerrar.onHoverState.IconRightImage = null;
            this.btnCerrar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.OnIdleState.BorderRadius = 1;
            this.btnCerrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnIdleState.BorderThickness = 1;
            this.btnCerrar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnIdleState.IconLeftImage = null;
            this.btnCerrar.OnIdleState.IconRightImage = null;
            this.btnCerrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCerrar.OnPressedState.BorderRadius = 1;
            this.btnCerrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnPressedState.BorderThickness = 1;
            this.btnCerrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCerrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnPressedState.IconLeftImage = null;
            this.btnCerrar.OnPressedState.IconRightImage = null;
            this.btnCerrar.Size = new System.Drawing.Size(150, 39);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.TextMarginLeft = 0;
            this.btnCerrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCerrar.UseDefaultRadiusAndThickness = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmGrafico1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 564);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrafico1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrafico1";
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCerrar;
    }
}