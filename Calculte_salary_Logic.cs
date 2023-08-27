using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project01
{
   
  
  internal class Calculte_salary_Logic

    {

        double  total_Eraning=0, tax=0, otAmount=0, etf=0, deduction=0, net_salary = 0;
        public double otamount(double othours,double ot_rate)
        {       
            this.otAmount =othours*ot_rate; 
            return otAmount;  
        }
        public double earning(double basic,double bonus)
        {
            this.total_Eraning=basic+bonus+otAmount;
            return total_Eraning;
        }
        public double etfcal(double basic)
        { 
            this.etf=basic*0.08;
            return etf;
        }
        public double calTax(double basic)
        {
            this.tax =basic*0.10;
            return tax;

        }
        public double Caldeduction()
        {
            this.deduction =etf + tax;
            return deduction;
        }
        public double netSalary() 
        {
            this.net_salary = total_Eraning-deduction;
            return net_salary;
        }
    }
}

