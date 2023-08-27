using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace Project01
{
    public partial class Update_Employee : KryptonForm
    {
        public string EmpID { get; set; }
        public Update_Employee(string empID)
        {
            InitializeComponent();
            EmpID = empID;  
        }
        EmployeeInfo obj = new EmployeeInfo();

        private void Update_Employee_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
            DataTable da = obj.display("SELECT EmpID FROM EmployeeInfo");           
            Update_EmpID.DataSource = da;
            Update_EmpID.DisplayMember = "EmpID";
            Update_EmpID.ValueMember = "EmpID";
        }

        private void Update_EmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Update_EmpID.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)Update_EmpID.SelectedItem;
                string empID = Convert.ToString(selectedRow["EmpID"]);
                string q ="SELECT First_name, Last_name,Address,telephone,email,DOB,Gender,position,Dep_id FROM EmployeeInfo WHERE EmpID = @EmpID";
                DataRow EID = obj.GetEmployeeID(empID, q);
                if (EID != null)
                {
                    Update_Fname.Text = EID["First_name"].ToString();
                    Update_Lname.Text = EID["Last_name"].ToString();
                    Update_address.Text = EID["Address"].ToString();
                    Update_TP.Text = EID["telephone"].ToString();
                    Update_Email.Text = EID["email"].ToString();
                    Update_DoB.Text = EID["DOB"].ToString();
                    Update_gender.Text = EID["Gender"].ToString();
                    Update_Positions.Text = EID["position"].ToString();
                    Update_DepID.Text = EID["Dep_id"].ToString();
                } 
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = Update_DoB.Value;
                DateTime maxAllowDate = DateTime.Today.AddYears(-18);

                if (!Regex.IsMatch(Update_Fname.Text, @"^[A-Z][a-zA-Z]{0,19}$"))
                {
                    lbl_Error_msg.Text = ("Invalid First Name!, First Name must be start with UpperCase and It should be below 20 characters.");
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Update_Fname.Focus();
                }
                else if (!Regex.IsMatch(Update_Lname.Text, @"^[A-Z][a-zA-Z]{0,19}$"))
                {
                    lbl_Error_msg.Text = ("Invalid Last Name!, Last Name must be start with UpperCase and It should be below 20 characters.");
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Update_Lname.Focus();
                }
                else if (string.IsNullOrEmpty(Update_address.Text) || Update_address.Text.Length > 50 || !char.IsUpper(Update_address.Text[0]))
                {
                    lbl_Error_msg.Text = ("Invalid address!, Address must be start with UpperCase and It should be below 50 characters.");
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Update_address.Focus();
                }
                else if (!Regex.IsMatch(Update_TP.Text, @"^\+94\d{9}$"))
                {
                    lbl_Error_msg.Text = "Enter a valid Sri Lankan Phone number. \nEx:+94711234567";
                    MessageBox.Show("Invalid Format\nFor example, valid formats is: +94711234567", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Update_TP.Focus();
                }
                else if (!Regex.IsMatch(Update_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    lbl_Error_msg.Text = "Enter a valid email. Ex:name@gmail.com";
                    Update_Email.Focus();
                }
                else if (selectedDate > maxAllowDate)
                {
                    lbl_Error_msg.Text = "Invalid Date of Birth! Date of Birth should be at least 18 years ago.";
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
                else
                {
                    string query = "Update EmployeeInfo set First_name='" + Update_Fname.Text + "',Last_name = '" + Update_Lname.Text + "',Address='" + Update_address.Text + "',telephone='" + Update_TP.Text + "',email='" + Update_Email.Text + "' ,DOB= '" + Update_DoB.Value + "',Gender='" + Update_gender.SelectedItem.ToString() + "',position='" + Update_Positions.SelectedItem.ToString() + "',Dep_ID='" + Update_DepID.SelectedItem.ToString() + "'Where EmpID ='" + Update_EmpID.Text + "'  ";
                    int line = obj.Save_Update_Delete(query);
                    if (line == 1)
                    {
                        MessageBox.Show("Data updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbl_Error_msg.Visible = false;
                    }
                    else
                        MessageBox.Show("Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            if (HR.Instance != null)
            {
                HR.Instance.Show();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Update_Employee obj = new Update_Employee(EmpID);
            this.Close();
            obj.Show();             
        }

        private void show_EmpID_Click(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
        }

        private void lbl_Error_msg_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

