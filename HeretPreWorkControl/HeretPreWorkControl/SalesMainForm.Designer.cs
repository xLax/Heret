﻿namespace HeretPreWorkControl
{
    partial class SalesMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMainForm));
            this.lblHello = new System.Windows.Forms.Label();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrCheckNewJobsTimer = new System.Windows.Forms.Timer(this.components);
            this.pbMyJobs = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbEnterDeclinedOrder = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAddUser = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrTimerDeclinedJob = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pbAllNotifications = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbMyOrders = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterDeclinedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAllNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(41, 41);
            this.lblHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(235, 33);
            this.lblHello.TabIndex = 10;
            this.lblHello.Text = "שלום <שם עובד>";
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(16, 521);
            this.tbPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(820, 35);
            this.tbPanel.TabIndex = 9;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "עבודות לביצוע";
            // 
            // tmrCheckNewJobsTimer
            // 
            this.tmrCheckNewJobsTimer.Enabled = true;
            this.tmrCheckNewJobsTimer.Interval = 900000;
            this.tmrCheckNewJobsTimer.Tick += new System.EventHandler(this.tmrCheckNewJobsTimer_Tick);
            // 
            // pbMyJobs
            // 
            this.pbMyJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMyJobs.Location = new System.Drawing.Point(176, 102);
            this.pbMyJobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMyJobs.Name = "pbMyJobs";
            this.pbMyJobs.Size = new System.Drawing.Size(136, 121);
            this.pbMyJobs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyJobs.TabIndex = 11;
            this.pbMyJobs.TabStop = false;
            this.pbMyJobs.Click += new System.EventHandler(this.pbMyJobs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(372, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbEnterDeclinedOrder
            // 
            this.pbEnterDeclinedOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEnterDeclinedOrder.Location = new System.Drawing.Point(555, 102);
            this.pbEnterDeclinedOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbEnterDeclinedOrder.Name = "pbEnterDeclinedOrder";
            this.pbEnterDeclinedOrder.Size = new System.Drawing.Size(136, 121);
            this.pbEnterDeclinedOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnterDeclinedOrder.TabIndex = 13;
            this.pbEnterDeclinedOrder.TabStop = false;
            this.pbEnterDeclinedOrder.Click += new System.EventHandler(this.pbEnterDeclinedOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "הזנת הצעה לא";
            // 
            // pbAddUser
            // 
            this.pbAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddUser.Image = global::HeretPreWorkControl.Properties.Resources.Add_User;
            this.pbAddUser.Location = new System.Drawing.Point(89, 325);
            this.pbAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.Size = new System.Drawing.Size(136, 121);
            this.pbAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddUser.TabIndex = 15;
            this.pbAddUser.TabStop = false;
            this.pbAddUser.Click += new System.EventHandler(this.pbAddUser_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::HeretPreWorkControl.Properties.Resources.New_Order;
            this.pictureBox3.Location = new System.Drawing.Point(613, 325);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 449);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "הוסף לקוח";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "צור הזמנה";
            // 
            // tmrTimerDeclinedJob
            // 
            this.tmrTimerDeclinedJob.Enabled = true;
            this.tmrTimerDeclinedJob.Interval = 86400000;
            this.tmrTimerDeclinedJob.Tick += new System.EventHandler(this.tmrTimerDeclinedJob_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "מאושרת";
            // 
            // pbAllNotifications
            // 
            this.pbAllNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAllNotifications.Location = new System.Drawing.Point(720, 26);
            this.pbAllNotifications.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAllNotifications.Name = "pbAllNotifications";
            this.pbAllNotifications.Size = new System.Drawing.Size(83, 62);
            this.pbAllNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAllNotifications.TabIndex = 22;
            this.pbAllNotifications.TabStop = false;
            this.pbAllNotifications.Click += new System.EventHandler(this.pbAllNotifications_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 33);
            this.label6.TabIndex = 24;
            this.label6.Text = "הצג הזמנות שלי";
            // 
            // pbMyOrders
            // 
            this.pbMyOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMyOrders.Image = global::HeretPreWorkControl.Properties.Resources.Overview_Icon;
            this.pbMyOrders.Location = new System.Drawing.Point(352, 325);
            this.pbMyOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMyOrders.Name = "pbMyOrders";
            this.pbMyOrders.Size = new System.Drawing.Size(136, 121);
            this.pbMyOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyOrders.TabIndex = 23;
            this.pbMyOrders.TabStop = false;
            this.pbMyOrders.Click += new System.EventHandler(this.pbMyOrders_Click);
            // 
            // SalesMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(849, 571);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbMyOrders);
            this.Controls.Add(this.pbAllNotifications);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbAddUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbEnterDeclinedOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMyJobs);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SalesMainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesMainForm_FormClosing);
            this.Load += new System.EventHandler(this.SalesMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMyJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterDeclinedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAllNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyOrders)).EndInit();
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
        public System.Windows.Forms.PictureBox pbEnterDeclinedOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAddUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrTimerDeclinedJob;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pbAllNotifications;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbMyOrders;
    }
}