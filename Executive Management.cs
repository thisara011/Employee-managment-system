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
    public partial class Executive_Management : KryptonForm
    {
        public string EmpID { get; set; }
        public Executive_Management(string empID)
        {
            InitializeComponent();
            EmpID = empID;  
        }

        private void Executive_Management_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
        }

        private void btn_view_leave_req_Click(object sender, EventArgs e)
        {
            CEO_View_Leaves obj = new CEO_View_Leaves(EmpID);
            this.Hide();
            obj.ShowDialog();
        }

        private void btn_ViewEmpDetails_Click(object sender, EventArgs e)
        {
            View_Emp_Details obj = new View_Emp_Details(EmpID);
            this.Hide(); 
            obj.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginManager l = new LoginManager();
            this.Close();
            l.Logout();
        }

        private void btn_Announcement_Click(object sender, EventArgs e)
        {
            Send_Announcement obj = new Send_Announcement (EmpID);
            this.Hide();
            obj.ShowDialog();
        }

        private void View_sal_reports_Click(object sender, EventArgs e)
        {
            View_Salary_Reports obj = new View_Salary_Reports(EmpID);
            this.Hide();
            obj.ShowDialog();
        }

        private void btn_ViewLeave_Report_Click(object sender, EventArgs e)
        {
            CEO_View_Leave_Reports obj = new CEO_View_Leave_Reports(EmpID);
            this.Hide();
            obj.ShowDialog();
        }
    }
}
