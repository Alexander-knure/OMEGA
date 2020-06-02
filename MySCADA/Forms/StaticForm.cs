using MetroFramework;
using MySql.Data.MySqlClient;
using NLog;
using NURESCADA.DB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NURESCADA
{
    public partial class StaticForm : MetroFramework.Forms.MetroForm
    {
        private const short MAX = 7;
        private MainForm mf;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private double start = 0.0d;
        private double end = 0.0d;
        private List<string> graphs;
        SeriesChartType chartType = SeriesChartType.FastPoint;

        public StaticForm()
        {
            mf = new MainForm();
            graphs = new List<string>();

            InitializeComponent();
            mf.OpenConnection();
            MainChart.MouseWheel += MainChart_MouseWheel;
            MainChart.KeyDown += MainChart_KeyPress;

            List<string> types = new List<string>();
            types.Add(SeriesChartType.FastLine.ToString());
            types.Add(SeriesChartType.FastPoint.ToString());

            foreach (var i in types)
                cbTypePoints.Items.Add(i);
            cbTypePoints.SelectedIndex = 0;
            List<string> formats = new List<string>();
            formats.Add("Date");
            formats.Add("Year");
            formats.Add("Month");
            formats.Add("Day");
            formats.Add("Hour");
            formats.Add("Minute");
            formats.Add("Second");

            foreach (var i in formats)
                cbTimeFormat.Items.Add(i);

            cbTimeFormat.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }


        private void BuildingChart(string selected, string timeFormat)
        {
            MySqlDataReader reader;


            if (graphs.Count >= MAX)
            {
                DialogResult dr = MetroMessageBox.Show(this, "So mush sensors, do you want clear all?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                if (dr == DialogResult.Yes)
                {
                    graphs.Clear();
                    MainChart.Series.Clear();
                }
                else if (dr == DialogResult.No)
                {
                    return;
                }
            }

            string query = "SELECT value, timeStamp FROM `variables_data` INNER JOIN `trends_data` ON variables_data.ID = trends_data.ID WHERE variables_data.Name = \"" + selected + "\" AND value > 0;";
            MySqlCommand msc = new MySqlCommand(query, DBUtils.conn);
            try
            {
              
                MainChart.ChartAreas[0].AxisX.Interval = 1;
                MainChart.ChartAreas[0].AxisX.IntervalOffset = 1;

                MainChart.Series.Add(selected);
                MainChart.Series[selected].BorderWidth = 3;
                MainChart.Series[selected].LegendText = selected;
                MainChart.Series[selected].ChartType = chartType;

                MainChart.ChartAreas[0].CursorX.IsUserEnabled = true;
                MainChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                MainChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                MainChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

                MainChart.ChartAreas[0].CursorY.IsUserEnabled = true;
                MainChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                MainChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                MainChart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

                cbVariables.Items.Clear();
                reader = msc.ExecuteReader();
                    MainChart.Series[0].XValueType = ChartValueType.DateTime;
                while (reader.Read())
                {
                    switch (timeFormat)
                    {
                        //YOU MUST TO CHANGE SECONDS IN TOTAL_SECONDS -> EACH CASE
                        case "Year":
                            MainChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
                            MainChart.Series[selected].Points.AddXY(reader.GetDateTime(1), reader.GetDouble(0));
                            break;
                        case "Month":
                            MainChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy MM";
                            MainChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                            MainChart.Series[selected].Points.AddXY(reader.GetDateTime(1), reader.GetDouble(0));
                            break;
                        case "Day":
                            MainChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd MMMM";
                            MainChart.Series[selected].Points.AddXY(reader.GetDateTime(1), reader.GetDouble(0));
                            break;
                        case "Hour":
                            MainChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd hh";
                            //double hour = (int)reader.GetDateTime(1).TimeOfDay.TotalHours;
                            //hour += Math.Round((reader.GetDateTime(1).TimeOfDay.TotalHours * 100) % 100 * 0.6) * 0.01;

                            MainChart.Series[selected].Points.AddXY(reader.GetDateTime(1), reader.GetDouble(0));
                            break;
                        case "Minute":
                            MainChart.Series[selected].Points.AddXY(reader.GetDateTime(1).TimeOfDay.TotalMinutes, reader.GetDouble(0));
                            break;
                        case "Second":
                            MainChart.Series[selected].Points.AddXY(reader.GetDateTime(1).TimeOfDay.TotalSeconds, reader.GetDouble(0));
                            break;
                        case "Date":
                            MainChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd MMMM";
                            MainChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Auto;
                            MainChart.Series[selected].Points.AddXY(reader.GetDateTime(1).Date, reader.GetDouble(0));
                            break;
                        default: break;
                    }
                }
                reader.Close();
            }
            catch (Exception exc)
            {
                MSG.Show(this, exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, logger);
            }
        }

        private void cbVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            graphs.Add(cbVariables.SelectedItem.ToString());
            BuildingChart(cbVariables.SelectedItem.ToString(), cbTimeFormat.SelectedItem.ToString());
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
                    reader = msc.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetUInt32(0);
                        name = reader.GetString(1);
                        desc = reader.GetString(2);

                        cbVariables.Items.Add(name);
                    }
                    reader.Close();
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
            string showQuery = "SELECT Timestamp` FROM `trends_data` WHERE 1";

            MySqlCommand msc = new MySqlCommand(showQuery, DBUtils.conn);
            try
            {
                if (DBUtils.OpenConnection(lbStatus, logger))
                {
                    cbVariables.Items.Clear();
                }
            }
            catch
            {
                MSG.Show(this, "Please enable server connection", MessageBoxButtons.OK, MessageBoxIcon.Warning, logger);
            }
        }

        private void cbTypePoints_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbTypePoints.SelectedItem.ToString())
            {
                case "FastLine":
                    chartType = SeriesChartType.FastLine;
                    break;
                case "FastPoint":
                    chartType = SeriesChartType.FastPoint;
                    break;
                default:
                    break;
            }

            for (int i = 0; i < MainChart.Series.Count; i++)
            {
                MainChart.Series[i].ChartType = chartType;

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
                graphs.Clear();
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
            try
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
            catch (Exception exc)
            {
                MSG.Show(this, exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, logger);
            }
        }

        private void StaticForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.CloseConnection();
            DBUtils.CloseConnection(lbStatus, logger);
        }

        private void cbTimeFormat_ValueChanged(object sender, EventArgs e)
        {
            if (graphs.Count > 0)
            {
                MainChart.ChartAreas[0].AxisX.Title = cbTimeFormat.SelectedItem.ToString();
                MainChart.Series.Clear();
                foreach(var i in graphs)
                    BuildingChart(i, cbTimeFormat.SelectedItem.ToString());
            }
        }
    }
}
