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
using Microsoft.Reporting.WinForms;

namespace Project01
{
    public partial class CEO_View_Leave_Reports : KryptonForm
    {
        public string EmpID { get; set; }
        public CEO_View_Leave_Reports(string empID)
        {
            InitializeComponent();
            EmpID = empID;
        }
        EmployeeInfo obj = new EmployeeInfo();  

        private void View_Leave_Reports_Load(object sender, EventArgs e)
        {
               
        }

        private void Select_Emp_ID_CheckedChanged(object sender, EventArgs e)
        {     
            if(Select_Emp_ID.Checked)
            {
                Combo_Select_Emp_ID.Visible = true;
                combo_DepID.Visible = false;
            }
        }

       
      

        private void Combo_Select_Emp_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Select_Emp_ID.SelectedItem != null)
            {
                string empID = Combo_Select_Emp_ID.SelectedValue.ToString();
                this.leaveRequestTableAdapter.Fill1(this.dataSet2.LeaveRequest, empID);
                this.SalreportViewer1.RefreshReport();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
          
        }

        private void combo_DepID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_DepID.SelectedItem != null)
            {
                string depID = combo_DepID.Text.ToString();
                this.leaveRequestTableAdapter.Fill(this.dataSet2.LeaveRequest, depID);
                this.SalreportViewer1.RefreshReport();
            }
        }

        private void radio_dep_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_dep.Checked)
            {
                combo_DepID.Visible = true;
                Combo_Select_Emp_ID.Visible = false;
            }
        }

        private void radio_allEmp_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_allEmp.Checked)
            {
                Combo_Select_Emp_ID.Visible = false;
                combo_DepID.Visible = false;
                this.leaveRequestTableAdapter.FillBy(this.dataSet2.LeaveRequest);
                this.SalreportViewer1.RefreshReport();
            }
        }

        private void CEO_View_Leave_Reports_Load(object sender, EventArgs e)
        {
      
            // TODO: This line of code loads data into the 'dataSet2.LeaveRequest' table. You can move, or remove it, as needed.

            lbl_emp_id.Text = EmpID;
            Combo_Select_Emp_ID.Visible = false;
            combo_DepID.Visible = false;
            DataTable da = obj.display("SELECT DISTINCT EmpID FROM leaveRequest");
            Combo_Select_Emp_ID.DataSource = da;
            Combo_Select_Emp_ID.DisplayMember = "EmpID";
            Combo_Select_Emp_ID.ValueMember = "EmpID";
            this.SalreportViewer1.RefreshReport();

            this.SalreportViewer1.RefreshReport();
            this.SalreportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Executive_Management obj = new Executive_Management(EmpID);
            this.Close();
            obj.Show();

        }
    }
    
}
