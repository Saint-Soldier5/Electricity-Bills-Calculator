using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class customerBills : Form
    {
        public Customer[] customerArray { get; set; }
        public int customerCount { get; set; }
        public customerBills()
        {
            InitializeComponent();
        }

        private void customerBills_Load(object sender, EventArgs e)
        {
            listBoxDisplayOut.Items.Clear();
            comboNames.Items.Clear();
            for (int i = 0; i < customerCount; i++)
                comboNames.Items.Add($"{customerArray[i].FirstName} {customerArray[i].LastName}");
            
        }

        private void comboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDisplaySingle.Items.Clear();
            listBoxDisplaySingle.Items.Add($"Account Number\t\tFirstName\tLastName\tNo. kWh\t\tBill Amount");
            int personIndex = comboNames.SelectedIndex;
            listBoxDisplaySingle.Items.Add($"{customerArray[personIndex].AccountNo.ToString()}\t\t{customerArray[personIndex].FirstName}\t\t{customerArray[personIndex].LastName}\t\t{customerArray[personIndex].NumberKWh.ToString()}\t\t{customerArray[personIndex].BillAmount.ToString("c")}\n");
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            decimal totalKWh = 0m;
            decimal averageBill = 0m;
            listBoxDisplayOut.Items.Add($"Account Number\t\tFirstName\tLastName\tNo. kWh\t\tBill Amount");
            for (int i = 0; i < customerCount; i++)
            {
                //figure out tab spacing https://www.w3resource.com/c-programming-exercises/string/c-string-exercise-31.php
                listBoxDisplayOut.Items.Add($"{customerArray[i].AccountNo.ToString()}\t\t{customerArray[i].FirstName}\t\t{customerArray[i].LastName}\t\t{customerArray[i].NumberKWh.ToString()}\t\t{customerArray[i].BillAmount.ToString("c")}\n");
                totalKWh += customerArray[i].NumberKWh;
                averageBill += customerArray[i].BillAmount;
            }

                averageBill = averageBill / customerCount;
            //listDisplayStatistics.Items.Add("Monthly statistics:");
            //listDisplayStatistics.Items.Add($"Total Customers processed: {customerCount.ToString()}");
            //listDisplayStatistics.Items.Add($"Total KWh: {totalKWh.ToString()}");
            //listDisplayStatistics.Items.Add($"Average Bill: {averageBill.ToString("c")}");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            decimal totalKWh = 0m;
            decimal averageBill = 0m;
            for (int i = 0; i < customerCount; i++)
            {
                //figure out tab spacing https://www.w3resource.com/c-programming-exercises/string/c-string-exercise-31.php
                //listBoxDisplayOut.Items.Add($"{customerArray[i].AccountNo.ToString()}\t\t{customerArray[i].FirstName}\t\t{customerArray[i].LastName}\t\t{customerArray[i].NumberKWh.ToString()}\t\t{customerArray[i].BillAmount.ToString("c")}\n");
                totalKWh += customerArray[i].NumberKWh;
                averageBill += customerArray[i].BillAmount;
            }

            averageBill = averageBill / customerCount;
            listDisplayStatistics.Items.Add("Monthly statistics:");
            listDisplayStatistics.Items.Add($"Total Customers processed: {customerCount.ToString()}");
            listDisplayStatistics.Items.Add($"Total KWh: {totalKWh.ToString()}");
            listDisplayStatistics.Items.Add($"Average Bill: {averageBill.ToString("c")}");

        }
    }
}
