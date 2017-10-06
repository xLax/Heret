namespace HeretPreWorkControl
{
    partial class AdminOverviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOverviewForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curr_Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sla_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.lblEnterDeclined = new System.Windows.Forms.Label();
            this.pbEditOrderInfo = new System.Windows.Forms.PictureBox();
            this.lblReminder = new System.Windows.Forms.Label();
            this.pbReminder = new System.Windows.Forms.PictureBox();
            this.lbJobStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pbDeleteOrder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditOrderInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.Current_Situation;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbLogo.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbLogo.Location = new System.Drawing.Point(434, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(273, 70);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 17;
            this.pbLogo.TabStop = false;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::HeretPreWorkControl.Properties.Resources.Refresh_icon;
            this.pbRefresh.Location = new System.Drawing.Point(753, 45);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(54, 37);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 19;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client_Name,
            this.JobStatus,
            this.Curr_Dept,
            this.Creation_date,
            this.Sla_Status,
            this.ProjectDesc});
            this.dataGridView.Location = new System.Drawing.Point(12, 147);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(812, 274);
            this.dataGridView.TabIndex = 20;
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
            // JobStatus
            // 
            this.JobStatus.HeaderText = "סטטוס עבודה";
            this.JobStatus.Name = "JobStatus";
            this.JobStatus.ReadOnly = true;
            this.JobStatus.Width = 120;
            // 
            // Curr_Dept
            // 
            this.Curr_Dept.HeaderText = "מחלקה נוכחית";
            this.Curr_Dept.Name = "Curr_Dept";
            this.Curr_Dept.ReadOnly = true;
            this.Curr_Dept.Width = 90;
            // 
            // Creation_date
            // 
            this.Creation_date.HeaderText = "תאריך יצירת הזמנה";
            this.Creation_date.Name = "Creation_date";
            this.Creation_date.ReadOnly = true;
            // 
            // Sla_Status
            // 
            this.Sla_Status.HeaderText = "סטטוס SLA";
            this.Sla_Status.Name = "Sla_Status";
            this.Sla_Status.ReadOnly = true;
            // 
            // ProjectDesc
            // 
            this.ProjectDesc.HeaderText = "תיאור פרויקט\\ מס\' פריסה\\ מס\' תבנית\\ מס\' הזמנת לקוח";
            this.ProjectDesc.Name = "ProjectDesc";
            this.ProjectDesc.ReadOnly = true;
            this.ProjectDesc.Width = 150;
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(12, 465);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(812, 29);
            this.tbPanel.TabIndex = 21;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnterDeclined
            // 
            this.lblEnterDeclined.AutoSize = true;
            this.lblEnterDeclined.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDeclined.Location = new System.Drawing.Point(12, 432);
            this.lblEnterDeclined.Name = "lblEnterDeclined";
            this.lblEnterDeclined.Size = new System.Drawing.Size(135, 20);
            this.lblEnterDeclined.TabIndex = 25;
            this.lblEnterDeclined.Text = "הצג פרטי הזמנה";
            // 
            // pbEditOrderInfo
            // 
            this.pbEditOrderInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditOrderInfo.Image = global::HeretPreWorkControl.Properties.Resources.Update_Icon;
            this.pbEditOrderInfo.Location = new System.Drawing.Point(143, 427);
            this.pbEditOrderInfo.Name = "pbEditOrderInfo";
            this.pbEditOrderInfo.Size = new System.Drawing.Size(35, 31);
            this.pbEditOrderInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditOrderInfo.TabIndex = 24;
            this.pbEditOrderInfo.TabStop = false;
            this.pbEditOrderInfo.Click += new System.EventHandler(this.pbEditOrderInfo_Click);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.Location = new System.Drawing.Point(694, 432);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(93, 20);
            this.lblReminder.TabIndex = 23;
            this.lblReminder.Text = "תזכר מנהל";
            // 
            // pbReminder
            // 
            this.pbReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReminder.Image = global::HeretPreWorkControl.Properties.Resources.Notify;
            this.pbReminder.Location = new System.Drawing.Point(787, 427);
            this.pbReminder.Name = "pbReminder";
            this.pbReminder.Size = new System.Drawing.Size(35, 31);
            this.pbReminder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReminder.TabIndex = 22;
            this.pbReminder.TabStop = false;
            this.pbReminder.Click += new System.EventHandler(this.pbReminder_Click);
            // 
            // lbJobStatus
            // 
            this.lbJobStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lbJobStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbJobStatus.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbJobStatus.FormattingEnabled = true;
            this.lbJobStatus.Location = new System.Drawing.Point(145, 102);
            this.lbJobStatus.Name = "lbJobStatus";
            this.lbJobStatus.Size = new System.Drawing.Size(163, 28);
            this.lbJobStatus.TabIndex = 32;
            this.lbJobStatus.SelectedIndexChanged += new System.EventHandler(this.lbJobStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "הצג עבודות:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "החל מתאריך:";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtFromDate.Location = new System.Drawing.Point(546, 100);
            this.dtFromDate.MaxDate = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(161, 26);
            this.dtFromDate.TabIndex = 34;
            this.dtFromDate.Value = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtFromDate.ValueChanged += new System.EventHandler(this.dtFromDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "מחק הזמנה";
            // 
            // pbDeleteOrder
            // 
            this.pbDeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeleteOrder.Image = global::HeretPreWorkControl.Properties.Resources.Decline_Icon;
            this.pbDeleteOrder.Location = new System.Drawing.Point(458, 427);
            this.pbDeleteOrder.Name = "pbDeleteOrder";
            this.pbDeleteOrder.Size = new System.Drawing.Size(35, 31);
            this.pbDeleteOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteOrder.TabIndex = 38;
            this.pbDeleteOrder.TabStop = false;
            this.pbDeleteOrder.Click += new System.EventHandler(this.pbDeleteOrder_Click);
            // 
            // AdminOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(835, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbDeleteOrder);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbJobStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnterDeclined);
            this.Controls.Add(this.pbEditOrderInfo);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.pbReminder);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(851, 548);
            this.Name = "AdminOverviewForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.Load += new System.EventHandler(this.AdminOverviewForm_Load);
            this.SizeChanged += new System.EventHandler(this.AdminOverviewForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditOrderInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.Label lblEnterDeclined;
        private System.Windows.Forms.PictureBox pbEditOrderInfo;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.PictureBox pbReminder;
        private System.Windows.Forms.ComboBox lbJobStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curr_Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sla_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbDeleteOrder;
    }
}