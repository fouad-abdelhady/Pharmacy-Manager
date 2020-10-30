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
    public partial class AdvanceOrderViewer : Form
    {
        #region gridView Colms
        private readonly string ORDER_DATE = "Date";
        private readonly string ORDER_PRICE = "Cost";
        private readonly string CUSTOMER_NAME = "Customer";
        private readonly string DEBT_VALUE = "Debt";
        private readonly string PAID_AMOUNT = "Paid";
        #endregion
        private DataTable ordersTable;
        private bool dateFilter, generalFilter;
        private string paidOrAll;
        private string amountOfRows;
        private List<Orders> orders;
        private OrdersOperations Oo;
        private Orders currntOrder;
        private Home home;

        public AdvanceOrderViewer( Home home)
        {
            InitializeComponent();
            setFields(home);
        }
        private void setFields(Home home)
        {
            this.home = home;
            dateFilter = false;
            generalFilter = false;
            this.paidOrAll = " ; ";
            this.amountOfRows = " TOP 50 ";
            FromDatePicker.Value = DateTime.Today;
            ToDatePicker.Value = DateTime.Today.AddDays(-1);
            this.orders = new List<Orders>();
            this.Oo = new OrdersOperations();
            ordersTable = new DataTable();
            this.currntOrder = new Orders();
        }

        #region Date Filter RadioBoxes Check Handelers
        private void RadioDate_CheckedChanged(object sender, EventArgs e)
        {
            dateFilterChanged();
        }

        private void dateFilterChanged()
        {
            if (!dateFilter)
            {
                dateFilter = true;
                RadioPaid.Checked = false;
            }

            else
                dateFilter = false;
            showDateFilterPanel(dateFilter);
        }

        private void showDateFilterPanel(bool dateFilter)
        {
            DateFilterPanel.Visible = dateFilter;
        }

        private void RadioTo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FromDatePicker.Value > DateTime.Today)
            {
                FromDatePicker.Value = DateTime.Today;
                return;
            }

        }



        private void ToDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FromDatePicker.Value < ToDatePicker.Value)
            {
                showMessageBox("To Date cannot be greater Than From Date");
                ToDatePicker.Value = FromDatePicker.Value;
                return;
            }
        }

        private void applyDateFilter()
        {
            string query = "SELECT * FROM AllOrders WHERE OrderDate BETWEEN #{0}# AND #{1}# ;";
            query = string.Format(query, FromDatePicker.Value, ToDatePicker.Value);
            this.orders = Oo.getAllOrders(query);
        }
        #endregion

        #region General Filter Handelrs
        private void RadioPaid_CheckedChanged(object sender, EventArgs e)
        {
            generalFilterChanged();
        }

        private void generalFilterChanged()
        {
            if (!generalFilter)
            {
                this.generalFilter = true;
                RadioDate.Checked = false;
            }
            else
                this.generalFilter = false;

            showGeneralFilterPanel(generalFilter);
        }

        private void showGeneralFilterPanel(bool generalFilter)
        {
            GeneralFilterPanel.Visible = generalFilter;
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            if (!checkRowsAmount())
            {
                this.amountOfRows = " TOP 50 ";
            }
            else
            {
                int numOfOrders = int.Parse(NumOfOrders.Text.ToString());
                this.amountOfRows = " TOP " + numOfOrders;
            }


        }

        private bool checkRowsAmount()
        {
            if (!Companies.isNum(NumOfOrders.Text.ToString()))
                return false;

            int numOfOrders = int.Parse(NumOfOrders.Text.ToString());
            if (numOfOrders < 0)
            {
                NumOfOrders.Text = 0 + "";
                return false;
            }

            if (numOfOrders == 0)
                return false;

            return true;
        }

        private void RadioPaidOrders_CheckedChanged(object sender, EventArgs e)
        {
            paidOrAll = " WHERE CustomerID > -1 ;";
        }

        private void RadioAll_CheckedChanged(object sender, EventArgs e)
        {
            paidOrAll = " ; ";

        }

        public void applyGeneralFilter()
        {
            string query = "SELECT " + this.amountOfRows + " * FROM AllOrders " + this.paidOrAll;
            this.orders = Oo.getAllOrders(query);
        }


        #endregion

        private void showMessageBox(string v)
        {
            MessageBox.Show(v);
        }

        private void setOrdersDataGridViewDefs()
        {
            ordersTable = new DataTable();
            ordersTable.Columns.Add(ORDER_DATE);
            ordersTable.Columns.Add(ORDER_PRICE);
            ordersTable.Columns.Add(CUSTOMER_NAME);
            ordersTable.Columns.Add(PAID_AMOUNT);
            ordersTable.Columns.Add(DEBT_VALUE);
            OrdersDataGridView.DataSource = ordersTable;
        }

        private void showOrdersList()
        {
            DataRow dataRow;
            foreach (Orders ord in orders)
            {
                dataRow = ordersTable.NewRow();

                dataRow[ORDER_DATE] = ord.OrderDate.Date.ToString("dd MMM yyyy");
                dataRow[ORDER_PRICE] = ord.TotalPrice + " EGP";
                dataRow[PAID_AMOUNT] = ord.PaidAmount + " EGP";
                dataRow[DEBT_VALUE] = ord.DebtValue + " EGP";
                dataRow[CUSTOMER_NAME] = ord.Customer.CustomerName;

                this.ordersTable.Rows.Add(dataRow);
            }
        }

        private void AdvanceOrderViewer_Load(object sender, EventArgs e)
        {
            string query = "SELECT  TOP 50  * FROM AllOrders ;";
            this.orders = Oo.getAllOrders(query);
            setOrdersDataGridViewDefs();
            showOrdersList();
        }

        private void OrdersDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void OrdersDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idnex = OrdersDataGridView.CurrentCell.RowIndex;
            currntOrder = orders[idnex];
            if (currntOrder.ListOfMeds.Count == 0)
                Oo.getOrderMedsInfo(currntOrder);
            showOrderDetails();
        }

        private void showOrderDetails()
        {
            Oeders oderDetails = new Oeders(home, currntOrder);
            oderDetails.Show();
            home.Visible = false;
        }

        private void deteteButton_Click(object sender, EventArgs e)
        {
            DeleteOrder dOrder = new DeleteOrder(home);
            home.Visible = false;
            dOrder.Show();
        }

        private void ApplyFilter_Click(object sender, EventArgs e)
        {
            if (generalFilter)
            {
                applyGeneralFilter();
                setOrdersDataGridViewDefs();
                showOrdersList();
            }
            else if (dateFilter)
            {
                applyDateFilter();
                setOrdersDataGridViewDefs();
                showOrdersList();
            }
            else
            {

            }
        }
    }
}
