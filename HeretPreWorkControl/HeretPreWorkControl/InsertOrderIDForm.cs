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
        const int nLabelWidth = 130;
        const int nLabelHeight = 27;
        Font fLabelFont = new Font(new FontFamily("David"), (float)20, new FontStyle(), new GraphicsUnit(), 0, false);
        const string strFilesNumberName = "lblFileNumber";
        const string strFilesNumberText = "קובץ מספר : ";
        const string strOrderIdLabelName = "lblOrderId";
        const string strOrderIdLabelText = "מספר הזמנה :";
        const int nLabelX = 13;

        // Consts of input field
        Color cBackColor = Color.White;
        Font fInputFont = new Font(new FontFamily("David"), (float)25, new FontStyle(), new GraphicsUnit(), 177, false);
        const int nInputWidth = 172;
        const int nInputHeight = 37;
        RightToLeft rtlInputAlign = RightToLeft.No;
        const string strOrderIdInputName = "tbOrderId";
        const int nInputX = 208;


        const int nStartY = 80;
        private int? nfilesno = 0;

        // Consts for the flow layout size changes
        const int nTotalHeight = 74;

        tbl_orders OrderToInsert;

        public InsertOrderIDForm(tbl_orders CurrentOrder)
        {
            InitializeComponent();

            if(CurrentOrder.files_number != null)
            {
                nfilesno = CurrentOrder.files_number;
            }
            
            if(nfilesno > 1)
            {
                lblExecute.Text = "הזן מספרי הזמנות";
            }
            this.OrderToInsert = CurrentOrder;
            initLayout();
        }

        private void pbExecute_Click(object sender, EventArgs e)
        {
            // Check if all the orders id were filled
            bool isAllFilled = true;
            for (int i = 1; i <= nfilesno; i++)
            {
                if(this.Controls.Find(strOrderIdInputName + i, false).Single<Control>().Text == String.Empty)
                {
                    tbPanel.Text = "שגיאה! עליך להזין את כל מספרי ההזמנות";
                    isAllFilled = false;
                }
            }

            // Save the order changes in the db
            if(isAllFilled)
            {
                tbl_orders_id ordersId = new tbl_orders_id();

                this.OrderToInsert.order_number = this.OrderToInsert.ID;
                this.OrderToInsert.current_status_id = Globals.StatusClosed;

                using (var context = new DB_Entities()) 
                {
                    try
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
                    catch (Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }
                }

                // Create rows for the orders id in the db
                int nId = Utilities.GetNextOrderIDForFiles();

                using (var context = new DB_Entities())
                {
                    try
                    {
                        for (int i = 1; i <= nfilesno; i++)
                        {
                            ordersId = new tbl_orders_id();
                            ordersId.ID = nId + i - 1;
                            ordersId.order_id = this.OrderToInsert.ID;
                            ordersId.heret_order_id = this.Controls.Find(strOrderIdInputName + i, false).Single<Control>().Text;

                            context.tbl_orders_id.Add(ordersId);
                        }
                        context.SaveChanges();

                        tbPanel.Text = "ההזמנה נוצרה בהצלחה ! ";
                    }
                    catch (Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }
                }
            }
        }

        private void initLayout()
        {
            // Save the distance of the objects from the bottom edge of the screen
            int nErrorPanelYFromDownEdge = this.Height - tbPanel.Location.Y;
            int nOkButtonYFromDwonEdge = this.Height - pbExecute.Location.Y;
            int nOkLabelYFromDownEdge = this.Height - lblExecute.Location.Y;
            int nOkButtonTopToFormBottom = this.Height - pbExecute.Location.Y;

            // Save the distance of the objects from the left edge of the screen
            int nErrorPanelXFromLeftEdge = this.Width - tbPanel.Location.X;
            int nOkButtonXFromLeftEdge = this.Width - pbExecute.Location.X;
            int nOkLabelXFromLeftEdge = this.Width - lblExecute.Location.X;
            int nLogoXFromLeftEdge = this.Width - pbLogo.Location.X;

            // Save the prevuis size of the screen
            int nPreviusHeight = this.Height;
            int nPreviusWidth = this.Width;

            // Save error panel distance from edges
            int nErrorPanelSpace = this.Width - tbPanel.Width;

            for (int i = 1; i <= nfilesno; i++ )
            {
                Label lblFilesNumber = new Label();
                lblFilesNumber.Width = nLabelWidth;
                lblFilesNumber.Height = nLabelHeight;
                lblFilesNumber.Font = fLabelFont;
                lblFilesNumber.Name = strFilesNumberName + i;
                lblFilesNumber.Text = strFilesNumberText + i;
                lblFilesNumber.Location = new Point(nLabelX,nStartY + ( nTotalHeight * (i - 1)));
                this.Controls.Add(lblFilesNumber);

                Label lblOrderId = new Label();
                lblOrderId.Width = nLabelWidth;
                lblOrderId.Height = nLabelHeight;
                lblOrderId.Font = fLabelFont;
                lblOrderId.Name = strOrderIdLabelName + i;
                lblOrderId.Text = strOrderIdLabelText;
                lblOrderId.Location = new Point(nLabelX, nStartY + (nTotalHeight * (i - 1)) + (nTotalHeight / 2));
                this.Controls.Add(lblOrderId);

                TextBox tbOrderId = new TextBox();
                tbOrderId.Width = nInputWidth;
                tbOrderId.Height = nInputHeight;
                tbOrderId.Font = fInputFont;
                tbOrderId.Name = strOrderIdInputName + i;
                tbOrderId.RightToLeft = rtlInputAlign;
                tbOrderId.Location = new Point(lblOrderId.Location.X + lblOrderId.Width + 13, nStartY + (nTotalHeight * (i - 1)) + (nTotalHeight / 2) - 3);
                this.Controls.Add(tbOrderId);
            }

            this.Height = nStartY + (nTotalHeight * (int)nfilesno) + nOkButtonTopToFormBottom;
            //this.Width = flowLayoutPanel1.Location.X + flowLayoutPanel1.Width + (nPreviusWidth - nFlowLeft);
            tbPanel.Location = new Point(tbPanel.Location.X, this.Height - nErrorPanelYFromDownEdge);
            pbExecute.Location = new Point(this.Width - nOkButtonXFromLeftEdge, this.Height - nOkButtonYFromDwonEdge);
            lblExecute.Location = new Point(this.Width - nOkLabelXFromLeftEdge, this.Height - nOkLabelYFromDownEdge);
            pbLogo.Location = new Point(this.Width - nLogoXFromLeftEdge, pbLogo.Location.Y);
            tbPanel.Width = this.Width - nErrorPanelSpace;
        }

        //private void button1_click(object sender, EventArgs e)
        //{
        //    for (int i = 1; i <= nfilesno; i++)
        //    {
        //        tbPanel.Text = tbPanel.Text + this.Controls.Find(strOrderIdInputName + i, false).Single<Control>().Text + " , ";
        //    }
        //}
    }
}
