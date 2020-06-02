namespace NURESCADA
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.btnTimer = new MetroFramework.Controls.MetroButton();
            this.mainGrid = new MetroFramework.Controls.MetroGrid();
            this.btnDynamic = new MetroFramework.Controls.MetroButton();
            this.btnStatic = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnMnemonic = new MetroFramework.Controls.MetroButton();
            this.btnCommands = new MetroFramework.Controls.MetroButton();
            this.trendsminuteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simplescadaDataSet = new NURESCADA.simplescadaDataSet();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.lbHeader = new MetroFramework.Controls.MetroLabel();
            this.cbDataSets = new MetroFramework.Controls.MetroComboBox();
            this.trends_minuteTableAdapter = new NURESCADA.simplescadaDataSetTableAdapters.trends_minuteTableAdapter();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendsminuteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplescadaDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Status: unknow";
            this.lbStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbStatus.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.Black;
            this.metroPanel1.Controls.Add(this.btnLoad);
            this.metroPanel1.Controls.Add(this.btnTimer);
            this.metroPanel1.Controls.Add(this.mainGrid);
            this.metroPanel1.Controls.Add(this.btnDynamic);
            this.metroPanel1.Controls.Add(this.btnStatic);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 6;
            this.metroPanel1.Location = new System.Drawing.Point(16, 78);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(930, 502);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(744, 9);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(186, 29);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseCustomBackColor = true;
            this.btnLoad.UseCustomForeColor = true;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.UseStyleColors = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.Navy;
            this.btnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTimer.ForeColor = System.Drawing.Color.White;
            this.btnTimer.Location = new System.Drawing.Point(0, 9);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(186, 29);
            this.btnTimer.Style = MetroFramework.MetroColorStyle.Red;
            this.btnTimer.TabIndex = 9;
            this.btnTimer.Text = "Start";
            this.btnTimer.UseCustomBackColor = true;
            this.btnTimer.UseCustomForeColor = true;
            this.btnTimer.UseSelectable = true;
            this.btnTimer.UseStyleColors = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // mainGrid
            // 
            this.mainGrid.AllowUserToResizeRows = false;
            this.mainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mainGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.mainGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainGrid.EnableHeadersVisualStyles = false;
            this.mainGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mainGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainGrid.Location = new System.Drawing.Point(0, 51);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mainGrid.RowHeadersWidth = 60;
            this.mainGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGrid.Size = new System.Drawing.Size(930, 448);
            this.mainGrid.TabIndex = 10;
            this.mainGrid.UseCustomBackColor = true;
            this.mainGrid.UseCustomForeColor = true;
            // 
            // btnDynamic
            // 
            this.btnDynamic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnDynamic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDynamic.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDynamic.ForeColor = System.Drawing.Color.White;
            this.btnDynamic.Location = new System.Drawing.Point(372, 9);
            this.btnDynamic.Margin = new System.Windows.Forms.Padding(0);
            this.btnDynamic.Name = "btnDynamic";
            this.btnDynamic.Size = new System.Drawing.Size(186, 29);
            this.btnDynamic.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDynamic.TabIndex = 4;
            this.btnDynamic.Text = "Dynamic graph";
            this.btnDynamic.UseCustomBackColor = true;
            this.btnDynamic.UseCustomForeColor = true;
            this.btnDynamic.UseSelectable = true;
            this.btnDynamic.Click += new System.EventHandler(this.btnDynamic_Click);
            // 
            // btnStatic
            // 
            this.btnStatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnStatic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatic.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStatic.ForeColor = System.Drawing.Color.White;
            this.btnStatic.Location = new System.Drawing.Point(186, 9);
            this.btnStatic.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(186, 29);
            this.btnStatic.Style = MetroFramework.MetroColorStyle.Red;
            this.btnStatic.TabIndex = 3;
            this.btnStatic.Text = "Static graph";
            this.btnStatic.UseCustomBackColor = true;
            this.btnStatic.UseCustomForeColor = true;
            this.btnStatic.UseSelectable = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(558, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 29);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMnemonic
            // 
            this.btnMnemonic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnMnemonic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMnemonic.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnMnemonic.ForeColor = System.Drawing.Color.White;
            this.btnMnemonic.Location = new System.Drawing.Point(390, 44);
            this.btnMnemonic.Margin = new System.Windows.Forms.Padding(0);
            this.btnMnemonic.Name = "btnMnemonic";
            this.btnMnemonic.Size = new System.Drawing.Size(186, 29);
            this.btnMnemonic.Style = MetroFramework.MetroColorStyle.Red;
            this.btnMnemonic.TabIndex = 6;
            this.btnMnemonic.Text = "Mnemonic schema";
            this.btnMnemonic.UseCustomBackColor = true;
            this.btnMnemonic.UseCustomForeColor = true;
            this.btnMnemonic.UseSelectable = true;
            this.btnMnemonic.Visible = false;
            this.btnMnemonic.Click += new System.EventHandler(this.btnMnemonic_Click);
            // 
            // btnCommands
            // 
            this.btnCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnCommands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCommands.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCommands.ForeColor = System.Drawing.Color.White;
            this.btnCommands.Location = new System.Drawing.Point(760, 44);
            this.btnCommands.Margin = new System.Windows.Forms.Padding(0);
            this.btnCommands.Name = "btnCommands";
            this.btnCommands.Size = new System.Drawing.Size(186, 29);
            this.btnCommands.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCommands.TabIndex = 7;
            this.btnCommands.Text = "Commands";
            this.btnCommands.UseCustomBackColor = true;
            this.btnCommands.UseCustomForeColor = true;
            this.btnCommands.UseSelectable = true;
            this.btnCommands.Click += new System.EventHandler(this.btnCommands_Click);
            // 
            // trendsminuteBindingSource
            // 
            this.trendsminuteBindingSource.DataMember = "trends_minute";
            this.trendsminuteBindingSource.DataSource = this.simplescadaDataSet;
            // 
            // simplescadaDataSet
            // 
            this.simplescadaDataSet.DataSetName = "simplescadaDataSet";
            this.simplescadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
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
            this.lbHeader.Size = new System.Drawing.Size(145, 25);
            this.lbHeader.TabIndex = 10;
            this.lbHeader.Text = "SCADA VIEWER";
            this.lbHeader.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbHeader.UseCustomForeColor = true;
            // 
            // cbDataSets
            // 
            this.cbDataSets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDataSets.ForeColor = System.Drawing.Color.White;
            this.cbDataSets.FormattingEnabled = true;
            this.cbDataSets.ItemHeight = 23;
            this.cbDataSets.Location = new System.Drawing.Point(574, 44);
            this.cbDataSets.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbDataSets.Name = "cbDataSets";
            this.cbDataSets.PromptText = "Choose table";
            this.cbDataSets.Size = new System.Drawing.Size(186, 29);
            this.cbDataSets.Style = MetroFramework.MetroColorStyle.Black;
            this.cbDataSets.TabIndex = 11;
            this.cbDataSets.Tag = "";
            this.cbDataSets.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbDataSets.UseSelectable = true;
            this.cbDataSets.SelectedIndexChanged += new System.EventHandler(this.cbDataSets_SelectedIndexChanged);
            this.cbDataSets.Click += new System.EventHandler(this.cbDataSets_Click);
            // 
            // trends_minuteTableAdapter
            // 
            this.trends_minuteTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.cbDataSets);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btnCommands);
            this.Controls.Add(this.btnMnemonic);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lbStatus);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 240);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendsminuteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplescadaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbStatus;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnStatic;
        private MetroFramework.Controls.MetroButton btnCommands;
        private MetroFramework.Controls.MetroButton btnMnemonic;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnDynamic;
        private System.Windows.Forms.Timer mainTimer;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroButton btnTimer;
        private MetroFramework.Controls.MetroLabel lbHeader;
        private MetroFramework.Controls.MetroComboBox cbDataSets;
        private simplescadaDataSet simplescadaDataSet;
        private System.Windows.Forms.BindingSource trendsminuteBindingSource;
        private simplescadaDataSetTableAdapters.trends_minuteTableAdapter trends_minuteTableAdapter;
        private MetroFramework.Controls.MetroGrid mainGrid;
    }
}

