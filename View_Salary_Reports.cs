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
    public partial class View_Salary_Reports : KryptonForm
    {
        public string EmpID { get; set; }
        public View_Salary_Reports(string empID)
        {
            InitializeComponent();
            EmpID = empID;
        }
        EmployeeInfo obj = new EmployeeInfo();

        private void View_Salary_Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.dataSet2.salary);
            // TODO: This line of code loads data into the 'dataSet2.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.dataSet2.salary);
            show_EmpID.Text = EmpID;//show logged EmpId
            Combo_Select_Month.Visible = false;
            combo_DepID.Visible = false;
            Combo_Select_Emp_ID.Visible = false;
            Combo_position.Visible = false;
            // TODO: This line of code loads data into the 'dataSet2.salary' table. You can move, or remove it, as needed.
            DataTable da = obj.display("SELECT DISTINCT EmpID FROM EmployeeInfo");
            Combo_Select_Emp_ID.DataSource = da;
            Combo_Select_Emp_ID.DisplayMember = "EmpID";
            Combo_Select_Emp_ID.ValueMember = "EmpID";

        }

        private void Select__Month_CheckedChanged(object sender, EventArgs e)
        {
            if (Select__Month.Checked)
            {
                Combo_Select_Month.Visible = true;
                combo_DepID.Visible = false;
                Combo_Select_Emp_ID.Visible = false;
                Combo_position.Visible = false;
            }
        }

        private void radio_dep_CheckedChanged(object sender, EventArgs e)
        {

            if (radio_dep.Checked)
            {
                Combo_Select_Month.SelectedIndex = -1;
                Combo_Select_Month.Visible = false;
                combo_DepID.Visible = true;
                Combo_Select_Emp_ID.Visible = false;
                Combo_position.Visible = false;
            }
        }

        private void Select_Emp_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (Select_Emp_ID.Checked)
            {
                MessageBox.Show("Please select a month to view the Employee's Monthly Salary Report. \nAlternatively, you can choose to view all monthly salary reports by not selecting any specific month.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Combo_Select_Emp_ID.Visible = true;
                combo_DepID.Visible = false;
                Combo_Select_Month.Visible = true;
                Combo_position.Visible = false;
                
            }
        }

        private void radio_position_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_position.Checked)
            {
                Combo_Select_Month.SelectedIndex = -1;
                Combo_Select_Month.Visible = false;
                combo_DepID.Visible = false;
                Combo_Select_Emp_ID.Visible = false;
                Combo_position.Visible = true;
            }
        }

        private void radio_allEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_allEmp.Checked)
            {
                Combo_Select_Month.Visible = false;
                combo_DepID.Visible = false;
                Combo_Select_Emp_ID.Visible = false;
                Combo_position.Visible = false;
                this.salaryTableAdapter.Fill(this.dataSet2.salary);
                this.SalreportViewer1.RefreshReport();
            }

        }

        private void Combo_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_position.SelectedItem != null)
            {
                string position = Combo_position.SelectedItem.ToString();
                this.salaryTableAdapter.FillBy3(this.dataSet2.salary, position);//get data by position
                this.SalreportViewer1.RefreshReport();
            }
        }

        private void Combo_Select_Emp_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Select_Emp_ID.SelectedItem != null)
            {

                if (Combo_Select_Month.SelectedItem != null)
                {
                    string month = Combo_Select_Month.SelectedItem.ToString();
                    string emid = Combo_Select_Emp_ID.SelectedValue.ToString();
                    this.salaryTableAdapter.FillBy4(this.dataSet2.salary, emid, month);//get data by empid and month
                    this.SalreportViewer1.RefreshReport();                   
                }
                else
                {
                    Combo_Select_Month.SelectedIndex = -1;
                    string empid = Combo_Select_Emp_ID.SelectedValue.ToString();
                    this.salaryTableAdapter.FillBy2(this.dataSet2.salary, empid);//get data by empid
                    this.SalreportViewer1.RefreshReport();
                } 

            }
        }

        private void combo_DepID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_DepID.SelectedItem != null)
            {
                string depID = combo_DepID.SelectedItem.ToString();
                this.salaryTableAdapter.FillBy1(this.dataSet2.salary, depID);//get data by DepID
                this.SalreportViewer1.RefreshReport();
            }
        }

        private void SalreportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Combo_Select_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Select__Month.Checked)
            {
                if (Combo_Select_Month.SelectedItem != null)
                {
                    string month = Combo_Select_Month.SelectedItem.ToString();
                    this.salaryTableAdapter.FillBy(this.dataSet2.salary, month);//get data by month
                    this.SalreportViewer1.RefreshReport();
                }
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            string q = "SELECT Login_Type FROM Login WHERE EmpID = '" + EmpID + "'";
            DataRow EID = obj.GetEmployeeID(EmpID, q);

            if (EID != null)
            {
                string LT = EID["Login_Type"].ToString();
                
                if (LT == "Accountant")
                {
                    Accountant obj = new Accountant(EmpID);
                    this.Close();
                    obj.Show();
                }
                else 
                {
                    Executive_Management obj = new Executive_Management(EmpID);
                    this.Close();
                    obj.Show();
                }
               
            }
        }
    }
}

