using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;


namespace Project01
{
    public partial class salary_CAL : KryptonForm
    {
        public string EmpID { get; set; }

        public salary_CAL(string EmpId)
        {
            InitializeComponent();
            // Initialize the MonthCalendar control
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;

            // Add the MonthCalendar control to the form
            Controls.Add(monthCalendar1);
            EmpID = EmpId;
        }
        
        Calculte_salary_Logic logic = new Calculte_salary_Logic();
        EmployeeInfo obj = new EmployeeInfo();
        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salary_CAL_Load(object sender, EventArgs e)
        { 
            DataTable dt = obj.display("SELECT EmpID FROM EmployeeInfo");
            txt_CalSal_EmpID.DataSource = dt;
            txt_CalSal_EmpID.DisplayMember = "EmpID";
            txt_CalSal_EmpID.ValueMember = "EmpID";
        }

        private void txt_CalSal_EmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_CalSal_EmpID.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)txt_CalSal_EmpID.SelectedItem;
                string empID = Convert.ToString(selectedRow["EmpID"]);
                string q ="SELECT First_name,position FROM EmployeeInfo WHERE EmpID = @EmpID";
                DataRow EID = obj.GetEmployeeID(empID, q);
                if (EID != null)
                {
                    txt_CalSal_Name.Text = EID["First_name"].ToString();
                    Cal_Sal_Position.Text = EID["position"].ToString();
                }
            }
        }

        private void btn_CalSal_SAVE_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string empId = txt_CalSal_EmpID.Text;
                    string month = txt_CalSal_month.Text;
                    if (string.IsNullOrEmpty(txt_CalSal_NetSal.Text))
                    {
                        MessageBox.Show("Please click calculate button before save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txt_CalSal_month.Text))
                    {
                        MessageBox.Show("Please select Month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txt_SalCal_OThours.Text))
                    {
                        MessageBox.Show("Please Enter OtHours\nIf there is no OT hours pls input as 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txt_CalSal_Bonus.Text))
                    {
                        MessageBox.Show("Please Enter Bonus\nIf there is no bouns pls input as 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    else if (obj.IsSalEntered(empId, month))
                    {
                        MessageBox.Show("Salary already Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_CalSal_month.Focus();
                    }
                    else
                    {
                        string query = "Insert into salary values('" + txt_CalSal_EmpID.Text + "','" + txt_CalSal_Name.Text + "','" + decimal.Parse(txt_CalSal_Bsal.Text) + "','" + int.Parse(txt_SalCal_OThours.Text) + "','" + decimal.Parse(txt_CalSal_OTamount.Text) + "','" + decimal.Parse(txt_CalSal_TAX.Text) + "','" + decimal.Parse(txt_CalSal_ETF.Text) + "','" + decimal.Parse(txt_CalSal_Bonus.Text) + "','" + decimal.Parse(txt_CalSal_totEarning.Text) + "','" + decimal.Parse(txt_CalSal_Deductions.Text) + "','" + decimal.Parse(txt_CalSal_NetSal.Text) + "','" + txt_CalSal_month.Text + "')";
                        int line = obj.Save_Update_Delete(query);

                        if (line == 1)
                        {
                            MessageBox.Show("Data saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string empID=txt_CalSal_EmpID.Text.ToString();
                            string q = "Select Telephone From EmployeeInfo where EmpID='" + empID + "'";
                            DataRow EID = obj.GetEmployeeID(empID, q);
                            if (EID != null)
                            {
                                string telephone = EID["Telephone"].ToString();

                                // Use the telephone number to send an SMS

                                string message = "We would like to inform you that the Salary Report has been processed";
                                SMS s = new SMS();
                                s.Send(message, telephone);

                                // After sending the SMS, navigate to the next form
                                salary_CAL obj = new salary_CAL(EmpID);
                                this.Close();
                                obj.Show();
                            }
                            
                        }
                        else
                            MessageBox.Show("Data Cannot save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Error\n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salary_CAL obj = new salary_CAL(EmpID);
                    this.Close();
                    obj.Show();
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Error\n" + ex,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_CalSal_CAL_Click(object sender, EventArgs e)
        {
            try
            {
                double basic = Convert.ToDouble(txt_CalSal_Bsal.Text);
                double ot_hours = Convert.ToDouble(txt_SalCal_OThours.Text);
                double bonus = Convert.ToDouble(txt_CalSal_Bonus.Text);
                if (string.IsNullOrEmpty(txt_CalSal_month.Text))
                {
                    MessageBox.Show("Please select Month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (Cal_Sal_Position.SelectedIndex == 0)//ceo sal
                    {
                        txt_SalCal_OThours.Visible = false;
                        double otRate = 0.00;
                        txt_CalSal_OTamount.Text = logic.otamount(ot_hours, otRate).ToString();
                        txt_CalSal_TAX.Text = logic.calTax(basic).ToString();
                        txt_CalSal_ETF.Text = logic.etfcal(basic).ToString();
                        txt_CalSal_totEarning.Text = logic.earning(basic, bonus).ToString();
                        txt_CalSal_Deductions.Text = logic.Caldeduction().ToString();
                        txt_CalSal_NetSal.Text = logic.netSalary().ToString();

                    }
                    else if (Cal_Sal_Position.SelectedIndex == 1)//HR sal
                    {
                        txt_SalCal_OThours.Visible = false;
                        double otRate = 0.00;
                        txt_CalSal_OTamount.Text = logic.otamount(ot_hours, otRate).ToString();
                        txt_CalSal_TAX.Text = logic.calTax(basic).ToString();
                        txt_CalSal_ETF.Text = logic.etfcal(basic).ToString();
                        txt_CalSal_totEarning.Text = logic.earning(basic, bonus).ToString();
                        txt_CalSal_Deductions.Text = logic.Caldeduction().ToString();
                        txt_CalSal_NetSal.Text = logic.netSalary().ToString();

                    }
                    else if (Cal_Sal_Position.SelectedIndex == 2)//Marketing Sal
                    {
                        txt_SalCal_OThours.Visible = false;
                        double otRate = 0.00;
                        txt_CalSal_OTamount.Text = logic.otamount(ot_hours, otRate).ToString();
                        txt_CalSal_TAX.Text = logic.calTax(basic).ToString();
                        txt_CalSal_ETF.Text = logic.etfcal(basic).ToString();
                        txt_CalSal_totEarning.Text = logic.earning(basic, bonus).ToString();
                        txt_CalSal_Deductions.Text = logic.Caldeduction().ToString();
                        txt_CalSal_NetSal.Text = logic.netSalary().ToString();
                    }
                    else if (Cal_Sal_Position.SelectedIndex == 3)//Salaes representative sal
                    {
                        double otRate = 100.00;
                        txt_CalSal_OTamount.Text = logic.otamount(ot_hours, otRate).ToString();
                        txt_CalSal_TAX.Text = logic.calTax(basic).ToString();
                        txt_CalSal_ETF.Text = logic.etfcal(basic).ToString();
                        txt_CalSal_totEarning.Text = logic.earning(basic, bonus).ToString();
                        txt_CalSal_Deductions.Text = logic.Caldeduction().ToString();
                        txt_CalSal_NetSal.Text = logic.netSalary().ToString();
                    }
                    else if (Cal_Sal_Position.SelectedIndex == 4)//Project mnager sal
                    {
                        double otRate = 150.00;
                        txt_CalSal_OTamount.Text = logic.otamount(ot_hours, otRate).ToString();
                        txt_CalSal_TAX.Text = logic.calTax(basic).ToString();
                        txt_CalSal_ETF.Text = logic.etfcal(basic).ToString();
                        txt_CalSal_totEarning.Text = logic.earning(basic, bonus).ToString();
                        txt_CalSal_Deductions.Text = logic.Caldeduction().ToString();
                        txt_CalSal_NetSal.Text = logic.netSalary().ToString();
                    }
                    else if (Cal_Sal_Position.SelectedIndex == 5)//Accountant
                    {
                        double otRate = 200.00;
                        txt_CalSal_OTamount.Text = logic.otamount(ot_hours, otRate).ToString();
                        txt_CalSal_TAX.Text = logic.calTax(basic).ToString();
                        txt_CalSal_ETF.Text = logic.etfcal(basic).ToString();
                        txt_CalSal_totEarning.Text = logic.earning(basic, bonus).ToString();
                        txt_CalSal_Deductions.Text = logic.Caldeduction().ToString();
                        txt_CalSal_NetSal.Text = logic.netSalary().ToString();
                    }
                    else if (Cal_Sal_Position.SelectedIndex == 6)//Leagal sal
                    {
                        double otRate = 100.00;
                        txt_CalSal_OTamount.Text = logic.otamount(ot_hours, otRate).ToString();
                        txt_CalSal_TAX.Text = logic.calTax(basic).ToString();
                        txt_CalSal_ETF.Text = logic.etfcal(basic).ToString();
                        txt_CalSal_totEarning.Text = logic.earning(basic, bonus).ToString();
                        txt_CalSal_Deductions.Text = logic.Caldeduction().ToString();
                        txt_CalSal_NetSal.Text = logic.netSalary().ToString();
                    }
                    else if (Cal_Sal_Position.SelectedIndex == 7 || Cal_Sal_Position.SelectedIndex == 8 || Cal_Sal_Position.SelectedIndex == 9)//Others sal
                    {
                        double otRate = 300.00;
                        txt_CalSal_OTamount.Text = logic.otamount(ot_hours, otRate).ToString();
                        txt_CalSal_TAX.Text = logic.calTax(basic).ToString();
                        txt_CalSal_ETF.Text = logic.etfcal(basic).ToString();
                        txt_CalSal_totEarning.Text = logic.earning(basic, bonus).ToString();
                        txt_CalSal_Deductions.Text = logic.Caldeduction().ToString();
                        txt_CalSal_NetSal.Text = logic.netSalary().ToString();
                    }

                    MessageBox.Show("Data calculate successful.\nNow you can Save Informations", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
            catch (FormatException)
            {
                MessageBox.Show("Invalid Type!\nFill the boxes .  If there has no value to fill, pls enter 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void txt_CalSal_Bsal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_CalSal_OTamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_CalSal_EmpID.SelectedIndex = -1;
            txt_CalSal_Name.Clear();
            txt_CalSal_Bsal.Clear();
            Cal_Sal_Position.SelectedIndex = -1;   
            txt_SalCal_OThours.Text="0";
            txt_CalSal_OTamount.Clear();
            txt_CalSal_TAX.Clear();
            txt_CalSal_ETF.Clear();
            txt_CalSal_Bonus.Text = "00";
            txt_CalSal_totEarning.Clear();
            txt_CalSal_Deductions.Clear();
            txt_CalSal_NetSal.Clear();
            txt_CalSal_month.Clear();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Retrieve the selected month name
            string selectedMonthName = monthCalendar1.SelectionStart.ToString("MMMM");

            // Display the selected month name
            
            txt_CalSal_month.Text = selectedMonthName;

        }

        private void txt_CalSal_month_TextChanged(object sender, EventArgs e)
        {
            try
            {
              // check sal has already calculated in entered month
                string empId = txt_CalSal_EmpID.Text;
                string month = txt_CalSal_month.Text;
                if (obj.IsSalEntered(empId,month))
                {
                    
                    MessageBox.Show("Salary already Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CalSal_month.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Accountant obj = new Accountant(EmpID);
            this.Close();
            obj.Show();
        }
    }
}


