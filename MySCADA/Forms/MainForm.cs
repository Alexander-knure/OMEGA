﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using NLog;
using NURESCADA.Forms;
using MetroFramework;

namespace NURESCADA
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private List<string> TableNames = new List<string>();
        public MySqlConnection conn;

        static object locker = new object();
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            OpenConnection();
        }

        public bool OpenConnection()
        {
            try
            {
                conn = DBUtils.GetDBConnection();
                lb1.Text = String.Empty;
                lb1.ForeColor = Color.Yellow;
                lb1.Text += "Status: openning connection";
                conn.Open();

                lb1.ForeColor = Color.GreenYellow;
                lb1.Text = String.Empty;
                lb1.Text += "Status: connection successful!";

                logger.Info("connection successful");
                return true;
            }
            catch(MySqlException exc)
            {
                lb1.ForeColor = Color.Red;

                lb1.Text = "Status: error (check server)";

                mainTimer.Enabled = false;
                btnTimer.Text = String.Empty;
                btnTimer.Text = "Play";

                logger.Error("open connection:" + exc);
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                lb1.Text = "Status: connection closed";
                lb1.ForeColor = Color.Yellow;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                lb1.Text = "Status: error";
                lb1.ForeColor = Color.Red;
                logger.Error("close connection: " + ex.Message);
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if(mainTimer.Enabled)
            {
                mainTimer.Enabled = false;
                btnTimer.Text  = String.Empty;
                btnTimer.Text = "Play";
                CloseConnection();
            }
            else
            {
                mainTimer.Enabled = true;
                btnTimer.Text = String.Empty;
                btnTimer.Text = "Stop";
            }
        }


        private void cbDataSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM " + cbDataSets.SelectedItem.ToString();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        mainGrid.DataSource = ds.Tables[0];
                    }
                    catch
                    {

                    }
                }
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            StaticForm sf = new StaticForm();
            sf.Show();
            Hide();
        }

        private void btnDynamic_Click(object sender, EventArgs e)
        {
            DynamicForm df = new DynamicForm();
            df.Show();
            Hide();
        }

        private void btnMnemonic_Click(object sender, EventArgs e)
        {
            MnemonicForm mf = new MnemonicForm();
            mf.Show();
            Hide();
        }

        private void btnCommands_Click(object sender, EventArgs e)
        {
            CommandForm cf = new CommandForm();
            cf.Show();
            Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "sCADADataSet.trends_minute". При необходимости она может быть перемещена или удалена.

        }

        private void cbDataSets_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            string showQuery = "show tables";
            MySqlCommand msc = new MySqlCommand(showQuery, conn);
            try
            {
                cbDataSets.Items.Clear();
                TableNames.Clear();
                reader = msc.ExecuteReader();
                while (reader.Read())
                {
                    cbDataSets.Items.Add(reader.GetString(0));
                    TableNames.Add(reader.GetString(0));
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Please enable server connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
        }
    }
}