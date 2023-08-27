using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace Project01
{
    public partial class Delete_Employees : KryptonForm
    {
        public string EmpID { get; set; }
        public Delete_Employees(string empID)
        {
            InitializeComponent();
            EmpID = empID;
        }
        EmployeeInfo emp = new EmployeeInfo();

        private void Delete_Employees_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
            DataTable da = emp.display("SELECT EmpID FROM EmployeeInfo");
            Del_EmpID.DataSource = da;
            Del_EmpID.DisplayMember = "EmpID";
            Del_EmpID.ValueMember = "EmpID";
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string q1 = "Delete from salary Where EmpId='" + Del_EmpID.SelectedValue.ToString() + "' ";
            int l = emp.Save_Update_Delete(q1);
            if (l == 1)
            {
                MessageBox.Show("salary records under this EmpId, Delete successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string q2 = "Delete from Login Where EmpId='"+Del_EmpID.SelectedValue.ToString()+"' ";
            int l2 = emp.Save_Update_Delete(q2);
            if (l2 == 1)
            {
                MessageBox.Show("Login profile Delete successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string q3 = "Delete from LeaveRequest Where EmpId='" + Del_EmpID.SelectedValue.ToString() + "' ";
            int l3 = emp.Save_Update_Delete(q3);
            if (l3 == 1)
            {
                MessageBox.Show("Leave Request under this EmpId, Delete successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string query= "DELETE FROM EmployeeInfo WHERE EmpId= '"+Del_EmpID.SelectedValue.ToString()+"' ";
            int line = emp.Save_Update_Delete(query);
            if (line == 1)
            {
                MessageBox.Show("Delete successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Delete_Employees obj = new Delete_Employees(EmpID);
                this.Close();
                obj.Show();
            }
            else
                MessageBox.Show("Cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


       
        private void Del_EmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Del_EmpID.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)Del_EmpID.SelectedItem;
                string empID = Convert.ToString(selectedRow["EmpID"]);
                string q ="SELECT First_name, Last_name FROM EmployeeInfo WHERE EmpID = @EmpID";
                DataRow EID = emp.GetEmployeeID(empID, q);
               
                if (EID != null)
                {
                    Del_Fname.Text = EID["First_name"].ToString();
                    Del_Lname.Text = EID["Last_name"].ToString();
                }
                
            }
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
            Delete_Employees obj = new Delete_Employees(EmpID);
            this.Close();
            obj.Show();
        }

        
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            if (HR.Instance != null)
            {
                HR.Instance.Show();
            }
        }
    }
}
