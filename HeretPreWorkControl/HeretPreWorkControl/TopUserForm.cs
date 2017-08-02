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
    public partial class TopUserForm : Form
    {
        public TopUserForm()
        {
            InitializeComponent();
        }

        private void TopUserForm_Load(object sender, EventArgs e)
        {
            lblHello.Text = "שלום " + Globals.Name;
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            new CreateUserForm().Show();
        }
    }
}
