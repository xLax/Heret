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
    public partial class AddEmployeeForm : Form
    {
        private tbl_employees currEmployee = new tbl_employees();
        private List<tbl_employees> lstCurrEmployees = new List<tbl_employees>();

        public AddEmployeeForm()
        {
            InitializeComponent();

            lbDepartment.Items.Add(Globals.StudioUserType);
            lbDepartment.Items.Add(Globals.KadasUserType);
            lbDepartment.Items.Add(Globals.OrdersUserType);
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            Utilities.GetAllMyEmployees();
        }

        private void AddEmployeeForm_KeyUp(object sender, KeyEventArgs e)
       {
            if(e.KeyValue == Globals.KeyValueEnter)
            {
                
            }
        }

        private void SearchAndUpdateCurrEmployee()
        {
            lstCurrEmployees = Globals.AllMyEmployees.
                    Where(a => a.name.Equals(tbWorkerName.Text.ToString()))
                        .ToList<tbl_employees>();

            if (lstCurrEmployees.Count == 0)
            {
                tbPanel.Text = "לא נמצא עובד בשם זה";
                this.currEmployee = null;
            }
            else if (lstCurrEmployees.Count == 1)
            {
                this.currEmployee = lstCurrEmployees[0];

                string strDepartmentDesc = this.GetDepartmentDescFromID(this.currEmployee.Department_id);
                lbDepartment.SelectedItem = strDepartmentDesc;
            }
            else
            {
                tbPanel.Text = "יש יותר מעובד אחד בשם זה";
                this.currEmployee = null;
                this.pbAddEmplyee.Enabled = false;
            }
        }

        private string GetDepartmentDescFromID(int nDepartmentID)
        {
            switch (nDepartmentID)
            {
                case (Globals.StudioUserID):
                    return Globals.StudioUserType;
                case (Globals.KadasUserID):
                    return Globals.KadasUserType;
                case (Globals.OrdersUserID):
                    return Globals.OrdersUserType;
            }

            return null;
        }

        private int GetDepartmentIDFromDesc()
        {
            switch (lbDepartment.SelectedItem)
            {
                case (Globals.StudioUserType):
                    return Globals.StudioUserID;
                case (Globals.KadasUserType):
                    return Globals.KadasUserID;
                case (Globals.OrdersUserType):
                    return Globals.OrdersUserID;
            }

            return 0;
        }

        private void pbAddEmplyee_Click(object sender, EventArgs e)
        {
            this.SearchAndUpdateCurrEmployee();

            if (this.currEmployee == null)
            {
                if (lbDepartment.SelectedItem == null)
                {
                    tbPanel.Text = "שגיאה ! עליך לבחור מחלקה";
                }
                else
                {
                    try
                    {
                        using (var context = new DB_Entities())
                        {
                            tbl_employees myEmployee = new tbl_employees();

                            myEmployee.ID = Utilities.GetNextEmployeeID();
                            myEmployee.Department_id = this.GetDepartmentIDFromDesc();
                            myEmployee.name = tbWorkerName.Text.ToString();

                            context.tbl_employees.Add(myEmployee);

                            context.SaveChanges();

                            tbPanel.Text = "העובד נוצר בהצלחה !";

                            Globals.AllMyEmployees.Add(myEmployee);
                        }
                    }
                    catch (Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל!";
                    }
                }
            }
            else
            {
                tbPanel.Text = "שים לב! עליך לבחור שם ייחודי לעובד";
            }
        }

        private void pbDeleteEmp_Click(object sender, EventArgs e)
        {
            this.SearchAndUpdateCurrEmployee();

            if (this.currEmployee != null)
            {
                using (var context = new DB_Entities())
                {
                    try
                    {
                        List<tbl_sla_data> lstSlaDataOfEmployee =
                                context.tbl_sla_data.Where(s => s.employee_name != null &&
                                                           s.employee_name.Equals(this.currEmployee.name))
                                                      .ToList<tbl_sla_data>();

                        context.tbl_sla_data.RemoveRange(lstSlaDataOfEmployee);

                        context.tbl_employees.Attach(this.currEmployee);
                        context.tbl_employees.Remove(this.currEmployee);

                        context.SaveChanges();

                        tbPanel.Text = "העובד ורשומותיו נמחקו בהצלחה";
                    }
                    catch (Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל!";
                    }
                }
            }
        }
    }
}
