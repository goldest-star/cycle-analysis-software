using CycleAnalysisSoftwareB.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleAnalysisSoftwareB
{
    public partial class frmHome : Form
    {
        public static string Path;
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = "HRM FILES ONLY|*.hrm;*.HRM;";
            browse.FilterIndex = 2;
            browse.RestoreDirectory = true;
            if (browse.ShowDialog() == DialogResult.OK)
            {
                lblMessage.Text = "You Have Uploaded a File.";
                Path = browse.FileName;
            }
            if(Path!=null)
            {
                panelHome.Visible = true;
            }
        }

        private void dataViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataView DataView = new frmDataView();
            DataView.Show();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvancedCalculation adcalc = new AdvancedCalculation();
            adcalc.Show();
        }

        private void selectedGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataSelectionGraph dsg = new frmDataSelectionGraph();
            dsg.Show();
        }

        private void calendarViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendarView calView = new frmCalendarView();
            calView.Show();
        }

        private void liveGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLiveGraph lvGrph = new frmLiveGraph();
            lvGrph.Show();
        }

        private void pnlSelectedGraph_MouseHover(object sender, EventArgs e)
        {
            pnlSelectedGraph.BackgroundImage = Resources.SelectedGraph2;
        }

        private void pnlSelectedGraph_MouseLeave(object sender, EventArgs e)
        {
            pnlSelectedGraph.BackgroundImage = Resources.SelectedGraph;
        }
        private void pnlSelectedGraph_MouseClick(object sender, MouseEventArgs e)
        {
            frmDataSelectionGraph DSG = new frmDataSelectionGraph();
            DSG.Show();
        }

        private void pnlViewData_MouseHover(object sender, EventArgs e)
        {
            pnlViewData.BackgroundImage = Resources.ViewData2;
        }

        private void pnlViewData_MouseLeave(object sender, EventArgs e)
        {
            pnlViewData.BackgroundImage = Resources.View_Data;
        }
        private void pnlViewData_MouseClick(object sender, MouseEventArgs e)
        {
            frmDataView DV = new frmDataView();
            DV.Show();
        }

        private void pnlLiveGraph_MouseHover(object sender, EventArgs e)
        {
            pnlLiveGraph.BackgroundImage = Resources.LiveGraph2;
        }

        private void pnlLiveGraph_MouseLeave(object sender, EventArgs e)
        {
            pnlLiveGraph.BackgroundImage = Resources.LiveGraph;
        }
        private void pnlLiveGraph_MouseClick(object sender, MouseEventArgs e)
        {
            frmLiveGraph LG = new frmLiveGraph();
            LG.Show();
        }

        private void pnlCalculateData_MouseHover(object sender, EventArgs e)
        {
            pnlCalculateData.BackgroundImage = Resources.CalculateData2;
        }

        private void pnlCalculateData_MouseLeave(object sender, EventArgs e)
        {
            pnlCalculateData.BackgroundImage = Resources.CalculateData;
        }
        private void pnlCalculateData_MouseClick(object sender, MouseEventArgs e)
        {
            AdvancedCalculation AC = new AdvancedCalculation();
            AC.Show();
        }

        private void pnlCalendarView_MouseHover(object sender, EventArgs e)
        {
            pnlCalendarView.BackgroundImage = Resources.CalendarView2;
        }

        private void pnlCalendarView_MouseLeave(object sender, EventArgs e)
        {
            pnlCalendarView.BackgroundImage = Resources.Calendar_View;
        }
        private void pnlCalendarView_MouseClick(object sender, MouseEventArgs e)
        {
            frmCalendarView CV = new frmCalendarView();
            CV.Show();
        }

        private void pnlExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pnlExit_MouseHover(object sender, EventArgs e)
        {
            pnlExit.BackgroundImage = Resources.Exit2;
        }

        private void pnlExit_MouseLeave(object sender, EventArgs e)
        {
            pnlExit.BackgroundImage = Resources.Exit;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblAuthor.Text = "Developed By: Vijay Thapa";
        }
    }
}
