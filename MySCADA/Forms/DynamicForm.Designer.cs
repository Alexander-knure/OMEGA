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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicForm));
            this.lbPoint = new MetroFramework.Controls.MetroLabel();
            this.dtToTime = new MetroFramework.Controls.MetroDateTime();
            this.dtFromTime = new MetroFramework.Controls.MetroDateTime();
            this.lbTo = new MetroFramework.Controls.MetroLabel();
            this.lbFrom = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
            this.cbTimeInterval = new MetroFramework.Controls.MetroComboBox();
            this.cbVariables = new MetroFramework.Controls.MetroComboBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbHeader = new MetroFramework.Controls.MetroLabel();
            this.dTimer = new System.Windows.Forms.Timer(this.components);
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
            this.dtToTime.Value = new System.DateTime(2020, 5, 26, 0, 0, 0, 0);
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
            this.lbStatus.TabIndex = 44;
            this.lbStatus.Text = "Status: unknow";
            this.lbStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbStatus.UseCustomForeColor = true;
            // 
            // cbTimeInterval
            // 
            this.cbTimeInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTimeInterval.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbTimeInterval.ForeColor = System.Drawing.Color.White;
            this.cbTimeInterval.FormattingEnabled = true;
            this.cbTimeInterval.ItemHeight = 23;
            this.cbTimeInterval.Location = new System.Drawing.Point(716, 16);
            this.cbTimeInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbTimeInterval.Name = "cbTimeInterval";
            this.cbTimeInterval.PromptText = "Choose time";
            this.cbTimeInterval.Size = new System.Drawing.Size(186, 29);
            this.cbTimeInterval.Style = MetroFramework.MetroColorStyle.Black;
            this.cbTimeInterval.TabIndex = 43;
            this.cbTimeInterval.Tag = "";
            this.cbTimeInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbTimeInterval.UseSelectable = true;
            this.cbTimeInterval.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            this.cbTimeInterval.Click += new System.EventHandler(this.cbTimeFrom_Click);
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
            chartArea3.Area3DStyle.Inclination = 10;
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea3.Area3DStyle.PointDepth = 40;
            chartArea3.Area3DStyle.Rotation = 10;
            chartArea3.Area3DStyle.WallWidth = 5;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Angle = 1;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.Title = "X";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 90F;
            chartArea3.InnerPlotPosition.Width = 90F;
            chartArea3.InnerPlotPosition.X = 10F;
            chartArea3.InnerPlotPosition.Y = 4.49097F;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.DarkGray;
            this.MainChart.ChartAreas.Add(chartArea3);
            this.MainChart.Cursor = System.Windows.Forms.Cursors.Cross;
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.BorderWidth = 5;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Font = new System.Drawing.Font("Consolas", 12F);
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend3.HeaderSeparatorColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend3.MaximumAutoSize = 10F;
            legend3.Name = "Legend1";
            legend3.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.TitleForeColor = System.Drawing.Color.White;
            legend3.TitleSeparatorColor = System.Drawing.Color.White;
            this.MainChart.Legends.Add(legend3);
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
            // DynamicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.dtToTime);
            this.Controls.Add(this.dtFromTime);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbTimeInterval);
            this.Controls.Add(this.cbVariables);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.lbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DynamicForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DynamicForm_FormClosed);
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
        private MetroFramework.Controls.MetroLabel lbStatus;
        private MetroFramework.Controls.MetroComboBox cbTimeInterval;
        private MetroFramework.Controls.MetroComboBox cbVariables;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private MetroFramework.Controls.MetroLabel lbHeader;
        private System.Windows.Forms.Timer dTimer;
    }
}