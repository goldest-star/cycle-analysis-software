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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleAnalysisSoftwareB
{
    public partial class frmDataView : Form
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

        public frmDataView()
        {
            InitializeComponent();
        }
        public static string[] SplitParm(string line)
        {
            return line.Split('=');
        }
        public static string[] SplitData(string line)
        {
            return Regex.Split(line, @"\W+");
        }

        private void frmDataView_Load(object sender, EventArgs e)
        {
            //Getting Path Value from Home Form
            Path = frmHome.Path;
            //CHecking if the file is uploaded or not
            //PAth is Null if File Not Selected
            if(Path==null)
            {
                //File not Upoaded
                MessageBox.Show("Please Upload File First");
                this.Close();
            }
            else
            {
                //File Selected
                //Load Data and Show Summary
                #region Load Data on Top
                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader SR = new StreamReader(Path))
                    {
                        string line;
                        // Read and display lines from the file until the end of 
                        // the file is reached.
                        bool isp = false, IsHrData = false;
                        while ((line = SR.ReadLine()) != null)
                        {
                            if (isp == true)
                            {
                                //  Console.WriteLine(line);
                                string[] parm = SplitParm(line);
                                if (parm.Length > 1)
                                {
                                    Console.WriteLine("Param    " + parm[0] + parm[1]);
                                    param.Add(parm[0], parm[1]);

                                    if (line.Substring(0, 1) == "[")
                                    {
                                        isp = false;
                                    }
                                }
                            }

                            if (line == "[Params]")
                            {
                                isp = true;
                            }

                            if (IsHrData == true)
                            {
                                string[] data = SplitData(line);
                                hra.Add(data[0]);
                            }


                            if (line == "[HRData]")
                            {
                                IsHrData = true;
                                Console.WriteLine("isdata");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(ex.ToString());
                }
                #endregion
                #region Load All Data and Summary
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
                int colIndex1 = dgvData.Columns.Add(time);
                DataGridViewColumn heartrate = new DataGridViewTextBoxColumn();
                heartrate.HeaderText = "Heart Rate";
                int colIndex2 = dgvData.Columns.Add(heartrate);
                DataGridViewColumn speeding = new DataGridViewTextBoxColumn();
                speeding.HeaderText = "Speed";
                int colIndex3 = dgvData.Columns.Add(speeding);
                DataGridViewColumn cadencer = new DataGridViewTextBoxColumn();
                cadencer.HeaderText = "Cadence";
                int colIndex4 = dgvData.Columns.Add(cadencer);
                DataGridViewColumn alt = new DataGridViewTextBoxColumn();
                alt.HeaderText = "Altitude";
                int colIndex5 = dgvData.Columns.Add(alt);
                DataGridViewColumn pwr = new DataGridViewTextBoxColumn();
                pwr.HeaderText = "Power (watts)";
                int colIndex6 = dgvData.Columns.Add(pwr);

                DataGridViewColumn pwrbal = new DataGridViewTextBoxColumn();
                pwrbal.HeaderText = "Power Balance";
                int colIndex7 = dgvData.Columns.Add(pwrbal);

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
                    dgvData.Rows.Add(myDateTime, heart, speed, cadence, altitude, power, powerbal);
                }
                double averageHeart = 0.0;
                double averageSpeed = 0.0;
                double averagePower = 0.0;
                double averageAltitude = 0.0;
                //double maxHeartrate = 0.0;

                if (counter > 0)
                {
                    //Calculating Average
                    averageHeart = heartTotal / counter;
                    averageSpeed = speedTotal / counter;
                    averagePower = powerTotal / counter;
                    averageAltitude = altTotal / counter;
                    //Calculating Max Heart RAte
                    int[] maxHeartRate = (from DataGridViewRow row in dgvData.Rows
                                          where row.Cells[1].FormattedValue.ToString() != string.Empty
                                          select Convert.ToInt32(row.Cells[1].FormattedValue)).ToArray();
                    lblMaxHeartRate.Text = maxHeartRate.Max().ToString();

                    //Calculating Min Heart RAte
                    int[] minHeartRate = (from DataGridViewRow row in dgvData.Rows
                                          where row.Cells[1].FormattedValue.ToString() != string.Empty
                                          select Convert.ToInt32(row.Cells[1].FormattedValue)).ToArray();
                    lblMinHeartRate.Text = maxHeartRate.Min().ToString();

                    //Calculating Max Speed
                    decimal[] maxSpeed = (from DataGridViewRow row in dgvData.Rows
                                          where row.Cells[2].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDecimal(row.Cells[2].FormattedValue)).ToArray();
                    lblMaxSpeed.Text = maxSpeed.Max().ToString();
                    lblMinSpeed.Text = maxSpeed.Min().ToString();

                    //Calculating Max Min Altitude
                    int[] maxAltitude = (from DataGridViewRow row in dgvData.Rows
                                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                                         select Convert.ToInt32(row.Cells[4].FormattedValue)).ToArray();
                    lblMaxAltitude.Text = maxAltitude.Max().ToString();
                    lblMinAltitude.Text = maxAltitude.Min().ToString();

                    //Calculating Max Power
                    int[] maxPower = (from DataGridViewRow row in dgvData.Rows
                                      where row.Cells[4].FormattedValue.ToString() != string.Empty
                                      select Convert.ToInt32(row.Cells[4].FormattedValue)).ToArray();
                    lblMaxPower.Text = maxPower.Max().ToString();
                    lblMinPower.Text = maxPower.Min().ToString();

                }
                //Setting The Values to Label
                lblAvgAltitude.Text = averageAltitude.ToString();
                lblAvgHeartRate.Text = averageHeart.ToString();
                lblAvgPower.Text = averagePower.ToString();
                lblAvgSpeed.Text = averageSpeed.ToString();

                //Loading DAta to Labels

                lblVersion.Text = param["Version"];
                lblMonitor.Text = param["Monitor"];
                lblSMode.Text = param["SMode"];
                lblDate.Text = param["Date"];
                lblStartTime.Text = param["StartTime"];
                lblLength.Text = param["Length"];
                lblMaxHR.Text = param["MaxHR"];
                lblRestHR.Text = param["RestHR"];
                lblVo2Max.Text = param["VO2max"];
                lblWeight.Text = param["Weight"];
                #endregion
            }
        }
        private void ReadData()
        {

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
