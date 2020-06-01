using MetroFramework;
using MySql.Data.MySqlClient;
using NLog;
using NURESCADA.DB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NURESCADA.Forms
{
    public partial class DynamicForm : MetroFramework.Forms.MetroForm
    {
        private MainForm mf;
        private Variables variables;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private double start = 0.0d;
        private double end = 0.0d;
        private string selected;
        public DynamicForm()
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
            selected = cbVariables.SelectedItem.ToString();
            dTimer.Enabled = true;
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
                if (DBUtils.OpenConnection(lbStatus, logger))
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
                        variables.Add(new Variable(id, name, desc));
                    }
                }
            }
            catch (Exception exc)
            {
                //MetroMessageBox.Show(this, "Please enable server connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
                MSG.Show(this, exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, logger);
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
                MSG.Show(this, "Please enable server connection", MessageBoxButtons.OK, MessageBoxIcon.Warning, logger);
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

        private void StaticForm_Load(object sender, EventArgs e)
        {
            DBUtils.OpenConnection(lbStatus, MainForm.logger);
        }

        int numberOfZoom = 0;
        private void MainChart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = MainChart;
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
                if (numberOfZoom < 5)
                {
                    if (e.Delta < 0 && numberOfZoom > 0) // Scrolled down.
                    {
                        double posXStart = Math.Round(xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, numberOfZoom));
                        double posXFinish = Math.Round(xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, numberOfZoom));
                        double posYStart = Math.Round(yAxis.PixelPositionToValue(e.Location.Y) - IntervalY * 2 / Math.Pow(2, numberOfZoom));
                        double posYFinish = Math.Round(yAxis.PixelPositionToValue(e.Location.Y) + IntervalY * 2 / Math.Pow(2, numberOfZoom));

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
                    else if (e.Delta > 0) // Scrolled up.
                    {

                        double posXStart = Math.Round(xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, numberOfZoom));
                        double posXFinish = Math.Round(xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, numberOfZoom));
                        double posYStart = Math.Round(yAxis.PixelPositionToValue(e.Location.Y) - IntervalY / Math.Pow(2, numberOfZoom));
                        double posYFinish = Math.Round(yAxis.PixelPositionToValue(e.Location.Y) + IntervalY / Math.Pow(2, numberOfZoom));

                        xAxis.ScaleView.Zoom(posXStart, (int)posXFinish);
                        yAxis.ScaleView.Zoom(posYStart, (int)posYFinish);
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
                else
                {
                    if (e.Delta > 0)
                    {
                        DialogResult dr = MetroMessageBox.Show(this, "So much zoom, do you want reset scale?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                        if (dr == DialogResult.Yes)
                        {
                            yAxis.ScaleView.ZoomReset();
                            xAxis.ScaleView.ZoomReset();
                            numberOfZoom = 0;
                        }
                        else if (dr == DialogResult.No)
                        {
                            double posXStart = Math.Round(xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, numberOfZoom));
                            double posXFinish = Math.Round(xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, numberOfZoom));
                            double posYStart = Math.Round(yAxis.PixelPositionToValue(e.Location.Y) - IntervalY * 2 / Math.Pow(2, numberOfZoom));
                            double posYFinish = Math.Round(yAxis.PixelPositionToValue(e.Location.Y) + IntervalY * 2 / Math.Pow(2, numberOfZoom));

                            if (posXStart < 0) posXStart = 0;
                            if (posYStart < 0) posYStart = 0;
                            if (posYFinish > yAxis.Maximum) posYFinish = yAxis.Maximum;
                            if (posXFinish > xAxis.Maximum) posYFinish = xAxis.Maximum;
                            xAxis.ScaleView.Zoom(posXStart, posXFinish);
                            yAxis.ScaleView.Zoom(posYStart, posYFinish);
                            numberOfZoom--;
                        }
                    }
                    if (e.Delta < 0) return;
                }
            }
            catch
            {
                MSG.Show(this, "Error in zoom", MessageBoxButtons.OK, MessageBoxIcon.Error, logger);
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
                    yAxis.ScaleView.Position += 100;
                    break;
                case Keys.Down:
                    break;
                case Keys.Left:
                    MSG.Show(this, "Do you want clear all?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, logger);
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
                dTimer.Enabled = false;
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

        private void MainChart_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainChart.Series.Count > 0)
            {
                lbPoint.Visible = true;
                if (MainChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) >= MainChart.ChartAreas[0].AxisX.Minimum && MainChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) <= MainChart.ChartAreas[0].AxisX.Maximum &&
                    MainChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) >= MainChart.ChartAreas[0].AxisY.Minimum && MainChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) <= MainChart.ChartAreas[0].AxisX.Maximum)
                {
                    lbPoint.Text = "X:" + Math.Round(MainChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X)).ToString();
                    lbPoint.Text += " Y:" + Math.Round(MainChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y)).ToString();
                }
            }
            else
            {
                lbPoint.Visible = false;
            }
        }

        private void DynamicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.CloseConnection();
            DBUtils.CloseConnection(lbStatus, logger);
        }

        private void dTimer_Tick(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            
            if (MainChart.Series.IndexOf(selected) == -1)
            {
                if (countSelect >= 5)
                {
                    DialogResult dr = MetroMessageBox.Show(this, "So mush sensors, do you want clear all?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                    if (dr == DialogResult.Yes)
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
                        MainChart.Series.Add(selected);
                        MainChart.Series[selected].BorderWidth = 3;
                        MainChart.Series[selected].LegendText = selected;
                        MainChart.Series[selected].ChartType = SeriesChartType.FastLine;

                        MainChart.ChartAreas[0].CursorX.IsUserEnabled = true;
                        MainChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                        MainChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                        MainChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

                        MainChart.ChartAreas[0].CursorY.IsUserEnabled = true;
                        MainChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                        MainChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                        MainChart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

                        cbVariables.Items.Clear();
                        variables.Clear();
                        reader = msc.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.GetDouble(0) != null && countSelect <= 100)
                            {
                                MainChart.Series[selected].Points.AddY(reader.GetDouble(0));
                            }
                            else if(reader.GetDouble(0) != null && countSelect >100)
                            {
                                MainChart.Series[selected].Points.RemoveAt(0);
                            }

                        }
                        countSelect++;
                    }
                }
                catch (Exception exc)
                {
                    MSG.Show(this, exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, logger);
                }
            }
        }
    }
}
