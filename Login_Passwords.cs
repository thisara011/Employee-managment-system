using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace Project01
{
    public partial class Login_Passwords : KryptonForm
    {
        public string EmpID { get; set; }
        public Login_Passwords(string empID)
        {
            InitializeComponent();
            EmpID = empID;  
        }
        EmployeeInfo obj = new EmployeeInfo();

        private void Login_Passwords_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;    
            pws_box.UseSystemPasswordChar=true;
            DataTable dt = obj.display("SELECT EmpID FROM EmployeeInfo");
            Pword_select.DataSource = dt;
            Pword_select.DisplayMember = "EmpID";
            Pword_select.ValueMember = "EmpID"; 
            // clear all the boxes when loading form. user must select to load info
            Pword_select.SelectedIndex = -1;
            pword_username.Clear();
            pws_box.Clear();
            Login_type_box.SelectedIndex = -1;
            
        }       

        private void Pword_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pword_select.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)Pword_select.SelectedItem;
                string empID = Convert.ToString(selectedRow["EmpID"]);
                string q ="SELECT UserName,Password,login_type FROM Login WHERE EmpID = @EmpID";
                DataRow EID = obj.GetEmployeeID(empID, q);
                if (EID != null)
                {
                    pword_username.Text = EID["username"].ToString();
                    pws_box.Text = EID["Password"].ToString();
                    Login_type_box.Text = EID["login_Type"].ToString();
                }
                else
                {
                    pword_username.Text = "";
                    pws_box.Text = "";
                    Login_type_box.SelectedIndex=-1;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string u = pword_username.Text;
                string emp = Pword_select.Text;
                string checkquery = "SELECT COUNT(*) FROM login WHERE EmpID = @EmpID";

                if (obj.IsUsernameExists(u))
                {
                    lbl_Error_msg.Text = " User Name already exists. Please choose a different ID.";
                    MessageBox.Show("User Name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pword_username.Focus();
                }
                else if(obj.IsEmployeeIdExists(emp,checkquery))
                {
                    lbl_Error_msg.Text = "This employee already has login profile\n cannot create another profile under same EmpID.";
                    MessageBox.Show("This EmpID has already Profile!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(pword_username.Text) || pword_username.Text.Length > 20 || !char.IsUpper(pword_username.Text[0]))
                {
                    lbl_Error_msg.Text = ("Invalid User Name!, User Name must be start with UpperCase and It should be below 20 characters.");
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pword_username.Focus();
                }
                else if (!Regex.IsMatch(pws_box.Text, @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&(){}[\]:;<>,.?/~_+\-=|]).{8,12}$"))
                {
                    lbl_Error_msg.Text = "Invalid Password! \nPassword must be 8 to 12 characters long and include at least one digit, \none lowercase letter, \none uppercase letter, and one special character.";
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pws_box.Focus();
                }
                else if (string.IsNullOrEmpty(Login_type_box.Text))
                {
                    lbl_Error_msg.Text = "Select Login Type";
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Login_type_box.Focus();
                }
                else
                {
                    string query = "Insert into Login values('" + Pword_select.Text + "','" + pword_username.Text + "','" + pws_box.Text + "','"+Login_type_box.SelectedItem.ToString()+"')";
                    int line = obj.Save_Update_Delete(query);
                    if (line == 1)
                    {
                        MessageBox.Show("Data updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string empID = Pword_select.Text;
                        string q = "Select Telephone,First_Name From EmployeeInfo where EmpID='" + empID + "'";
                        DataRow EID = obj.GetEmployeeID(empID, q);
                        if (EID != null)
                        {
                            string telephone = EID["Telephone"].ToString();
                            string fname = EID["First_Name"].ToString();
                            string username = pword_username.Text;
                            string password = pws_box.Text;
                            string loginType = Login_type_box.SelectedItem.ToString();
                            string message = $"Welcome {fname}!\n\nYour Company Login Profile has been successfully created.\n\nusername : {username}\npassword : {password}\nlogin Type : {loginType} \n\nBest regards,\nCyberNex ";
                            SMS s = new SMS();
                            s.Send(message, telephone);

                            Login_Passwords login_Passwords = new Login_Passwords(EmpID);
                            this.Close();
                            login_Passwords.Show();
                        }                       
                    }
                    else
                        MessageBox.Show("Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Cannot duplicate EmpId" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                lbl_Error_msg.Text = ex.Message + "\nCannot create Duplicate Login Profiles in same EmpId!!\nPlease Refresh the Page & Try again Correctly ";
            }
            catch(Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!Regex.IsMatch(pws_box.Text, @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&(){}[\]:;<>,.?/~_+\-=|]).{8,12}$"))
                {
                    lbl_Error_msg.Text = "Invalid Password! \nPassword must be 8 to 12 characters long and include at least one digit, \none lowercase letter, \none uppercase letter, and one special character.";
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pws_box.Focus();
                }
                else
                {
                    string query = "Update Login set Password = '" + pws_box.Text + "',login_type='"+Login_type_box.Text+"'Where EmpID ='" + Pword_select.Text + "'  ";
                    int line = obj.Save_Update_Delete(query);
                    if (line == 1)
                    {
                        MessageBox.Show("Data updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbl_Error_msg.Visible = false;
                        string empID = Pword_select.Text;
                        string q = "Select Telephone,First_Name From EmployeeInfo where EmpID='" + empID + "'";
                        DataRow EID = obj.GetEmployeeID(empID, q);
                        if (EID != null)
                        {
                            string telephone = EID["Telephone"].ToString();
                            string fname = EID["First_Name"].ToString();
                            string username = pword_username.Text;
                            string password = pws_box.Text;
                            string loginType = Login_type_box.SelectedItem.ToString();
                            string message = $"Dear {fname}!\n\nYour Company Login Profile has been updated. Please find your updated login details below:\n\nusername : {username}\npassword : {password}\nlogin Type : {loginType} \n\nBest regards,\nCyberNex ";
                            SMS s = new SMS();
                            s.Send(message, telephone);

                            Login_Passwords login_Passwords = new Login_Passwords(EmpID);
                            this.Close();
                            login_Passwords.Show();
                        }

                    }
                    else
                        MessageBox.Show("Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void pws_view_Click(object sender, EventArgs e)
        {
            pws_box.UseSystemPasswordChar = !pws_box.UseSystemPasswordChar;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Login_Passwords obj = new Login_Passwords(EmpID);
            this.Close();
            obj.Show();
            lbl_Error_msg.Visible=false;
        }

        private void pword_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_Error_msg_Paint(object sender, PaintEventArgs e)
        {
                               

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
