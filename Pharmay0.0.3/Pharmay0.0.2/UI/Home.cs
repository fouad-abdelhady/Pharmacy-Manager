using Pharmay0._0._2.Database.ClassesDatabaseOperations;
using Pharmay0._0._2.UI.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmay0._0._2.UI
{
    public partial class Home : Form
    {
        CustomersOrders custOrders = null;
        private Form activeForm = null;
        CustomersOperations co;
        Load load;
        public Home()
        {
            InitializeComponent();
          //  setLoad();
            hideSubList();
        }

        private void setLoad()
        {
            load = new Load(this);
            load.Show();           
        }


        #region myFunctions
        private void hideSubList(){
           // medsList.Visible = false;
            suppliersList.Visible = false;
        }
        private void shawSubList(Panel panel) {
           
            if (panel.Visible) 
                panel.Visible = false;
            else
                panel.Visible = true;
            
        }
        public void openChildForm(Form childForm) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            uiContainerPanel.Controls.Add(childForm);
            uiContainerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Buttons events
        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void meds_Click(object sender, EventArgs e)
        {
            // shawSubList(medsList);    
            openChildForm(new Inventory(this));
        }
        private void suppliers_Click(object sender, EventArgs e)
        {
            shawSubList(suppliersList);
            openChildForm(new Companies(this));
        }
        #endregion

        private void homeButton_Click(object sender, EventArgs e)
        {
            displayCustomerOrderForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new ShipmentsForm(this));
        }

        private void orders_Click(object sender, EventArgs e)
        {
            openChildForm(new AdvanceOrderViewer(this));
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            CustomersOperations co = new CustomersOperations();
            co.getAllCustomers();
            displayCustomerOrderForm();
           // setLoad();
        }

        private void displayCustomerOrderForm()
        {
            
                custOrders = new CustomersOrders(this);
                
           
            openChildForm(custOrders);
        }


        private void customers_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerR(this));
        }

        private void reports_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports(this));
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            setLoad();
            this.Visible = false;
        }
    }
}
