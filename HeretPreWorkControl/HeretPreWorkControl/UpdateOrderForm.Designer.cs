namespace HeretPreWorkControl
{
    partial class UpdateOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateOrderForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbPriseTempDesc = new System.Windows.Forms.ComboBox();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.UpdateOrder;
            this.pictureBox2.Location = new System.Drawing.Point(10, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(229, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.Info;
            this.tbDescription.Enabled = false;
            this.tbDescription.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbDescription.Location = new System.Drawing.Point(164, 89);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDescription.Size = new System.Drawing.Size(296, 31);
            this.tbDescription.TabIndex = 5;
            this.tbDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPriseTempDesc
            // 
            this.lbPriseTempDesc.BackColor = System.Drawing.SystemColors.Info;
            this.lbPriseTempDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbPriseTempDesc.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbPriseTempDesc.FormattingEnabled = true;
            this.lbPriseTempDesc.Location = new System.Drawing.Point(10, 90);
            this.lbPriseTempDesc.Name = "lbPriseTempDesc";
            this.lbPriseTempDesc.Size = new System.Drawing.Size(149, 28);
            this.lbPriseTempDesc.TabIndex = 38;
            this.lbPriseTempDesc.SelectedIndexChanged += new System.EventHandler(this.lbPriseTempDesc_SelectedIndexChanged);
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(10, 180);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(450, 29);
            this.tbPanel.TabIndex = 39;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "עדכן הזמנה";
            // 
            // Login_Button
            // 
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.Image = global::HeretPreWorkControl.Properties.Resources.Go_icon;
            this.Login_Button.Location = new System.Drawing.Point(414, 129);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(45, 40);
            this.Login_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login_Button.TabIndex = 40;
            this.Login_Button.TabStop = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // UpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(469, 219);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.lbPriseTempDesc);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "UpdateOrderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox lbPriseTempDesc;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Login_Button;
    }
}