namespace HeretPreWorkControl
{
    partial class AddEmployeeForm
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbAddEmplyee = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbCreateUserTitle = new System.Windows.Forms.PictureBox();
            this.lbDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEmplyee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateUserTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(22, 140);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 20);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "מחלקה :";
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.Location = new System.Drawing.Point(21, 95);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(100, 20);
            this.lblWorkerName.TabIndex = 8;
            this.lblWorkerName.Text = "שם העובד :";
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.BackColor = System.Drawing.SystemColors.Window;
            this.tbWorkerName.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbWorkerName.Location = new System.Drawing.Point(191, 89);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWorkerName.Size = new System.Drawing.Size(234, 31);
            this.tbWorkerName.TabIndex = 7;
            this.tbWorkerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(20, 220);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(405, 29);
            this.tbPanel.TabIndex = 15;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "צור עובד";
            // 
            // pbAddEmplyee
            // 
            this.pbAddEmplyee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddEmplyee.Image = global::HeretPreWorkControl.Properties.Resources.Plus_icon;
            this.pbAddEmplyee.Location = new System.Drawing.Point(388, 180);
            this.pbAddEmplyee.Name = "pbAddEmplyee";
            this.pbAddEmplyee.Size = new System.Drawing.Size(37, 34);
            this.pbAddEmplyee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddEmplyee.TabIndex = 31;
            this.pbAddEmplyee.TabStop = false;
            this.pbAddEmplyee.Click += new System.EventHandler(this.pbAddEmplyee_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbLogo.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbLogo.Location = new System.Drawing.Point(240, 19);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(185, 55);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pbCreateUserTitle
            // 
            this.pbCreateUserTitle.Image = global::HeretPreWorkControl.Properties.Resources.AddEmployeeTitle;
            this.pbCreateUserTitle.Location = new System.Drawing.Point(20, 19);
            this.pbCreateUserTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pbCreateUserTitle.Name = "pbCreateUserTitle";
            this.pbCreateUserTitle.Size = new System.Drawing.Size(184, 55);
            this.pbCreateUserTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCreateUserTitle.TabIndex = 0;
            this.pbCreateUserTitle.TabStop = false;
            // 
            // lbDepartment
            // 
            this.lbDepartment.BackColor = System.Drawing.SystemColors.Window;
            this.lbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbDepartment.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbDepartment.FormattingEnabled = true;
            this.lbDepartment.Location = new System.Drawing.Point(191, 137);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(234, 28);
            this.lbDepartment.TabIndex = 35;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 267);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbAddEmplyee);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.tbWorkerName);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbCreateUserTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddEmployeeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddEmployeeForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEmplyee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateUserTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCreateUserTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAddEmplyee;
        private System.Windows.Forms.ComboBox lbDepartment;
    }
}