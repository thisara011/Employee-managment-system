using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace Project01
{
    public partial class HR : KryptonForm
    {
        public static HR Instance { get; private set; }
        public string EmpID { get; set; }

        public HR(string empID)
        {
            InitializeComponent();
            Instance = this;
            EmpID = empID;
        }

        private void HR_Load(object sender, EventArgs e)
        {
            lbl_empID.Text = EmpID;
        }

        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            Add_Employee add_Employee = new Add_Employee(EmpID);
            this.Hide();
            add_Employee.ShowDialog();

        }

        private void btn_del_emp_Click(object sender, EventArgs e)
        {
            Delete_Employees obj = new Delete_Employees(EmpID);
            this.Hide();
            obj.Show();

        }

        private void btn_update_emp_Click(object sender, EventArgs e)
        {
            Update_Employee obj = new Update_Employee(EmpID);
            this.Hide();
            obj.ShowDialog();
        }

        private void btn_Create_UserName_Pws_Click(object sender, EventArgs e)
        {
            Login_Passwords obj = new Login_Passwords(EmpID);
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

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginManager l = new LoginManager();
            this.Close();
            l.Logout();
        }

        private void btn_ViewEmpDetails_Click(object sender, EventArgs e)
        {
            View_Emp_Details obj = new View_Emp_Details(EmpID);
            this.Hide();
            obj.ShowDialog();
        }
    }
}
