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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicForm));
            this.lbPoint = new MetroFramework.Controls.MetroLabel();
            this.dtToTime = new MetroFramework.Controls.MetroDateTime();
            this.dtFromTime = new MetroFramework.Controls.MetroDateTime();
            this.lbTo = new MetroFramework.Controls.MetroLabel();
            this.lbFrom = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.cbVariables = new MetroFramework.Controls.MetroComboBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbHeader = new MetroFramework.Controls.MetroLabel();
            this.dTimer = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new MetroFramework.Controls.MetroLabel();
            this.btTimer = new MetroFramework.Controls.MetroButton();
            this.cbTypePoints = new MetroFramework.Controls.MetroComboBox();
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPoint
            // 
            this.lbPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPoint.AutoSize = true;
            this.lbPoint.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPoint.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbPoint.ForeColor = System.Drawing.Color.White;
            this.lbPoint.Location = new System.Drawing.Point(26, 75);
            this.lbPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(17, 25);
            this.lbPoint.TabIndex = 50;
            this.lbPoint.Text = " ";
            this.lbPoint.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbPoint.UseCustomForeColor = true;
            // 
            // dtToTime
            // 
            this.dtToTime.AllowDrop = true;
            this.dtToTime.CalendarFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtToTime.CalendarForeColor = System.Drawing.Color.White;
            this.dtToTime.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtToTime.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtToTime.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtToTime.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtToTime.CustomFormat = "hh:mm:ss   dd/MM/yyyy";
            this.dtToTime.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtToTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToTime.Location = new System.Drawing.Point(716, 48);
            this.dtToTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtToTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtToTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtToTime.Name = "dtToTime";
            this.dtToTime.Size = new System.Drawing.Size(186, 29);
            this.dtToTime.Style = MetroFramework.MetroColorStyle.Red;
            this.dtToTime.TabIndex = 49;
            this.dtToTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtToTime.Value = new System.DateTime(2020, 6, 3, 0, 0, 0, 0);
            this.dtToTime.Visible = false;
            this.dtToTime.ValueChanged += new System.EventHandler(this.dtToTime_ValueChanged);
            // 
            // dtFromTime
            // 
            this.dtFromTime.AllowDrop = true;
            this.dtFromTime.CalendarFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtFromTime.CalendarForeColor = System.Drawing.Color.White;
            this.dtFromTime.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtFromTime.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtFromTime.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtFromTime.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtFromTime.CustomFormat = "hh:mm:ss   dd/MM/yyyy";
            this.dtFromTime.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromTime.Location = new System.Drawing.Point(491, 48);
            this.dtFromTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtFromTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFromTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFromTime.Name = "dtFromTime";
            this.dtFromTime.Size = new System.Drawing.Size(186, 29);
            this.dtFromTime.Style = MetroFramework.MetroColorStyle.Red;
            this.dtFromTime.TabIndex = 48;
            this.dtFromTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtFromTime.Value = new System.DateTime(2020, 5, 18, 0, 0, 0, 0);
            this.dtFromTime.Visible = false;
            this.dtFromTime.ValueChanged += new System.EventHandler(this.dtFromTime_ValueChanged);
            // 
            // lbTo
            // 
            this.lbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTo.AutoSize = true;
            this.lbTo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbTo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbTo.ForeColor = System.Drawing.Color.White;
            this.lbTo.Location = new System.Drawing.Point(682, 48);
            this.lbTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(29, 25);
            this.lbTo.TabIndex = 47;
            this.lbTo.Text = "to";
            this.lbTo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbTo.UseCustomForeColor = true;
            this.lbTo.Visible = false;
            // 
            // lbFrom
            // 
            this.lbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFrom.AutoSize = true;
            this.lbFrom.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbFrom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbFrom.ForeColor = System.Drawing.Color.White;
            this.lbFrom.Location = new System.Drawing.Point(435, 48);
            this.lbFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(51, 25);
            this.lbFrom.TabIndex = 46;
            this.lbFrom.Text = "from";
            this.lbFrom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbFrom.UseCustomForeColor = true;
            this.lbFrom.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(230, 48);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 29);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbVariables
            // 
            this.cbVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVariables.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbVariables.ForeColor = System.Drawing.Color.White;
            this.cbVariables.FormattingEnabled = true;
            this.cbVariables.ItemHeight = 23;
            this.cbVariables.Location = new System.Drawing.Point(491, 16);
            this.cbVariables.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbVariables.Name = "cbVariables";
            this.cbVariables.PromptText = "Choose variable";
            this.cbVariables.Size = new System.Drawing.Size(186, 29);
            this.cbVariables.Style = MetroFramework.MetroColorStyle.Black;
            this.cbVariables.TabIndex = 42;
            this.cbVariables.Tag = "";
            this.cbVariables.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbVariables.UseSelectable = true;
            this.cbVariables.SelectedIndexChanged += new System.EventHandler(this.cbVariables_SelectedIndexChanged);
            this.cbVariables.Click += new System.EventHandler(this.cbVariables_Click);
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
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.MainChart.Cursor = System.Windows.Forms.Cursors.Cross;
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
            this.MainChart.Location = new System.Drawing.Point(0, 122);
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
            this.MainChart.Size = new System.Drawing.Size(940, 473);
            this.MainChart.TabIndex = 40;
            this.MainChart.Text = "MainChart";
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
            this.lbHeader.TabIndex = 39;
            this.lbHeader.Text = "Dynamic graph";
            this.lbHeader.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbHeader.UseCustomForeColor = true;
            // 
            // dTimer
            // 
            this.dTimer.Interval = 1000;
            this.dTimer.Tick += new System.EventHandler(this.dTimer_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimer.AutoSize = true;
            this.lbTimer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbTimer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(643, 85);
            this.lbTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(103, 25);
            this.lbTimer.TabIndex = 51;
            this.lbTimer.Text = "Time: 00:00";
            this.lbTimer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbTimer.UseCustomForeColor = true;
            // 
            // btTimer
            // 
            this.btTimer.BackColor = System.Drawing.Color.Transparent;
            this.btTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTimer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btTimer.ForeColor = System.Drawing.Color.White;
            this.btTimer.Location = new System.Drawing.Point(230, 81);
            this.btTimer.Margin = new System.Windows.Forms.Padding(0);
            this.btTimer.Name = "btTimer";
            this.btTimer.Size = new System.Drawing.Size(186, 29);
            this.btTimer.TabIndex = 52;
            this.btTimer.Text = "Start";
            this.btTimer.UseCustomBackColor = true;
            this.btTimer.UseCustomForeColor = true;
            this.btTimer.UseSelectable = true;
            this.btTimer.Click += new System.EventHandler(this.btTimer_Click);
            // 
            // cbTypePoints
            // 
            this.cbTypePoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTypePoints.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbTypePoints.ForeColor = System.Drawing.Color.White;
            this.cbTypePoints.FormattingEnabled = true;
            this.cbTypePoints.ItemHeight = 23;
            this.cbTypePoints.Location = new System.Drawing.Point(716, 16);
            this.cbTypePoints.Margin = new System.Windows.Forms.Padding(0);
            this.cbTypePoints.Name = "cbTypePoints";
            this.cbTypePoints.PromptText = "Choose type";
            this.cbTypePoints.Size = new System.Drawing.Size(186, 29);
            this.cbTypePoints.Style = MetroFramework.MetroColorStyle.Black;
            this.cbTypePoints.TabIndex = 53;
            this.cbTypePoints.Tag = "";
            this.cbTypePoints.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbTypePoints.UseSelectable = true;
            this.cbTypePoints.SelectedIndexChanged += new System.EventHandler(this.cbTypePoints_SelectedIndexChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(16, 48);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(132, 25);
            this.lbStatus.TabIndex = 54;
            this.lbStatus.Text = "Status: unknow";
            this.lbStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbStatus.UseCustomForeColor = true;
            // 
            // DynamicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbTypePoints);
            this.Controls.Add(this.btTimer);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.dtToTime);
            this.Controls.Add(this.dtFromTime);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbVariables);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.lbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DynamicForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DynamicForm_FormClosed);
            this.Load += new System.EventHandler(this.DynamicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbPoint;
        private MetroFramework.Controls.MetroDateTime dtToTime;
        private MetroFramework.Controls.MetroDateTime dtFromTime;
        private MetroFramework.Controls.MetroLabel lbTo;
        private MetroFramework.Controls.MetroLabel lbFrom;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroComboBox cbVariables;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private MetroFramework.Controls.MetroLabel lbHeader;
        private MetroFramework.Controls.MetroLabel lbTimer;
        public System.Windows.Forms.Timer dTimer;
        private MetroFramework.Controls.MetroButton btTimer;
        private MetroFramework.Controls.MetroComboBox cbTypePoints;
        private MetroFramework.Controls.MetroLabel lbStatus;
    }
}