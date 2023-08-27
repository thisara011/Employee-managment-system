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
    public partial class Send_Announcement : KryptonForm
    {
        public string EmpID { get; set; }
        public Send_Announcement(string empID)
        {
            InitializeComponent();
            EmpID = empID;
        }
        EmployeeInfo obj = new EmployeeInfo();

        private void Send_Announcement_Load(object sender, EventArgs e)
        {
            show_EmpID.Text = EmpID;
            txt_Fname.Visible = false;
            Select_EmpID_combo.Visible = false;
            Select_Positions.Visible = false;
            show_EmpID.Text = EmpID;
            DataTable dt = obj.display("select EmpID from EmployeeInfo");
            Select_EmpID_combo.DataSource = dt;
            Select_EmpID_combo.DisplayMember = "EmpID";
            Select_EmpID_combo.ValueMember = "EmpID";
            
        }

        private void radio_allEmp_CheckedChanged(object sender, EventArgs e)
        {
            Select_EmpID_combo.SelectedIndex = -1;
            txt_Fname.Visible = false;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio_allEmp.Checked)
                {
                    try
                    {
                        string message = msgText_box.Text.ToString();
                        string query = "SELECT Telephone FROM EmployeeInfo";
                        DataTable recipientNumbers = obj.display(query);
                        if (recipientNumbers != null)
                        {

                            SMS sMS = new SMS();
                            int count=sMS.SendALL(message, recipientNumbers);
                            if (count > 0) 
                            {
                                MessageBox.Show("Message sent to all the Employees.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //after sent
                                Send_Announcement obj = new Send_Announcement(EmpID);
                                this.Close();
                                obj.Show();
                            }
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error getting phone numbers or sending messages: " + ex.Message);
                    }
                }
                else if (radio_selectEmp.Checked)
                {
                    if (Select_EmpID_combo.SelectedItem != null)
                    {
                        string message = msgText_box.Text.ToString();
                        DataRowView selectedRow = (DataRowView)Select_EmpID_combo.SelectedItem;
                        string empID = Convert.ToString(selectedRow["EmpID"]);
                        string q = "select Telephone from EmployeeInfo where empId=@EmpID ";
                        DataRow EID = obj.GetEmployeeID(empID, q);
                        if (EID != null)
                        {
                            string telephone = EID["Telephone"].ToString();
                            SMS sMS = new SMS();
                            sMS.Send(message, telephone);

                            //after sent
                            Send_Announcement obj = new Send_Announcement(EmpID);
                            this.Close();
                            obj.Show();
                        }
                    }
                }
                else if (rad_Position.Checked)
                {
                    if (Select_Positions.SelectedItem != null)
                    {
                        try
                        {
                            string message = msgText_box.Text.ToString();
                            string query = "SELECT Telephone FROM EmployeeInfo where Position='" + Select_Positions.SelectedItem.ToString() + "'";
                            DataTable recipientNumbers = obj.display(query);
                            if (recipientNumbers != null)
                            {

                                SMS sMS = new SMS();
                                int count = sMS.SendALL(message, recipientNumbers);
                                if (count > 0)
                                {
                                    MessageBox.Show("Message sent to the Selected Position.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //after sent
                                    Send_Announcement obj = new Send_Announcement(EmpID);
                                    this.Close();
                                    obj.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("There are No Telephone Under this Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error getting phone numbers or sending messages: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Position!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radio_selectEmp_CheckedChanged(object sender, EventArgs e)
        {
            Select_EmpID_combo.Visible = radio_selectEmp.Checked;
            txt_Fname.Visible = radio_selectEmp.Checked;
            txt_Fname.Clear();

        }

        private void Select_EmpID_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Select_EmpID_combo.SelectedItem != null)
                {
                    DataRowView selectedRow = (DataRowView)Select_EmpID_combo.SelectedItem;
                    string empID = Convert.ToString(selectedRow["EmpID"]);
                    string q = "select First_name,Telephone from EmployeeInfo where empId=@EmpID ";
                    DataRow EID = obj.GetEmployeeID(empID, q);
                    if (EID != null)
                    {
                        txt_Fname.Text = EID["First_Name"].ToString();
                    }
                }
                else
                {
                    txt_Fname.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rad_Position_CheckedChanged(object sender, EventArgs e)
        {
            Select_Positions.Visible=rad_Position.Checked;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Executive_Management obj = new Executive_Management(EmpID);
            this.Close();
            obj.Show();   
        }
    }
}
