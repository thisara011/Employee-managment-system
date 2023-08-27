using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace Project01
{
    public partial class CEO_View_Leaves : KryptonForm
    {
        EmployeeInfo obj = new EmployeeInfo();
        public string EmpID { get; set; }

        public CEO_View_Leaves(string empID)
        {
            InitializeComponent();
            EmpID = empID;
        }

        private void CEO_View_Leaves_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
            DataTable dt = obj.display("select EmpID from LeaveRequest where Leavestatus='pending'");
            combo_empID.DataSource = dt;
            combo_empID.DisplayMember = "EmpID";
            combo_empID.ValueMember = "EmpID";
            /***/
           
            string query = "SELECT LR.*, EI.First_Name AS Employee_Name " +
               "FROM LeaveRequest LR " +
               "JOIN EmployeeInfo EI ON LR.EmpId = EI.EmpID";
            Grid_Leave_View.DataSource = obj.display(query);

        }

        private void combo_empID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_empID.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)combo_empID.SelectedItem;
                string empID = Convert.ToString(selectedRow["EmpID"]);
                string q = "select * from LeaveRequest where empId=@EmpID AND leavestatus='Pending'";
                DataRow EID = obj.GetEmployeeID(empID, q);

                if (EID != null)
                {                       
                    leavetype_combo.Text = EID["LeaveType"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(EID["LeaveStartDate"]);
                    dateTimePicker2.Value = Convert.ToDateTime(EID["LeaveEndDate"]);
                    timeUnit_combo.Text = EID["TimeUnit"].ToString();
                    combo_status.Text = EID["LeaveStatus"].ToString();

                    DateTime startDate = dateTimePicker1.Value;//count dates
                    DateTime endDate = dateTimePicker2.Value;
                    TimeSpan timeSpan = endDate - startDate;
                    int numberOfDays = timeSpan.Days;
                    int totalDaysCount = numberOfDays + 1;
                    txt_Days.Text = totalDaysCount.ToString();

                }
            }
        }

        private void View_Leave_Update_Click(object sender, EventArgs e)
        {
            string query = "Update LeaveRequest set LeaveStatus = '" + combo_status.SelectedItem.ToString() + "'Where EmpID ='" + combo_empID.Text + "' and LeaveStatus='Pending'  ";
            int line = obj.Save_Update_Delete(query);

            if (line == 1)
            {
                MessageBox.Show("Leave Status Update Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fetch telephone number from the database
                string empID = combo_empID.Text;
                string q = "Select Telephone From EmployeeInfo where EmpID='" + empID + "'";
                DataRow EID = obj.GetEmployeeID(empID, q);

                if (EID != null)
                {
                    string telephone = EID["Telephone"].ToString();

                    // Use the telephone number to send an SMS
                    string status = combo_status.SelectedItem.ToString();
                    string message = $"Your Leave Request is {status}.";
                    SMS s = new SMS();
                    s.Send(message, telephone);

                    // After sending the SMS, navigate to the next form
                    CEO_View_Leaves objnew = new CEO_View_Leaves(EmpID);
                    this.Close();
                    objnew.Show();
                }
                else
                {
                    MessageBox.Show("Telephone number not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
                MessageBox.Show("Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void combo_Grid_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(combo_Grid_Status.SelectedIndex == 0) 
            {
                string query = "SELECT LR.*, EI.First_Name AS EmployeeFirstName " +
               "FROM LeaveRequest LR " +
               "JOIN EmployeeInfo EI ON LR.EmpId = EI.EmpID " +
               "WHERE  LR.LeaveStatus = 'Pending'";
                Grid_Leave_View.DataSource = obj.display(query);
            }
            else if(combo_Grid_Status.SelectedIndex==1)
            {
                string query = "SELECT LR.*, EI.First_Name AS EmployeeFirstName " +
               "FROM LeaveRequest LR " +
               "JOIN EmployeeInfo EI ON LR.EmpId = EI.EmpID " +
               "WHERE LR.LeaveStatus = 'Accepted'";
                Grid_Leave_View.DataSource = obj.display(query);
            }
            else if(combo_Grid_Status.SelectedIndex==2)
            {
                string query = "SELECT LR.*, EI.First_Name AS EmployeeFirstName " +
               "FROM LeaveRequest LR " +
               "JOIN EmployeeInfo EI ON LR.EmpId = EI.EmpID " +
               "WHERE  LR.LeaveStatus = 'Rejected'";
                Grid_Leave_View.DataSource = obj.display(query);
            }
            else if (combo_Grid_Status.SelectedIndex == 3)
            {
                string query = "SELECT LR.*, EI.First_Name AS Employee_Name " +
              "FROM LeaveRequest LR " +
              "JOIN EmployeeInfo EI ON LR.EmpId = EI.EmpID";
                Grid_Leave_View.DataSource = obj.display(query);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Executive_Management obj = new Executive_Management(EmpID);
            this.Close();
            obj.Show();
        }
    }
}

