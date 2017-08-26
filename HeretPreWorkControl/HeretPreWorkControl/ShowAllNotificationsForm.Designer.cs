namespace HeretPreWorkControl
{
    partial class ShowAllNotificationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllNotificationsForm));
            this.lvListView = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbHeret = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSetWatched = new System.Windows.Forms.PictureBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.tbPanel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetWatched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lvListView
            // 
            this.lvListView.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lvListView.Location = new System.Drawing.Point(12, 92);
            this.lvListView.Name = "lvListView";
            this.lvListView.RightToLeftLayout = true;
            this.lvListView.Size = new System.Drawing.Size(583, 148);
            this.lvListView.TabIndex = 0;
            this.lvListView.UseCompatibleStateImageBehavior = false;
            this.lvListView.View = System.Windows.Forms.View.List;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.WatchNotesTitle;
            this.pictureBox1.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pbHeret
            // 
            this.pbHeret.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbHeret.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbHeret.Location = new System.Drawing.Point(297, 12);
            this.pbHeret.Name = "pbHeret";
            this.pbHeret.Size = new System.Drawing.Size(230, 65);
            this.pbHeret.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeret.TabIndex = 29;
            this.pbHeret.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "סמן כנצפו";
            // 
            // pbSetWatched
            // 
            this.pbSetWatched.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSetWatched.Image = global::HeretPreWorkControl.Properties.Resources.Overview_Icon;
            this.pbSetWatched.Location = new System.Drawing.Point(544, 254);
            this.pbSetWatched.Name = "pbSetWatched";
            this.pbSetWatched.Size = new System.Drawing.Size(51, 39);
            this.pbSetWatched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSetWatched.TabIndex = 31;
            this.pbSetWatched.TabStop = false;
            this.pbSetWatched.Click += new System.EventHandler(this.pbSetWatched_Click);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::HeretPreWorkControl.Properties.Resources.Refresh_icon;
            this.pbRefresh.Location = new System.Drawing.Point(541, 40);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(54, 37);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 33;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(12, 304);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(583, 29);
            this.tbPanel.TabIndex = 34;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowAllNotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 345);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbSetWatched);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbHeret);
            this.Controls.Add(this.lvListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ShowAllNotificationsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetWatched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbHeret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSetWatched;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.TextBox tbPanel;
    }
}