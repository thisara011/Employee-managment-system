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
using Azure.Communication;
using Azure.Communication.Email;
using Azure;
using System.Web.UI.WebControls;

namespace Project01
{
    public partial class Fogot_Password : KryptonForm
    {
        private readonly string connectionString = "endpoint=https://isuru101.unitedstates.communication.azure.com/;accesskey=OhqWN9YnNg+dKgm/MOvJGiBLH6YOQJV7cb4/iuZoAXflsuhUwS9lRUpMSdimvdf5j+2ZS1iik+VnpLvrsmvmEQ==";
        private readonly string senderEmail = "DoNotReply@b7d0fced-04e7-4e65-b231-1b9796643b5b.azurecomm.net";

        private readonly EmailClient emailClient;
        EmployeeInfo obj = new EmployeeInfo();
        LoginManager l = new LoginManager();
        public Fogot_Password()
        {
            InitializeComponent();

            var key = new AzureKeyCredential("OhqWN9YnNg+dKgm/MOvJGiBLH6YOQJV7cb4/iuZoAXflsuhUwS9lRUpMSdimvdf5j+2ZS1iik+VnpLvrsmvmEQ==");
            var endpoint = new Uri("https://isuru101.unitedstates.communication.azure.com/");
            emailClient = new EmailClient(endpoint, key);
        }


        private void Fogot_Password_Load(object sender, EventArgs e)
        {

        }

        private async void btn_Fogot_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Fogot_empID.Text))
                {
                    MessageBox.Show("Enter EmpID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Fogot_empID.Focus();
                }
                else if (string.IsNullOrEmpty(Fogot_username.Text))
                {
                    MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Fogot_username.Focus();
                }
                else if (string.IsNullOrEmpty(Fogot_Login_type_box.Text))
                {
                    MessageBox.Show("Select Login type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Fogot_Login_type_box.Focus();
                }
                else
                {
                    string enteredEmpID = Fogot_empID.Text;
                    string enteredUsername = Fogot_username.Text;
                    string selectedLoginType = Fogot_Login_type_box.Text;
                    bool isAuthenticated = l.FLogAuthenticateUser(enteredEmpID, enteredUsername, selectedLoginType);//match details with database
                    if (isAuthenticated)
                    {
                        MessageBox.Show("Details are correct, Email is sending\nPlease wait untill get success message", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dt = obj.display("SELECT TOP 1 email FROM EmployeeInfo WHERE position = 'Human Resources Manager' ORDER BY NEWID()");//select randomly e mail by position HR
                        if (dt.Rows.Count > 0)
                        {
                            string recipientEmail = dt.Rows[0]["email"].ToString(); // Get the recipient email from the ComboBox
                            string subject = "Request for the Password Reset";
                            string htmlContent = $"<html><body><h1>Password Reset Request</h1><br/><h4>The details are given below.</h4></body></html>";
                            htmlContent += $"<p>EmpId     : {Fogot_empID.Text}</p>";
                            htmlContent += $"<p>User Name : {Fogot_username.Text}</p>";
                            htmlContent += $"<p>Login Type: {Fogot_Login_type_box.SelectedItem}</p>";
                            htmlContent += "<p>Thank you.</p>";
                            try
                            {

                                EmailSendOperation emailSendOperation = await emailClient.SendAsync(
                                    Azure.WaitUntil.Completed,

                                    senderEmail,
                                    recipientEmail,
                                    subject,
                                    htmlContent);
                                EmailSendResult statusMonitor = emailSendOperation.Value;

                                Console.WriteLine($"Email Sent. Status = {emailSendOperation.Value.Status}");

                                // Get the OperationId so that it can be used for tracking the message for troubleshooting
                                string operationId = emailSendOperation.Id;
                                Console.WriteLine($"Email operation id = {operationId}");

                                MessageBox.Show("Email sent successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (RequestFailedException ex)
                            {
                                // OperationID is contained in the exception message and can be used for troubleshooting purposes
                                Console.WriteLine($"Email send operation failed with error code: {ex.ErrorCode}, message: {ex.Message}");
                                MessageBox.Show($"Email send operation failed with error code: {ex.ErrorCode}, message: {ex.Message}");
                            }
                        }

                    }
                    else
                    {
                        // Invalid username or password
                        MessageBox.Show("Invalid username or EmpId or wrong Login Type!!. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
           
        private void btn_back_Click(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            this.Close();
            l.Show();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Fogot_empID.Clear();
            Fogot_username.Clear();
            Fogot_Login_type_box.SelectedIndex = -1;
        }
    }
}
