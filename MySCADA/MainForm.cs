using System;
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

namespace NURESCADA
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        static object locker = new object();
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            Connection();
        }
        ///////////////////////////////////////////////////////////////////////
        ///                             <summary>                                    ///
        ///                             Test method`s                                 ///
        ///                              </summary>                                 ///
        //////////////////////////////////////////////////////////////////////

        public void Connection()
        {

            Console.WriteLine("Getting Connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                lb1.Text = String.Empty;
                lb1.ForeColor = Color.Yellow;
                lb1.Text += "Openning Connection ...";
                conn.Open();


                lb1.ForeColor = Color.GreenYellow;
                lb1.Text = String.Empty;
                lb1.Text += "Status: connection successful!";
            }
            catch (Exception e)
            {
                lb1.ForeColor = Color.Red;

                lb1.Text += "Error";

                mainTimer.Enabled = false;
                btnTimer.Text = String.Empty;
                btnTimer.Text = "Play";
            }
        }

        private void ShowList(List<Row> rows)
        {
            foreach (var item in rows)
            {
                var viewItem = new ListViewItem(Convert.ToString(item.id));
                viewItem.SubItems.Add(Convert.ToString(item.password));
                viewItem.SubItems.Add(Convert.ToString(item.last_login));
                viewItem.SubItems.Add(Convert.ToString(item.username));
                viewItem.SubItems.Add(Convert.ToString(item.first_name));
                viewItem.SubItems.Add(Convert.ToString(item.last_name));
                viewItem.SubItems.Add(Convert.ToString(item.email));
                viewItem.SubItems.Add(Convert.ToString(item.date_joined));

            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if(mainTimer.Enabled)
            {
                mainTimer.Enabled = false;
                btnTimer.Text  = String.Empty;
                btnTimer.Text = "Play";
            }
            else
            {
                mainTimer.Enabled = true;
                btnTimer.Text = String.Empty;
                btnTimer.Text = "Stop";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pylab1DataSet.auth_user". При необходимости она может быть перемещена или удалена.
            this.auth_userTableAdapter.Fill(this.pylab1DataSet.auth_user);

        }
    }

}
