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
    public partial class AdvancedCalculation : Form
    {
        static string Path;
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
        public AdvancedCalculation()
        {
            InitializeComponent();
        }

        private void AdvancedCalculation_Load(object sender, EventArgs e)
        {
            Path = frmHome.Path;
            if (Path == null)
            {
                MessageBox.Show("Please Select File to Show Data.");
                this.Close();
            }
            else
            {
                //SHow DAta Based on the Path
                #region Showing Data
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
                    //dgvHRData.Rows.Add(myDateTime, heart, speed, cadence, altitude, power, powerbal);
                }
                double averagePower = 0.0;
                //double maxHeartrate = 0.0;

                if (counter > 0)
                {
                    //Calculating Average

                    averagePower = powerTotal / counter;

                    //Calculating Functional Threshold Power
                    double FTP = averagePower * 0.95;
                    //double totalFTP = averagePower - FTP;
                    lblFTP.Text = FTP.ToString();

                    //Calculating Normalized Power
                    double f = Math.Pow(averagePower, 4.0);
                    double m = f * 66.0;
                    double time = m / 60.0;
                    double np = Math.Pow(time, (1.0 / 4));
                    lblNP.Text = np.ToString();

                    //Calculating Intensity Factor
                    double IF = np / FTP;
                    lblIF.Text = IF.ToString();

                    //Calculating TSS
                    double tss = ((3960 * np * IF) / (FTP * 3600)) * 100;
                    lblTSS.Text = tss.ToString();
                }
                //Setting The Values to Label

                lblAvgPower.Text = averagePower.ToString();
                #endregion
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
    }
}
