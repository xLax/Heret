namespace HeretPreWorkControl
{
    partial class InsertOrderIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertOrderIDForm));
            this.lblExecute = new System.Windows.Forms.Label();
            this.pbExecute = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbPanel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExecute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExecute
            // 
            this.lblExecute.AutoSize = true;
            this.lblExecute.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecute.Location = new System.Drawing.Point(187, 211);
            this.lblExecute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExecute.Name = "lblExecute";
            this.lblExecute.Size = new System.Drawing.Size(178, 27);
            this.lblExecute.TabIndex = 16;
            this.lblExecute.Text = "הזן מספר הזמנה";
            // 
            // pbExecute
            // 
            this.pbExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExecute.Image = global::HeretPreWorkControl.Properties.Resources.Go_icon;
            this.pbExecute.Location = new System.Drawing.Point(391, 203);
            this.pbExecute.Margin = new System.Windows.Forms.Padding(4);
            this.pbExecute.Name = "pbExecute";
            this.pbExecute.Size = new System.Drawing.Size(47, 38);
            this.pbExecute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExecute.TabIndex = 15;
            this.pbExecute.TabStop = false;
            this.pbExecute.Click += new System.EventHandler(this.pbExecute_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbLogo.Location = new System.Drawing.Point(233, 15);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(204, 62);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.InsertOrderNumberTitle;
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(16, 249);
            this.tbPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(420, 35);
            this.tbPanel.TabIndex = 20;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InsertOrderIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(453, 300);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblExecute);
            this.Controls.Add(this.pbExecute);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InsertOrderIDForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InsertOrderIDForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbExecute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblExecute;
        private System.Windows.Forms.PictureBox pbExecute;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbPanel;
    }
}