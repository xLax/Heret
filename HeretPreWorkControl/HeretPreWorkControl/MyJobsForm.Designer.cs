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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExecute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetDeclinedAndInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(16, 509);
            this.tbPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(972, 35);
            this.tbPanel.TabIndex = 9;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client_Name,
            this.No_Files,
            this.Project_Desc,
            this.Sla,
            this.Action_Type});
            this.dataGridView.Location = new System.Drawing.Point(16, 121);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(973, 284);
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
            this.pbRefresh.Location = new System.Drawing.Point(917, 55);
            this.pbRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(72, 46);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 11;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.MyJobsTitle;
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(495, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbExecute
            // 
            this.pbExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExecute.Image = global::HeretPreWorkControl.Properties.Resources.Go_icon;
            this.pbExecute.Location = new System.Drawing.Point(943, 463);
            this.pbExecute.Margin = new System.Windows.Forms.Padding(4);
            this.pbExecute.Name = "pbExecute";
            this.pbExecute.Size = new System.Drawing.Size(47, 38);
            this.pbExecute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExecute.TabIndex = 13;
            this.pbExecute.TabStop = false;
            this.pbExecute.Click += new System.EventHandler(this.pbExecute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(891, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "בצע";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEnterDeclined
            // 
            this.lblEnterDeclined.AutoSize = true;
            this.lblEnterDeclined.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDeclined.Location = new System.Drawing.Point(11, 469);
            this.lblEnterDeclined.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterDeclined.Name = "lblEnterDeclined";
            this.lblEnterDeclined.Size = new System.Drawing.Size(110, 27);
            this.lblEnterDeclined.TabIndex = 16;
            this.lblEnterDeclined.Text = "הזן דחייה";
            this.lblEnterDeclined.Click += new System.EventHandler(this.lblEnterDeclined_Click);
            // 
            // pbSetDeclinedAndInsert
            // 
            this.pbSetDeclinedAndInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSetDeclinedAndInsert.Image = global::HeretPreWorkControl.Properties.Resources.Decline_Icon;
            this.pbSetDeclinedAndInsert.Location = new System.Drawing.Point(125, 463);
            this.pbSetDeclinedAndInsert.Margin = new System.Windows.Forms.Padding(4);
            this.pbSetDeclinedAndInsert.Name = "pbSetDeclinedAndInsert";
            this.pbSetDeclinedAndInsert.Size = new System.Drawing.Size(47, 38);
            this.pbSetDeclinedAndInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSetDeclinedAndInsert.TabIndex = 15;
            this.pbSetDeclinedAndInsert.TabStop = false;
            this.pbSetDeclinedAndInsert.Click += new System.EventHandler(this.pbSetDeclinedAndInsert_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(536, 418);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(163, 27);
            this.lblEmployee.TabIndex = 18;
            this.lblEmployee.Text = "מנה עובד מבצע";
            this.lblEmployee.Visible = false;
            // 
            // pbSetEmployee
            // 
            this.pbSetEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSetEmployee.Image = global::HeretPreWorkControl.Properties.Resources.Add_User;
            this.pbSetEmployee.Location = new System.Drawing.Point(705, 412);
            this.pbSetEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.pbSetEmployee.Name = "pbSetEmployee";
            this.pbSetEmployee.Size = new System.Drawing.Size(47, 38);
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
            this.lbEmployees.Location = new System.Drawing.Point(276, 415);
            this.lbEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(251, 33);
            this.lbEmployees.TabIndex = 30;
            this.lbEmployees.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::HeretPreWorkControl.Properties.Resources.Update_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(574, 463);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 469);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 32;
            this.label1.Text = "עדכן הזמנה";
            // 
            // MyJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1005, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}