using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace Project01
{
    public partial class Other : KryptonForm
    {
        public string EmpID { get; set; }
        public Other(string empID)
        {
            InitializeComponent();
            EmpID = empID;
        }



        private void Other_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginManager l = new LoginManager();
            this.Close();
            l.Logout();
        }

        private void btn_Leave_Req_Click(object sender, EventArgs e)
        {
            Leave_Request obj = new Leave_Request(EmpID);
            this.Hide();
            obj.ShowDialog();
        }

        private void btn_mypayroll_Click(object sender, EventArgs e)
        {
            Payrolls obj = new Payrolls(EmpID);
            this.Hide();
            obj.ShowDialog();
        }
    }
}
