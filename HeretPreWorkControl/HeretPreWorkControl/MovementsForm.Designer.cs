namespace HeretPreWorkControl
{
    partial class MovementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovementsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSalesOfferID = new System.Windows.Forms.TextBox();
            this.lblSalesOfferID = new System.Windows.Forms.Label();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.pbMoveButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtSalesOfferDate = new System.Windows.Forms.DateTimePicker();
            this.lblStudioWork = new System.Windows.Forms.Label();
            this.lbStudioWork = new System.Windows.Forms.ComboBox();
            this.lbKadasWork = new System.Windows.Forms.ComboBox();
            this.lblKadasWork = new System.Windows.Forms.Label();
            this.tbPanel = new System.Windows.Forms.TextBox();
            this.lblSalesNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeretPreWorkControl.Properties.Resources.MovementTitle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(268, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Department});
            this.dataGridView.Location = new System.Drawing.Point(12, 85);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(177, 165);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.HeaderText = "מחלקה";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbSalesOfferID
            // 
            this.tbSalesOfferID.BackColor = System.Drawing.SystemColors.Window;
            this.tbSalesOfferID.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbSalesOfferID.Location = new System.Drawing.Point(356, 108);
            this.tbSalesOfferID.Name = "tbSalesOfferID";
            this.tbSalesOfferID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSalesOfferID.Size = new System.Drawing.Size(121, 31);
            this.tbSalesOfferID.TabIndex = 21;
            this.tbSalesOfferID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalesOfferID
            // 
            this.lblSalesOfferID.AutoSize = true;
            this.lblSalesOfferID.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOfferID.Location = new System.Drawing.Point(189, 115);
            this.lblSalesOfferID.Name = "lblSalesOfferID";
            this.lblSalesOfferID.Size = new System.Drawing.Size(130, 19);
            this.lblSalesOfferID.TabIndex = 20;
            this.lblSalesOfferID.Text = "מס\' הצעת מחיר: ";
            // 
            // lblSalesDate
            // 
            this.lblSalesDate.AutoSize = true;
            this.lblSalesDate.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesDate.Location = new System.Drawing.Point(189, 156);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(150, 19);
            this.lblSalesDate.TabIndex = 22;
            this.lblSalesDate.Text = "תאריך שליחת הצעה";
            // 
            // pbMoveButton
            // 
            this.pbMoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMoveButton.Image = global::HeretPreWorkControl.Properties.Resources.Go_icon;
            this.pbMoveButton.Location = new System.Drawing.Point(440, 269);
            this.pbMoveButton.Name = "pbMoveButton";
            this.pbMoveButton.Size = new System.Drawing.Size(37, 34);
            this.pbMoveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoveButton.TabIndex = 24;
            this.pbMoveButton.TabStop = false;
            this.pbMoveButton.Click += new System.EventHandler(this.pbMoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "העבר";
            // 
            // dtSalesOfferDate
            // 
            this.dtSalesOfferDate.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtSalesOfferDate.Location = new System.Drawing.Point(247, 178);
            this.dtSalesOfferDate.Name = "dtSalesOfferDate";
            this.dtSalesOfferDate.Size = new System.Drawing.Size(230, 23);
            this.dtSalesOfferDate.TabIndex = 26;
            // 
            // lblStudioWork
            // 
            this.lblStudioWork.AutoSize = true;
            this.lblStudioWork.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudioWork.Location = new System.Drawing.Point(189, 137);
            this.lblStudioWork.Name = "lblStudioWork";
            this.lblStudioWork.Size = new System.Drawing.Size(114, 19);
            this.lblStudioWork.TabIndex = 27;
            this.lblStudioWork.Text = "עבודה נדרשת :";
            // 
            // lbStudioWork
            // 
            this.lbStudioWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbStudioWork.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbStudioWork.FormattingEnabled = true;
            this.lbStudioWork.Location = new System.Drawing.Point(236, 159);
            this.lbStudioWork.Name = "lbStudioWork";
            this.lbStudioWork.Size = new System.Drawing.Size(241, 27);
            this.lbStudioWork.TabIndex = 28;
            // 
            // lbKadasWork
            // 
            this.lbKadasWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbKadasWork.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbKadasWork.FormattingEnabled = true;
            this.lbKadasWork.Location = new System.Drawing.Point(236, 159);
            this.lbKadasWork.Name = "lbKadasWork";
            this.lbKadasWork.Size = new System.Drawing.Size(241, 27);
            this.lbKadasWork.TabIndex = 30;
            // 
            // lblKadasWork
            // 
            this.lblKadasWork.AutoSize = true;
            this.lblKadasWork.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKadasWork.Location = new System.Drawing.Point(189, 137);
            this.lblKadasWork.Name = "lblKadasWork";
            this.lblKadasWork.Size = new System.Drawing.Size(114, 19);
            this.lblKadasWork.TabIndex = 29;
            this.lblKadasWork.Text = "עבודה נדרשת :";
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(12, 309);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(465, 29);
            this.tbPanel.TabIndex = 31;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalesNote
            // 
            this.lblSalesNote.AutoSize = true;
            this.lblSalesNote.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesNote.ForeColor = System.Drawing.Color.Red;
            this.lblSalesNote.Location = new System.Drawing.Point(12, 260);
            this.lblSalesNote.Name = "lblSalesNote";
            this.lblSalesNote.Size = new System.Drawing.Size(404, 16);
            this.lblSalesNote.TabIndex = 32;
            this.lblSalesNote.Text = "* שים לב ! תוכל להזין מס\' הצעת מחיר ותאריך דרך עבודות לביצוע";
            // 
            // MovementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 350);
            this.Controls.Add(this.lblSalesNote);
            this.Controls.Add(this.tbPanel);
            this.Controls.Add(this.lbKadasWork);
            this.Controls.Add(this.lblKadasWork);
            this.Controls.Add(this.lbStudioWork);
            this.Controls.Add(this.lblStudioWork);
            this.Controls.Add(this.dtSalesOfferDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMoveButton);
            this.Controls.Add(this.lblSalesDate);
            this.Controls.Add(this.tbSalesOfferID);
            this.Controls.Add(this.lblSalesOfferID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MovementsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מערכת לבקרת תהליך קדם העבודה";
            this.Load += new System.EventHandler(this.MovementsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.TextBox tbSalesOfferID;
        private System.Windows.Forms.Label lblSalesOfferID;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.PictureBox pbMoveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtSalesOfferDate;
        private System.Windows.Forms.Label lblStudioWork;
        private System.Windows.Forms.ComboBox lbStudioWork;
        private System.Windows.Forms.ComboBox lbKadasWork;
        private System.Windows.Forms.Label lblKadasWork;
        private System.Windows.Forms.TextBox tbPanel;
        private System.Windows.Forms.Label lblSalesNote;
    }
}