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
    public partial class Payrolls : KryptonForm
    {
        public string EmpID { get; set; }
        
        public Payrolls(string empID)
        {
            InitializeComponent();
            EmpID = empID;  
        }
        EmployeeInfo obj = new EmployeeInfo();


        private void Payrolls_Load(object sender, EventArgs e)
        {
            lbl_emp_id.Text = EmpID;
            payrol_comboMonth.Visible=false;
            DataTable da = obj.display("SELECT month FROM salary Where EmpId = '" + lbl_emp_id.Text + "'");
            payrol_comboMonth.DataSource = da;
            payrol_comboMonth.DisplayMember = "month";
            payrol_comboMonth.ValueMember = "month";
            string query = "select * from salary Where EmpId = '" + lbl_emp_id.Text + "' ";
            GridView_MyPayroll.DataSource = obj.display(query);
        }

        private void all_Month_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            payrol_comboMonth.SelectedIndex = -1;
            string query = "select * from salary Where EmpId = '" + lbl_emp_id.Text + "' ";
            GridView_MyPayroll.DataSource = obj.display(query);
        }

        private void payrol_comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payrol_comboMonth.SelectedIndex != -1)
            {
                if (select_radiobtn.Checked)
                {
                    string query = "select * from salary Where EmpId = '" + lbl_emp_id.Text + "'and month='" + payrol_comboMonth.SelectedValue.ToString() + "' ";
                    GridView_MyPayroll.DataSource = obj.display(query);
                }
            }
        }

        private void select_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            payrol_comboMonth.Visible = select_radiobtn.Checked;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            
            string q = "SELECT Login_Type FROM Login WHERE EmpID = '"+EmpID+"'";
            DataRow EID = obj.GetEmployeeID(EmpID, q);

            if (EID != null)
            {
                string LT = EID["Login_Type"].ToString();
                if(LT == "HR")
                {
                    HR obj = new HR(EmpID);
                    this.Close();
                    obj.Show();
                }
                else if(LT== "Accountant")
                {
                    Accountant obj = new Accountant(EmpID);
                    this.Close();
                    obj.Show();
                }
                else if (LT== "Executive")
                {
                    Executive_Management obj = new Executive_Management(EmpID);
                    this.Close();
                    obj.Show();
                }
                else
                {
                    Other obj = new Other(EmpID);
                    this.Close();
                    obj.Show();
                }


            }

        }
    }
}
    