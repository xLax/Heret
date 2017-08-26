using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeretPreWorkControl
{
    public partial class InsertOrderIDForm : Form
    {
        // Consts of label
        const int nLabelWidth = 149;
        const int nLabelHeight = 27;
        Font fLabelFont = new Font(new FontFamily("David"), (float)15.75, new FontStyle(), new GraphicsUnit(), 0, false);
        const string strFilesNumberName = "FileNumber";
        const string strFilesNumberText = "מספר קובץ: ";

        // Consts of input field
        Color cBackColor = Color.White;
        Font fInputFont = new Font(new FontFamily("David"), (float)18, new FontStyle(), new GraphicsUnit(), 177, false);
        const int nInputWidth = 228;
        const int nInputHeight = 37;
        RightToLeft rtlInputAlign = RightToLeft.No;

        // Consts for the flow layout size changes
        const int nTotalHeight = 74;

        tbl_orders OrderToInsert;

        public InsertOrderIDForm(tbl_orders CurrentOrder)
        {
            InitializeComponent();

            this.OrderToInsert = CurrentOrder;
            initLayout(3);
        }

        private void pbExecute_Click(object sender, EventArgs e)
        {
            if(tbOrderNum.Text == String.Empty)
            {
                tbPanel.Text = "שגיאה! עליך להזין מספר הזמנה";
            }
            else
            {
                this.OrderToInsert.order_number = tbOrderNum.Text;
                this.OrderToInsert.current_status_id = Globals.StatusClosed;

                try
                {
                    using (var context = new DB_Entities())
                    {
                        context.tbl_orders.Attach(this.OrderToInsert);
                        var Entry = context.Entry(this.OrderToInsert);

                        Entry.Property(o => o.order_number).IsModified = true;
                        Entry.Property(o => o.current_status_id).IsModified = true;
                        // context.tbl_orders.AddOrUpdate(DeclinedOrder);

                        context.SaveChanges();

                        MyJobsForm.isJobSucceeded = true;
                        tbPanel.Text = "מספר ההזמנה הוכנס למערכת בהצלחה !";
                    }
                }
                catch (Exception ex)
                {
                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                }
            }
        }

        private void initLayout(int nFilesNumber)
        {
            // Save the distance of the objects from the bottom edge of the screen
            int nErrorPanelYFromDownEdge = this.Height - tbPanel.Location.Y;
            int nOkButtonYFromDwonEdge = this.Height - pbExecute.Location.Y;
            int nOkLabelYFromDownEdge = this.Height - label3.Location.Y;

            // Save the distance of the objects from the left edge of the screen
            int nErrorPanelXFromLeftEdge = this.Width - tbPanel.Location.X;
            int nOkButtonXFromLeftEdge = this.Width - pbExecute.Location.X;
            int nOkLabelXFromLeftEdge = this.Width - label3.Location.X;
            int nLogoXFromLeftEdge = this.Width - pbLogo.Location.X;

            // Save the prevuis size of the screen
            int nPreviusHeight = this.Height;
            int nPreviusWidth = this.Width;

            // Save error panel distance from edges
            int nErrorPanelSpace = this.Width - tbPanel.Width;

            int nFlowBottom = flowLayoutPanel1.Location.Y + flowLayoutPanel1.Height;
            int nFlowLeft = flowLayoutPanel1.Location.X + flowLayoutPanel1.Width;

            for (int i = 1; i <= nFilesNumber; i++ )
            {
                Label lbl = new Label();
                //lbl
            }


            flowLayoutPanel1.Height = 400;
            flowLayoutPanel1.Width = 400;
            this.Height = flowLayoutPanel1.Location.Y + flowLayoutPanel1.Height + (nPreviusHeight - nFlowBottom);
            this.Width = flowLayoutPanel1.Location.X + flowLayoutPanel1.Width + (nPreviusWidth - nFlowLeft);
            tbPanel.Location = new Point(tbPanel.Location.X, this.Height - nErrorPanelYFromDownEdge);
            pbExecute.Location = new Point(this.Width - nOkButtonXFromLeftEdge, this.Height - nOkButtonYFromDwonEdge);
            label3.Location = new Point(this.Width - nOkLabelXFromLeftEdge, this.Height - nOkLabelYFromDownEdge);
            pbLogo.Location = new Point(this.Width - nLogoXFromLeftEdge, pbLogo.Location.Y);
            tbPanel.Width = this.Width - nErrorPanelSpace;
        }
    }
}
