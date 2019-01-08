namespace CycleAnalysisSoftwareB
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pnlCalendarView = new System.Windows.Forms.Panel();
            this.pnlCalculateData = new System.Windows.Forms.Panel();
            this.pnlLiveGraph = new System.Windows.Forms.Panel();
            this.pnlViewData = new System.Windows.Forms.Panel();
            this.pnlSelectedGraph = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataViewToolStripMenuItem,
            this.graphToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.intervalDetectionToolStripMenuItem,
            this.calendarViewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataViewToolStripMenuItem
            // 
            this.dataViewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataViewToolStripMenuItem.Name = "dataViewToolStripMenuItem";
            this.dataViewToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.dataViewToolStripMenuItem.Text = "Data View";
            this.dataViewToolStripMenuItem.Click += new System.EventHandler(this.dataViewToolStripMenuItem_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveGraphToolStripMenuItem,
            this.selectedGraphToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // liveGraphToolStripMenuItem
            // 
            this.liveGraphToolStripMenuItem.Name = "liveGraphToolStripMenuItem";
            this.liveGraphToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.liveGraphToolStripMenuItem.Text = "Live Graph";
            this.liveGraphToolStripMenuItem.Click += new System.EventHandler(this.liveGraphToolStripMenuItem_Click);
            // 
            // selectedGraphToolStripMenuItem
            // 
            this.selectedGraphToolStripMenuItem.Name = "selectedGraphToolStripMenuItem";
            this.selectedGraphToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.selectedGraphToolStripMenuItem.Text = "Selected Graph";
            this.selectedGraphToolStripMenuItem.Click += new System.EventHandler(this.selectedGraphToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // intervalDetectionToolStripMenuItem
            // 
            this.intervalDetectionToolStripMenuItem.Name = "intervalDetectionToolStripMenuItem";
            this.intervalDetectionToolStripMenuItem.Size = new System.Drawing.Size(121, 21);
            this.intervalDetectionToolStripMenuItem.Text = "Interval Detection";
            // 
            // calendarViewToolStripMenuItem
            // 
            this.calendarViewToolStripMenuItem.Name = "calendarViewToolStripMenuItem";
            this.calendarViewToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.calendarViewToolStripMenuItem.Text = "Calendar View";
            this.calendarViewToolStripMenuItem.Click += new System.EventHandler(this.calendarViewToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblMessage.Location = new System.Drawing.Point(580, 212);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(176, 20);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Please Upload File First";
            // 
            // btnUpload
            // 
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.Gray;
            this.btnUpload.Location = new System.Drawing.Point(601, 248);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(132, 56);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHome.BackgroundImage")));
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHome.Controls.Add(this.pnlExit);
            this.panelHome.Controls.Add(this.pnlCalendarView);
            this.panelHome.Controls.Add(this.pnlCalculateData);
            this.panelHome.Controls.Add(this.pnlLiveGraph);
            this.panelHome.Controls.Add(this.pnlViewData);
            this.panelHome.Controls.Add(this.pnlSelectedGraph);
            this.panelHome.Location = new System.Drawing.Point(405, 322);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(548, 236);
            this.panelHome.TabIndex = 4;
            this.panelHome.Visible = false;
            // 
            // pnlExit
            // 
            this.pnlExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlExit.BackgroundImage")));
            this.pnlExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlExit.Location = new System.Drawing.Point(433, 121);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(102, 100);
            this.pnlExit.TabIndex = 7;
            this.pnlExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlExit_MouseClick);
            this.pnlExit.MouseLeave += new System.EventHandler(this.pnlExit_MouseLeave);
            this.pnlExit.MouseHover += new System.EventHandler(this.pnlExit_MouseHover);
            // 
            // pnlCalendarView
            // 
            this.pnlCalendarView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCalendarView.BackgroundImage")));
            this.pnlCalendarView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCalendarView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCalendarView.Location = new System.Drawing.Point(433, 11);
            this.pnlCalendarView.Name = "pnlCalendarView";
            this.pnlCalendarView.Size = new System.Drawing.Size(102, 100);
            this.pnlCalendarView.TabIndex = 6;
            this.pnlCalendarView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCalendarView_MouseClick);
            this.pnlCalendarView.MouseLeave += new System.EventHandler(this.pnlCalendarView_MouseLeave);
            this.pnlCalendarView.MouseHover += new System.EventHandler(this.pnlCalendarView_MouseHover);
            // 
            // pnlCalculateData
            // 
            this.pnlCalculateData.BackColor = System.Drawing.Color.Transparent;
            this.pnlCalculateData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCalculateData.BackgroundImage")));
            this.pnlCalculateData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCalculateData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCalculateData.Location = new System.Drawing.Point(221, 121);
            this.pnlCalculateData.Name = "pnlCalculateData";
            this.pnlCalculateData.Size = new System.Drawing.Size(200, 100);
            this.pnlCalculateData.TabIndex = 4;
            this.pnlCalculateData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCalculateData_MouseClick);
            this.pnlCalculateData.MouseLeave += new System.EventHandler(this.pnlCalculateData_MouseLeave);
            this.pnlCalculateData.MouseHover += new System.EventHandler(this.pnlCalculateData_MouseHover);
            // 
            // pnlLiveGraph
            // 
            this.pnlLiveGraph.BackColor = System.Drawing.Color.Transparent;
            this.pnlLiveGraph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLiveGraph.BackgroundImage")));
            this.pnlLiveGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLiveGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLiveGraph.Location = new System.Drawing.Point(221, 11);
            this.pnlLiveGraph.Name = "pnlLiveGraph";
            this.pnlLiveGraph.Size = new System.Drawing.Size(200, 100);
            this.pnlLiveGraph.TabIndex = 1;
            this.pnlLiveGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLiveGraph_MouseClick);
            this.pnlLiveGraph.MouseLeave += new System.EventHandler(this.pnlLiveGraph_MouseLeave);
            this.pnlLiveGraph.MouseHover += new System.EventHandler(this.pnlLiveGraph_MouseHover);
            // 
            // pnlViewData
            // 
            this.pnlViewData.BackColor = System.Drawing.Color.Transparent;
            this.pnlViewData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlViewData.BackgroundImage")));
            this.pnlViewData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlViewData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlViewData.Location = new System.Drawing.Point(11, 121);
            this.pnlViewData.Name = "pnlViewData";
            this.pnlViewData.Size = new System.Drawing.Size(200, 100);
            this.pnlViewData.TabIndex = 3;
            this.pnlViewData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlViewData_MouseClick);
            this.pnlViewData.MouseLeave += new System.EventHandler(this.pnlViewData_MouseLeave);
            this.pnlViewData.MouseHover += new System.EventHandler(this.pnlViewData_MouseHover);
            // 
            // pnlSelectedGraph
            // 
            this.pnlSelectedGraph.BackColor = System.Drawing.Color.Transparent;
            this.pnlSelectedGraph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSelectedGraph.BackgroundImage")));
            this.pnlSelectedGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSelectedGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSelectedGraph.Location = new System.Drawing.Point(11, 11);
            this.pnlSelectedGraph.Name = "pnlSelectedGraph";
            this.pnlSelectedGraph.Size = new System.Drawing.Size(200, 100);
            this.pnlSelectedGraph.TabIndex = 0;
            this.pnlSelectedGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlSelectedGraph_MouseClick);
            this.pnlSelectedGraph.MouseLeave += new System.EventHandler(this.pnlSelectedGraph_MouseLeave);
            this.pnlSelectedGraph.MouseHover += new System.EventHandler(this.pnlSelectedGraph_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAuthor.Location = new System.Drawing.Point(581, 611);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(12, 16);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = ".";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 636);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervalDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ToolStripMenuItem liveGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarViewToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel pnlCalculateData;
        private System.Windows.Forms.Panel pnlLiveGraph;
        private System.Windows.Forms.Panel pnlViewData;
        private System.Windows.Forms.Panel pnlSelectedGraph;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel pnlCalendarView;
        private System.Windows.Forms.Label lblAuthor;
    }
}

