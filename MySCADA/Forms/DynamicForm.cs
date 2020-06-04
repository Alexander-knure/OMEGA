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
        private DateTime endTime;
        private DateTime startTime;
        private List<Variable> variables;
        SeriesChartType chartType = SeriesChartType.FastPoint;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private double start = 0.0d;
        int numberOfZoom = 0;
        private double end = 0.0d;
        private string selected;
        TimeSpan ts = TimeSpan.Zero;
        public DynamicForm()
        {
            mf = new MainForm();
            variables = new List<Variable>();
            InitializeComponent();
            mf.OpenConnection();
            MainChart.MouseWheel += MainChart_MouseWheel;

            List<string> types = new List<string>();
            types.Add(SeriesChartType.FastLine.ToString());
            types.Add(SeriesChartType.FastPoint.ToString());

            foreach (var i in types)
                cbTypePoints.Items.Add(i);
            cbTypePoints.SelectedIndex = 0;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }

        private void cbVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            endTime = DateTime.Now;

            startTime = endTime.AddSeconds(-1);

            MainChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            MainChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            MainChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            MainChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            MainChart.ChartAreas[0].CursorY.IsUserEnabled = true;
            MainChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            MainChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            MainChart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            selected = cbVariables.SelectedItem.ToString();
            MainChart.Series.Add(selected);
        }

        void addVariable()
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
        private void DynamicForm_Load(object sender, EventArgs e)
        {
            DBUtils.OpenConnection(lbStatus, MainForm.logger);
        }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "Do you want clear all?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
            if (dr == DialogResult.Yes)
            {
                MainChart.Series.Clear();
                ts = TimeSpan.Zero;
                lbTimer.Text = "Timer: " + ts.ToString();
                dTimer.Enabled = false;
            }
            else if (dr == DialogResult.No)
                return;
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
        private void DynamicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.CloseConnection();
            DBUtils.CloseConnection(lbStatus, logger);
        }

        List<DateTime> current_data = new List<DateTime>();
        List<DateTime> full_data = new List<DateTime>();
        List<double> data = new List<double>();
        int c = 0;
        private void ExecuteQuery(string query)
        {
            try
            {
                MySqlCommand msc = new MySqlCommand(query, DBUtils.conn);
                if (DBUtils.OpenConnection(lbStatus, logger))
                {
                    MainChart.Series[selected].BorderWidth = 3;
                    MainChart.Series[selected].LegendText = selected;

                    MainChart.Series[selected].ChartType = chartType;

                    cbVariables.Items.Clear();

                    MySqlDataReader reader = msc.ExecuteReader();
                    c++;
                    while (reader.Read())
                    {
                        current_data.Add(reader.GetDateTime(1));
                        data.Add(reader.GetDouble(0));
                    }

                    for (int i = 0; i < current_data.Count; i++)
                    {
                        if (!full_data.Contains(current_data[i]))
                        {
                            full_data.Add(current_data[i]);
                            //MainChart.Series[selected].Points.AddY(data[i]);
                            MainChart.Series[selected].Points.AddY(data[i]);
                        }
                        else
                        {
                            MainChart.Series[selected].Points.AddY(data[i]);
                            //MainChart.Series[selected].Points.AddY(data[i]);
                        }
                    }



                    current_data.Clear();

                    reader.Close();
                }
            }
            catch (Exception exc)
            {
                MSG.Show(this, exc.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, logger);
            }
        }
        private void dTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan second = new TimeSpan(0, 0, 1);
            ts += second;
            lbTimer.Text = "Timer: " + ts.ToString();

            if (selected != null)
            {
                if (MainChart.Series.Count >= 5)
                {
                    DialogResult dr = MetroMessageBox.Show(this, "So mush sensors, do you want clear all?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                    if (dr == DialogResult.Yes)
                        MainChart.Series.Clear();
                    else if (dr == DialogResult.No)
                        return;
                }


                string sDate = startTime.Date.ToString("yyyy-MM-dd");
                string sTime = startTime.ToString("hh:mm:ss");
                string eDate = endTime.Date.ToString("yyyy-MM-dd");
                string eTime = endTime.ToString("hh:mm:ss");
                // string query = "SELECT Value, TimeStamp FROM `variables_data` INNER JOIN `trends_data` ON variables_data.ID = trends_data.ID" +
                //    " WHERE variables_data.Name = \"" + selected + "\"" +
                //    " AND TimeStamp > TIMESTAMP(\"" + sDate + "\", \"" + sTime + "\")" +
                //    //" AND TimeStamp < TIMESTAMP(\"" + eDate + "\", \"" + eTime + "\")" +
                //    "ORDER BY TimeStamp ASC;";

                string query = "SELECT Value, TimeStamp FROM variables_data INNER JOIN trends_data ON variables_data.ID = trends_data.ID " +
                    " WHERE variables_data.Name = \"" + selected + "\"" +
                    // " AND TimeStamp > (NOW() - INTERVAL 1 DAY) " + ""
                    " AND TimeStamp < NOW() " +
                    " ORDER BY TimeStamp  DESC" +
                    " LIMIT 120";

                endTime = endTime.AddSeconds(1);
                ExecuteQuery(query);
            }
        }

        private void btTimer_Click(object sender, EventArgs e)
        {
            if (dTimer.Enabled == true) //Stopping
            {
                btTimer.Text = string.Format("Start");
                dTimer.Enabled = false;
                dTimer.Stop();
            }
            else //Starting
            {
                btTimer.Text = string.Format("Stop");
                dTimer.Enabled = true;
                dTimer.Start();
            }
        }

        private void cbVariables_Click(object sender, EventArgs e)
        {
            if (dTimer.Enabled)
            {
                MSG.Show(this, "Please stop the timer", MessageBoxButtons.OK, MessageBoxIcon.Warning, logger);
            }
            else
            {
                full_data.Clear();
                data.Clear();
                lbTimer.Text = "Start the timer";
                addVariable();
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
    }
}
