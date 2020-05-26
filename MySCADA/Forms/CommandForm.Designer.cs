namespace NURESCADA.Forms
{
    partial class CommandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandForm));
            this.lbHeader = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.tbQuery = new MetroFramework.Controls.MetroTextBox();
            this.btnQuery = new MetroFramework.Controls.MetroButton();
            this.btnGrid = new MetroFramework.Controls.MetroButton();
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
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
            this.lbHeader.Size = new System.Drawing.Size(106, 25);
            this.lbHeader.TabIndex = 11;
            this.lbHeader.Text = "Commands";
            this.lbHeader.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbHeader.UseCustomForeColor = true;
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
            // tbQuery
            // 
            // 
            // 
            // 
            this.tbQuery.CustomButton.Image = null;
            this.tbQuery.CustomButton.Location = new System.Drawing.Point(442, 2);
            this.tbQuery.CustomButton.Name = "";
            this.tbQuery.CustomButton.Size = new System.Drawing.Size(485, 485);
            this.tbQuery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbQuery.CustomButton.TabIndex = 1;
            this.tbQuery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbQuery.CustomButton.UseSelectable = true;
            this.tbQuery.CustomButton.Visible = false;
            this.tbQuery.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbQuery.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbQuery.ForeColor = System.Drawing.Color.White;
            this.tbQuery.Lines = new string[0];
            this.tbQuery.Location = new System.Drawing.Point(16, 90);
            this.tbQuery.MaxLength = 32767;
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.PasswordChar = '\0';
            this.tbQuery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbQuery.SelectedText = "";
            this.tbQuery.SelectionLength = 0;
            this.tbQuery.SelectionStart = 0;
            this.tbQuery.ShortcutsEnabled = true;
            this.tbQuery.Size = new System.Drawing.Size(930, 490);
            this.tbQuery.TabIndex = 27;
            this.tbQuery.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbQuery.UseSelectable = true;
            this.tbQuery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbQuery.WaterMarkFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuery.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(416, 16);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(186, 29);
            this.btnQuery.TabIndex = 28;
            this.btnQuery.Text = "Execute query";
            this.btnQuery.UseCustomBackColor = true;
            this.btnQuery.UseCustomForeColor = true;
            this.btnQuery.UseSelectable = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnGrid
            // 
            this.btnGrid.BackColor = System.Drawing.Color.Transparent;
            this.btnGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrid.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGrid.ForeColor = System.Drawing.Color.White;
            this.btnGrid.Location = new System.Drawing.Point(602, 16);
            this.btnGrid.Margin = new System.Windows.Forms.Padding(0);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(186, 29);
            this.btnGrid.TabIndex = 29;
            this.btnGrid.Text = "Show table";
            this.btnGrid.UseCustomBackColor = true;
            this.btnGrid.UseCustomForeColor = true;
            this.btnGrid.UseSelectable = true;
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
            this.lbStatus.TabIndex = 30;
            this.lbStatus.Text = "Status: unknow";
            this.lbStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbStatus.UseCustomForeColor = true;
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CommandForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.CommandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbHeader;
        private MetroFramework.Controls.MetroButton btnBack;
        public MetroFramework.Controls.MetroTextBox tbQuery;
        private MetroFramework.Controls.MetroButton btnQuery;
        private MetroFramework.Controls.MetroButton btnGrid;
        private MetroFramework.Controls.MetroLabel lbStatus;
    }
}