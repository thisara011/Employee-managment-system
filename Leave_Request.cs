using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace Project01
{

    public partial class Leave_Request : KryptonForm
    {
        public string EmpID { get; set; }
        public Leave_Request(string empID)
        {
            InitializeComponent();
            EmpID = empID;

        }
        EmployeeInfo obj = new EmployeeInfo();


        private void Leave_Request_Load(object sender, EventArgs e)
        {
            lbl_emp_ID.Text = EmpID;
            string query = "select * from LeaveRequest Where EmpId = '" + lbl_emp_ID.Text + "' ";
            dataGridView1.DataSource = obj.display(query);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string eid = lbl_emp_ID.Text.ToString();
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime maxAllowDate = DateTime.Today;
            try
            {
                if (string.IsNullOrEmpty(leavetype_combo.Text))
                {
                    MessageBox.Show("Select Leave Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    leavetype_combo.Focus();
                }
                else if (selectedDate < maxAllowDate)
                {
                    MessageBox.Show("Please Enter Correct Start Day", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedDate > dateTimePicker2.Value)
                {
                    MessageBox.Show("Start Date cannot be after End Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(leavetype_combo.Text))
                {
                    MessageBox.Show("Select Time Unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    leavetype_combo.Focus();
                }
                else if (obj.IsLeavePending(eid))
                {
                    MessageBox.Show("Sorry\nYou already have a pending leave request. Please wait for it to be approved or rejected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string query = "INSERT INTO LeaveRequest (EmpID, LeaveType, LeaveStartDate, LeaveEndDate,TimeUnit, LeaveStatus) " +
                              "VALUES ('" + lbl_emp_ID.Text + "','" + leavetype_combo.SelectedItem.ToString() + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + timeUnit_combo.SelectedItem.ToString() + "','Pending')";
                    int line = obj.Save_Update_Delete(query);
                    if (line == 1)
                    {
                        MessageBox.Show("Data Submit successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Leave_Request l1 = new Leave_Request(EmpID);
                        this.Close();
                        l1.Show();

                    }

                    else
                        MessageBox.Show("Data Cannot save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            leavetype_combo.SelectedIndex = -1;
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
                else if (LT == "Accountant")
                {
                    Accountant obj = new Accountant(EmpID);
                    this.Close();
                    obj.Show();
                }
                else if (LT == "Executive")
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
