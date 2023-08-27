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
    public partial class View_Emp_Details : KryptonForm
    {
        public string EmpID { get; set; }
        public View_Emp_Details(string empID)
        {
            InitializeComponent();
            EmpID = empID;  
        }
        EmployeeInfo obj = new EmployeeInfo();

        private void View_Emp_Details_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
            Select_EmpID_combo.Visible = false;
            DataTable da = obj.display("SELECT empid FROM EmployeeInfo ");
            Select_EmpID_combo.DataSource = da;
            Select_EmpID_combo.DisplayMember = "empid";
            Select_EmpID_combo.ValueMember = "empid";
        }

        private void all_emp_CheckedChanged(object sender, EventArgs e)
        {           
            string query = "SELECT * FROM EmployeeInfo ";
            View_EmpGridView.DataSource = obj.display(query);
        }

        private void Select_EmpID_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Select_EmpID_combo.SelectedIndex != -1)
            {
                if (Select_Emp.Checked)
                {
                    string query = "select * from EmployeeInfo Where EmpId = '" + Select_EmpID_combo.SelectedValue.ToString() + "'";
                    View_EmpGridView.DataSource = obj.display(query);
                }
            }
        }

        private void Select_Emp_CheckedChanged(object sender, EventArgs e)
        {
            Select_EmpID_combo.Visible=Select_Emp.Checked;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            string q = "SELECT Login_Type FROM Login WHERE EmpID = '" + EmpID + "'";
            DataRow EID = obj.GetEmployeeID(EmpID, q);

            if (EID != null)
            {
                string LT = EID["Login_Type"].ToString();
                if (LT == "HR")
                {
                    HR obj = new HR(EmpID);
                    this.Close();
                    obj.Show();
                }
                
                else 
                {
                    Executive_Management obj = new Executive_Management(EmpID);
                    this.Close();
                    obj.Show();
                }
            }
        }
    }
}
