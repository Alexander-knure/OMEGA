using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using NURESCADA.Forms;
using NURESCADA.DB;
using NURESCADA.Models;

namespace NURESCADA
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        private List<string> TableNames = new List<string>();

        public OpenFileDialog rdlg = new OpenFileDialog();
        public OpenFileDialog sdlg = new OpenFileDialog();
        public Actions actions;
        public Messages messages;
        public Recipes recipes;
        public Trends trends;
        public Variables variables;

        public MainForm()
        {
            InitializeComponent();
            sdlg.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            rdlg.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            OpenConnection();
        }

        public void OpenConnection()
        {
            if (!DBUtils.OpenConnection(lbStatus, logger))
            {
                mainTimer.Enabled = false;
                btnTimer.Text = String.Empty;
                btnTimer.Text = "Play";
            }
        }

        public void CloseConnection()
        {
            try
            {
                lbStatus.Text = "Status: connection closed";
                lbStatus.ForeColor = Color.Yellow;
                DBUtils.conn.Close();
            }
            catch (MySqlException ex)
            {
                lbStatus.Text = "Status: error";
                lbStatus.ForeColor = Color.Red;
                logger.Error("close connection: " + ex.Message);
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (mainTimer.Enabled)
            {
                mainTimer.Enabled = false;
                btnTimer.Text = String.Empty;
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
            if (DBUtils.conn.State == ConnectionState.Open)
            {
                MySqlDataReader r;

                string query = "SELECT * FROM " + cbDataSets.SelectedItem.ToString();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBUtils.conn))
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        mainGrid.DataSource = ds.Tables[0];
                        r = adapter.SelectCommand.ExecuteReader();
                        switch(cbDataSets.SelectedItem.ToString())
                        {
                            case "actions_data":
                                actions = new Actions();
                                while (r.Read())                                
                                    actions.Add(new ActionData(r.GetDateTime(0),r.GetInt32(1),r.GetString(2)));
                                
                                break;
                            case "messages_data":
                                messages = new Messages();
                                while (r.Read())                                
                                    messages.Add(new MessageData(r.GetDateTime(0), r.GetInt32(1), r.GetInt32(2), r.GetInt32(3), r.GetString(4)));
                                
                                break;
                            case "recipes":
                                recipes = new Recipes();
                                while (r.Read())                                
                                    recipes.Add(new Recipe(r.GetUInt32(0), r.GetString(1), r.GetDateTime(2), r.GetFloat(3), r.GetFloat(4), r.GetFloat(5)));                                
                                break;
                            case "trends_day":
                            case "trends_hour":
                            case "trends_minute":
                            case "trends_data":
                                trends = new Trends();
                                while (r.Read())                                
                                    trends.Add(new Trend(r.GetUInt32(0), r.GetDateTime(1), r.GetFloat(2), r.GetInt16(3)));
                                break;
                            case "variables_data":
                                variables = new Variables();
                                while (r.Read())                                
                                    variables.Add(new Variable(r.GetUInt32(0), r.GetString(1), r.GetString(2)));
                                break;
                            default:
                                break;
                        }
                    }
                    catch(Exception exc)
                    {
                        MSG.Show(this, exc.ToString(), exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, logger);
                    }
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

            try
            {
                MySqlCommand msc = new MySqlCommand(showQuery, DBUtils.conn);
                cbDataSets.Items.Clear();
                TableNames.Clear();
                reader = msc.ExecuteReader();
                while (reader.Read())
                {
                    cbDataSets.Items.Add(reader.GetString(0));
                    TableNames.Add(reader.GetString(0));
                }
            }
            catch (Exception exc)
            {
                MSG.Show(this, "Please enable server connection", exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning, logger);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBUtils.CloseConnection(lbStatus, logger);
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //
        //    if (sdlg.ShowDialog() == DialogResult.OK)
        //    {
        //        string query = "SELECT * FROM " + cbDataSets.SelectedItem.ToString();
        //        string fileName;
        //
        //        MySqlCommand msc = new MySqlCommand(query, DBUtils.conn);
        //        fileName = sdlg.FileName;
        //
        //        MySqlDataReader reader = msc.ExecuteReader(); ;
        //        using (StreamWriter fs = new StreamWriter(fileName))
        //        {
        //            while (reader.Read())
        //            {
        //                switch (cbDataSets.SelectedItem.ToString())
        //                {
        //                    case ("actions_data"):
        //
        //                        fs.Write("{0} {1} {2}", "|" + reader[0], "|" + reader[1], "|" + reader[2]);
        //                        fs.WriteLine();
        //                        break;
        //                    case ("messages_data"):
        //                        fs.Write("{0} {1} {2} {3} {4}", "|" + reader[0], "|" + reader[1], "|" + reader[2], "|" + reader[3], "|" + reader[4]);
        //                        fs.WriteLine();
        //                        break;
        //                    case ("recipes"):
        //                        fs.Write("{0} {1} {2} {3} {4} {5} {6}", "|" + reader[0], "|" + reader[1], "|" + reader[2], "|" + reader[3], "|" + reader[4], "|" + reader[5], "|" + reader[6]);
        //                        fs.WriteLine();
        //                        break;
        //                    case ("trends_data"):
        //
        //                    case ("trends_day"):
        //
        //                    case ("trends_hour"):
        //
        //                    case ("trends_minute"):
        //                        fs.Write("{0} {1} {2} {3}", "|" + reader[0], "|" + reader[1], "|" + reader[2], "|" + reader[3]);
        //                        fs.WriteLine();
        //                        break;
        //                    case ("variables_data"):
        //                        fs.Write("{0} {1} {2}", "|" + reader[0], "|" + reader[1], "|" + reader[2] + "|");
        //                        fs.WriteLine();
        //                        break;
        //                }
        //            }
        //        }
        //    }
        //}
        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    DataTable table = new DataTable();
        //
        //    if (rdlg.ShowDialog() == DialogResult.OK)
        //    {
        //        string fileName;
        //        fileName = rdlg.FileName;
        //        //MessageBox.Show(fileName);
        //
        //
        //        string[] dataLines = File.ReadAllLines(fileName);
        //        var data = (dataLines.Select(s => (s.Split(new[] { '|' })
        //                   .Where((i, j) => (j != 0 && j != 1))))).ToArray();
        //
        //        int maxDataLengthCount = data.OrderBy(d => d.Count()).Last().Count();
        //        DataTable dt = new DataTable();
        //        for (int i = 0; i < maxDataLengthCount; i++)
        //        {
        //            DataColumn dataColumn = new DataColumn();
        //            dt.Columns.Add(dataColumn);
        //        }
        //
        //        for (int i = 0; i < data.Count(); i++)
        //        {
        //            DataRow newRow = dt.NewRow();
        //            newRow.ItemArray = data[i].ToArray();
        //            dt.Rows.Add(newRow);
        //        }
        //        mainGrid.DataSource = dt;
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sdlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = sdlg.FileName;
                using (StreamWriter fs = new StreamWriter(fileName))
                {
                    switch (cbDataSets.SelectedItem.ToString())
                    {
                        case "actions_data":
                            string data = JsonConvert.SerializeObject(actions);
                            fs.Write(data);
                            break;
                        case "messages_data":
                            fs.Write(JsonConvert.SerializeObject(messages));
                            break;
                        case "recipes":
                            fs.Write(JsonConvert.SerializeObject(recipes));
                            break;
                        case "trends_day":
                        case "trends_hour":
                        case "trends_minute":
                        case "trends_data":
                            fs.Write(JsonConvert.SerializeObject(trends));
                            break;
                        case "variables_data":
                            fs.Write(JsonConvert.SerializeObject(variables));
                            break;
                        default:
                            break;
                    }
                }
            }
        }
       private void btnLoad_Click(object sender, EventArgs e)
       {
       //     if (rdlg.ShowDialog() == DialogResult.OK)
       //     {
       //         string fileName = rdlg.FileName;
       //         using (StreamReader sr = new StreamReader(fileName))
       //         {
       //             switch (cbDataSets.SelectedItem.ToString())
       //             {
       //                 case "actions_data":
       //                     break;
       //                 case "messages_data":
       //                     while (!sr.EndOfStream)
       //                         messages = JsonConvert.DeserializeObject<Messages>(sr);
       //                     break;
       //                 case "recipes":
       //                     while (!sr.EndOfStream)
       //                         recipes = serializer.Deserialize<Recipes>(sr);
       //                     break;
       //                 case "trends_day":
       //                 case "trends_hour":
       //                 case "trends_minute":
       //                 case "trends_data":
       //                     while (!sr.EndOfStream)
       //                         trends = serializer.Deserialize<Trends>(reader);
       //                     break;
       //                 case "variables_data":
       //                     while (!sr.EndOfStream)
       //                         variables = serializer.Deserialize<Variables>(reader);
       //                     break;
       //                 default:
       //                     break;
       //             }
       //         }
       //     }
       }
    }
}