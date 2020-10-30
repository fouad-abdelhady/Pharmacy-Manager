using Pharmay0._0._2.Database.ClassesDatabaseOperations;
using Pharmay0._0._2.Classes;
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

    public partial class Reports : Form
    {
        private static string MED_NAME = "Med";
        private static string OLD_AMOUNT = "Old";
        private static string OLD_VALUE = "Old ";
        private static string NEW_AMOUNT = "New";
        private static string NEW_VALUE = "New ";
        private static string TOTAL_VALUE = "Total ";

        private static string ORDER_DATE = "Date";
        private static string TOTAL_PRICE = "Total";
        private static string PAID_AMOUNT = "Paid";
        private static string DEPT_VALUE = "Late";

        private double dTotalSales;
        private double dPaid;
        private double dDept;


        private List<Orders> listOfDaysSales;
        private Home home;
        private MedicienOperations mO;
        private DataTable dataTable;
        private DataTable daysSalesTable;
        private CustomersOperations co;
        private OrdersOperations oO;
        public Reports(Home home)
        {
            InitializeComponent();
            setValues(home);
        }

        private void setValues(Home home)
        {
            mO = new MedicienOperations();
            co = new CustomersOperations();
            oO = new OrdersOperations();

            dTotalSales = 0;
            dPaid = 0;
            dDept = 0;

            listOfDaysSales = new List<Orders>();
            
            SalesDatePicker.Value = DateTime.Today;

            this.home = home;
        }


        private void soldMedsReport_Click_1(object sender, EventArgs e)
        {
            SoldMedsReport smr = new SoldMedsReport(home);
            smr.Show();
            home.Visible = false;
        }

        private void Reports_Load(object sender, EventArgs e)
        {

            mO.getInventory();
            showInventory();
        }

        private void showInventory()
        {
            setDataTable();
           
            getDaysSales();
            showInveotryinDataTable();
            showDaysSalesInTable();
            getLateFees();
        }

        private void showDaysSalesInTable()
        {


            setDaysSalesTable();
            DataRow dataRow;
            foreach (Orders o in listOfDaysSales)
            {
                dataRow = daysSalesTable.NewRow();

                dataRow[ORDER_DATE] = o.OrderDate.ToString("dd MMM yyyy");
                dataRow[TOTAL_PRICE] = o.TotalPrice + " EGP";                
                dataRow[PAID_AMOUNT] = o.PaidAmount + " EGP";
                dataRow[DEPT_VALUE] = o.DebtValue + " EGP";

                dTotalSales += o.TotalPrice;
                dPaid += o.PaidAmount;
                dDept += o.DebtValue;

                this.daysSalesTable.Rows.Add(dataRow);
            }
            setTPDvalus();
        }

        private void setTPDvalus()
        {
            totalSales.Text = dTotalSales + " EGP";
            Paid.Text = dPaid + " EGP";
            Late.Text = dDept + " EGP";

            dTotalSales = 0;
            dDept = 0;
            dPaid = 0;
        }

        private void getLateFees()
        {
            LateFees.Text = co.getCustomerDebtsTotalValue() + " EGP";
            SuppliersDepts.Text = co.getSuplierDebts() + " EGP";
        }

        private void getDaysSales() {
            this.listOfDaysSales = new List<Orders>();
            this.listOfDaysSales = oO.getDaySales(SalesDatePicker.Value);
        }

        private void showInveotryinDataTable()
        {
            DataRow dataRow;
            foreach (InventoryC i in InventoryC.INVNTRY)
            {
                dataRow = dataTable.NewRow();

                dataRow[MED_NAME] = i.MedName;
                dataRow[OLD_AMOUNT] = i.OldAmount;
                dataRow[OLD_VALUE] = i.OldValue + " EGP";
                dataRow[NEW_AMOUNT] = i.NewAmount;
                dataRow[NEW_VALUE] = i.NewValue + " EGP";
                dataRow[TOTAL_VALUE] = i.TotalMedValue + " EGP";

                InventoryC.TOTAL_INVENT_VALUE += i.TotalMedValue;
                this.dataTable.Rows.Add(dataRow);
            }
            totalValue.Text = InventoryC.TOTAL_INVENT_VALUE + " EGP";
        }
        
        private void setDataTable()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add(MED_NAME);
            dataTable.Columns.Add(OLD_AMOUNT);
            dataTable.Columns.Add(OLD_VALUE);
            dataTable.Columns.Add(NEW_AMOUNT);
            dataTable.Columns.Add(NEW_VALUE);
            dataTable.Columns.Add(TOTAL_VALUE);

            InventoryDataGridView.DataSource = dataTable;
        }

        private void setDaysSalesTable()
        {
            daysSalesTable = new DataTable();

            daysSalesTable.Columns.Add(ORDER_DATE);
            daysSalesTable.Columns.Add(TOTAL_PRICE);
            daysSalesTable.Columns.Add(PAID_AMOUNT);
            daysSalesTable.Columns.Add(DEPT_VALUE);
                   
            DaySalesGridView1.DataSource = daysSalesTable;
        }

        private void SalesDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if(SalesDatePicker.Value > DateTime.Today)
            {
                SalesDatePicker.Value = DateTime.Today;
            }
            getDaysSales();
            showDaysSalesInTable();
        }
    }
}
