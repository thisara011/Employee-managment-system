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
using PasswordTextBoxControl;

namespace Project01
{
    public partial class LOGIN :KryptonForm
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        LoginManager loginManager = new LoginManager();    
        private void LOGIN_Load(object sender, EventArgs e)
        {
            Login_Pword.UseSystemPasswordChar = true;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login_type.Text))
            {                
                MessageBox.Show("Select relevent Login Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login_type.Focus();
            }
            else if (string.IsNullOrEmpty(Login_Uname.Text))
            {
                MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login_Uname.Focus();
            }
            else if(string.IsNullOrEmpty(Login_Pword.Text))
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login_Pword.Focus();
            }
            else
            {
                string enteredUsername = Login_Uname.Text;
                string enteredPassword = Login_Pword.Text;
                string selectedLoginType = Login_type.Text;

                if (Login_type.SelectedIndex == 0)
                {
                    bool isAuthenticated = loginManager.AuthenticateUser(enteredUsername, enteredPassword, selectedLoginType);

                    if (isAuthenticated)
                    {
                        // Grant access to the user
                        MessageBox.Show("Login successful. Access granted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Open the main form or perform other actions
                        //get EMpId
                        string i = loginManager.LAuthenticateUser(enteredUsername);
                        Executive_Management obj = new Executive_Management(i);
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else
                    {
                        // Invalid username or password
                        MessageBox.Show("Invalid username or password or wrong Login Type!!. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Login_type.SelectedIndex == 1)
                {
                    bool isAuthenticated = loginManager.AuthenticateUser(enteredUsername, enteredPassword, selectedLoginType);

                    if (isAuthenticated)
                    {
                        // Grant access to the user
                        MessageBox.Show("Login successful. Access granted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Open the main form or perform other actions
                        string empID = loginManager.LAuthenticateUser(enteredUsername);
                        HR obj = new HR(empID);
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else
                    {
                        // Invalid username or password
                        MessageBox.Show("Invalid username or password or wrong Login Type!!. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Login_type.SelectedIndex == 2)
                {
                    bool isAuthenticated = loginManager.AuthenticateUser(enteredUsername, enteredPassword, selectedLoginType);

                    if (isAuthenticated)
                    {
                        // Grant access to the user
                        MessageBox.Show("Login successful. Access granted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Open the main form or perform other actions
                        string empID = loginManager.LAuthenticateUser(enteredUsername);
                        Accountant obj = new Accountant(empID);
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else
                    {
                        // Invalid username or password
                        MessageBox.Show("Invalid username or password or wrong Login Type!!. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Login_type.SelectedIndex == 3)
                {
                    bool isAuthenticated = loginManager.AuthenticateUser(enteredUsername, enteredPassword, selectedLoginType);

                    if (isAuthenticated)
                    {
                        // Grant access to the user
                        MessageBox.Show("Login successful. Access granted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Open the main form or perform other actions
                        string empID = loginManager.LAuthenticateUser(enteredUsername);
                        Other obj = new Other(empID);
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else
                    {
                        // Invalid username or password
                        MessageBox.Show("Invalid username or password or wrong Login Type!!. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Login_Pword.Clear();
            Login_Uname.Clear();
            Login_type.SelectedIndex=-1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HOME obj = new HOME();
            this.Close();
            obj.Show();
        }

        private void Forget_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Fogot_Password obj = new Fogot_Password();
            this.Close();
            obj.ShowDialog();
        }
    }
}
