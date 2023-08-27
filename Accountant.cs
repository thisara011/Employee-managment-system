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
    public partial class Accountant : KryptonForm
    {
        public string EmpID { get; set; }
        public Accountant(string empID)
        {
            InitializeComponent();
            EmpID = empID;
        }

        private void Accountant_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginManager l = new LoginManager();
            this.Close();
            l.Logout();

        }

        private void btn_calcu_salary_Click(object sender, EventArgs e)
        {
            salary_CAL obj = new salary_CAL(EmpID);
            this.Hide();
            obj.ShowDialog();
        }

        private void menuitem__leaveRequest_Click(object sender, EventArgs e)
        {
            Leave_Request obj = new Leave_Request(EmpID);
            this.Hide();
            obj.ShowDialog();
        }

        private void menuitem_payroll_Click(object sender, EventArgs e)
        {
            Payrolls obj = new Payrolls(EmpID);
            this.Hide();
            obj.ShowDialog();
        }

        private void View_sal_reports_Click(object sender, EventArgs e)
        {
            View_Salary_Reports obj = new View_Salary_Reports(EmpID);
            this.Hide();
            obj.ShowDialog();
        }
    }
}



