namespace CycleAnalysisSoftwareB
{
    partial class frmDataSelectionGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataSelectionGraph));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSG = new System.Windows.Forms.DataGridView();
            this.zedGraphControlDSG = new ZedGraph.ZedGraphControl();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxHR = new System.Windows.Forms.Label();
            this.lblMinHR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMinSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMinCadence = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMaxcadence = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMinAltitude = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMaxAltitude = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMinPower = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaxPower = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSG)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graph From Selected Data";
            // 
            // dgvDSG
            // 
            this.dgvDSG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSG.Location = new System.Drawing.Point(25, 47);
            this.dgvDSG.Name = "dgvDSG";
            this.dgvDSG.Size = new System.Drawing.Size(468, 371);
            this.dgvDSG.TabIndex = 1;
            this.dgvDSG.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSG_CellMouseUp);
            // 
            // zedGraphControlDSG
            // 
            this.zedGraphControlDSG.Location = new System.Drawing.Point(539, 47);
            this.zedGraphControlDSG.Name = "zedGraphControlDSG";
            this.zedGraphControlDSG.ScrollGrace = 0D;
            this.zedGraphControlDSG.ScrollMaxX = 0D;
            this.zedGraphControlDSG.ScrollMaxY = 0D;
            this.zedGraphControlDSG.ScrollMaxY2 = 0D;
            this.zedGraphControlDSG.ScrollMinX = 0D;
            this.zedGraphControlDSG.ScrollMinY = 0D;
            this.zedGraphControlDSG.ScrollMinY2 = 0D;
            this.zedGraphControlDSG.Size = new System.Drawing.Size(563, 371);
            this.zedGraphControlDSG.TabIndex = 2;
            this.zedGraphControlDSG.UseExtendedPrintDialog = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max HR";
            // 
            // lblMaxHR
            // 
            this.lblMaxHR.AutoSize = true;
            this.lblMaxHR.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHR.Location = new System.Drawing.Point(74, 433);
            this.lblMaxHR.Name = "lblMaxHR";
            this.lblMaxHR.Size = new System.Drawing.Size(11, 13);
            this.lblMaxHR.TabIndex = 4;
            this.lblMaxHR.Text = ".";
            // 
            // lblMinHR
            // 
            this.lblMinHR.AutoSize = true;
            this.lblMinHR.BackColor = System.Drawing.Color.Transparent;
            this.lblMinHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinHR.Location = new System.Drawing.Point(74, 459);
            this.lblMinHR.Name = "lblMinHR";
            this.lblMinHR.Size = new System.Drawing.Size(11, 13);
            this.lblMinHR.TabIndex = 6;
            this.lblMinHR.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min HR";
            // 
            // lblMinSpeed
            // 
            this.lblMinSpeed.AutoSize = true;
            this.lblMinSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblMinSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinSpeed.Location = new System.Drawing.Point(186, 459);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(11, 13);
            this.lblMinSpeed.TabIndex = 10;
            this.lblMinSpeed.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(119, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min Speed";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSpeed.Location = new System.Drawing.Point(186, 433);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(11, 13);
            this.lblMaxSpeed.TabIndex = 8;
            this.lblMaxSpeed.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(119, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Max Speed";
            // 
            // lblMinCadence
            // 
            this.lblMinCadence.AutoSize = true;
            this.lblMinCadence.BackColor = System.Drawing.Color.Transparent;
            this.lblMinCadence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinCadence.Location = new System.Drawing.Point(291, 459);
            this.lblMinCadence.Name = "lblMinCadence";
            this.lblMinCadence.Size = new System.Drawing.Size(11, 13);
            this.lblMinCadence.TabIndex = 14;
            this.lblMinCadence.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(215, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Min Cadence";
            // 
            // lblMaxcadence
            // 
            this.lblMaxcadence.AutoSize = true;
            this.lblMaxcadence.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxcadence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxcadence.Location = new System.Drawing.Point(291, 433);
            this.lblMaxcadence.Name = "lblMaxcadence";
            this.lblMaxcadence.Size = new System.Drawing.Size(11, 13);
            this.lblMaxcadence.TabIndex = 12;
            this.lblMaxcadence.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(212, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Max Cadence";
            // 
            // lblMinAltitude
            // 
            this.lblMinAltitude.AutoSize = true;
            this.lblMinAltitude.BackColor = System.Drawing.Color.Transparent;
            this.lblMinAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAltitude.Location = new System.Drawing.Point(389, 459);
            this.lblMinAltitude.Name = "lblMinAltitude";
            this.lblMinAltitude.Size = new System.Drawing.Size(11, 13);
            this.lblMinAltitude.TabIndex = 18;
            this.lblMinAltitude.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(318, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Min Altitude";
            // 
            // lblMaxAltitude
            // 
            this.lblMaxAltitude.AutoSize = true;
            this.lblMaxAltitude.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAltitude.Location = new System.Drawing.Point(389, 433);
            this.lblMaxAltitude.Name = "lblMaxAltitude";
            this.lblMaxAltitude.Size = new System.Drawing.Size(11, 13);
            this.lblMaxAltitude.TabIndex = 16;
            this.lblMaxAltitude.Text = ".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(318, 433);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Max Altitude";
            // 
            // lblMinPower
            // 
            this.lblMinPower.AutoSize = true;
            this.lblMinPower.BackColor = System.Drawing.Color.Transparent;
            this.lblMinPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPower.Location = new System.Drawing.Point(480, 459);
            this.lblMinPower.Name = "lblMinPower";
            this.lblMinPower.Size = new System.Drawing.Size(11, 13);
            this.lblMinPower.TabIndex = 22;
            this.lblMinPower.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(414, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Min Power";
            // 
            // lblMaxPower
            // 
            this.lblMaxPower.AutoSize = true;
            this.lblMaxPower.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPower.Location = new System.Drawing.Point(482, 433);
            this.lblMaxPower.Name = "lblMaxPower";
            this.lblMaxPower.Size = new System.Drawing.Size(11, 13);
            this.lblMaxPower.TabIndex = 20;
            this.lblMaxPower.Text = ",";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(414, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Max Power";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMinHR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblMinSpeed);
            this.panel1.Controls.Add(this.lblMaxHR);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblMinCadence);
            this.panel1.Controls.Add(this.lblMaxSpeed);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblMaxPower);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblMaxcadence);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblMinAltitude);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblMinPower);
            this.panel1.Controls.Add(this.lblMaxAltitude);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.zedGraphControlDSG);
            this.panel1.Controls.Add(this.dgvDSG);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 489);
            this.panel1.TabIndex = 23;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1083, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 38);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 23;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_MouseClick);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // frmDataSelectionGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1155, 527);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDataSelectionGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDataSelectionGraph";
            this.Load += new System.EventHandler(this.frmDataSelectionGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSG;
        private ZedGraph.ZedGraphControl zedGraphControlDSG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxHR;
        private System.Windows.Forms.Label lblMinHR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMinSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMinCadence;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMaxcadence;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMinAltitude;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMaxAltitude;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMinPower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxPower;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}