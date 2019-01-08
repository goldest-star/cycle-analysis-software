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

namespace CycleAnalysisSoftwareB
{
    public partial class frmCalendarView : Form
    {
        private static String Path;
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
        public frmCalendarView()
        {
            InitializeComponent();
        }

        private void frmCalendarView_Load(object sender, EventArgs e)
        {
            Path = frmHome.Path;
            if(Path==null)
            {
                MessageBox.Show("Please Select File First.");
                this.Close();
            }
        }

        private void monthCalendarData_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Load Data on Date Selection
            LoadData();
        }
        private void LoadData()
        {
            #region Load Data to the Data Grid View
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
            int colIndex1 = dgvDateData.Columns.Add(time);
            DataGridViewColumn heartrate = new DataGridViewTextBoxColumn();
            heartrate.HeaderText = "Heart Rate";
            int colIndex2 = dgvDateData.Columns.Add(heartrate);
            DataGridViewColumn speeding = new DataGridViewTextBoxColumn();
            speeding.HeaderText = "Speed";
            int colIndex3 = dgvDateData.Columns.Add(speeding);
            DataGridViewColumn cadencer = new DataGridViewTextBoxColumn();
            cadencer.HeaderText = "Cadence";
            int colIndex4 = dgvDateData.Columns.Add(cadencer);
            DataGridViewColumn alt = new DataGridViewTextBoxColumn();
            alt.HeaderText = "Altitude";
            int colIndex5 = dgvDateData.Columns.Add(alt);
            DataGridViewColumn pwr = new DataGridViewTextBoxColumn();
            pwr.HeaderText = "Power (watts)";
            int colIndex6 = dgvDateData.Columns.Add(pwr);

            DataGridViewColumn pwrbal = new DataGridViewTextBoxColumn();
            pwrbal.HeaderText = "Power Balance";
            int colIndex7 = dgvDateData.Columns.Add(pwrbal);

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
                dgvDateData.Rows.Add(myDateTime, heart, speed, cadence, altitude, power, powerbal);
            }
            #endregion
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
    }
}
