namespace HeretPreWorkControl
{
    partial class TopUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopUserForm));
            this.lblHello = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreateUser = new System.Windows.Forms.Label();
            this.lblSpecialApprove = new System.Windows.Forms.Label();
            this.lblUnapprovedJobs = new System.Windows.Forms.Label();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.btnGetClientsFromExcel = new System.Windows.Forms.Button();
            this.pbStatistics = new System.Windows.Forms.PictureBox();
            this.pbUnapprovedJobs = new System.Windows.Forms.PictureBox();
            this.pbSpecialApprove = new System.Windows.Forms.PictureBox();
            this.pbAddUser = new System.Windows.Forms.PictureBox();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.pbHeret = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnapprovedJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpecialApprove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeret)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(99, 60);
            this.lblHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHello.Size = new System.Drawing.Size(235, 33);
            this.lblHello.TabIndex = 11;
            this.lblHello.Text = "שלום <שם עובד>";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(193, 260);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(211, 33);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "הצג תמונת מצב";
            // 
            // lblCreateUser
            // 
            this.lblCreateUser.AutoSize = true;
            this.lblCreateUser.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateUser.Location = new System.Drawing.Point(539, 260);
            this.lblCreateUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateUser.Name = "lblCreateUser";
            this.lblCreateUser.Size = new System.Drawing.Size(168, 33);
            this.lblCreateUser.TabIndex = 19;
            this.lblCreateUser.Text = "צור משתמש";
            // 
            // lblSpecialApprove
            // 
            this.lblSpecialApprove.AutoSize = true;
            this.lblSpecialApprove.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialApprove.Location = new System.Drawing.Point(16, 449);
            this.lblSpecialApprove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialApprove.Name = "lblSpecialApprove";
            this.lblSpecialApprove.Size = new System.Drawing.Size(272, 33);
            this.lblSpecialApprove.TabIndex = 21;
            this.lblSpecialApprove.Text = "אישור קידום עבודות";
            // 
            // lblUnapprovedJobs
            // 
            this.lblUnapprovedJobs.AutoSize = true;
            this.lblUnapprovedJobs.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnapprovedJobs.Location = new System.Drawing.Point(356, 449);
            this.lblUnapprovedJobs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnapprovedJobs.Name = "lblUnapprovedJobs";
            this.lblUnapprovedJobs.Size = new System.Drawing.Size(180, 33);
            this.lblUnapprovedJobs.TabIndex = 23;
            this.lblUnapprovedJobs.Text = "הצעות שנדחו";
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.Location = new System.Drawing.Point(623, 449);
            this.lblStatistics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(187, 33);
            this.lblStatistics.TabIndex = 25;
            this.lblStatistics.Text = "הצג דוח מנהל";
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(16, 495);
            this.tbPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(828, 35);
            this.tbPanel.TabIndex = 26;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetClientsFromExcel
            // 
            this.btnGetClientsFromExcel.Location = new System.Drawing.Point(0, 0);
            this.btnGetClientsFromExcel.Name = "btnGetClientsFromExcel";
            this.btnGetClientsFromExcel.Size = new System.Drawing.Size(75, 23);
            this.btnGetClientsFromExcel.TabIndex = 0;
            // 
            // pbStatistics
            // 
            this.pbStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStatistics.Image = global::HeretPreWorkControl.Properties.Resources.Statistics_Icon;
            this.pbStatistics.Location = new System.Drawing.Point(653, 325);
            this.pbStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.pbStatistics.Name = "pbStatistics";
            this.pbStatistics.Size = new System.Drawing.Size(136, 121);
            this.pbStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatistics.TabIndex = 24;
            this.pbStatistics.TabStop = false;
            // 
            // pbUnapprovedJobs
            // 
            this.pbUnapprovedJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUnapprovedJobs.Image = global::HeretPreWorkControl.Properties.Resources.Unapproved_Jobs;
            this.pbUnapprovedJobs.Location = new System.Drawing.Point(381, 325);
            this.pbUnapprovedJobs.Margin = new System.Windows.Forms.Padding(4);
            this.pbUnapprovedJobs.Name = "pbUnapprovedJobs";
            this.pbUnapprovedJobs.Size = new System.Drawing.Size(136, 121);
            this.pbUnapprovedJobs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUnapprovedJobs.TabIndex = 22;
            this.pbUnapprovedJobs.TabStop = false;
            // 
            // pbSpecialApprove
            // 
            this.pbSpecialApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSpecialApprove.Image = global::HeretPreWorkControl.Properties.Resources.Special_Approval_Icon;
            this.pbSpecialApprove.Location = new System.Drawing.Point(89, 325);
            this.pbSpecialApprove.Margin = new System.Windows.Forms.Padding(4);
            this.pbSpecialApprove.Name = "pbSpecialApprove";
            this.pbSpecialApprove.Size = new System.Drawing.Size(136, 121);
            this.pbSpecialApprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpecialApprove.TabIndex = 20;
            this.pbSpecialApprove.TabStop = false;
            // 
            // pbAddUser
            // 
            this.pbAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddUser.Image = global::HeretPreWorkControl.Properties.Resources.Add_User;
            this.pbAddUser.Location = new System.Drawing.Point(557, 135);
            this.pbAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.Size = new System.Drawing.Size(136, 121);
            this.pbAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddUser.TabIndex = 18;
            this.pbAddUser.TabStop = false;
            this.pbAddUser.Click += new System.EventHandler(this.pbAddUser_Click);
            // 
            // pbStatus
            // 
            this.pbStatus.Image = global::HeretPreWorkControl.Properties.Resources.Overview_Icon;
            this.pbStatus.Location = new System.Drawing.Point(236, 135);
            this.pbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(136, 121);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatus.TabIndex = 12;
            this.pbStatus.TabStop = false;
            // 
            // pbHeret
            // 
            this.pbHeret.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbHeret.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbHeret.Location = new System.Drawing.Point(457, 36);
            this.pbHeret.Margin = new System.Windows.Forms.Padding(4);
            this.pbHeret.Name = "pbHeret";
            this.pbHeret.Size = new System.Drawing.Size(307, 80);
            this.pbHeret.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeret.TabIndex = 1;
            this.pbHeret.TabStop = false;
            // 
            // TopUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 545);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.lblStatistics);
            this.Controls.Add(this.pbStatistics);
            this.Controls.Add(this.lblUnapprovedJobs);
            this.Controls.Add(this.pbUnapprovedJobs);
            this.Controls.Add(this.lblSpecialApprove);
            this.Controls.Add(this.pbSpecialApprove);
            this.Controls.Add(this.lblCreateUser);
            this.Controls.Add(this.pbAddUser);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pbHeret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TopUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopUserForm_FormClosing);
            this.Load += new System.EventHandler(this.TopUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnapprovedJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpecialApprove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeret;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreateUser;
        private System.Windows.Forms.PictureBox pbAddUser;
        private System.Windows.Forms.Label lblSpecialApprove;
        private System.Windows.Forms.PictureBox pbSpecialApprove;
        private System.Windows.Forms.Label lblUnapprovedJobs;
        private System.Windows.Forms.PictureBox pbUnapprovedJobs;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.PictureBox pbStatistics;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.Button btnGetClientsFromExcel;
    }
}