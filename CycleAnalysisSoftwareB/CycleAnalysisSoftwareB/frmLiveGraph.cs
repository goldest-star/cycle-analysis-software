using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ZedGraph;

namespace CycleAnalysisSoftwareB
{
    public partial class frmLiveGraph : Form
    {
        #region Variables to create Graph
        public static string Path;
        delegate void SetTextCallback(string text);
        delegate void axisChangeZedGraphCallBack(ZedGraphControl zg);
        public Thread garthererThread;

        LineItem myCurve, myCurve2, myCurve3, myCurve4, myCurve5, myCurve6;
        PointPairList list1;
        PointPairList list2;
        PointPairList list3;
        PointPairList list4;
        PointPairList list5;
        PointPairList list6;
        GraphPane myPane;


        string[] heartrate;
        string[] speed;
        string[] Cadence;
        string[] altitude;
        string[] Power;
        string[] Balance;
        #endregion
        public frmLiveGraph()
        {
            InitializeComponent();
        }
        private void frmLiveGraph_Load(object sender, EventArgs e)
        {
            Path = frmHome.Path;
            if (Path == null)
            {
                MessageBox.Show("Please Select File to Show Graph.");
                this.Close();
            }
            else
            {
                #region Creating and Showing Graph

                myPane = zedGraphControl1.GraphPane;
                list1 = new PointPairList();
                list2 = new PointPairList();
                list3 = new PointPairList();
                list4 = new PointPairList();
                list5 = new PointPairList();
                list6 = new PointPairList();
                myCurve = myPane.AddCurve("HR",
                     list1, Color.Red, SymbolType.Diamond);


                myCurve2 = myPane.AddCurve("Speed",
                     list2, Color.Blue, SymbolType.Circle);


                myCurve3 = myPane.AddCurve("CAD",
                   list3, Color.Green, SymbolType.Diamond);


                myCurve4 = myPane.AddCurve("ALT",
                     list4, Color.Purple, SymbolType.Diamond);


                myCurve5 = myPane.AddCurve("PWR",
                     list5, Color.Brown, SymbolType.Diamond);

                myCurve6 = myPane.AddCurve("BAL",
                     list6, Color.DarkGray, SymbolType.Diamond);
                Thread tid1 = new Thread(new ThreadStart(Thread1));
                Thread tid2 = new Thread(new ThreadStart(Thread2));
                Thread tid3 = new Thread(new ThreadStart(Thread3));
                Thread tid4 = new Thread(new ThreadStart(Thread4));
                Thread tid5 = new Thread(new ThreadStart(Thread5));
                //Thread tid6 = new Thread(new ThreadStart(Thread6));
                Thread tidgc = new Thread(new ThreadStart(CreateGraph));
                tid1.Start();
                tid2.Start();
                tid3.Start();
                tid4.Start();
                tid5.Start();
                tidgc.Start();
                #endregion

            }
        }

