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
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeretPreWorkControl.Properties.Resources.Heret_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(357, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Department});
            this.dataGridView.Location = new System.Drawing.Point(16, 105);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(236, 203);
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
            this.tbSalesOfferID.Location = new System.Drawing.Point(475, 133);
            this.tbSalesOfferID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSalesOfferID.Name = "tbSalesOfferID";
            this.tbSalesOfferID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSalesOfferID.Size = new System.Drawing.Size(160, 37);
            this.tbSalesOfferID.TabIndex = 21;
            // 
            // lblSalesOfferID
            // 
            this.lblSalesOfferID.AutoSize = true;
            this.lblSalesOfferID.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOfferID.Location = new System.Drawing.Point(252, 142);
            this.lblSalesOfferID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesOfferID.Name = "lblSalesOfferID";
            this.lblSalesOfferID.Size = new System.Drawing.Size(162, 24);
            this.lblSalesOfferID.TabIndex = 20;
            this.lblSalesOfferID.Text = "מס\' הצעת מחיר: ";
            // 
            // lblSalesDate
            // 
            this.lblSalesDate.AutoSize = true;
            this.lblSalesDate.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesDate.Location = new System.Drawing.Point(252, 192);
            this.lblSalesDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(186, 24);
            this.lblSalesDate.TabIndex = 22;
            this.lblSalesDate.Text = "תאריך שליחת הצעה";
            // 
            // pbMoveButton
            // 
            this.pbMoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMoveButton.Image = global::HeretPreWorkControl.Properties.Resources.Go_icon;
            this.pbMoveButton.Location = new System.Drawing.Point(587, 331);
            this.pbMoveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMoveButton.Name = "pbMoveButton";
            this.pbMoveButton.Size = new System.Drawing.Size(49, 42);
            this.pbMoveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoveButton.TabIndex = 24;
            this.pbMoveButton.TabStop = false;
            this.pbMoveButton.Click += new System.EventHandler(this.pbMoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "העבר";
            // 
            // dtSalesOfferDate
            // 
            this.dtSalesOfferDate.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtSalesOfferDate.Location = new System.Drawing.Point(329, 219);
            this.dtSalesOfferDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtSalesOfferDate.Name = "dtSalesOfferDate";
            this.dtSalesOfferDate.Size = new System.Drawing.Size(305, 27);
            this.dtSalesOfferDate.TabIndex = 26;
            // 
            // lblStudioWork
            // 
            this.lblStudioWork.AutoSize = true;
            this.lblStudioWork.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudioWork.Location = new System.Drawing.Point(252, 169);
            this.lblStudioWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudioWork.Name = "lblStudioWork";
            this.lblStudioWork.Size = new System.Drawing.Size(140, 24);
            this.lblStudioWork.TabIndex = 27;
            this.lblStudioWork.Text = "עבודה נדרשת :";
            // 
            // lbStudioWork
            // 
            this.lbStudioWork.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbStudioWork.FormattingEnabled = true;
            this.lbStudioWork.Location = new System.Drawing.Point(315, 196);
            this.lbStudioWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbStudioWork.Name = "lbStudioWork";
            this.lbStudioWork.Size = new System.Drawing.Size(320, 32);
            this.lbStudioWork.TabIndex = 28;
            // 
            // lbKadasWork
            // 
            this.lbKadasWork.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbKadasWork.FormattingEnabled = true;
            this.lbKadasWork.Location = new System.Drawing.Point(315, 196);
            this.lbKadasWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbKadasWork.Name = "lbKadasWork";
            this.lbKadasWork.Size = new System.Drawing.Size(320, 32);
            this.lbKadasWork.TabIndex = 30;
            // 
            // lblKadasWork
            // 
            this.lblKadasWork.AutoSize = true;
            this.lblKadasWork.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKadasWork.Location = new System.Drawing.Point(252, 169);
            this.lblKadasWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKadasWork.Name = "lblKadasWork";
            this.lblKadasWork.Size = new System.Drawing.Size(140, 24);
            this.lblKadasWork.TabIndex = 29;
            this.lblKadasWork.Text = "עבודה נדרשת :";
            // 
            // tbPanel
            // 
            this.tbPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tbPanel.Enabled = false;
            this.tbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPanel.Location = new System.Drawing.Point(16, 380);
            this.tbPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPanel.Multiline = true;
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.Size = new System.Drawing.Size(619, 35);
            this.tbPanel.TabIndex = 31;
            this.tbPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalesNote
            // 
            this.lblSalesNote.AutoSize = true;
            this.lblSalesNote.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesNote.ForeColor = System.Drawing.Color.Red;
            this.lblSalesNote.Location = new System.Drawing.Point(16, 320);
            this.lblSalesNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesNote.Name = "lblSalesNote";
            this.lblSalesNote.Size = new System.Drawing.Size(482, 20);
            this.lblSalesNote.TabIndex = 32;
            this.lblSalesNote.Text = "* שים לב ! תוכל להזין מס\' הצעת מחיר ותאריך דרך עבודות לביצוע";
            // 
            // MovementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(652, 431);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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