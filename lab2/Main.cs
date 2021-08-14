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
    public partial class Main : Form
    {

        readonly Customer[] customerArray;
        int customerCount = 0;


        public Main()
        {
            InitializeComponent();
            customerArray = new Customer[10];
        }



        
        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            //
            if ((txtFName.Text == "") | (txtKWhUsage.Text == "") | (txtLName.Text == ""))
            {
                MessageBox.Show("Please ensure all fields are filled.", "Field Input Incomplete");
            }

            else
            {
                customerArray[customerCount] = new Customer(txtFName.Text, txtLName.Text, Convert.ToDecimal(txtKWhUsage.Text));
                customerCount++;


                

                
                txtFName.Text = "";
                txtLName.Text = "";
                txtKWhUsage.Text = "";
                MessageBox.Show("Your information has been successfully saved.", "Data Saved");

            }
           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            customerBills displayCustomerBills = new customerBills();
            displayCustomerBills.customerArray = customerArray;
            displayCustomerBills.customerCount = customerCount;
            displayCustomerBills.ShowDialog();
            customerCount = displayCustomerBills.customerCount;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
