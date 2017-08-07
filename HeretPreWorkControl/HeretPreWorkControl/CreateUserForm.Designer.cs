namespace HeretPreWorkControl
{
    partial class CreateUserForm
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.lbUserType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbCreateUserTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InsertButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateUserTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(42, 140);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(115, 20);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "שם משתמש :";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(181, 135);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUserName.Size = new System.Drawing.Size(234, 31);
            this.tbUserName.TabIndex = 9;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.Location = new System.Drawing.Point(42, 95);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(100, 20);
            this.lblWorkerName.TabIndex = 8;
            this.lblWorkerName.Text = "שם העובד :";
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.BackColor = System.Drawing.SystemColors.Window;
            this.tbWorkerName.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbWorkerName.Location = new System.Drawing.Point(181, 90);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWorkerName.Size = new System.Drawing.Size(234, 31);
            this.tbWorkerName.TabIndex = 7;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(42, 230);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(114, 20);
            this.lblUserType.TabIndex = 14;
            this.lblUserType.Text = "סוג משתמש :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(42, 185);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 20);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "סיסמא :";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPassword.Location = new System.Drawing.Point(181, 180);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPassword.Size = new System.Drawing.Size(234, 31);
            this.tbPassword.TabIndex = 11;
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(16, 325);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(413, 29);
            this.tbPanel.TabIndex = 15;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbUserType
            // 
            this.lbUserType.BackColor = System.Drawing.SystemColors.Window;
            this.lbUserType.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbUserType.FormattingEnabled = true;
            this.lbUserType.Location = new System.Drawing.Point(181, 225);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(234, 28);
            this.lbUserType.TabIndex = 30;
            this.lbUserType.SelectedIndexChanged += new System.EventHandler(this.lbUserType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "צור משתמש";
            // 
            // InsertButton
            // 
            this.InsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertButton.Image = global::HeretPreWorkControl.Properties.Resources.Plus_icon;
            this.InsertButton.Location = new System.Drawing.Point(369, 269);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(45, 40);
            this.InsertButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InsertButton.TabIndex = 31;
            this.InsertButton.TabStop = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbLogo.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbLogo.Location = new System.Drawing.Point(244, 19);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(185, 55);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pbCreateUserTitle
            // 
            this.pbCreateUserTitle.Image = global::HeretPreWorkControl.Properties.Resources.CreateUserTitle;
            this.pbCreateUserTitle.Location = new System.Drawing.Point(25, 19);
            this.pbCreateUserTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pbCreateUserTitle.Name = "pbCreateUserTitle";
            this.pbCreateUserTitle.Size = new System.Drawing.Size(192, 55);
            this.pbCreateUserTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCreateUserTitle.TabIndex = 0;
            this.pbCreateUserTitle.TabStop = false;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.lbUserType);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.tbWorkerName);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbCreateUserTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "מסך יצירת משתמש";
            ((System.ComponentModel.ISupportInitialize)(this.InsertButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateUserTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCreateUserTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.ComboBox lbUserType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox InsertButton;
    }
}