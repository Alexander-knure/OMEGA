using MetroFramework;
using MySql.Data.MySqlClient;
using NLog;
using NURESCADA.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NURESCADA
{
    public partial class StaticForm : MetroFramework.Forms.MetroForm {
        private MainForm mf;
        private Variables variables;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private double start = 0.0d;
        private double end = 0.0d;
        

        public StaticForm()
        {
            mf = new MainForm();
            variables = new Variables();
            InitializeComponent();
            mf.OpenConnection();
            MainChart.MouseWheel += MainChart_MouseWheel;
            MainChart.KeyDown += MainChart_KeyPress;

            List<String> list = new List<string>();
            list.Add("day");
            list.Add("hour");
            list.Add("minute");
            list.Add("second");

            foreach (var i in list)
                cbTimeInterval.Items.Add(i);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }

        ushort countSelect = 0;
        private void cbVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            var selected = cbVariables.SelectedItem.ToString();
            if (MainChart.Series.IndexOf(selected) == -1)
            {
                if(countSelect >= 5)
                {
                    DialogResult dr =  MetroMessageBox.Show(this, "So mush sensors, do you want clear all?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                    if(dr == DialogResult.Yes)
                    {
                        countSelect = 0;
                        MainChart.Series.Clear();
                    }
                    else if (dr == DialogResult.No)
                    {
                        return;
                    }
                }
                //
                //Add where -/- and timefrom = timestamp_min to max in other method!
                //
                string query = "SELECT VALUE, TimeStamp FROM `variables_data` INNER JOIN `trends_data` ON variables_data.ID = trends_data.ID WHERE variables_data.Name = \"" + selected + "\";";
                MySqlCommand msc = new MySqlCommand(query, DBUtils.conn);
                try
                {
                    if (DBUtils.OpenConnection(lbStatus, logger))
                    {
                        countSelect++;
                        MainChart.Series.Add(selected);
                        MainChart.Series[selected].BorderWidth = 3;
                        MainChart.Series[selected].LegendText = selected;
                        MainChart.Series[selected].ChartType = SeriesChartType.FastLine;

                        cbVariables.Items.Clear();
                        variables.Clear();
                        reader = msc.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.GetDouble(0) != null)
                            {
                                //bed code

                                MainChart.Series[selected].Points.AddXY(reader.GetDateTime(1).ToOADate(), reader.GetDouble(0));
                            }

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
            //string showQuery = "Select * From variables_data";
            string showQuery = "SELECT DISTINCT variables_data.ID, variables_data.name, variables_data.Description FROM variables_data INNER JOIN trends_data ON variables_data.ID = trends_data.ID WHERE trends_data.Value = ANY(SELECT VALUE From variables_data)";
            uint id;
            string name;
            string desc;
            MySqlCommand msc = new MySqlCommand(showQuery, DBUtils.conn);
            try
            {
                if(DBUtils.OpenConnection(lbStatus, logger))
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
            catch(Exception exc)
            {
                //MetroMessageBox.Show(this, "Please enable server connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
                MetroMessageBox.Show(this, exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void cbTimeFrom_Click(object sender, EventArgs e)
        {
            //SELECT `Timestamp` FROM `trends_data` WHERE 1
            MySqlDataReader reader;
            string showQuery = "Timestamp` FROM `trends_data` WHERE 1";

            MySqlCommand msc = new MySqlCommand(showQuery, DBUtils.conn);
            try
            {
                if (DBUtils.OpenConnection(lbStatus, logger))
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

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
                var tInterval = cbTimeInterval.SelectedItem.ToString();
                MainChart.ChartAreas[0].AxisX.Title = tInterval;
                switch (tInterval)
                {
                 case "day":
                        MainChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                        break;
                 case "hour":
                        MainChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
                        break;
                 case "minute":
                        MainChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
                        break;
                 case "second":
                        MainChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                        break;
                }
        }

        private void cbTimeInterval_Click(object sender, EventArgs e)
        {
          
        }

        private void StaticForm_Load(object sender, EventArgs e)
        {
            DBUtils.OpenConnection(lbStatus, MainForm.logger);
        }

            int numberOfZoom = 0;
        private void MainChart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;
            double xMin = xAxis.ScaleView.ViewMinimum;
            double xMax = xAxis.ScaleView.ViewMaximum;
            double yMin = yAxis.ScaleView.ViewMinimum;
            double yMax = yAxis.ScaleView.ViewMaximum;
            double IntervalX = chart.ChartAreas[0].AxisX.Maximum;
            double IntervalY = chart.ChartAreas[0].AxisY.Maximum;
            try
            {
                if (e.Delta < 0 && numberOfZoom > 0) // Scrolled down.
                {
                    double posXStart = (xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, numberOfZoom));
                    double posXFinish = (xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, numberOfZoom));
                    double posYStart = (yAxis.PixelPositionToValue(e.Location.Y) - IntervalY * 2 / Math.Pow(2, numberOfZoom));
                    double posYFinish = (yAxis.PixelPositionToValue(e.Location.Y) + IntervalY * 2 / Math.Pow(2, numberOfZoom));

                    if (posXStart < 0) posXStart = 0;
                    if (posYStart < 0) posYStart = 0;
                    if (posYFinish > yAxis.Maximum) posYFinish = yAxis.Maximum;
                    if (posXFinish > xAxis.Maximum) posYFinish = xAxis.Maximum;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                    numberOfZoom--;
                }
                else if (e.Delta < 0 && numberOfZoom == 0) //Last scrolled dowm
                {
                    yAxis.ScaleView.ZoomReset();
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0 || numberOfZoom == 10) // Scrolled up.
                {

                    double posXStart = (xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, numberOfZoom));
                    double posXFinish = (xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, numberOfZoom));
                    double posYStart = (yAxis.PixelPositionToValue(e.Location.Y) - IntervalY / Math.Pow(2, numberOfZoom));
                    double posYFinish = (yAxis.PixelPositionToValue(e.Location.Y) + IntervalY / Math.Pow(2, numberOfZoom));

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                    numberOfZoom++;
                }
                else
                {
                    yAxis.ScaleView.ZoomReset();
                    xAxis.ScaleView.ZoomReset();
                    numberOfZoom = 0;
                    return;
                }
            }
            catch {
                MetroMessageBox.Show(this, "Error in zoom", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        public void MainChart_KeyPress(object sender, KeyEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    yAxis.ScaleView.Position+=100;
                    break;
                case Keys.Down:
                    break;
                case Keys.Left:
                    MetroMessageBox.Show(this, "Do you want clear all?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                    break;
                case Keys.Right:
                    break;
                default:
                    break;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "Do you want clear all?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
            if (dr == DialogResult.Yes)
            {
                MainChart.Series.Clear();
            }
            else if (dr == DialogResult.No)
            {
                return;
            }
        }

        private void dtFromTime_ValueChanged(object sender, EventArgs e)
        {
            start = dtFromTime.Value.ToOADate();
            MainChart.ChartAreas[0].AxisX.Minimum = start;
            
        }

        private void dtToTime_ValueChanged(object sender, EventArgs e)
        {
            end = dtToTime.Value.ToOADate();
            MainChart.ChartAreas[0].AxisX.Maximum = end;
        }
    }
}
