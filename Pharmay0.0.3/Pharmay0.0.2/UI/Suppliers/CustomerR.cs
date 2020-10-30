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

    public partial class CustomerR : Form
    {
        private Home home;
        private DataTable customersTable;
        private DataTable customerOrdersTable;
        private CustomersOperations Co;
        private Customers currentSelectedCustomer;
        private OrdersOperations Oo;
        #region tables columes names
        private readonly string CUSTOMER_NAME  ="Name";
        private readonly string DEBT_VALUE = "Late Fee";
        private readonly string CUSTOMER_MOBILE_NUM = "Mobile";
        private readonly string ORDER_DATE = "Order Date";
        private readonly string TOTAL_PRICE = "Total";
        private readonly string PAID_AMOUNT = "Paid";
        #endregion

        public CustomerR(Home home)
        {
            InitializeComponent();
            setValues(home);
        }

        private void setValues(Home home)
        {
            this.home = home;
            Oo = new OrdersOperations();
            Co = new CustomersOperations();
            customersTable = new DataTable();
            customerOrdersTable = new DataTable();
            currentSelectedCustomer = new Customers();
            
        }

        private void CustomerR_Load(object sender, EventArgs e)
        {
            CustomersListDataGridView.DataSource = getCustomersDataSource();
            Co.resetCustomerList();
            getAllCustomers();
            displayCustomers();
           
        }

        private void displayCustomers()
        {
            DataRow dataRow = customersTable.NewRow(); 
            foreach (Customers customer in CustomersOperations.CUSTOMERS_LIST) {

                dataRow[CUSTOMER_NAME] = customer.CustomerName;
                dataRow[CUSTOMER_MOBILE_NUM] = customer.MobileNumber;
                dataRow[DEBT_VALUE] = customer.DebtValue + " EGP";

                this.customersTable.Rows.Add(dataRow);
                dataRow = customersTable.NewRow();
            }
        }

        private void getAllCustomers()
        {
            
                Co.getAllCustomers();
           
        }

        private object getCustomersDataSource()
        {
            customersTable.Columns.Add(CUSTOMER_NAME);
            customersTable.Columns.Add(CUSTOMER_MOBILE_NUM);
            customersTable.Columns.Add(DEBT_VALUE);                     
            return this.customersTable;
        }

        private void setCustomersOrdersDataSource()
        {
            customerOrdersTable = new DataTable();

            customerOrdersTable.Columns.Add(ORDER_DATE);
            customerOrdersTable.Columns.Add(TOTAL_PRICE);
            customerOrdersTable.Columns.Add(PAID_AMOUNT);
            customerOrdersTable.Columns.Add(DEBT_VALUE);

            CustomerOrdersGridView.DataSource = customerOrdersTable;          
        }
        private void showCustomerOrders() {
            DataRow newOrder; 
            foreach (Orders order in currentSelectedCustomer.CutomerOrders) {
                newOrder = customerOrdersTable.NewRow();

                newOrder[ORDER_DATE] = order.OrderDate.Date.ToString("dd MMM yyyy"); ;
                newOrder[TOTAL_PRICE] = order.TotalPrice + " EGP";
                newOrder[PAID_AMOUNT] = order.PaidAmount + " EGP";
                newOrder[DEBT_VALUE] = order.DebtValue + " EGP";

                this.customerOrdersTable.Rows.Add(newOrder);
            }
        }

        private void CustomersListDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void CustomersListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idnex = CustomersListDataGridView.CurrentCell.RowIndex;
            currentSelectedCustomer = (Customers)CustomersOperations.CUSTOMERS_LIST[idnex];
            if (currentSelectedCustomer.CutomerOrders.Count == 0) {
                Co.getAllOrdersForCustomer(currentSelectedCustomer);
            }
            setCustomersOrdersDataSource();
            showCustomerOrders();
        }

        private void CustomerOrdersGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idnex = CustomersListDataGridView.CurrentCell.RowIndex;
            currentSelectedCustomer = (Customers)CustomersOperations.CUSTOMERS_LIST[idnex];
            int orderIndex = CustomerOrdersGridView.CurrentCell.RowIndex;
            setOrderToPaid(orderIndex);
        }

        private void setOrderToPaid(int orderIndex)
        {

            Orders order = currentSelectedCustomer.CutomerOrders[orderIndex]; 
            string message = "Are you sure that you want to set this order as Paid order? ";
            DialogResult dialogResult = MessageBox.Show(message, "Confirm Process", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Oo.setOrderToPaid(order))
                {
                    showDeletedOrderResults(orderIndex);
                }
            }
            else {

            }
        }

        private void showDeletedOrderResults(int orderIndex)
        {
            currentSelectedCustomer.DebtValue -= currentSelectedCustomer.CutomerOrders[orderIndex].DebtValue;
            currentSelectedCustomer.CutomerOrders.RemoveAt(orderIndex);
            CustomerOrdersGridView.Rows.RemoveAt(orderIndex);
        }
    }
}
