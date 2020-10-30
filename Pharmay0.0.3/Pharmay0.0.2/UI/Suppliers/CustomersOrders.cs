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
    public partial class CustomersOrders : Form
    {
        private string colmMedName = "Med Name";
        private string colmAmount = "Amount";
        private string colmTotalPrice = "Price";

        private DataTable table;

        private Home home;
        private MedicienOperations medOp;
        private Orders order;
        private Medicine med;
        private MedAndOrder mao;
        private OrdersOperations ordersOp;

        private int currentSelectedIndex;
        private double totalPrice;

        public CustomersOrders(Home home)
        {
            InitializeComponent();
            setValues(home);
            addAndRefreshCustomersComboBox();
        }

        private void setValues(Home home)
        {
            this.home = home;
            setObjcts();
            resetFields();
            setDataGridViewDefaults();

        }

        private void resetFields()
        {
            setFocusToParCodeTextBox();
            
            amoutTextBox.Text = "0";
            parcodeTextBx.Text = "";
            sellingPricePerSlipLabel.Text =
                totalPriceForMedLabel.Text = "0 EGP";
            amoutTextBox.Enabled = false;
            oldCheckBox.Visible = false;
            updateOrderMedsPanel.Visible = false;
            //saveCancelPanel.Visible = false;
            addExtraMedToOrder.Visible = false;
            medNameLabel.Visible = false;
            addToLatePaymentsPanel.Visible = false;
           
        }

        private void setFocusToParCodeTextBox()
        {
            orderDetailsEntery.Focus();
            parcodeTextBx.Select();
        }

        private void setObjcts()
        {
            table = new DataTable();

            medOp = new MedicienOperations();

            order = new Orders();
            med = new Medicine();
            mao = new MedAndOrder();
            ordersOp = new OrdersOperations();
            mao.Medicen = med;
        }

        private void setDataGridViewDefaults()
        {
            totalPriceForOrder.Text = "0 EGP";
            table = new DataTable();
            table.Columns.Add(colmMedName);
            table.Columns.Add(colmAmount);
            table.Columns.Add(colmTotalPrice);

            orderMedsDetails.DataSource = table;
        }

        internal void addAndRefreshCustomersComboBox()
        {
            foreach (Customers cust in CustomersOperations.CUSTOMERS_LIST)
            {
                customersListCombox.Items.Add(cust.CustomerName + " -Mobile- " + cust.MobileNumber);
            }
        }

        internal void addAndRefreshCustomersComboBox(Customers customer)
        {
            customersListCombox.Items.Add(customer.CustomerName + " -Mobile- " + customer.MobileNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //                addAndRefreshCustomersComboBox();
            latePaymentTotalLabel.Text = totalPrice + " EGP";
            debtValueLabel.Text = (totalPrice - double.Parse(paidAmount.Text.ToString())) + " EGP";
            showLatePaymentPanel(true);
            enableLatePaymentFields(false);
        }

        private void enableLatePaymentFields(bool v)
        {
            save.Enabled = v;
            paidAmount.Enabled = v;
        }

        private void showLatePaymentPanel(bool v)
        {
            addToLatePaymentsPanel.Visible = v;
            placeOrderPanel.Enabled = !v;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            showLatePaymentPanel(false);
        }

        private void save_Click(object sender, EventArgs e)
        {

            if (Companies.isEmpty(paidAmount) || 
                !Companies.isNum(paidAmount.Text.ToString())) {
                MessageBox.Show("Enter a valid number in the paid amount field");
                return;
            }
            
            this.order.Customer = getCustomer(customersListCombox.SelectedItem.ToString());
            this.order.CustomerId = this.order.Customer.CustomerID;            
            this.order.Paid = false;
            this.order.PaidAmount = double.Parse(paidAmount.Text.ToString());

            showLatePaymentPanel(false);
        }

        private Customers getCustomer(string v)
        {
            string cutomerItem;            
            foreach (Customers cust in CustomersOperations.CUSTOMERS_LIST) {
                cutomerItem = cust.CustomerName + " -Mobile- " + cust.MobileNumber;
                if (v.Equals(cutomerItem)) {
                    return cust;
                }
            }
            return null;           
        }

        private void parcodeTextBx_TextChanged(object sender, EventArgs e)
        {
            if (parcodeTextBx.Text.ToString().Length != 13)
            {
                enabelAllFields(false);
                return;
            }
            if(!searchOrdersMeds(parcodeTextBx.Text.ToString()))
                showMedInfo(medOp.getMedicen(parcodeTextBx.Text.ToString()));

        }

        private void enabelAllFields(bool v)
        {
            amoutTextBox.Enabled = v;
            addExtraMedToOrder.Visible = v;
            medNameLabel.Visible = v;
            if (orderMedsDetails.Rows.Count == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void showMedInfo(Medicine medicine)
        {
            oldCheckBox.Visible = false;
            if (medicine == null)
            {
                MessageBox.Show("This med is not avaliable in the inventory.");
                button1.Enabled = false;
                return;
            }
            this.med = medicine;
            medNameLabel.Text = medicine.MedName;
            amoutTextBox.Text = medicine.TabPerPackage.ToString();
            sellingPricePerSlipLabel.Text = medicine.TabPrice + " EGP";
            totalPriceForMedLabel.Text = (medicine.TabPerPackage * medicine.TabPrice) + " EGP";
            oldCheckBox.Checked = med.IsItOld;
            if (med.Oldmed != null && med.Oldmed.RemainingAmount > 0)
            {

                oldCheckBox.Visible = true;
                MessageBox.Show("There are old " +
                    med.Oldmed.RemainingAmount +
                    " strips of this med with expiry date " +
                    med.Oldmed.ExpiryDate.ToString("dd/MMM/yyyy"));

            }
            enabelAllFields(true);
        }

        private void addExtraMedToOrder_Click(object sender, EventArgs e)
        {
            if (!Companies.isNum(amoutTextBox.Text.ToString()))
            {
                return;
            }
            if (int.Parse(amoutTextBox.Text.ToString()) == 0) {
                MessageBox.Show("The amount value Cannot be 0 ");
                return;
            }
            setMedOrderObj();
            addMedDetailsToSideTabel();
            resetFields();
        }

        private void setMedOrderObj()
        {

            mao = new MedAndOrder();
            mao.Medicen = this.med;
            mao.MedicenId = this.med.MedID;
            mao.NumOfTabes = int.Parse(amoutTextBox.Text.ToString());
            mao.TotalPrice = this.med.TabPrice * mao.NumOfTabes;
            mao.NumOfPackages = (double)(mao.NumOfTabes / mao.Medicen.TabPerPackage);
            totalPrice += mao.TotalPrice;
            this.order.addMedOrdToList(mao);
            
        }

        private void addMedDetailsToSideTabel()
        {
            DataRow dataRow = table.NewRow();

            dataRow[colmMedName] = mao.Medicen.MedName;
            dataRow[colmAmount] = mao.NumOfTabes.ToString();
            dataRow[colmTotalPrice] = mao.TotalPrice.ToString();

            table.Rows.Add(dataRow);
            totalPriceForOrder.Text = totalPrice + " EGP";
        }

        private void addMedDetailsToSideTabel(int index)
        {
            DataRow dataRow = table.NewRow();

            dataRow[colmMedName] = mao.Medicen.MedName;
            dataRow[colmAmount] = mao.NumOfTabes.ToString();
            dataRow[colmTotalPrice] = mao.TotalPrice.ToString();

            table.Rows.Add(dataRow);
        }

        private void amoutTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (Companies.isEmpty(amoutTextBox) ||
                !Companies.isNum(amoutTextBox.Text.ToString()))
            {
                return;
            }
            int amount = int.Parse(amoutTextBox.Text.ToString());
            if (amount < 0)
            {
                amoutTextBox.Text = "0";
                
            }

            if (!checkAmountAvaliablity(amount)) {
               
                return;
            }
                    
            totalPriceForMedLabel.Text = (amount * this.med.TabPrice) + " EGP";
        }

        private bool checkAmountAvaliablity(int amount)
        {
            int remainingAmount = this.med.NumOfTabes - amount ;
            if (remainingAmount < 0 && this.med.Parecode != null) {
                if (med.NumOfTabes == 0) {
                    this.parcodeTextBx.Text = "";
                    MessageBox.Show("No meds avaliable.");
                    resetFields();
                    return false;
                }
                amoutTextBox.Text = med.NumOfTabes+"";
                MessageBox.Show("Only " + med.NumOfTabes + " slips are avaliable in your store");
                return false;
            }
            if (remainingAmount < 0 && med.Parecode == null) {
                return false;
            }              
           
            return true;
        }

        private void orderMedsDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentSelectedIndex = orderMedsDetails.CurrentCell.RowIndex;
            mao = (MedAndOrder)order.ListOfMeds[currentSelectedIndex];

            showMedInfoToUpdate(mao.Medicen);
        }

        private void showUpdateButtons(bool on)
        {
            updateOrderMedsPanel.Visible = on;
            amoutTextBox.Enabled = on;
            medNameLabel.Visible = on;
            addExtraMedToOrder.Visible = !on;

        }
        private bool searchOrdersMeds(string pareCode)
        {
            // MedAndOrder m = order.ListOfMeds[currentSelectedIndex]
            int index = 0;
            foreach (MedAndOrder m in order.ListOfMeds) {
               
                if (pareCode.Equals(m.Medicen.Parecode)) {
                    currentSelectedIndex = index;
                    mao = m;
                    showMedInfoToUpdate(m.Medicen);
                    return true;
                }
                index++;
            }
            return false;
        }
        private void showMedInfoToUpdate(Medicine medicine)
        {
            int tempAmount;
            oldCheckBox.Visible = false;
            this.med = medicine;
            medNameLabel.Text = medicine.MedName;
            if(mao.NumOfTabes == 0)
                tempAmount = medicine.TabPerPackage;
            else
                tempAmount = mao.NumOfTabes;
            amoutTextBox.Text = tempAmount + "";
            sellingPricePerSlipLabel.Text = medicine.TabPrice + " EGP";
            totalPriceForMedLabel.Text = (tempAmount * medicine.TabPrice) + " EGP";
            oldCheckBox.Checked = med.IsItOld;
            if (med.Oldmed != null && med.Oldmed.RemainingAmount > 0)
            {

                oldCheckBox.Visible = true;
                MessageBox.Show("There are old " +
                    med.Oldmed.RemainingAmount +
                    " strips of this med with expiry date " +
                    med.Oldmed.ExpiryDate.ToString("dd/MMM/yyyy"));

            }
            showUpdateButtons(true);
        }

        private void oldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.med.IsItOld = oldCheckBox.Checked;
        }

        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (Companies.isEmpty(amoutTextBox) ||
                !Companies.isNum(amoutTextBox.Text.ToString()))
            {
                MessageBox.Show("Invalid value in Amount field");
                return;
            }
            this.table.Rows.RemoveAt(currentSelectedIndex);
            MedAndOrder t = (MedAndOrder)this.order.ListOfMeds[currentSelectedIndex];
            totalPrice -= t.TotalPrice;
            this.order.ListOfMeds.RemoveAt(currentSelectedIndex);
            setMedOrderObj();
            addMedDetailsToSideTabel();
            resetFields();
        }

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void deteteButton_Click(object sender, EventArgs e)
        {
            totalPrice -= mao.TotalPrice;
            resetFields();
            this.table.Rows.RemoveAt(currentSelectedIndex);
            this.order.ListOfMeds.RemoveAt(currentSelectedIndex);
            totalPriceForOrder.Text = totalPrice + " EGP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (order.ListOfMeds.Count == 0) {

                if (!Companies.isNum(amoutTextBox.Text.ToString()) ||
                Companies.isEmpty(parcodeTextBx)) {
                    MessageBox.Show("Make sure that enterd the medicien details correctly.");
                    return;
                }
                setMedOrderObj();
            }            
            prepareOrderObj();
            ordersOp.addOrder(this.order);
            resetOpjects();
            setDataGridViewDefaults();
            return;           
        }

        private void resetOpjects()
        {
            order = new Orders();
            mao = new MedAndOrder();
            med = new Medicine();
            totalPrice = 0;
            resetFields();
        }

        private void prepareOrderObj()
        {
            order.OrderDate = DateTime.Today;
            order.TotalPrice = totalPrice;
        }

        private void customersListCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableLatePaymentFields(true);
        }

        private void paidAmount_TextChanged(object sender, EventArgs e)
        {
            if (Companies.isEmpty(paidAmount) || 
                !Companies.isNum(paidAmount.Text.ToString())) {
                return;
            }
            debtValueLabel.Text = (totalPrice - double.Parse(paidAmount.Text.ToString())) + " EGP";
        }

        private void moveToAddCom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home.Visible = false;
            AddNewCustomer anc = new AddNewCustomer(this, home);
            anc.Show();
        }

        private void orderMedsDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            payLater.Enabled = true;
        }

        private void orderMedsDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (orderMedsDetails.Rows.Count == 0) {
                payLater.Enabled = false;
                return;
            }
            payLater.Enabled = true;
        }
    }
}
