using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows;
using System.Windows.Forms;

namespace Project01
{
    internal class EmployeeInfo
    {
        SqlConnection con;//Initiate the pipe line
        SqlCommand cmd;//Initiate the space ship
        SqlDataAdapter da;//iniate the basket
        SqlDataReader reader;
        public EmployeeInfo()//Default Constructor
        {
            con = new SqlConnection("Data Source=DESKTOP-NJ19TCF;Initial Catalog=EmployeeManagement;Integrated Security=True");
        }
        public int Save_Update_Delete(string q)
        {
            con.Open();
            cmd = new SqlCommand(q, con);//con meaning pipeline
            int i = cmd.ExecuteNonQuery();//execute inside database
            con.Close();
            return i;
        }
        public  DataTable display(string q)
        {
            con.Open();
            da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool IsEmployeeIdExists(string empId,string checkquery)
        {
            
            {
                con.Open();
                string c = checkquery;
                cmd = new SqlCommand(c, con);
                cmd .Parameters.AddWithValue("@EmpID", empId);
                int existingEmpCount = (int)cmd.ExecuteScalar();
                con.Close();
                return existingEmpCount > 0;
            }
        }
        public bool IsUsernameExists(string u)
        {

            { 
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM Login WHERE UserName = @UserName";
                cmd = new SqlCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@UserName", u);
                int existingUserCount = (int)cmd.ExecuteScalar();
                con.Close();
                return existingUserCount > 0;
            }
        }
        public bool IsSalEntered(string e, string m)
        {
            con.Open();
            string checkQuery = "SELECT COUNT(*) FROM salary  WHERE empId = @EmpId AND month = @Month";
            cmd = new SqlCommand(checkQuery, con);
            cmd.Parameters.AddWithValue("@EmpId", e);
            cmd.Parameters.AddWithValue("@Month", m);
            int existingUserCount = (int)cmd.ExecuteScalar();
            con.Close();
            return existingUserCount > 0;
        }
        public bool IsLeavePending(string e)
        {
            con.Open();
            string checkQuery = "SELECT COUNT(*) FROM LeaveRequest WHERE EmpID = @EmpID AND LeaveStatus = 'Pending'"; ;
            cmd = new SqlCommand(checkQuery, con);
            cmd.Parameters.AddWithValue("@EmpId", e);
            int pendingLeaveCount = (int)cmd.ExecuteScalar();
            con.Close();
            return pendingLeaveCount > 0;
        }
        public DataRow GetEmployeeID(string empID, string q)
        {
            DataRow EID = null;
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    using (reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        if (dt.Rows.Count > 0)
                        {
                            EID = dt.Rows[0];
                        }
                    }
                }
            }
            con.Close();
            return EID;
        }
        public DataRow GetEmpTel( string q)
        {
            DataRow TP = null;
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(q, con))
                {
                    
                    using (reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        if (dt.Rows.Count > 0)
                        {
                            TP = dt.Rows[0];
                        }
                    }
                }
            }
            con.Close();
            return TP;
        }
        
    }
}


