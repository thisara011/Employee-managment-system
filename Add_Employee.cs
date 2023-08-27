using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
    public partial class Add_Employee : KryptonForm
    {
        public string EmpID { get; set; }
        public Add_Employee(string empID)
        {
            InitializeComponent();
            EmpID = empID;  
        }
        EmployeeInfo obj = new EmployeeInfo();

        private void label10_Click(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
        }
        private void btn_AddNewEmp_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime selectedDate = Reg_DoB.Value;
                DateTime maxAllowDate = DateTime.Today.AddYears(-18);
                string empId = Reg_EmpID.Text;
                string checkQuery = "SELECT COUNT(*) FROM EmployeeInfo WHERE EmpID = @EmpID";

                if (!Regex.IsMatch(Reg_EmpID.Text, @"^^E\d{3}$"))
                {
                    lbl_Error_msg.Text = ("Invalid EmpID!, EmpId must be start with E and It should be 4 characters.");
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_EmpID.Focus();
                }

                else if (!Regex.IsMatch(Reg_Fname.Text, @"^[A-Z][a-zA-Z]{0,19}$"))
                {
                    lbl_Error_msg.Text = ("Invalid First Name!, First Name must be start with UpperCase and It should be below 20 characters.");
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_Fname.Focus();
                }
                else if (!Regex.IsMatch(Reg_Lname.Text, @"^[A-Z][a-zA-Z]{0,19}$"))
                {
                    lbl_Error_msg.Text = ("Invalid Last Name!, Last Name must be start with UpperCase and It should be below 20 characters.");
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_Lname.Focus();
                }
                else if (string.IsNullOrEmpty(Reg_address.Text) || Reg_address.Text.Length > 50 || !char.IsUpper(Reg_address.Text[0]))
                {
                    lbl_Error_msg.Text = ("Invalid address!, Address must be start with UpperCase and It should be below 50 characters.");
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_address.Focus();
                }
                else if (!Regex.IsMatch(Reg_TP.Text, @"^\+94\d{9}$"))
                {
                    lbl_Error_msg.Text = ("Invalid Sri Lankan mobile number. \nPlease enter a valid 9-digit number starting with +94.");
                    MessageBox.Show("Invalid Format\nFor example, valid formats is: +94711234567", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_TP.Focus();
                }
                else if (!Regex.IsMatch(Reg_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")) 
                {
                    lbl_Error_msg.Text = "Enter a valid email. Ex:name@gmail.com";
                    MessageBox.Show("Invalid Format\nFor example, Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_Email.Focus();
                }
                else if (selectedDate > maxAllowDate)
                {
                    lbl_Error_msg.Text = "Invalid Date of Birth! Date of Birth should be at least 18 years ago.";
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(Reg_gender.Text))
                {
                    lbl_Error_msg.Text = "Select Gender";
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_gender.Focus();
                }
                else if (string.IsNullOrEmpty(Reg_Positions.Text))
                {
                    lbl_Error_msg.Text = "Select Position";
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_Positions.Focus();
                }
                else if (string.IsNullOrEmpty(Reg_Dep_Id.Text))
                {
                    lbl_Error_msg.Text = "Select DepID";
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_Dep_Id.Focus();
                }
                else if (obj.IsEmployeeIdExists(empId, checkQuery))
                {
                    lbl_Error_msg.Text = "Employee ID already exists. Please choose a different ID.";
                    MessageBox.Show("I said again! Employee ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_EmpID.Focus();
                }
                else
                {
                    string query = "Insert into EmployeeInfo values('" + Reg_EmpID.Text + "','" + Reg_Fname.Text + "','" + Reg_Lname.Text + "','" + Reg_address.Text + "','" + Reg_TP.Text + "','" + Reg_Email.Text + "','" + Reg_DoB.Value + "','" + Reg_gender.SelectedItem.ToString() + "','" + Reg_Positions.SelectedItem.ToString() + "','" + Reg_Dep_Id.SelectedItem.ToString() + "')";
                    int line = obj.Save_Update_Delete(query);
                    if (line == 1)
                    {
                        MessageBox.Show("Data saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Add_Employee obj=new Add_Employee(EmpID);
                        this.Close();
                        obj.ShowDialog();
                    }                      
                    else
                        MessageBox.Show("Data Cannot save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void Add_Employee_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            if (HR.Instance != null)
            {
                HR.Instance.Show();
            }
        }

        private void txtbox_EmpId(object sender, EventArgs e)
        {
            try
            {
                //For check EmployeeId which already have saved in database
                string empId = Reg_EmpID.Text;
                string checkQuery = "SELECT COUNT(*) FROM EmployeeInfo WHERE EmpID = @EmpID";

                if (obj.IsEmployeeIdExists(empId,checkQuery))
                {
                    lbl_Error_msg.Text = "Employee ID already exists. Please choose a different ID.";
                    MessageBox.Show("I said again! Employee ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reg_EmpID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reg_EmpID.Clear();
            Reg_Fname.Clear();
            Reg_Lname.Clear();
            Reg_address.Clear();
            Reg_TP.Clear();
            Reg_Email.Clear();
            Reg_gender.SelectedIndex = -1;
            Reg_Positions.SelectedIndex = -1;
            Reg_Dep_Id.SelectedIndex = -1;
        }
    }
}
