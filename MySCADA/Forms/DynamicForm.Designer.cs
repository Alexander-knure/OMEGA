namespace NURESCADA.Forms
{
    partial class DynamicForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicForm));
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
            this.lbHeader.Size = new System.Drawing.Size(141, 25);
            this.lbHeader.TabIndex = 12;
            this.lbHeader.Text = "Dynamic graph";
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
            chartArea7.Area3DStyle.Inclination = 10;
            chartArea7.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea7.Area3DStyle.PointDepth = 40;
            chartArea7.Area3DStyle.Rotation = 10;
            chartArea7.Area3DStyle.WallWidth = 5;
            chartArea7.AxisX.IsLabelAutoFit = false;
            chartArea7.AxisX.LabelStyle.Angle = 1;
            chartArea7.AxisX.LabelStyle.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.LineWidth = 0;
            chartArea7.AxisX.TitleFont = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.Maximum = 100D;
            chartArea7.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea7.BackSecondaryColor = System.Drawing.Color.White;
            chartArea7.BorderWidth = 0;
            chartArea7.InnerPlotPosition.Auto = false;
            chartArea7.InnerPlotPosition.Height = 90F;
            chartArea7.InnerPlotPosition.Width = 90F;
            chartArea7.InnerPlotPosition.X = 10F;
            chartArea7.InnerPlotPosition.Y = 4.49097F;
            chartArea7.Name = "ChartArea1";
            chartArea7.ShadowColor = System.Drawing.Color.DarkGray;
            this.MainChart.ChartAreas.Add(chartArea7);
            legend7.Alignment = System.Drawing.StringAlignment.Center;
            legend7.BackColor = System.Drawing.Color.Transparent;
            legend7.BorderWidth = 5;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend7.Font = new System.Drawing.Font("Consolas", 12F);
            legend7.ForeColor = System.Drawing.Color.White;
            legend7.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend7.HeaderSeparatorColor = System.Drawing.Color.White;
            legend7.IsTextAutoFit = false;
            legend7.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend7.MaximumAutoSize = 10F;
            legend7.Name = "Legend1";
            legend7.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend7.TitleForeColor = System.Drawing.Color.White;
            legend7.TitleSeparatorColor = System.Drawing.Color.White;
            this.MainChart.Legends.Add(legend7);
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
            series31.BorderWidth = 2;
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series31.Font = new System.Drawing.Font("Consolas", 20F);
            series31.LabelBackColor = System.Drawing.Color.Transparent;
            series31.LabelBorderColor = System.Drawing.Color.Transparent;
            series31.LabelForeColor = System.Drawing.Color.White;
            series31.Legend = "Legend1";
            series31.Name = "CPU";
            series32.BorderWidth = 2;
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series32.Font = new System.Drawing.Font("Consolas", 8F);
            series32.LabelBorderWidth = 2;
            series32.LabelForeColor = System.Drawing.Color.White;
            series32.Legend = "Legend1";
            series32.Name = "RAM";
            series33.BorderWidth = 2;
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series33.Font = new System.Drawing.Font("Consolas", 8F);
            series33.LabelBorderWidth = 2;
            series33.LabelForeColor = System.Drawing.Color.White;
            series33.Legend = "Legend1";
            series33.Name = "t CPU";
            series34.BorderWidth = 2;
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series34.Font = new System.Drawing.Font("Consolas", 8F);
            series34.LabelBorderWidth = 2;
            series34.LabelForeColor = System.Drawing.Color.White;
            series34.Legend = "Legend1";
            series34.Name = "t motherboard";
            series35.BorderWidth = 2;
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series35.Font = new System.Drawing.Font("Consolas", 8F);
            series35.LabelBorderWidth = 2;
            series35.LabelForeColor = System.Drawing.Color.White;
            series35.Legend = "Legend1";
            series35.Name = "Voltage";
            this.MainChart.Series.Add(series31);
            this.MainChart.Series.Add(series32);
            this.MainChart.Series.Add(series33);
            this.MainChart.Series.Add(series34);
            this.MainChart.Series.Add(series35);
            this.MainChart.Size = new System.Drawing.Size(940, 520);
            this.MainChart.TabIndex = 23;
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
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DynamicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.lbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DynamicForm";
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