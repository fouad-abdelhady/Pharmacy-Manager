using Pharmay0._0._2.Classes;
using Pharmay0._0._2.Database.ClassesDatabaseOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmay0._0._2.UI.Suppliers
{   
    public partial class AddNewCustomer : Form
    {
        private CustomersOperations co;
        private CustomersOrders cOrds;
        private Home home;
        private bool cancel;

        public AddNewCustomer(CustomersOrders cOrds, Home home)
        {
            InitializeComponent();
            setValues(cOrds, home);
            cancel = false;
        }

        private void setValues(CustomersOrders cOrds, Home home)
        {
            this.home = home;
            this.cOrds = cOrds;
            co = new CustomersOperations();
            co.COrders = cOrds;

            errorMessage.Visible = false;
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if (!check())
                return;
            Customers customer = new Customers();
            customer.CustomerName = customerName.Text.ToString();
            customer.MobileNumber = mobileNum.Text.ToString();
            if (co.addNewCustomer(customer)) {
                this.home.Visible = true;
                this.Close();
                return;
            }
            MessageBox.Show("Something Went worng");
        }
        private bool check()
        {

            if (Companies.isEmpty(customerName) || Companies.isEmpty(mobileNum))
            {
                showErrorMessage("Please fill the missing fields");
                return false;
            }            

            if (!Companies.isMobileNum(mobileNum.Text))
            {
                showErrorMessage("Please enter a valid Mobile Number.");
                return false;
            }
            errorMessage.Visible = false;
            return true;
        }      
        private void showErrorMessage(string v)
        {
            errorMessage.Visible = true;
            errorMessage.Text = v;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //if (!cancel)
            //{
            //    MessageBox.Show("Press CANCEL Button Again To Ensure The CANCELATION");
            //    cancel = true;
            //    return;
            //}
            this.home.Visible = true;
            this.Close();
        }
    }
}
