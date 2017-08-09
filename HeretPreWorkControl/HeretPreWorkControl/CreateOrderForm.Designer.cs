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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrderForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtContactDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSalesAgent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilesNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPriseTempDesc = new System.Windows.Forms.ComboBox();
            this.tbPrisaTempDesc = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.PictureBox();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.cbMoveToManager = new System.Windows.Forms.CheckBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(395, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.CreateOrderTitle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtContactDate
            // 
            this.dtContactDate.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtContactDate.Location = new System.Drawing.Point(352, 220);
            this.dtContactDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtContactDate.MaxDate = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtContactDate.Name = "dtContactDate";
            this.dtContactDate.Size = new System.Drawing.Size(289, 31);
            this.dtContactDate.TabIndex = 28;
            this.dtContactDate.Value = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "תאריך יצירת קשר :";
            // 
            // tbClientNumber
            // 
            this.tbClientNumber.BackColor = System.Drawing.SystemColors.Window;
            this.tbClientNumber.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbClientNumber.Location = new System.Drawing.Point(205, 156);
            this.tbClientNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbClientNumber.Name = "tbClientNumber";
            this.tbClientNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbClientNumber.Size = new System.Drawing.Size(133, 37);
            this.tbClientNumber.TabIndex = 30;
            this.tbClientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbClientNumber.Leave += new System.EventHandler(this.tbClientNumber_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "מספר לקוח :";
            // 
            // tbSalesAgent
            // 
            this.tbSalesAgent.BackColor = System.Drawing.SystemColors.Info;
            this.tbSalesAgent.Enabled = false;
            this.tbSalesAgent.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbSalesAgent.Location = new System.Drawing.Point(352, 96);
            this.tbSalesAgent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSalesAgent.Name = "tbSalesAgent";
            this.tbSalesAgent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSalesAgent.Size = new System.Drawing.Size(289, 37);
            this.tbSalesAgent.TabIndex = 33;
            this.tbSalesAgent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "סוכן מכירות אחראי :";
            // 
            // tbFilesNo
            // 
            this.tbFilesNo.BackColor = System.Drawing.SystemColors.Info;
            this.tbFilesNo.Enabled = false;
            this.tbFilesNo.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbFilesNo.Location = new System.Drawing.Point(352, 263);
            this.tbFilesNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFilesNo.Name = "tbFilesNo";
            this.tbFilesNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFilesNo.Size = new System.Drawing.Size(289, 37);
            this.tbFilesNo.TabIndex = 35;
            this.tbFilesNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "מספר קבצים :";
            // 
            // lbPriseTempDesc
            // 
            this.lbPriseTempDesc.BackColor = System.Drawing.SystemColors.Info;
            this.lbPriseTempDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbPriseTempDesc.Enabled = false;
            this.lbPriseTempDesc.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbPriseTempDesc.FormattingEnabled = true;
            this.lbPriseTempDesc.Location = new System.Drawing.Point(41, 316);
            this.lbPriseTempDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPriseTempDesc.Name = "lbPriseTempDesc";
            this.lbPriseTempDesc.Size = new System.Drawing.Size(185, 33);
            this.lbPriseTempDesc.TabIndex = 36;
            this.lbPriseTempDesc.SelectedIndexChanged += new System.EventHandler(this.lbPriseTempDesc_SelectedIndexChanged);
            // 
            // tbPrisaTempDesc
            // 
            this.tbPrisaTempDesc.BackColor = System.Drawing.SystemColors.Info;
            this.tbPrisaTempDesc.Enabled = false;
            this.tbPrisaTempDesc.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPrisaTempDesc.Location = new System.Drawing.Point(352, 313);
            this.tbPrisaTempDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrisaTempDesc.Name = "tbPrisaTempDesc";
            this.tbPrisaTempDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPrisaTempDesc.Size = new System.Drawing.Size(289, 33);
            this.tbPrisaTempDesc.TabIndex = 37;
            this.tbPrisaTempDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.SystemColors.Info;
            this.tbAmount.Enabled = false;
            this.tbAmount.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbAmount.Location = new System.Drawing.Point(352, 362);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAmount.Size = new System.Drawing.Size(289, 37);
            this.tbAmount.TabIndex = 39;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 27);
            this.label7.TabIndex = 38;
            this.label7.Text = "כמות :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 425);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 41;
            this.label6.Text = "צור הזמנה";
            // 
            // InsertButton
            // 
            this.InsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertButton.Enabled = false;
            this.InsertButton.Image = global::HeretPreWorkControl.Properties.Resources.Plus_icon;
            this.InsertButton.Location = new System.Drawing.Point(592, 416);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(51, 43);
            this.InsertButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InsertButton.TabIndex = 40;
            this.InsertButton.TabStop = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(16, 484);
            this.tbPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(656, 35);
            this.tbPanel.TabIndex = 42;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMoveToManager
            // 
            this.cbMoveToManager.AutoSize = true;
            this.cbMoveToManager.Enabled = false;
            this.cbMoveToManager.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbMoveToManager.Location = new System.Drawing.Point(41, 428);
            this.cbMoveToManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMoveToManager.Name = "cbMoveToManager";
            this.cbMoveToManager.Size = new System.Drawing.Size(340, 28);
            this.cbMoveToManager.TabIndex = 43;
            this.cbMoveToManager.Text = "הזמנה חוזרת ( העבר לאישור מנהל )";
            this.cbMoveToManager.UseVisualStyleBackColor = true;
            // 
            // tbClientName
            // 
            this.tbClientName.BackColor = System.Drawing.SystemColors.Info;
            this.tbClientName.Enabled = false;
            this.tbClientName.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbClientName.Location = new System.Drawing.Point(352, 142);
            this.tbClientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbClientName.Multiline = true;
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbClientName.Size = new System.Drawing.Size(289, 70);
            this.tbClientName.TabIndex = 44;
            this.tbClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(689, 528);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.cbMoveToManager);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPriseTempDesc);
            this.Controls.Add(this.tbPrisaTempDesc);
            this.Controls.Add(this.tbFilesNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSalesAgent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClientNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtContactDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CreateOrderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CreateOrderForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtContactDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSalesAgent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilesNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lbPriseTempDesc;
        private System.Windows.Forms.TextBox tbPrisaTempDesc;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox InsertButton;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.CheckBox cbMoveToManager;
        private System.Windows.Forms.TextBox tbClientName;
    }
}