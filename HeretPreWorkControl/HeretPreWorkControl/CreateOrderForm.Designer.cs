namespace HeretPreWorkControl
{
    partial class CreateOrderForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbClientNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEnglishClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStatusClient = new System.Windows.Forms.ComboBox();
            this.lbResponsibleEmployee = new System.Windows.Forms.ComboBox();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSalesNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(231, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.AddClientTitle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbClientNumber
            // 
            this.tbClientNumber.BackColor = System.Drawing.SystemColors.Window;
            this.tbClientNumber.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbClientNumber.Location = new System.Drawing.Point(227, 89);
            this.tbClientNumber.Name = "tbClientNumber";
            this.tbClientNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbClientNumber.Size = new System.Drawing.Size(213, 31);
            this.tbClientNumber.TabIndex = 15;
            this.tbClientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbClientNumber.Leave += new System.EventHandler(this.tbClientNumber_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "* מספר לקוח :";
            // 
            // tbClientName
            // 
            this.tbClientName.BackColor = System.Drawing.SystemColors.Window;
            this.tbClientName.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbClientName.Location = new System.Drawing.Point(227, 126);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbClientName.Size = new System.Drawing.Size(213, 31);
            this.tbClientName.TabIndex = 17;
            this.tbClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "* שם לקוח :";
            // 
            // tbEnglishClientName
            // 
            this.tbEnglishClientName.BackColor = System.Drawing.SystemColors.Window;
            this.tbEnglishClientName.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbEnglishClientName.Location = new System.Drawing.Point(227, 165);
            this.tbEnglishClientName.Name = "tbEnglishClientName";
            this.tbEnglishClientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEnglishClientName.Size = new System.Drawing.Size(213, 31);
            this.tbEnglishClientName.TabIndex = 19;
            this.tbEnglishClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "שם לקוח לועזי :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "* סטטוס לקוח :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "* עובד אחראי :";
            // 
            // lbStatusClient
            // 
            this.lbStatusClient.BackColor = System.Drawing.SystemColors.Window;
            this.lbStatusClient.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbStatusClient.FormattingEnabled = true;
            this.lbStatusClient.Location = new System.Drawing.Point(227, 205);
            this.lbStatusClient.Name = "lbStatusClient";
            this.lbStatusClient.Size = new System.Drawing.Size(213, 28);
            this.lbStatusClient.TabIndex = 30;
            // 
            // lbResponsibleEmployee
            // 
            this.lbResponsibleEmployee.BackColor = System.Drawing.SystemColors.Window;
            this.lbResponsibleEmployee.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbResponsibleEmployee.FormattingEnabled = true;
            this.lbResponsibleEmployee.Location = new System.Drawing.Point(227, 242);
            this.lbResponsibleEmployee.Name = "lbResponsibleEmployee";
            this.lbResponsibleEmployee.Size = new System.Drawing.Size(213, 28);
            this.lbResponsibleEmployee.TabIndex = 31;
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(12, 317);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(428, 29);
            this.tbPanel.TabIndex = 34;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InsertButton
            // 
            this.InsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertButton.Image = global::HeretPreWorkControl.Properties.Resources.Plus_icon;
            this.InsertButton.Location = new System.Drawing.Point(402, 276);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(38, 35);
            this.InsertButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InsertButton.TabIndex = 32;
            this.InsertButton.TabStop = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "צור\\ עדכן לקוח";
            // 
            // lblSalesNote
            // 
            this.lblSalesNote.AutoSize = true;
            this.lblSalesNote.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesNote.ForeColor = System.Drawing.Color.Red;
            this.lblSalesNote.Location = new System.Drawing.Point(12, 287);
            this.lblSalesNote.Name = "lblSalesNote";
            this.lblSalesNote.Size = new System.Drawing.Size(85, 16);
            this.lblSalesNote.TabIndex = 36;
            this.lblSalesNote.Text = "* שדות חובה";
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(452, 350);
            this.Controls.Add(this.lblSalesNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.lbResponsibleEmployee);
            this.Controls.Add(this.lbStatusClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEnglishClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbClientNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CreateOrderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbClientNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEnglishClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lbStatusClient;
        private System.Windows.Forms.ComboBox lbResponsibleEmployee;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.PictureBox InsertButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSalesNote;
    }
}