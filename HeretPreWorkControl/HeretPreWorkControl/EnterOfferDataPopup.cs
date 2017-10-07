using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeretPreWorkControl
{
    public partial class EnterOfferDataPopup : Form
    {
        private int OrderID;

        public EnterOfferDataPopup(int nOrderID)
        {
            InitializeComponent();

            this.OrderID = nOrderID;
        }

        private void EnterOfferDataPopup_Load(object sender, EventArgs e)
        {
            dtSalesOfferDate.Format = DateTimePickerFormat.Custom;
            dtSalesOfferDate.CustomFormat = "dd/MM/yyyy";
            dtSalesOfferDate.MaxDate = DateTime.Today;
            dtSalesOfferDate.Value = DateTime.Today.Date;
        }

        private void pbInsertButton_Click(object sender, EventArgs e)
        {
            string strOfferID = tbSalesOfferID.Text.ToString();

            if(strOfferID.Equals(String.Empty))
            {
                tbPanel.Text = "שגיאה! עליך להזין מספר הצעה";
                tbSalesOfferID.BackColor = Color.Tomato;
            }
            else
            {
                tbl_offers currOffer = new tbl_offers();

                tbSalesOfferID.BackColor = Color.White;

                currOffer.offer_date = dtSalesOfferDate.Value.Date;
                currOffer.order_id = this.OrderID;
                currOffer.offer_id = strOfferID;

                using (var context = new DB_Entities())
                {
                    try
                    {
                        context.tbl_offers.AddOrUpdate(currOffer);
                        context.SaveChanges();

                        tbPanel.Text = "פרטי ההצעה הוזנו בהצלחה! ";
                    }
                    catch(Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }
                }
            }
            
        }

        private void EnterOfferDataPopup_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == Globals.KeyValueEnter)
            {
                this.pbInsertButton_Click(new object(), new EventArgs());
            }
        }
    }
}
