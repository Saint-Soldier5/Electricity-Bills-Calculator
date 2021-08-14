using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public class Customer
    {
       
        private static int accountNumberSeed = 1234567890;
        public int AccountNo { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal NumberKWh { get; set; }
        public decimal BillAmount { get; set; }

        public Customer()
        { }

        public Customer(string fName,string Lname, decimal kWh)
        {
            FirstName = fName;
            LastName = Lname;
            NumberKWh = kWh;
            AccountNo = accountNumberSeed;
            accountNumberSeed++;
            BillAmount = CalculateBillTotal(kWh);
        }

        public decimal CalculateBillTotal(decimal kWh)
        {
            const decimal ADMIN_CHARGE = 12m;
            const decimal ENERGY_CHARGE = 0.07M;
            return (kWh * ENERGY_CHARGE + ADMIN_CHARGE);
        }


    }

  

    
}
