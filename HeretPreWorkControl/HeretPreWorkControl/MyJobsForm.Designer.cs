namespace HeretPreWorkControl
{
    partial class MyJobsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyJobsForm));
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbExecute = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEnterDeclined = new System.Windows.Forms.Label();
            this.pbSetDeclinedAndInsert = new System.Windows.Forms.PictureBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pbSetEmployee = new System.Windows.Forms.PictureBox();
            this.lbEmployees = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExecute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetDeclinedAndInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(12, 372);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(730, 29);
            this.tbPanel.TabIndex = 9;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client_Name,
            this.No_Files,
            this.Project_Desc,
            this.Sla,
            this.Action_Type});
            this.dataGridView.Location = new System.Drawing.Point(12, 98);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(730, 231);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
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
            this.Project_Desc.Width = 132;
            // 
            // Sla
            // 
            this.Sla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sla.HeaderText = "סטטוס SLA";
            this.Sla.Name = "Sla";
            this.Sla.ReadOnly = true;
            // 
            // Action_Type
            // 
            this.Action_Type.HeaderText = "סוג פעולה";
            this.Action_Type.Name = "Action_Type";
            this.Action_Type.ReadOnly = true;
            this.Action_Type.Width = 200;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::HeretPreWorkControl.Properties.Resources.Refresh_icon;
            this.pbRefresh.Location = new System.Drawing.Point(688, 45);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(54, 37);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 11;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.MyJobsTitle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(371, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbExecute
            // 
            this.pbExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExecute.Image = global::HeretPreWorkControl.Properties.Resources.Go_icon;
            this.pbExecute.Location = new System.Drawing.Point(707, 335);
            this.pbExecute.Name = "pbExecute";
            this.pbExecute.Size = new System.Drawing.Size(35, 31);
            this.pbExecute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExecute.TabIndex = 13;
            this.pbExecute.TabStop = false;
            this.pbExecute.Click += new System.EventHandler(this.pbExecute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "בצע";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEnterDeclined
            // 
            this.lblEnterDeclined.AutoSize = true;
            this.lblEnterDeclined.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDeclined.Location = new System.Drawing.Point(8, 340);
            this.lblEnterDeclined.Name = "lblEnterDeclined";
            this.lblEnterDeclined.Size = new System.Drawing.Size(86, 20);
            this.lblEnterDeclined.TabIndex = 16;
            this.lblEnterDeclined.Text = "הזן דחייה";
            this.lblEnterDeclined.Click += new System.EventHandler(this.lblEnterDeclined_Click);
            // 
            // pbSetDeclinedAndInsert
            // 
            this.pbSetDeclinedAndInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSetDeclinedAndInsert.Image = global::HeretPreWorkControl.Properties.Resources.Decline_Icon;
            this.pbSetDeclinedAndInsert.Location = new System.Drawing.Point(94, 335);
            this.pbSetDeclinedAndInsert.Name = "pbSetDeclinedAndInsert";
            this.pbSetDeclinedAndInsert.Size = new System.Drawing.Size(35, 31);
            this.pbSetDeclinedAndInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSetDeclinedAndInsert.TabIndex = 15;
            this.pbSetDeclinedAndInsert.TabStop = false;
            this.pbSetDeclinedAndInsert.Click += new System.EventHandler(this.pbSetDeclinedAndInsert_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(402, 340);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(125, 20);
            this.lblEmployee.TabIndex = 18;
            this.lblEmployee.Text = "מנה עובד מבצע";
            this.lblEmployee.Visible = false;
            // 
            // pbSetEmployee
            // 
            this.pbSetEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSetEmployee.Image = global::HeretPreWorkControl.Properties.Resources.Add_User;
            this.pbSetEmployee.Location = new System.Drawing.Point(529, 335);
            this.pbSetEmployee.Name = "pbSetEmployee";
            this.pbSetEmployee.Size = new System.Drawing.Size(35, 31);
            this.pbSetEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSetEmployee.TabIndex = 17;
            this.pbSetEmployee.TabStop = false;
            this.pbSetEmployee.Visible = false;
            this.pbSetEmployee.Click += new System.EventHandler(this.pbSetEmployee_Click);
            // 
            // lbEmployees
            // 
            this.lbEmployees.BackColor = System.Drawing.SystemColors.Window;
            this.lbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbEmployees.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.Location = new System.Drawing.Point(207, 337);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(189, 28);
            this.lbEmployees.TabIndex = 30;
            this.lbEmployees.Visible = false;
            // 
            // MyJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(754, 424);
            this.Controls.Add(this.lbEmployees);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.pbSetEmployee);
            this.Controls.Add(this.lblEnterDeclined);
            this.Controls.Add(this.pbSetDeclinedAndInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbExecute);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyJobsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.Load += new System.EventHandler(this.MyJobsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExecute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetDeclinedAndInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pbExecute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnterDeclined;
        private System.Windows.Forms.PictureBox pbSetDeclinedAndInsert;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PictureBox pbSetEmployee;
        private System.Windows.Forms.ComboBox lbEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action_Type;
    }
}