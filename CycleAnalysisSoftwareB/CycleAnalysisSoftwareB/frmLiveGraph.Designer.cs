namespace CycleAnalysisSoftwareB
{
    partial class frmLiveGraph
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPowerTxt = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblAltitudeTxt = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.Label();
            this.lblCadenceTxt = new System.Windows.Forms.Label();
            this.lblCadence = new System.Windows.Forms.Label();
            this.lblSpeedTxt = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblHeartRateTxt = new System.Windows.Forms.Label();
            this.lblHeartRate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkboxPower = new System.Windows.Forms.CheckBox();
            this.chkboxAltitude = new System.Windows.Forms.CheckBox();
            this.chkboxCadence = new System.Windows.Forms.CheckBox();
            this.chkboxSpeed = new System.Windows.Forms.CheckBox();
            this.HeartRate = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPowerTxt);
            this.panel1.Controls.Add(this.lblPower);
            this.panel1.Controls.Add(this.lblAltitudeTxt);
            this.panel1.Controls.Add(this.Altitude);
            this.panel1.Controls.Add(this.lblCadenceTxt);
            this.panel1.Controls.Add(this.lblCadence);
            this.panel1.Controls.Add(this.lblSpeedTxt);
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.lblHeartRateTxt);
            this.panel1.Controls.Add(this.lblHeartRate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(831, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 513);
            this.panel1.TabIndex = 0;
            // 
            // lblPowerTxt
            // 
            this.lblPowerTxt.AutoSize = true;
            this.lblPowerTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblPowerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerTxt.Location = new System.Drawing.Point(73, 401);
            this.lblPowerTxt.Name = "lblPowerTxt";
            this.lblPowerTxt.Size = new System.Drawing.Size(13, 20);
            this.lblPowerTxt.TabIndex = 29;
            this.lblPowerTxt.Text = ".";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.BackColor = System.Drawing.Color.Transparent;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(51, 377);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(58, 20);
            this.lblPower.TabIndex = 28;
            this.lblPower.Text = "Power";
            // 
            // lblAltitudeTxt
            // 
            this.lblAltitudeTxt.AutoSize = true;
            this.lblAltitudeTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblAltitudeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitudeTxt.Location = new System.Drawing.Point(73, 333);
            this.lblAltitudeTxt.Name = "lblAltitudeTxt";
            this.lblAltitudeTxt.Size = new System.Drawing.Size(13, 20);
            this.lblAltitudeTxt.TabIndex = 27;
            this.lblAltitudeTxt.Text = ".";
            // 
            // Altitude
            // 
            this.Altitude.AutoSize = true;
            this.Altitude.BackColor = System.Drawing.Color.Transparent;
            this.Altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altitude.Location = new System.Drawing.Point(51, 309);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(71, 20);
            this.Altitude.TabIndex = 26;
            this.Altitude.Text = "Altitude";
            // 
            // lblCadenceTxt
            // 
            this.lblCadenceTxt.AutoSize = true;
            this.lblCadenceTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblCadenceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadenceTxt.Location = new System.Drawing.Point(73, 273);
            this.lblCadenceTxt.Name = "lblCadenceTxt";
            this.lblCadenceTxt.Size = new System.Drawing.Size(13, 20);
            this.lblCadenceTxt.TabIndex = 25;
            this.lblCadenceTxt.Text = ".";
            // 
            // lblCadence
            // 
            this.lblCadence.AutoSize = true;
            this.lblCadence.BackColor = System.Drawing.Color.Transparent;
            this.lblCadence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadence.Location = new System.Drawing.Point(51, 249);
            this.lblCadence.Name = "lblCadence";
            this.lblCadence.Size = new System.Drawing.Size(80, 20);
            this.lblCadence.TabIndex = 24;
            this.lblCadence.Text = "Cadence";
            // 
            // lblSpeedTxt
            // 
            this.lblSpeedTxt.AutoSize = true;
            this.lblSpeedTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedTxt.Location = new System.Drawing.Point(73, 208);
            this.lblSpeedTxt.Name = "lblSpeedTxt";
            this.lblSpeedTxt.Size = new System.Drawing.Size(13, 20);
            this.lblSpeedTxt.TabIndex = 23;
            this.lblSpeedTxt.Text = ".";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(51, 184);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(61, 20);
            this.lblSpeed.TabIndex = 22;
            this.lblSpeed.Text = "Speed";
            // 
            // lblHeartRateTxt
            // 
            this.lblHeartRateTxt.AutoSize = true;
            this.lblHeartRateTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblHeartRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeartRateTxt.Location = new System.Drawing.Point(73, 147);
            this.lblHeartRateTxt.Name = "lblHeartRateTxt";
            this.lblHeartRateTxt.Size = new System.Drawing.Size(13, 20);
            this.lblHeartRateTxt.TabIndex = 21;
            this.lblHeartRateTxt.Text = ".";
            // 
            // lblHeartRate
            // 
            this.lblHeartRate.AutoSize = true;
            this.lblHeartRate.BackColor = System.Drawing.Color.Transparent;
            this.lblHeartRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeartRate.Location = new System.Drawing.Point(51, 123);
            this.lblHeartRate.Name = "lblHeartRate";
            this.lblHeartRate.Size = new System.Drawing.Size(98, 20);
            this.lblHeartRate.TabIndex = 20;
            this.lblHeartRate.Text = "Heart Rate";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chkboxPower);
            this.panel2.Controls.Add(this.chkboxAltitude);
            this.panel2.Controls.Add(this.chkboxCadence);
            this.panel2.Controls.Add(this.chkboxSpeed);
            this.panel2.Controls.Add(this.HeartRate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Live Graph";
            // 
            // chkboxPower
            // 
            this.chkboxPower.AutoSize = true;
            this.chkboxPower.BackColor = System.Drawing.Color.Transparent;
            this.chkboxPower.Checked = true;
            this.chkboxPower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxPower.Location = new System.Drawing.Point(582, 56);
            this.chkboxPower.Name = "chkboxPower";
            this.chkboxPower.Size = new System.Drawing.Size(77, 24);
            this.chkboxPower.TabIndex = 14;
            this.chkboxPower.Text = "Power";
            this.chkboxPower.UseVisualStyleBackColor = false;
            this.chkboxPower.CheckedChanged += new System.EventHandler(this.chkboxPower_CheckedChanged);
            // 
            // chkboxAltitude
            // 
            this.chkboxAltitude.AutoSize = true;
            this.chkboxAltitude.BackColor = System.Drawing.Color.Transparent;
            this.chkboxAltitude.Checked = true;
            this.chkboxAltitude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxAltitude.Location = new System.Drawing.Point(486, 56);
            this.chkboxAltitude.Name = "chkboxAltitude";
            this.chkboxAltitude.Size = new System.Drawing.Size(90, 24);
            this.chkboxAltitude.TabIndex = 13;
            this.chkboxAltitude.Text = "Altitude";
            this.chkboxAltitude.UseVisualStyleBackColor = false;
            this.chkboxAltitude.CheckedChanged += new System.EventHandler(this.chkboxAltitude_CheckedChanged);
            // 
            // chkboxCadence
            // 
            this.chkboxCadence.AutoSize = true;
            this.chkboxCadence.BackColor = System.Drawing.Color.Transparent;
            this.chkboxCadence.Checked = true;
            this.chkboxCadence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxCadence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxCadence.Location = new System.Drawing.Point(381, 56);
            this.chkboxCadence.Name = "chkboxCadence";
            this.chkboxCadence.Size = new System.Drawing.Size(99, 24);
            this.chkboxCadence.TabIndex = 12;
            this.chkboxCadence.Text = "Cadence";
            this.chkboxCadence.UseVisualStyleBackColor = false;
            this.chkboxCadence.CheckedChanged += new System.EventHandler(this.chkboxCadence_CheckedChanged);
            // 
            // chkboxSpeed
            // 
            this.chkboxSpeed.AutoSize = true;
            this.chkboxSpeed.BackColor = System.Drawing.Color.Transparent;
            this.chkboxSpeed.Checked = true;
            this.chkboxSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxSpeed.Location = new System.Drawing.Point(295, 56);
            this.chkboxSpeed.Name = "chkboxSpeed";
            this.chkboxSpeed.Size = new System.Drawing.Size(80, 24);
            this.chkboxSpeed.TabIndex = 11;
            this.chkboxSpeed.Text = "Speed";
            this.chkboxSpeed.UseVisualStyleBackColor = false;
            this.chkboxSpeed.CheckedChanged += new System.EventHandler(this.chkboxSpeed_CheckedChanged);
            // 
            // HeartRate
            // 
            this.HeartRate.AutoSize = true;
            this.HeartRate.BackColor = System.Drawing.Color.Transparent;
            this.HeartRate.Checked = true;
            this.HeartRate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HeartRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeartRate.Location = new System.Drawing.Point(172, 56);
            this.HeartRate.Name = "HeartRate";
            this.HeartRate.Size = new System.Drawing.Size(117, 24);
            this.HeartRate.TabIndex = 10;
            this.HeartRate.Text = "Heart Rate";
            this.HeartRate.UseVisualStyleBackColor = false;
            this.HeartRate.CheckedChanged += new System.EventHandler(this.HeartRate_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.zedGraphControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 413);
            this.panel3.TabIndex = 2;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(831, 413);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // frmLiveGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 513);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLiveGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLiveGraph";
            this.Load += new System.EventHandler(this.frmLiveGraph_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPowerTxt;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblAltitudeTxt;
        private System.Windows.Forms.Label Altitude;
        private System.Windows.Forms.Label lblCadenceTxt;
        private System.Windows.Forms.Label lblCadence;
        private System.Windows.Forms.Label lblSpeedTxt;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblHeartRateTxt;
        private System.Windows.Forms.Label lblHeartRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkboxPower;
        private System.Windows.Forms.CheckBox chkboxAltitude;
        private System.Windows.Forms.CheckBox chkboxCadence;
        private System.Windows.Forms.CheckBox chkboxSpeed;
        private System.Windows.Forms.CheckBox HeartRate;
        private System.Windows.Forms.Panel panel3;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}