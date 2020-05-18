using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NURESCADA
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            SomeTest();
        }
        public void SomeTest()
        {
                Console.WriteLine("Getting Connection ...");
                MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                lb1.ForeColor = Color.Yellow;
                lb1.Text += "Openning Connection ...";
                conn.Open();


                lb1.ForeColor = Color.GreenYellow;
                lb1.Text = null;
                lb1.Text += "Connection successful!";
            }
            catch (Exception e)
            {
                lb1.ForeColor = Color.Red;
                lb1.Text = null;
                lb1.Text += "Error: " + e.Message;
            }

                Console.Read();
        }
    }
}
