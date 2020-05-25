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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticForm));
            this.lbHeader = new MetroFramework.Controls.MetroLabel();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.cbVariables = new MetroFramework.Controls.MetroComboBox();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.cbTimeInterval = new MetroFramework.Controls.MetroComboBox();
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
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 40;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 1;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 10F;
            chartArea1.InnerPlotPosition.Y = 4.49097F;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.DarkGray;
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderWidth = 5;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Consolas", 12F);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.MaximumAutoSize = 10F;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(0, 75);
            this.MainChart.Margin = new System.Windows.Forms.Padding(0);
            this.MainChart.Name = "MainChart";
            this.MainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.MainChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow,
        System.Drawing.Color.DarkViolet,
        System.Drawing.Color.White,
        System.Drawing.Color.Silver,
        System.Drawing.Color.IndianRed,
        System.Drawing.Color.Green};
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "v";
            this.MainChart.Series.Add(series1);
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
            // cbVariables
            // 
            this.cbVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVariables.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbVariables.ForeColor = System.Drawing.Color.White;
            this.cbVariables.FormattingEnabled = true;
            this.cbVariables.ItemHeight = 23;
            this.cbVariables.Location = new System.Drawing.Point(474, 16);
            this.cbVariables.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbVariables.Name = "cbVariables";
            this.cbVariables.PromptText = "Choose variable";
            this.cbVariables.Size = new System.Drawing.Size(186, 29);
            this.cbVariables.Style = MetroFramework.MetroColorStyle.Black;
            this.cbVariables.TabIndex = 26;
            this.cbVariables.Tag = "";
            this.cbVariables.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbVariables.UseSelectable = true;
            this.cbVariables.SelectedIndexChanged += new System.EventHandler(this.cbVariables_SelectedIndexChanged);
            this.cbVariables.Click += new System.EventHandler(this.cbVariables_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.AllowDrop = true;
            this.dtFrom.CalendarFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtFrom.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.dtFrom.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(474, 51);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(186, 29);
            this.dtFrom.Style = MetroFramework.MetroColorStyle.Black;
            this.dtFrom.TabIndex = 29;
            this.dtFrom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtFrom.Value = new System.DateTime(2020, 5, 25, 2, 27, 20, 0);
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.AllowDrop = true;
            this.dtTo.CalendarFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtTo.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.dtTo.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(707, 51);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(186, 29);
            this.dtTo.Style = MetroFramework.MetroColorStyle.Black;
            this.dtTo.TabIndex = 30;
            this.dtTo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtTo.Value = new System.DateTime(2020, 5, 25, 2, 27, 20, 0);
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // cbTimeInterval
            // 
            this.cbTimeInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTimeInterval.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbTimeInterval.ForeColor = System.Drawing.Color.White;
            this.cbTimeInterval.FormattingEnabled = true;
            this.cbTimeInterval.ItemHeight = 23;
            this.cbTimeInterval.Location = new System.Drawing.Point(707, 16);
            this.cbTimeInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbTimeInterval.Name = "cbTimeInterval";
            this.cbTimeInterval.PromptText = "Choose time";
            this.cbTimeInterval.Size = new System.Drawing.Size(186, 29);
            this.cbTimeInterval.Style = MetroFramework.MetroColorStyle.Black;
            this.cbTimeInterval.TabIndex = 31;
            this.cbTimeInterval.Tag = "";
            this.cbTimeInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbTimeInterval.UseSelectable = true;
            this.cbTimeInterval.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            this.cbTimeInterval.Click += new System.EventHandler(this.cbTimeInterval_Click);
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.cbTimeInterval);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.cbVariables);
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
        private MetroFramework.Controls.MetroComboBox cbVariables;
        private MetroFramework.Controls.MetroDateTime dtFrom;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MetroFramework.Controls.MetroComboBox cbTimeInterval;
    }
}