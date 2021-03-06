﻿using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NURESCADA.Forms
{
    public partial class MnemonicForm : MetroFramework.Forms.MetroForm
    {
        public MnemonicForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }

        private void MnemonicForm_Load(object sender, EventArgs e)
        {
            DBUtils.OpenConnection(lbStatus, MainForm.logger);
        }
    }
}
