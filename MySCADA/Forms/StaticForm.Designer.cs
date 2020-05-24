namespace NURESCADA
{
    partial class StaticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticForm));
            this.lbHeader = new MetroFramework.Controls.MetroLabel();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHeader.AutoSize = true;
            this.lbHeader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(16, 16);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(115, 25);
            this.lbHeader.TabIndex = 11;
            this.lbHeader.Text = "Static graph";
            this.lbHeader.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbHeader.UseCustomForeColor = true;
            // 
            // MainChart
            // 
            this.MainChart.BackColor = System.Drawing.Color.Transparent;
            this.MainChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            this.MainChart.BorderSkin.BackColor = System.Drawing.Color.Maroon;
            this.MainChart.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DiagonalBrick;
            this.MainChart.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.MainChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.MainChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea8.Area3DStyle.Inclination = 10;
            chartArea8.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea8.Area3DStyle.PointDepth = 40;
            chartArea8.Area3DStyle.Rotation = 10;
            chartArea8.Area3DStyle.WallWidth = 5;
            chartArea8.AxisX.IsLabelAutoFit = false;
            chartArea8.AxisX.LabelStyle.Angle = 1;
            chartArea8.AxisX.LabelStyle.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea8.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisX.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MajorGrid.LineWidth = 0;
            chartArea8.AxisX.TitleFont = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea8.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.Maximum = 100D;
            chartArea8.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea8.BackColor = System.Drawing.Color.Transparent;
            chartArea8.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea8.BackSecondaryColor = System.Drawing.Color.White;
            chartArea8.BorderWidth = 0;
            chartArea8.InnerPlotPosition.Auto = false;
            chartArea8.InnerPlotPosition.Height = 90F;
            chartArea8.InnerPlotPosition.Width = 90F;
            chartArea8.InnerPlotPosition.X = 10F;
            chartArea8.InnerPlotPosition.Y = 4.49097F;
            chartArea8.Name = "ChartArea1";
            chartArea8.ShadowColor = System.Drawing.Color.DarkGray;
            this.MainChart.ChartAreas.Add(chartArea8);
            legend8.Alignment = System.Drawing.StringAlignment.Center;
            legend8.BackColor = System.Drawing.Color.Transparent;
            legend8.BorderWidth = 5;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Font = new System.Drawing.Font("Consolas", 12F);
            legend8.ForeColor = System.Drawing.Color.White;
            legend8.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend8.HeaderSeparatorColor = System.Drawing.Color.White;
            legend8.IsTextAutoFit = false;
            legend8.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend8.MaximumAutoSize = 10F;
            legend8.Name = "Legend1";
            legend8.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend8.TitleForeColor = System.Drawing.Color.White;
            legend8.TitleSeparatorColor = System.Drawing.Color.White;
            this.MainChart.Legends.Add(legend8);
            this.MainChart.Location = new System.Drawing.Point(0, 75);
            this.MainChart.Margin = new System.Windows.Forms.Padding(0);
            this.MainChart.Name = "MainChart";
            this.MainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.MainChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow};
            series36.BorderWidth = 2;
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series36.Font = new System.Drawing.Font("Consolas", 20F);
            series36.LabelBackColor = System.Drawing.Color.Transparent;
            series36.LabelBorderColor = System.Drawing.Color.Transparent;
            series36.LabelForeColor = System.Drawing.Color.White;
            series36.Legend = "Legend1";
            series36.Name = "CPU";
            series37.BorderWidth = 2;
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series37.Font = new System.Drawing.Font("Consolas", 8F);
            series37.LabelBorderWidth = 2;
            series37.LabelForeColor = System.Drawing.Color.White;
            series37.Legend = "Legend1";
            series37.Name = "RAM";
            series38.BorderWidth = 2;
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series38.Font = new System.Drawing.Font("Consolas", 8F);
            series38.LabelBorderWidth = 2;
            series38.LabelForeColor = System.Drawing.Color.White;
            series38.Legend = "Legend1";
            series38.Name = "t CPU";
            series39.BorderWidth = 2;
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series39.Font = new System.Drawing.Font("Consolas", 8F);
            series39.LabelBorderWidth = 2;
            series39.LabelForeColor = System.Drawing.Color.White;
            series39.Legend = "Legend1";
            series39.Name = "t motherboard";
            series40.BorderWidth = 2;
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series40.Font = new System.Drawing.Font("Consolas", 8F);
            series40.LabelBorderWidth = 2;
            series40.LabelForeColor = System.Drawing.Color.White;
            series40.Legend = "Legend1";
            series40.Name = "Voltage";
            this.MainChart.Series.Add(series36);
            this.MainChart.Series.Add(series37);
            this.MainChart.Series.Add(series38);
            this.MainChart.Series.Add(series39);
            this.MainChart.Series.Add(series40);
            this.MainChart.Size = new System.Drawing.Size(940, 520);
            this.MainChart.TabIndex = 24;
            this.MainChart.Text = "MainChart";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(230, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(186, 29);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.lbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaticForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}