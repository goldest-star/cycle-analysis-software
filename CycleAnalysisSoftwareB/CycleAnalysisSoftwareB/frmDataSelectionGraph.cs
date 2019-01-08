using CycleAnalysisSoftwareB.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace CycleAnalysisSoftwareB
{
    public partial class frmDataSelectionGraph : Form
    {
        public static string Path;
        private int seconds;
        private int counter;
        private int NumberOfLines;
        private string heart;
        private string speed;
        private string cadence;
        private string altitude;
        private string power;
        private string powerbal;
        private string line;
        private string HRM;
        private double[] heartgrapharr;
        DateTime myDateTime;
        IDictionary<string, string> param = new Dictionary<string, string>();
        ArrayList hra = new ArrayList();
        #region Variables For Graph
        PointPairList pwrList = new PointPairList();
        LineItem myCurve1, myCurve2, myCurve3, myCurve4, myCurve5;
        ZedGraphControl zgc;
        GraphPane myPane;
        PointPairList hrList = new PointPairList();
        PointPairList spdList = new PointPairList();
        PointPairList cadList = new PointPairList();
        PointPairList altList = new PointPairList();
        #endregion
        public frmDataSelectionGraph()
        {
            InitializeComponent();
        }

        private void dgvDSG_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            CreateGraph();
        }

        private void frmDataSelectionGraph_Load(object sender, EventArgs e)
        {
            Path = frmHome.Path;
            if(Path==null)
            {
                MessageBox.Show("Select File First.");
                this.Close();
            }
            else
            {
                //Load Data on the Graph
                LoadData();
                SetMaxMinOnLoad();
            }
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Resources.Close2;
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Resources.Close;
        }

        private void pictureBoxClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            #region Load Data to the DataGridView
            StreamReader reader = new StreamReader(Path, System.Text.Encoding.Default);
            string TextFF = reader.ReadToEnd();
            int lineIndex = TextFF.IndexOf("Date=");
            string lineDate = TextFF.Substring(lineIndex + 5, 8);// 8 characters = 20090412
            lineDate = lineDate.Insert(4, "-"); // add hyphen after yyyy
            lineDate = lineDate.Insert(7, "-"); // add hyphen after MM

            lineIndex = TextFF.IndexOf("StartTime=");
            string lineTime = TextFF.Substring(lineIndex + 10, 8); // 8 characters= hh:mm:ss
            lineIndex = TextFF.IndexOf("Interval="); //eg: StartTime=14:26:18.0
            string lineinter1 = TextFF.Substring(lineIndex + 9, 1); // 8 characters= hh:mm:ss
            lineIndex = TextFF.IndexOf("Length="); //eg: Length=14:26:18.0
            string lineLength = TextFF.Substring(lineIndex + 7, 8); // 8 characters= hh:mm:ss


            string textTimeStamp = lineDate + "   " + lineTime;
            // DateTime myDateTime = DateTime.ParseExact(textTimeStamp,"YYYY-mm-DD  hh24:mm:ss", null);
            StreamReader sr = new StreamReader(Path, System.Text.Encoding.Default);
            HRM = null;
            NumberOfLines = File.ReadAllLines(Path).Length;
            while ((HRM = sr.ReadLine()) != null)
            {
                if (HRM.IndexOf("[HRData]") != -1)
                {
                    //found it
                    break;
                }
            }
            line = sr.ReadLine();
            // Setup an accumulator
            int heartTotal = 0, speedTotal = 0, powerTotal = 0, altTotal = 0;
            double mph = 0;

            DataGridViewColumn time = new DataGridViewTextBoxColumn();
            time.HeaderText = "Time Stamp";
            int colIndex1 = dgvDSG.Columns.Add(time);
            DataGridViewColumn heartrate = new DataGridViewTextBoxColumn();
            heartrate.HeaderText = "Heart Rate";
            int colIndex2 = dgvDSG.Columns.Add(heartrate);
            DataGridViewColumn speeding = new DataGridViewTextBoxColumn();
            speeding.HeaderText = "Speed";
            int colIndex3 = dgvDSG.Columns.Add(speeding);
            DataGridViewColumn cadencer = new DataGridViewTextBoxColumn();
            cadencer.HeaderText = "Cadence";
            int colIndex4 = dgvDSG.Columns.Add(cadencer);
            DataGridViewColumn alt = new DataGridViewTextBoxColumn();
            alt.HeaderText = "Altitude";
            int colIndex5 = dgvDSG.Columns.Add(alt);
            DataGridViewColumn pwr = new DataGridViewTextBoxColumn();
            pwr.HeaderText = "Power (watts)";
            int colIndex6 = dgvDSG.Columns.Add(pwr);

            DataGridViewColumn pwrbal = new DataGridViewTextBoxColumn();
            pwrbal.HeaderText = "Power Balance";
            int colIndex7 = dgvDSG.Columns.Add(pwrbal);

            seconds = Convert.ToInt32(lineinter1);
            counter = 0;
            heartgrapharr = new double[0];
            while (line != null)
            {

                //Increment counter each pass through the loop.
                counter++;
                if (seconds <= 1)
                {
                    myDateTime = myDateTime.AddSeconds(seconds);
                }
                else
                {
                    if (seconds >= 1)
                        myDateTime = myDateTime.AddSeconds(seconds);
                }
                heart = line.Split('\t')[0];
                int heartint = Convert.ToInt32(heart);
                List<string> heartarr = new List<string>();
                heartarr.Add(heart);
                heartTotal += heartint;
                speed = line.Split('\t')[1];
                int speedint = Convert.ToInt32(speed);
                speedTotal += speedint;
                mph = ((double)speedint / (double)1.6);

                if (speedint <= 1)
                {
                    speed = speed.Insert(1, "."); // add point after two numbers

                }
                else
                {
                    if (speedint >= 1)
                        speed = speed.Insert(2, "."); // add point after two numbers
                }
                cadence = line.Split('\t')[2];
                int cadenceint = Convert.ToInt32(cadence);
                altitude = line.Split('\t')[3];
                int altitudeint = Convert.ToInt32(altitude);
                altTotal += altitudeint;
                power = line.Split('\t')[4];

                powerbal = line.Split('\t')[5];
                int Powerbalint = Convert.ToInt32(powerbal);
                int powerint = Convert.ToInt32(power);
                powerTotal += powerint;
                line = sr.ReadLine();
                dgvDSG.Rows.Add(myDateTime, heart, speed, cadence, altitude, power, powerbal);
            }
            #endregion
        }
        private void CreateGraph()
        {
            int count = dgvDSG.SelectedRows.Count;
            string[] hr = new string[count];
            string[] sp = new string[count];
            string[] cd = new string[count];
            string[] al = new string[count];
            string[] po = new string[count];

            int i = 0;
            foreach (DataGridViewRow row in dgvDSG.SelectedRows)
            {
                hr[i] = row.Cells[1].Value.ToString();
                sp[i] = row.Cells[2].Value.ToString();
                cd[i] = row.Cells[3].Value.ToString();
                al[i] = row.Cells[4].Value.ToString();
                po[i] = row.Cells[5].Value.ToString();

                i++;
            }

            PointPairList hrPairList = new PointPairList();
            PointPairList spPairList = new PointPairList();
            PointPairList cdPairList = new PointPairList();
            PointPairList alPairList = new PointPairList();
            PointPairList poPairList = new PointPairList();

            for (int j = 0; j < count; j++)
            {
                hrPairList.Add(j, Double.Parse(hr[j]));
                spPairList.Add(j, Double.Parse(sp[j]));
                cdPairList.Add(j, Double.Parse(cd[j]));
                alPairList.Add(j, Double.Parse(al[j]));
                poPairList.Add(j, Double.Parse(po[j]));

            }

            ZedGraphControl zedGraph = zedGraphControlDSG;
            GraphPane mypane = zedGraph.GraphPane;

            mypane.CurveList.Clear();

            mypane.Title.Text = "Cycle Analysis Software Graph";
            mypane.XAxis.Title.Text = "No. Of Data";
            mypane.YAxis.Title.Text = "Rate";
            mypane.XAxis.Scale.Min = 0;
            mypane.XAxis.Scale.Max = count;


            myCurve1 = mypane.AddCurve("heart rate", hrPairList, Color.Red);
            myCurve2 = mypane.AddCurve("Speed", spPairList, Color.Blue);
            myCurve3 = mypane.AddCurve("Cadence", cdPairList, Color.Green);
            myCurve4 = mypane.AddCurve("Altitude", alPairList, Color.Yellow);
            myCurve5 = mypane.AddCurve("Power", poPairList, Color.Purple);


            zedGraph.AxisChange();
            zedGraph.Invalidate();

            //Loading Max Min Data on Labels
            SetMaxMinOnSelect();
            
        }
        private void SetMaxMinOnLoad()
        {
            lblMaxHR.Text = 0.ToString();
            lblMinHR.Text = 0.ToString();
            lblMaxAltitude.Text = 0.ToString();
            lblMinAltitude.Text = 0.ToString();
            lblMaxPower.Text = 0.ToString();
            lblMinPower.Text = 0.ToString();
            lblMaxcadence.Text = 0.ToString();
            lblMinCadence.Text = 0.ToString();
        }
        private void SetMaxMinOnSelect()
        {
            #region Load Max Min Data
            //Finding Max Heart Rate Among Selected Value
            int count = dgvDSG.SelectedRows.Count;
            if (count > 0)
            {
                //Calculating Max Min Hear Rate
                int[] maxHeartRate = (from DataGridViewRow row in dgvDSG.SelectedRows
                                      where row.Cells[1].FormattedValue.ToString() != string.Empty
                                      select Convert.ToInt32(row.Cells[1].FormattedValue)).ToArray();
                lblMaxHR.Text = maxHeartRate.Max().ToString();
                lblMinHR.Text = maxHeartRate.Min().ToString();

                //Calculating Max Min Speed
                decimal[] Speed = (from DataGridViewRow row in dgvDSG.SelectedRows
                                   where row.Cells[2].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDecimal(row.Cells[2].FormattedValue)).ToArray();
                lblMaxSpeed.Text = Speed.Max().ToString();
                lblMinSpeed.Text = Speed.Min().ToString();

                //Calculating Max Min Cadence
                int[] Cadence = (from DataGridViewRow row in dgvDSG.SelectedRows
                                 where row.Cells[3].FormattedValue.ToString() != string.Empty
                                 select Convert.ToInt32(row.Cells[3].FormattedValue)).ToArray();
                lblMaxcadence.Text = Cadence.Max().ToString();
                lblMinCadence.Text = Cadence.Min().ToString();

                //Calculating Max Min Altitude
                int[] maxAltitude = (from DataGridViewRow row in dgvDSG.SelectedRows
                                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                                     select Convert.ToInt32(row.Cells[4].FormattedValue)).ToArray();
                lblMaxAltitude.Text = maxAltitude.Max().ToString();
                lblMinAltitude.Text = maxAltitude.Min().ToString();

                //Calculating Max Power
                int[] maxPower = (from DataGridViewRow row in dgvDSG.SelectedRows
                                  where row.Cells[5].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[5].FormattedValue)).ToArray();
                lblMaxPower.Text = maxPower.Max().ToString();
                lblMinPower.Text = maxPower.Min().ToString();
            }
            else
            {
                MessageBox.Show("Select Data to Show Graph and Summary.");
            }
            #endregion
        }
    }
}
