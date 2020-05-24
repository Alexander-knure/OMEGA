using MetroFramework;
using MySql.Data.MySqlClient;
using NLog;
using System;
using System.Windows.Forms;

namespace NURESCADA.Forms
{
    public partial class CommandForm : MetroFramework.Forms.MetroForm
    {
        private MainForm mf;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public CommandForm()
        {
            mf = new MainForm();
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mf.Show();
            Hide();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {
            string query = tbQuery.Text;
            if (query == "")
            {
                MetroMessageBox.Show(this, "Please insert SQL query!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
                logger.Warn("SQL query: empty");
                return;
            }
            // mf.conn;

            MySqlCommand cmddb = new MySqlCommand(query, mf.conn);
            cmddb.CommandTimeout = 60;

            try
            {
                if(mf.OpenConnection())
                {
                    MySqlDataReader reader = cmddb.ExecuteReader();
                    MetroMessageBox.Show(this, "SQL query successfully executed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    logger.Info("SQL query: " + query);
                }
           
                
            }catch(Exception exc)
            {
                MetroMessageBox.Show(this, exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                logger.Error(exc.ToString());
            }
        }
    }
}
