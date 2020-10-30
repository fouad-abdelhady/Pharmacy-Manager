using Pharmay0._0._2.Classes;
using Pharmay0._0._2.Database.ClassesDatabaseOperations;
using System;
using System.Collections;
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
    public partial class ShipmentsForm : Form
    {
        private static string COMPANY_NAME = "Company";
        private static string SHIPMENT_DATE = "Date";
        private static string COST = "Cost";
        private static string PAID_AMOUNT = "Paid";
        private static string REMAINING_AMOUNT = "Remaining";

        private string restOfQuery;

        private Home home;
        ShipmentsDatabaseOperations sDOobj;
        private DataTable table;
        private ArrayList shipmentsList;

        public ShipmentsForm(Home home)
        {
            InitializeComponent();
            setOjects(home);
        }

        private void setOjects(Home home)
        {
            this.home = home;
            this.sDOobj = new ShipmentsDatabaseOperations();
            table = new DataTable();
            FromDatePicker.Value = DateTime.Today;
            ToDatePicker.Value = DateTime.Today.AddDays(-1);
            restOfQuery = " AND DebtValue > 0 ";
        }



        #region display shipments

        private void ShipmentsForm_Load(object sender, EventArgs e)
        {
            getCurrentSupplierOrders();
            getShipmentsTable();

        }

        private void getShipmentsTable()
        {
            table = new DataTable();
            table.Columns.Add(COMPANY_NAME);
            table.Columns.Add(SHIPMENT_DATE);
            table.Columns.Add(COST);
            table.Columns.Add(PAID_AMOUNT);
            table.Columns.Add(REMAINING_AMOUNT);
            DataRow dataRow;
            foreach (Shipments shipment in shipmentsList)
            {
                dataRow = table.NewRow();

                dataRow[COMPANY_NAME] = shipment.CompanyName;
                dataRow[SHIPMENT_DATE] = shipment.OrderDate.ToString("dd MMM yyyy");
                dataRow[COST] = shipment.TotalPrice;
                dataRow[PAID_AMOUNT] = shipment.PaidAmount;
                dataRow[REMAINING_AMOUNT] = shipment.DebtValue;
                
                table.Rows.Add(dataRow);
            }

            shipmentsData.DataSource = table;
        }

        private void getCurrentSupplierOrders()
        {
            sDOobj = new ShipmentsDatabaseOperations();
            this.shipmentsList = sDOobj.getAllShipmentsOrdered(FromDatePicker.Value, ToDatePicker.Value, restOfQuery);
        }

        #endregion



        private void addNewShipment_Click(object sender, EventArgs e)
        {
            home.openChildForm(new NewShipmentForm(this.home, null));
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            getCurrentSupplierOrders();
            getShipmentsTable();
        }

        #region date insertion part
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
              //  showMessageBox("To Date cannot be greater Than From Date");
                ToDatePicker.Value = FromDatePicker.Value;
                return;
            }
        }
        #endregion

        private void showMessageBox(string v)
        {
            MessageBox.Show(v);
        }

        private void PaidNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (PaidNotPaid.Checked)
            {
                PaidNotPaid.Text = "Paid";
                restOfQuery = " AND DebtValue = 0 ";
               // showMessageBox(restOfQuery);
            }
            else
            {
                PaidNotPaid.Text = "NotPaid";
                restOfQuery = " AND DebtValue > 0 ";
                //showMessageBox(restOfQuery);
            }
        }

        private void All_CheckedChanged(object sender, EventArgs e)
        {
            if (All.Checked)
            {
                PaidNotPaid.Enabled = false;
                restOfQuery = " ";
            }
            else { 
                PaidNotPaid.Enabled = true;
                PaidNotPaid_CheckedChanged(sender, e);
                showMessageBox(restOfQuery+" Empty ");
            }
        }

        private void deteteButton_Click(object sender, EventArgs e)
        {
            if (!makeSure("Make sure delet process"))
                return;
            if (sDOobj.deleteCompanyOrder(FromDatePicker.Value, ToDatePicker.Value, restOfQuery)) {
                getCurrentSupplierOrders();
                getShipmentsTable();
            } 

        }

        private bool makeSure(string v)
        {
            DialogResult dialogResult = MessageBox.Show(v, "Confirm Process", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return false;
            }
            return false;
        }
    }
}
