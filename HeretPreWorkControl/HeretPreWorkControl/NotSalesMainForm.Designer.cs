namespace HeretPreWorkControl
{
    partial class NotSalesMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotSalesMainForm));
            this.lblHello = new System.Windows.Forms.Label();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMyJobs = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrCheckNewJobsTimer = new System.Windows.Forms.Timer(this.components);
            this.pbAllNotifications = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAllNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(13, 36);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(184, 27);
            this.lblHello.TabIndex = 10;
            this.lblHello.Text = "שלום <שם עובד>";
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(18, 237);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(482, 29);
            this.tbPanel.TabIndex = 9;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "עבודות לביצוע";
            // 
            // pbMyJobs
            // 
            this.pbMyJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMyJobs.Location = new System.Drawing.Point(205, 83);
            this.pbMyJobs.Name = "pbMyJobs";
            this.pbMyJobs.Size = new System.Drawing.Size(102, 98);
            this.pbMyJobs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyJobs.TabIndex = 11;
            this.pbMyJobs.TabStop = false;
            this.pbMyJobs.Click += new System.EventHandler(this.pbMyJobs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(270, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrCheckNewJobsTimer
            // 
            this.tmrCheckNewJobsTimer.Enabled = true;
            this.tmrCheckNewJobsTimer.Interval = 900000;
            this.tmrCheckNewJobsTimer.Tick += new System.EventHandler(this.tmrCheckNewJobsTimer_Tick);
            // 
            // pbAllNotifications
            // 
            this.pbAllNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAllNotifications.Location = new System.Drawing.Point(396, 83);
            this.pbAllNotifications.Name = "pbAllNotifications";
            this.pbAllNotifications.Size = new System.Drawing.Size(62, 50);
            this.pbAllNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAllNotifications.TabIndex = 23;
            this.pbAllNotifications.TabStop = false;
            this.pbAllNotifications.Click += new System.EventHandler(this.pbAllNotifications_Click);
            // 
            // NotSalesMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(517, 278);
            this.Controls.Add(this.pbAllNotifications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMyJobs);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NotSalesMainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotSalesMainForm_FormClosing);
            this.Load += new System.EventHandler(this.NotSalesMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMyJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAllNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox tbPanel;
        public System.Windows.Forms.PictureBox pbMyJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrCheckNewJobsTimer;
        public System.Windows.Forms.PictureBox pbAllNotifications;
    }
}

