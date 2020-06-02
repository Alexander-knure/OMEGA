using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
        public List<ActionData> ActionList = new List<ActionData>();
        public List<MessageData> MessageList = new List<MessageData>();
        public List<Recipe> ReciepList= new List<Recipe>();
        public List<Trend> TrendList=new List<Trend>();
        public List<Variable> VariableList=new List<Variable>();
        

        public MainForm()
        {
            InitializeComponent();
            sdlg.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            rdlg.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (DBUtils.conn != null)
            {
                if(DBUtils.conn.State == ConnectionState.Open)
                {
                    lbStatus.Text = "Start timer";
                }
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            OpenConnection();
            ShowTable(true);
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

        private void ShowRows(string query)
        {
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBUtils.conn))
            {
                try
                {
                     MySqlDataReader r;
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    mainGrid.DataSource = ds.Tables[0];
                    r = adapter.SelectCommand.ExecuteReader();
                    switch (cbDataSets.SelectedItem.ToString())
                    {
                        case "actions_data":

                            while (r.Read())
                            {
                                ActionData actionData = new ActionData(r.GetDateTime(0), r.GetInt32(1), r.GetString(2));
                                ActionList.Add(actionData);
                            }
                            break;
                        case "messages_data":
                            while (r.Read())
                            {
                                MessageData messageData = new MessageData(r.GetDateTime(0), r.GetInt32(1), r.GetInt32(2), r.GetInt32(3), r.GetString(4));
                                MessageList.Add(messageData);
                            }
                            break;
                        case "recipes":
                            while (r.Read())
                            {
                                Recipe reciep = new Recipe(r.GetUInt32(0), r.GetString(1), r.GetDateTime(2), r.GetFloat(3), r.GetFloat(4), r.GetFloat(5), r.GetString(6));
                                ReciepList.Add(reciep);
                            }
                            break;
                        case "trends_day":
                        case "trends_hour":
                        case "trends_minute":
                        case "trends_data":
                            while (r.Read())
                            {
                                Trend trend = new Trend(r.GetUInt32(0), r.GetDateTime(1), r.GetFloat(2), r.GetInt16(3));
                                TrendList.Add(trend);
                            }
                            break;
                        case "variables_data":
                            while (r.Read())
                            {
                                Variable variable = new Variable(r.GetUInt32(0), r.GetString(1), r.GetString(2));
                                VariableList.Add(variable);
                            }
                            break;
                        default:
                            break;
                    }
                    r.Close();
                }
                catch (Exception exc)
                {
                    MSG.Show(this, exc.ToString(), exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, logger);
                }
            }
        }
        private void ShowTable(bool isTimer)
        {
            string query;
            if (DBUtils.conn.State == ConnectionState.Open)
            {
                if (isTimer && cbDataSets.SelectedItem != null)
                {
                    query = cbDataSets.SelectedItem.ToString().Contains("trends") ? "SELECT * FROM (SELECT * FROM " + cbDataSets.SelectedItem.ToString() + " ORDER BY timestamp DESC LIMIT 100) AS T ORDER BY timestamp ASC" : "SELECT * FROM " + cbDataSets.SelectedItem.ToString();
                    ShowRows(query);
                }
                else if(cbDataSets.SelectedItem != null)
                {
                    query = "SELECT * FROM " + cbDataSets.SelectedItem.ToString();
                    ShowRows(query);
                }
            }
        }

        private void cbDataSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainTimer.Enabled = true;
            ShowTable(false) ;
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
                reader.Close();
            }
            catch (InvalidOperationException exc)
            {
                MSG.Show(this, "Please enable server connection", exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning, logger);

            }
            catch (Exception exc)
            {
                MSG.Show(this, exc.ToString(), exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, logger);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainTimer.Stop();
            DBUtils.CloseConnection(lbStatus, logger);
        }

      
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName;
            if (cbDataSets.SelectedItem != null)
            {
                switch (cbDataSets.SelectedItem.ToString())
                {
                    case "actions_data":
                        fileName = @"C:\Users\alex2\Desktop\Practice_saves_files\actions_data_Save.txt";
                        using (StreamWriter fs = new StreamWriter(fileName))
                        {
                            fs.Write(JsonConvert.SerializeObject(ActionList));
                        }
                        MessageBox.Show("information saved to file 'actions_data_Save'");
                        break;


                    case "messages_data":
                        fileName = @"C:\Users\alex2\Desktop\Practice_saves_files\messages_data_Save.txt";
                        using (StreamWriter fs = new StreamWriter(fileName))
                        {
                            fs.Write(JsonConvert.SerializeObject(MessageList));
                        }
                        MessageBox.Show("information saved to file 'messages_data_Save'");
                        break;


                    case "recipes":
                        fileName = @"C:\Users\alex2\Desktop\Practice_saves_files\recipes_Save.txt";
                        using (StreamWriter fs = new StreamWriter(fileName))
                        {
                            fs.Write(JsonConvert.SerializeObject(ReciepList));
                        }
                        MessageBox.Show("information saved to file 'recipes_Save'");
                        break;


                    case "trends_day":
                    case "trends_hour":
                    case "trends_minute":
                    case "trends_data":
                        fileName = @"C:\Users\alex2\Desktop\Practice_saves_files\trends_data_Save.txt";
                        using (StreamWriter fs = new StreamWriter(fileName))
                        {
                            fs.Write(JsonConvert.SerializeObject(TrendList));
                        }
                        MessageBox.Show("information saved to file 'trends_data_Save'");
                        break;


                    case "variables_data":
                        fileName = @"C:\Users\alex2\Desktop\Practice_saves_files\variables_data_Save.txt";
                        using (StreamWriter fs = new StreamWriter(fileName))
                        {
                            fs.Write(JsonConvert.SerializeObject(VariableList));
                        }
                        MessageBox.Show("information saved to file 'variables_data_Save.txt'");
                        break;


                    default:
                        break;
                }
            }
            else
            {
                MSG.Show(this, "Please, choose table", MessageBoxButtons.OK, MessageBoxIcon.Warning, logger);
            }
        }
       private void btnLoad_Click(object sender, EventArgs e)
       {
            if (rdlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = rdlg.FileName;
                string str;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    str = sr.ReadToEnd();

                    switch (fileName)
                    {
                        case @"C:\\Users\\alex2\\Desktop\\Practice_saves_files\\actions_data_Save.txt":
                            while (!sr.EndOfStream)
                                ActionList = JsonConvert.DeserializeObject<List<ActionData>>(str);
                            mainGrid.DataSource = ActionList;
                            break;
                        case @"C:\Users\alex2\Desktop\Practice_saves_files\messages_data_Save.txt":
                            while (!sr.EndOfStream)
                                MessageList = JsonConvert.DeserializeObject<List<MessageData>>(str);
                            mainGrid.DataSource = MessageList;
                            break;
                        case @"C:\Users\alex2\Desktop\Practice_saves_files\recipes_Save.txt":

                            ReciepList = JsonConvert.DeserializeObject<List<Recipe>>(str);
                            mainGrid.DataSource = ReciepList;
                            break;
                        case @"C:\Users\alex2\Desktop\Practice_saves_files\trends_day_Save.txt":
                        case @"C:\Users\alex2\Desktop\Practice_saves_files\trends_hour_Save.txt":
                        case @"C:\Users\alex2\Desktop\Practice_saves_files\trends_minute_Save.txt":
                        case @"C:\Users\alex2\Desktop\Practice_saves_files\trends_data_Save.txt":
                            while (!sr.EndOfStream)
                                TrendList = JsonConvert.DeserializeObject<List<Trend>>(str);
                            mainGrid.DataSource = TrendList;
                            break;
                        case @"C:\Users\alex2\Desktop\Practice_saves_files\variables_data_Save.txt":
                            while (!sr.EndOfStream)
                                VariableList = JsonConvert.DeserializeObject<List<Variable>>(str);
                            mainGrid.DataSource = VariableList;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}