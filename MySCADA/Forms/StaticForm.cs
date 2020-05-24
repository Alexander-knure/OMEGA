using MetroFramework;
using MySql.Data.MySqlClient;
using NURESCADA.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NURESCADA
{
    public partial class StaticForm : MetroFramework.Forms.MetroForm {
        MainForm mf;
        Variables variables;

        public StaticForm()
        {
            mf = new MainForm();
            variables = new Variables();
            InitializeComponent();
            mf.OpenConnection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }

        private void cbVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            var selected = cbVariables.SelectedItem.ToString();
            if (MainChart.Series.IndexOf(selected) == -1)
            {
                // MainChart.Series[selected].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

                //
                //Add where -/- and timefrom = timestamp_min to max in other method!
                //
                string query = "SELECT VALUE FROM `variables_data` INNER JOIN `trends_data` ON variables_data.ID = trends_data.ID WHERE variables_data.Name = \"" + selected + "\";";
                MySqlCommand msc = new MySqlCommand(query, mf.conn);
                try
                {
                    if (mf.OpenConnection())
                    {
                        MainChart.Series.Add(selected);
                        MainChart.Series[selected].BorderWidth = 3;
                        MainChart.Series[selected].LegendText = selected;

                        cbVariables.Items.Clear();
                        variables.Clear();
                        reader = msc.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.GetDouble(0) != null)
                                MainChart.Series[selected].Points.AddY(reader.GetDouble(0));
                        }
                    }
                }
                catch(Exception exc)
                {
                    MetroMessageBox.Show(this,exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                }
            }
        }

        private void cbVariables_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            string showQuery = "Select * From variables_data";
            uint id;
            string name;
            string desc;
            MySqlCommand msc = new MySqlCommand(showQuery, mf.conn);
            try
            {
                if(mf.OpenConnection())
                {
                    cbVariables.Items.Clear();
                    variables.Clear();
                    reader = msc.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetUInt32(0);
                        name = reader.GetString(1);
                        desc = reader.GetString(2);

                        cbVariables.Items.Add(name);
                        variables.Add(id, name, desc);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Please enable server connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
        }

        private void cbTimeFrom_Click(object sender, EventArgs e)
        {
            //SELECT `Timestamp` FROM `trends_data` WHERE 1
            MySqlDataReader reader;
            string showQuery = "Timestamp` FROM `trends_data` WHERE 1";

            MySqlCommand msc = new MySqlCommand(showQuery, mf.conn);
            try
            {
                if (mf.OpenConnection())
                {
                    cbVariables.Items.Clear();
                    variables.Clear();
                    reader = msc.ExecuteReader();
                    while (reader.Read())
                    {

                        //dtFrom.Items.Add(reader.GetString(0));
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Please enable server connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
        }

        private void cbTimeTo_Click(object sender, EventArgs e)
        {
            //SELECT `Timestamp` FROM `trends_data` WHERE 1
        }
    }
}
