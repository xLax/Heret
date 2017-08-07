﻿namespace HeretPreWorkControl
{
    partial class EnterOfferDataPopup
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
            this.dtSalesOfferDate = new System.Windows.Forms.DateTimePicker();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.tbSalesOfferID = new System.Windows.Forms.TextBox();
            this.lblSalesOfferID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbInsertButton = new System.Windows.Forms.PictureBox();
            this.tbPanel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.EnterOfferTitle;
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(176, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dtSalesOfferDate
            // 
            this.dtSalesOfferDate.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtSalesOfferDate.Location = new System.Drawing.Point(169, 121);
            this.dtSalesOfferDate.Name = "dtSalesOfferDate";
            this.dtSalesOfferDate.Size = new System.Drawing.Size(160, 23);
            this.dtSalesOfferDate.TabIndex = 30;
            // 
            // lblSalesDate
            // 
            this.lblSalesDate.AutoSize = true;
            this.lblSalesDate.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesDate.Location = new System.Drawing.Point(6, 124);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(157, 19);
            this.lblSalesDate.TabIndex = 29;
            this.lblSalesDate.Text = "תאריך שליחת הצעה:";
            // 
            // tbSalesOfferID
            // 
            this.tbSalesOfferID.BackColor = System.Drawing.SystemColors.Window;
            this.tbSalesOfferID.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbSalesOfferID.Location = new System.Drawing.Point(169, 76);
            this.tbSalesOfferID.Name = "tbSalesOfferID";
            this.tbSalesOfferID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSalesOfferID.Size = new System.Drawing.Size(160, 31);
            this.tbSalesOfferID.TabIndex = 28;
            // 
            // lblSalesOfferID
            // 
            this.lblSalesOfferID.AutoSize = true;
            this.lblSalesOfferID.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOfferID.Location = new System.Drawing.Point(6, 83);
            this.lblSalesOfferID.Name = "lblSalesOfferID";
            this.lblSalesOfferID.Size = new System.Drawing.Size(130, 19);
            this.lblSalesOfferID.TabIndex = 27;
            this.lblSalesOfferID.Text = "מס\' הצעת מחיר: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "הזן";
            // 
            // pbInsertButton
            // 
            this.pbInsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInsertButton.Image = global::HeretPreWorkControl.Properties.Resources.Go_icon;
            this.pbInsertButton.Location = new System.Drawing.Point(291, 152);
            this.pbInsertButton.Name = "pbInsertButton";
            this.pbInsertButton.Size = new System.Drawing.Size(38, 35);
            this.pbInsertButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInsertButton.TabIndex = 38;
            this.pbInsertButton.TabStop = false;
            this.pbInsertButton.Click += new System.EventHandler(this.pbInsertButton_Click);
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(12, 195);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(317, 29);
            this.tbPanel.TabIndex = 37;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnterOfferDataPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(341, 236);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbInsertButton);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.dtSalesOfferDate);
            this.Controls.Add(this.lblSalesDate);
            this.Controls.Add(this.tbSalesOfferID);
            this.Controls.Add(this.lblSalesOfferID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EnterOfferDataPopup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.Load += new System.EventHandler(this.EnterOfferDataPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtSalesOfferDate;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.TextBox tbSalesOfferID;
        private System.Windows.Forms.Label lblSalesOfferID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbInsertButton;
        private System.Windows.Forms.TextBox tbPanel;
    }
}