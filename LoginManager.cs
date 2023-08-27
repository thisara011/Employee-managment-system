using ComponentFactory.Krypton.Navigator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Project01
{
    internal class LoginManager
    {
        SqlCommand cmd;
        SqlConnection con;
        

        public LoginManager()
        {
            con = new SqlConnection("Data Source=DESKTOP-NJ19TCF;Initial Catalog=EmployeeManagement;Integrated Security=True");
        }
        public bool AuthenticateUser(string username, string password, string Logintype )
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM Login WHERE Username = @Username AND Password = @Password and Login_Type=@Logintype", con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@LoginType", Logintype);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                return true; // Valid username and password
            }
            else
            {
                return false; // Invalid username or password
            }
        }
        public string LAuthenticateUser(string username)
        {
            string empID = ""; // Default value if the username is not found

            using (con)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT EmpID FROM login WHERE username = @username", con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        empID = result.ToString();
                    }
                }
                con.Close();
            }

            return empID;
        }
        public bool FLogAuthenticateUser(string empid, string username, string Logintype)
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM Login WHERE EmpID = @empid AND username = @username and Login_Type=@Logintype", con);
            cmd.Parameters.AddWithValue("@empid", empid);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@LoginType", Logintype);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                return true; // Valid username and password and login type
            }
            else
            {
                return false; // Invalid username or password and login type
            }
        }
 
        public void Logout()
        {
            // Perform any necessary cleanup tasks
            // Reset session variables, close open forms, etc.
            
            // Show the login form
            HOME h = new HOME();
            h.Show();
        }
    }

}
