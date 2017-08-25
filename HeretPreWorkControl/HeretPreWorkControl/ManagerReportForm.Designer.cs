namespace HeretPreWorkControl
{
    partial class ManagerReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerReportForm));
            this.pbHeret = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TabStation = new System.Windows.Forms.TabPage();
            this.TabEmployees = new System.Windows.Forms.TabPage();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lbEmployees = new System.Windows.Forms.ComboBox();
            this.chartWorkers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.tbTrackBar = new System.Windows.Forms.TrackBar();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeret)).BeginInit();
            this.tabControl.SuspendLayout();
            this.TabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHeret
            // 
            this.pbHeret.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbHeret.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pbHeret.Location = new System.Drawing.Point(404, 12);
            this.pbHeret.Name = "pbHeret";
            this.pbHeret.Size = new System.Drawing.Size(230, 65);
            this.pbHeret.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeret.TabIndex = 12;
            this.pbHeret.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabStation);
            this.tabControl.Controls.Add(this.TabEmployees);
            this.tabControl.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl.Location = new System.Drawing.Point(12, 83);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(735, 401);
            this.tabControl.TabIndex = 14;
            // 
            // TabStation
            // 
            this.TabStation.Location = new System.Drawing.Point(4, 29);
            this.TabStation.Name = "TabStation";
            this.TabStation.Padding = new System.Windows.Forms.Padding(3);
            this.TabStation.Size = new System.Drawing.Size(727, 368);
            this.TabStation.TabIndex = 0;
            this.TabStation.Text = "דוח תחנות";
            this.TabStation.UseVisualStyleBackColor = true;
            // 
            // TabEmployees
            // 
            this.TabEmployees.Controls.Add(this.dtToDate);
            this.TabEmployees.Controls.Add(this.label1);
            this.TabEmployees.Controls.Add(this.dtFromDate);
            this.TabEmployees.Controls.Add(this.lblFromDate);
            this.TabEmployees.Controls.Add(this.pbRefresh);
            this.TabEmployees.Controls.Add(this.lblEmployee);
            this.TabEmployees.Controls.Add(this.lbEmployees);
            this.TabEmployees.Controls.Add(this.chartWorkers);
            this.TabEmployees.Controls.Add(this.lblPeriod);
            this.TabEmployees.Controls.Add(this.tbTrackBar);
            this.TabEmployees.Location = new System.Drawing.Point(4, 29);
            this.TabEmployees.Name = "TabEmployees";
            this.TabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.TabEmployees.Size = new System.Drawing.Size(727, 368);
            this.TabEmployees.TabIndex = 1;
            this.TabEmployees.Text = "דוח עובדים";
            this.TabEmployees.UseVisualStyleBackColor = true;
            // 
            // dtFromDate
            // 
            this.dtFromDate.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtFromDate.Location = new System.Drawing.Point(458, 62);
            this.dtFromDate.MaxDate = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(161, 26);
            this.dtFromDate.TabIndex = 47;
            this.dtFromDate.Value = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(636, 67);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(79, 20);
            this.lblFromDate.TabIndex = 46;
            this.lblFromDate.Text = "מתאריך:";
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::HeretPreWorkControl.Properties.Resources.Refresh_icon;
            this.pbRefresh.Location = new System.Drawing.Point(16, 8);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(54, 37);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 45;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(620, 20);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(95, 20);
            this.lblEmployee.TabIndex = 44;
            this.lblEmployee.Text = "הצג לעובד:";
            // 
            // lbEmployees
            // 
            this.lbEmployees.BackColor = System.Drawing.SystemColors.Window;
            this.lbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbEmployees.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.Location = new System.Drawing.Point(439, 17);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(180, 28);
            this.lbEmployees.TabIndex = 43;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            // 
            // chartWorkers
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWorkers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWorkers.Legends.Add(legend1);
            this.chartWorkers.Location = new System.Drawing.Point(16, 102);
            this.chartWorkers.Name = "chartWorkers";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Lime;
            series1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "בזמן";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "מאחר";
            this.chartWorkers.Series.Add(series1);
            this.chartWorkers.Series.Add(series2);
            this.chartWorkers.Size = new System.Drawing.Size(695, 260);
            this.chartWorkers.TabIndex = 42;
            this.chartWorkers.Text = "chart1";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriod.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(297, 20);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(47, 20);
            this.lblPeriod.TabIndex = 41;
            this.lblPeriod.Text = "שבוע";
            // 
            // tbTrackBar
            // 
            this.tbTrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.tbTrackBar.Location = new System.Drawing.Point(76, 17);
            this.tbTrackBar.Maximum = 1;
            this.tbTrackBar.Name = "tbTrackBar";
            this.tbTrackBar.Size = new System.Drawing.Size(215, 45);
            this.tbTrackBar.TabIndex = 40;
            this.tbTrackBar.Scroll += new System.EventHandler(this.tbTrackBar_Scroll);
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(16, 490);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(727, 29);
            this.tbPanel.TabIndex = 27;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.ManagerReportTitle;
            this.pictureBox1.InitialImage = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // dtToDate
            // 
            this.dtToDate.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtToDate.Location = new System.Drawing.Point(130, 61);
            this.dtToDate.MaxDate = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(161, 26);
            this.dtToDate.TabIndex = 49;
            this.dtToDate.Value = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "עד תאריך:";
            // 
            // ManagerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pbHeret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ManagerReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeret)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.TabEmployees.ResumeLayout(false);
            this.TabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbHeret;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TabStation;
        private System.Windows.Forms.TabPage TabEmployees;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tbTrackBar;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWorkers;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox lbEmployees;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label1;
    }
}