﻿namespace HeretPreWorkControl
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
            this.lblUpdateOrder = new System.Windows.Forms.Label();
            this.btnUpdateOrder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.UpdateOrder;
            this.pictureBox2.Location = new System.Drawing.Point(13, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(346, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.Info;
            this.tbDescription.Enabled = false;
            this.tbDescription.Font = new System.Drawing.Font("David", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbDescription.Location = new System.Drawing.Point(242, 112);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.MaxLength = 100;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDescription.Size = new System.Drawing.Size(412, 30);
            this.tbDescription.TabIndex = 5;
            this.tbDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPriseTempDesc
            // 
            this.lbPriseTempDesc.BackColor = System.Drawing.SystemColors.Info;
            this.lbPriseTempDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbPriseTempDesc.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbPriseTempDesc.FormattingEnabled = true;
            this.lbPriseTempDesc.Location = new System.Drawing.Point(13, 111);
            this.lbPriseTempDesc.Margin = new System.Windows.Forms.Padding(4);
            this.lbPriseTempDesc.Name = "lbPriseTempDesc";
            this.lbPriseTempDesc.Size = new System.Drawing.Size(221, 33);
            this.lbPriseTempDesc.TabIndex = 38;
            this.lbPriseTempDesc.SelectedIndexChanged += new System.EventHandler(this.lbPriseTempDesc_SelectedIndexChanged);
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(13, 222);
            this.tbPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(641, 35);
            this.tbPanel.TabIndex = 39;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUpdateOrder
            // 
            this.lblUpdateOrder.AutoSize = true;
            this.lblUpdateOrder.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateOrder.Location = new System.Drawing.Point(458, 171);
            this.lblUpdateOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateOrder.Name = "lblUpdateOrder";
            this.lblUpdateOrder.Size = new System.Drawing.Size(128, 27);
            this.lblUpdateOrder.TabIndex = 41;
            this.lblUpdateOrder.Text = "עדכן הזמנה";
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateOrder.Image = global::HeretPreWorkControl.Properties.Resources.Go_icon;
            this.btnUpdateOrder.Location = new System.Drawing.Point(594, 159);
            this.btnUpdateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(60, 49);
            this.btnUpdateOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUpdateOrder.TabIndex = 40;
            this.btnUpdateOrder.TabStop = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // UpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(667, 270);
            this.Controls.Add(this.lblUpdateOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.lbPriseTempDesc);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "UpdateOrderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox lbPriseTempDesc;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.Label lblUpdateOrder;
        private System.Windows.Forms.PictureBox btnUpdateOrder;
    }
}