        private void axisChangeZedGraph(ZedGraphControl zg)
        {
            if (zg.InvokeRequired)
            {
                axisChangeZedGraphCallBack ad = new axisChangeZedGraphCallBack(axisChangeZedGraph);
                zg.Invoke(ad, new object[] { zg });
            }
            else
            {
                zedGraphControl1.AxisChange();
                zg.Invalidate();
                zg.Refresh();
            }
        }
        #region Thread for Heart Rate
        public void Thread1()
        {
            string txtData = File.ReadAllText(Path);
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            heartrate = new string[arrData.Length - index2];
            int j = 0;



            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                heartrate[j] = arrHrdata[0];

                this.SetText1(heartrate[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }
        #endregion

        #region Thread for Speed
        public void Thread2()
        {
            string txtData = File.ReadAllText(Path);
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            speed = new string[arrData.Length - index2];
            int j = 0;

            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                speed[j] = arrHrdata[1];
                this.SetText2(speed[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }
        #endregion

        #region Thread For Cadence
        public void Thread3()
        {
            string txtData = File.ReadAllText(Path);
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            Cadence = new string[arrData.Length - index2];
            int j = 0;

            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                Cadence[j] = arrHrdata[2];

                this.SetText3(Cadence[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }
        #endregion

        #region Thread for Altitude
        public void Thread4()
        {
            string txtData = File.ReadAllText(Path);
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            altitude = new string[arrData.Length - index2];
            int j = 0;

            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                altitude[j] = arrHrdata[3];
                this.SetText4(altitude[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }
        #endregion

        #region Thread for Power
        public void Thread5()
        {
            string txtData = File.ReadAllText(Path);
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            Power = new string[arrData.Length - index2];
            int j = 0;

            for (int i = index2 + 1; i < arrData.Length - 1; i++)
            {
                string HRData = arrData[i];
                string[] arrHrdata = Regex.Split(HRData, @"\W+");
                Power[j] = arrHrdata[4];

                this.SetText5(Power[j].ToString());
                Thread.Sleep(700);
                j++;
            }
        }
        #endregion


        private void TimerCallback(object source, ElapsedEventArgs e)
        {
            garthererThread = new Thread(new ThreadStart(GartherData));
        }

        #region Gather Data
        private void GartherData()
        {
            List<float> gartheredInfo = new List<float>();

            //Do your garthering and parsing here (and put it in the gartheredInfo variable)

            //InformationHolder.Instance().graphData = gartheredInfo;

            zedGraphControl1.Invoke(new MethodInvoker( //you need to have a reference to the form
                    delegate
                    {
                        zedGraphControl1.Invalidate(); //or another method that redraws the graph
                    }));
        }
        #endregion

        #region Set Text on Heart Rate Label
        private void SetText1(string text)
        {
            if (lblHeartRateTxt.InvokeRequired)
            {
                SetTextCallback st = new SetTextCallback(SetText1);
                this.Invoke(st, new object[] { text });
            }
            else
            {
                lblHeartRateTxt.Text = text;
            }
        }

        
        #endregion

        #region Set Text on Speed Label
        private void SetText2(string text)
        {
            if (lblSpeedTxt.InvokeRequired)
            {
                SetTextCallback st = new SetTextCallback(SetText2);
                this.Invoke(st, new object[] { text });
            }
            else
            {
                lblSpeedTxt.Text = text;
            }
        }

        
        #endregion

        #region SEt Text on Cadence Label
        private void SetText3(string text)
        {
            if (lblCadenceTxt.InvokeRequired)
            {
                SetTextCallback st = new SetTextCallback(SetText3);
                this.Invoke(st, new object[] { text });
            }
            else
            {
                lblCadenceTxt.Text = text;
            }
        }
        #endregion

        #region SEt Text on Altitude Label
        private void SetText4(string text)
        {
            if (lblAltitudeTxt.InvokeRequired)
            {
                SetTextCallback st = new SetTextCallback(SetText4);
                this.Invoke(st, new object[] { text });
            }
            else
            {
                lblAltitudeTxt.Text = text;
            }
        }
        #endregion

        #region Set Text on Power Label
        private void SetText5(string text)
        {
            if (lblPowerTxt.InvokeRequired)
            {
                SetTextCallback st = new SetTextCallback(SetText5);
                this.Invoke(st, new object[] { text });
            }
            else
            {
                lblPowerTxt.Text = text;
            }
        }
        #endregion

        #region Create Graph
        private void CreateGraph()
        {

            myPane.Title.Text = "My Graph";
            myPane.XAxis.Title.Text = "My X Axis(LINE NUM)";
            myPane.YAxis.Title.Text = "My Y Axis(HR, SPD, CAD, ALT, PWR)";



            string txtData = File.ReadAllText(Path);
            string[] arrData = txtData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int index2 = Array.IndexOf(arrData, "[HRData]");
            heartrate = new string[arrData.Length - index2];
            speed = new string[arrData.Length - index2];
            Cadence = new string[arrData.Length - index2];
            altitude = new string[arrData.Length - index2];
            Power = new string[arrData.Length - index2];
            Balance = new string[arrData.Length - index2];
            int j = 0;



            // Make up some, data arrays based on the Sine function
            double x, y1, y2, y3, y4, y5, y6;
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            PointPairList list3 = new PointPairList();
            PointPairList list4 = new PointPairList();
            PointPairList list5 = new PointPairList();
            PointPairList list6 = new PointPairList();
            for (int i = index2 + 1; i < arrData.Length - 1; i += 1)
            {
                string HRData = arrData[i];

                string[] arrHrdata = Regex.Split(HRData, @"\W+");


                heartrate[j] = arrHrdata[0];
                speed[j] = arrHrdata[1];
                Cadence[j] = arrHrdata[2];
                altitude[j] = arrHrdata[3];
                Power[j] = arrHrdata[4];
                Balance[j] = arrHrdata[5];

                int a = Int32.Parse(heartrate[j]);
                int b = Int32.Parse(speed[j]);
                int c = Int32.Parse(Cadence[j]);
                int d = Int32.Parse(altitude[j]);
                int e = Int32.Parse(Power[j]);
                int f = Int32.Parse(Balance[j]);

                x = i;
                y1 = a;
                y2 = b;
                y3 = c;
                y4 = d;
                y5 = e;
                y6 = e;

                LineItem curve = zedGraphControl1.GraphPane.CurveList["HR"] as LineItem;
                // Get the PointPairList
                IPointListEdit list = curve.Points as IPointListEdit;
                list.Add(x, y1);
                LineItem curve2 = zedGraphControl1.GraphPane.CurveList["Speed"] as LineItem;
                // Get the PointPairList
                IPointListEdit list12 = curve2.Points as IPointListEdit;
                list12.Add(x, y2);
                LineItem curve3 = zedGraphControl1.GraphPane.CurveList["CAD"] as LineItem;
                // Get the PointPairList
                IPointListEdit list13 = curve3.Points as IPointListEdit;
                list13.Add(x, y3);
                LineItem curve4 = zedGraphControl1.GraphPane.CurveList["ALT"] as LineItem;
                // Get the PointPairList
                IPointListEdit list14 = curve4.Points as IPointListEdit;
                list14.Add(x, y4);
                LineItem curve5 = zedGraphControl1.GraphPane.CurveList["PWR"] as LineItem;
                // Get the PointPairList
                IPointListEdit list15 = curve5.Points as IPointListEdit;
                list15.Add(x, y5);
                LineItem curve6 = zedGraphControl1.GraphPane.CurveList["BAL"] as LineItem;
                // Get the PointPairList
                IPointListEdit list16 = curve6.Points as IPointListEdit;
                list15.Add(x, y6);

                axisChangeZedGraph(zedGraphControl1);
                Thread.Sleep(700);
            }
        }
        #endregion

        //Checkbox Not Working
        #region Heart Rate Checkbox Changed
        private void HeartRate_CheckedChanged(object sender, EventArgs e)
        {
            if (HeartRate.Checked == false)
            {
                myCurve.IsVisible = false;
                HeartRate.Invalidate();
            }
            else
            {
                myCurve.IsVisible = true;
                HeartRate.Invalidate();
            }
        }
        #endregion
        #region Speed Checkbox Changed
        private void chkboxSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSpeed.Checked == false)
            {
                myCurve2.IsVisible = false;
                chkboxSpeed.Invalidate();
            }
            else
            {
                myCurve2.IsVisible = true;
                chkboxSpeed.Invalidate();
            }
        }
        #endregion

        #region Cadence Checkbox Changed
        private void chkboxCadence_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxCadence.Checked == false)
            {
                myCurve3.IsVisible = false;
                chkboxCadence.Invalidate();
            }
            else
            {
                myCurve3.IsVisible = true;
                chkboxCadence.Invalidate();
            }
        }
        #endregion
        #region Altitude Checkbox Changed
        private void chkboxAltitude_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAltitude.Checked == false)
            {
                myCurve4.IsVisible = false;
                chkboxAltitude.Invalidate();
            }
            else
            {
                myCurve4.IsVisible = true;
                chkboxAltitude.Invalidate();
            }
        }
        #endregion

        #region power Checkbox Changed
        private void chkboxPower_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxPower.Checked == false)
            {
                myCurve5.IsVisible = false;
                chkboxPower.Invalidate();
            }
            else
            {
                myCurve5.IsVisible = true;
                chkboxPower.Invalidate();
            }
        }
        #endregion
    }
}
