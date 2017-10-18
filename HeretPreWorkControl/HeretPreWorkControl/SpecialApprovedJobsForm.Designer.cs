namespace HeretPreWorkControl
{
    partial class SpecialApprovedJobsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialApprovedJobsForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agent_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.lblEnterDeclined = new System.Windows.Forms.Label();
            this.pbDecline = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbApprove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApprove)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client_Name,
            this.ContactDate,
            this.No_Files,
            this.Project_Desc,
            this.Amount,
            this.Agent_Name});
            this.dataGridView.Location = new System.Drawing.Point(16, 133);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(730, 231);
            this.dataGridView.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "מס\"ד עבודה";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // Client_Name
            // 
            this.Client_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client_Name.HeaderText = "שם לקוח";
            this.Client_Name.Name = "Client_Name";
            this.Client_Name.ReadOnly = true;
            // 
            // ContactDate
            // 
            this.ContactDate.HeaderText = "תאריך יצירת קשר";
            this.ContactDate.Name = "ContactDate";
            this.ContactDate.ReadOnly = true;
            // 
            // No_Files
            // 
            this.No_Files.HeaderText = "מספר קבצים";
            this.No_Files.Name = "No_Files";
            this.No_Files.ReadOnly = true;
            this.No_Files.Width = 60;
            // 
            // Project_Desc
            // 
            this.Project_Desc.HeaderText = "מס\' תבנית/ מס\' פריסה/ תיאור פרויקט";
            this.Project_Desc.Name = "Project_Desc";
            this.Project_Desc.ReadOnly = true;
            this.Project_Desc.Width = 150;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "כמות";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Agent_Name
            // 
            this.Agent_Name.HeaderText = "סוכן אחראי";
            this.Agent_Name.Name = "Agent_Name";
            this.Agent_Name.ReadOnly = true;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::HeretPreWorkControl.Properties.Resources.Refresh_icon;
            this.pbRefresh.Location = new System.Drawing.Point(917, 55);
            this.pbRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(54, 37);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 13;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.ApprovedJobsTitle;
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(495, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(16, 480);
            this.tbPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(730, 29);
            this.tbPanel.TabIndex = 17;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnterDeclined
            // 
            this.lblEnterDeclined.AutoSize = true;
            this.lblEnterDeclined.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDeclined.Location = new System.Drawing.Point(10, 358);
            this.lblEnterDeclined.Name = "lblEnterDeclined";
            this.lblEnterDeclined.Size = new System.Drawing.Size(95, 20);
            this.lblEnterDeclined.TabIndex = 21;
            this.lblEnterDeclined.Text = "דחה בקשה";
            // 
            // pbDecline
            // 
            this.pbDecline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDecline.Image = global::HeretPreWorkControl.Properties.Resources.Decline_Icon;
            this.pbDecline.Location = new System.Drawing.Point(140, 434);
            this.pbDecline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDecline.Name = "pbDecline";
            this.pbDecline.Size = new System.Drawing.Size(35, 31);
            this.pbDecline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDecline.TabIndex = 20;
            this.pbDecline.TabStop = false;
            this.pbDecline.Click += new System.EventHandler(this.pbDecline_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "אשר העברה לקד\"ס";
            // 
            // pbApprove
            // 
            this.pbApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbApprove.Image = global::HeretPreWorkControl.Properties.Resources.Go_icon;
            this.pbApprove.Location = new System.Drawing.Point(943, 434);
            this.pbApprove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbApprove.Name = "pbApprove";
            this.pbApprove.Size = new System.Drawing.Size(35, 31);
            this.pbApprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApprove.TabIndex = 18;
            this.pbApprove.TabStop = false;
            this.pbApprove.Click += new System.EventHandler(this.pbApprove_Click);
            // 
            // SpecialApprovedJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(754, 428);
            this.Controls.Add(this.lblEnterDeclined);
            this.Controls.Add(this.pbDecline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbApprove);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pbRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SpecialApprovedJobsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApprove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agent_Name;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.Label lblEnterDeclined;
        private System.Windows.Forms.PictureBox pbDecline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbApprove;
    }
}