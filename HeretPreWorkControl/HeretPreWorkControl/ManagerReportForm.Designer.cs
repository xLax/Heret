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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerReportForm));
            this.pbHeret = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TabStation = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWorkersInDept = new System.Windows.Forms.ComboBox();
            this.rbStationWeek = new System.Windows.Forms.RadioButton();
            this.rbStationMonth = new System.Windows.Forms.RadioButton();
            this.chartStations = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pbStationRefresh = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.ComboBox();
            this.TabEmployees = new System.Windows.Forms.TabPage();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbHeret)).BeginInit();
            this.tabControl.SuspendLayout();
            this.TabStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStationRefresh)).BeginInit();
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
            this.TabStation.Controls.Add(this.label1);
            this.TabStation.Controls.Add(this.lbWorkersInDept);
            this.TabStation.Controls.Add(this.rbStationWeek);
            this.TabStation.Controls.Add(this.rbStationMonth);
            this.TabStation.Controls.Add(this.chartStations);
            this.TabStation.Controls.Add(this.dtFrom);
            this.TabStation.Controls.Add(this.label3);
            this.TabStation.Controls.Add(this.pbStationRefresh);
            this.TabStation.Controls.Add(this.label4);
            this.TabStation.Controls.Add(this.lbDepartment);
            this.TabStation.Location = new System.Drawing.Point(4, 29);
            this.TabStation.Name = "TabStation";
            this.TabStation.Padding = new System.Windows.Forms.Padding(3);
            this.TabStation.Size = new System.Drawing.Size(727, 368);
            this.TabStation.TabIndex = 0;
            this.TabStation.Text = "דוח תחנות";
            this.TabStation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "הצג לעובד:";
            // 
            // lbWorkersInDept
            // 
            this.lbWorkersInDept.BackColor = System.Drawing.SystemColors.Window;
            this.lbWorkersInDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbWorkersInDept.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbWorkersInDept.FormattingEnabled = true;
            this.lbWorkersInDept.Location = new System.Drawing.Point(71, 56);
            this.lbWorkersInDept.Name = "lbWorkersInDept";
            this.lbWorkersInDept.Size = new System.Drawing.Size(187, 28);
            this.lbWorkersInDept.TabIndex = 64;
            this.lbWorkersInDept.SelectedIndexChanged += new System.EventHandler(this.lbWorkersInDept_SelectedIndexChanged);
            // 
            // rbStationWeek
            // 
            this.rbStationWeek.AutoSize = true;
            this.rbStationWeek.Checked = true;
            this.rbStationWeek.Location = new System.Drawing.Point(293, 19);
            this.rbStationWeek.Name = "rbStationWeek";
            this.rbStationWeek.Size = new System.Drawing.Size(62, 23);
            this.rbStationWeek.TabIndex = 63;
            this.rbStationWeek.TabStop = true;
            this.rbStationWeek.Text = "שבוע";
            this.rbStationWeek.UseVisualStyleBackColor = true;
            this.rbStationWeek.CheckedChanged += new System.EventHandler(this.rbStationWeek_CheckedChanged);
            // 
            // rbStationMonth
            // 
            this.rbStationMonth.AutoSize = true;
            this.rbStationMonth.Location = new System.Drawing.Point(189, 18);
            this.rbStationMonth.Name = "rbStationMonth";
            this.rbStationMonth.Size = new System.Drawing.Size(65, 23);
            this.rbStationMonth.TabIndex = 62;
            this.rbStationMonth.Text = "חודש";
            this.rbStationMonth.UseVisualStyleBackColor = true;
            this.rbStationMonth.CheckedChanged += new System.EventHandler(this.rbStationMonth_CheckedChanged);
            // 
            // chartStations
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStations.ChartAreas.Add(chartArea1);
            this.chartStations.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Name = "Legend1";
            this.chartStations.Legends.Add(legend1);
            this.chartStations.Location = new System.Drawing.Point(6, 87);
            this.chartStations.Name = "chartStations";
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
            this.chartStations.Series.Add(series1);
            this.chartStations.Series.Add(series2);
            this.chartStations.Size = new System.Drawing.Size(715, 275);
            this.chartStations.TabIndex = 59;
            this.chartStations.Text = "chart1";
            this.chartStations.Click += new System.EventHandler(this.chartStations_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtFrom.Location = new System.Drawing.Point(432, 16);
            this.dtFrom.MaxDate = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(180, 26);
            this.dtFrom.TabIndex = 56;
            this.dtFrom.Value = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "מתאריך:";
            // 
            // pbStationRefresh
            // 
            this.pbStationRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStationRefresh.Image = global::HeretPreWorkControl.Properties.Resources.Refresh_icon;
            this.pbStationRefresh.Location = new System.Drawing.Point(28, 6);
            this.pbStationRefresh.Name = "pbStationRefresh";
            this.pbStationRefresh.Size = new System.Drawing.Size(54, 37);
            this.pbStationRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStationRefresh.TabIndex = 54;
            this.pbStationRefresh.TabStop = false;
            this.pbStationRefresh.Click += new System.EventHandler(this.pbStationRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(634, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "מחלקה:";
            // 
            // lbDepartment
            // 
            this.lbDepartment.BackColor = System.Drawing.SystemColors.Window;
            this.lbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbDepartment.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbDepartment.FormattingEnabled = true;
            this.lbDepartment.Location = new System.Drawing.Point(432, 56);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(180, 28);
            this.lbDepartment.TabIndex = 52;
            this.lbDepartment.SelectedIndexChanged += new System.EventHandler(this.lbDepartment_SelectedIndexChanged);
            // 
            // TabEmployees
            // 
            this.TabEmployees.Controls.Add(this.rbWeek);
            this.TabEmployees.Controls.Add(this.rbMonth);
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
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Checked = true;
            this.rbWeek.Location = new System.Drawing.Point(305, 19);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(62, 23);
            this.rbWeek.TabIndex = 57;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "שבוע";
            this.rbWeek.UseVisualStyleBackColor = true;
            this.rbWeek.CheckedChanged += new System.EventHandler(this.rbWeek_CheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(194, 19);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(65, 23);
            this.rbMonth.TabIndex = 56;
            this.rbMonth.Text = "חודש";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // dtFromDate
            // 
            this.dtFromDate.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtFromDate.Location = new System.Drawing.Point(434, 19);
            this.dtFromDate.MaxDate = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(180, 26);
            this.dtFromDate.TabIndex = 55;
            this.dtFromDate.Value = new System.DateTime(2017, 8, 7, 0, 0, 0, 0);
            this.dtFromDate.ValueChanged += new System.EventHandler(this.dtFromDate_ValueChanged);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(631, 24);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(79, 20);
            this.lblFromDate.TabIndex = 54;
            this.lblFromDate.Text = "מתאריך:";
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::HeretPreWorkControl.Properties.Resources.Refresh_icon;
            this.pbRefresh.Location = new System.Drawing.Point(30, 8);
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
            this.lblEmployee.Location = new System.Drawing.Point(615, 63);
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
            this.lbEmployees.Location = new System.Drawing.Point(434, 60);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(180, 28);
            this.lbEmployees.TabIndex = 43;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            // 
            // chartWorkers
            // 
            chartArea2.Name = "ChartArea1";
            this.chartWorkers.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWorkers.Legends.Add(legend2);
            this.chartWorkers.Location = new System.Drawing.Point(16, 102);
            this.chartWorkers.Name = "chartWorkers";
            series3.BorderColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Lime;
            series3.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "בזמן";
            series4.BorderColor = System.Drawing.Color.Black;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "מאחר";
            this.chartWorkers.Series.Add(series3);
            this.chartWorkers.Series.Add(series4);
            this.chartWorkers.Size = new System.Drawing.Size(695, 260);
            this.chartWorkers.TabIndex = 42;
            this.chartWorkers.Text = "chart1";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriod.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(303, 63);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(68, 20);
            this.lblPeriod.TabIndex = 41;
            this.lblPeriod.Text = "בתהליך";
            // 
            // tbTrackBar
            // 
            this.tbTrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.tbTrackBar.Location = new System.Drawing.Point(82, 60);
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
            this.Load += new System.EventHandler(this.ManagerReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeret)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.TabStation.ResumeLayout(false);
            this.TabStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStationRefresh)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbStationRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lbDepartment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStations;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.RadioButton rbWeek;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbStationWeek;
        private System.Windows.Forms.RadioButton rbStationMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lbWorkersInDept;
    }
}