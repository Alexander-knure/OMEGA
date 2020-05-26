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
    public partial class DynamicForm : MetroFramework.Forms.MetroForm
    {
        public DynamicForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }

        private void DynamicForm_Load(object sender, EventArgs e)
        {
            DBUtils.OpenConnection(lbStatus, MainForm.logger);
        }
    }
}
