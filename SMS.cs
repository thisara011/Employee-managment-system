using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project01
{
    internal class SMS
    {
        public void Send(string message, string recipientNumber)
        {
            string result;
            string url = $"https://app.notify.lk/api/v1/send?user_id=25340&api_key=05qFPEfbPCHX3rjOf9VM&sender_id=NotifyDEMO&to={recipientNumber}&message={message}";

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            objRequest.Method = "POST";

            try
            {
                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    // Close and clean up the StreamReader
                    sr.Close();
                }
                MessageBox.Show("Message Sent Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message not Sent!: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int SendALL(string message, DataTable recipientNumber)
        {
            int Count = 0;
            if (recipientNumber != null && recipientNumber.Rows.Count > 0)
            {
                foreach (DataRow row in recipientNumber.Rows)
                {
                    string phoneNumber = row["Telephone"].ToString();
                    string url = $"https://app.notify.lk/api/v1/send?user_id=25340&api_key=05qFPEfbPCHX3rjOf9VM&sender_id=NotifyDEMO&to={phoneNumber}&message={message}";

                    HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
                    objRequest.Method = "POST";

                    try
                    {
                        HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                        using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                        {
                            // You can read the response if needed, but it's not used in this code.
                            sr.ReadToEnd();
                            // Close and clean up the StreamReader
                            sr.Close();
                        }
                        Count++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Message not Sent to " + phoneNumber + ": " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                
            }
            else
            {
                MessageBox.Show("No recipients found in the DataTable.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Count;
        }
    } 
}
