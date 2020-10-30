
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
    public partial class SupplierProfile : Form
    {
        private static string ORDER_DATE = "Order Date";
        private static string TOTAL_COST = "Total Cost";
        private static string PAID_AMOUNT = "Paid";
        private static string REMAINING_AMOUNT = "Debt";

        private Home home = null;
        private CompaniesOperations operation;
        ShipmentsDatabaseOperations sdo;
        private Company companyObj = null;

        DataTable table;
        private ArrayList ordersList;


        public SupplierProfile(Home home, Company companyObj)
        {
            InitializeComponent();
            this.home = home;
            this.companyObj = companyObj;
            this.table = new DataTable();
            this.sdo = new ShipmentsDatabaseOperations();
            this.operation = new CompaniesOperations();
        }

        private DataTable getOrdersTable()
        {
            table = new DataTable();
            table.Columns.Add(ORDER_DATE);
            table.Columns.Add(TOTAL_COST);
            table.Columns.Add(PAID_AMOUNT);
            table.Columns.Add(REMAINING_AMOUNT);
            DataRow dataRow;

            foreach (Shipments shipment in ordersList)
            {
                dataRow = table.NewRow();
                dataRow[ORDER_DATE] = shipment.OrderDate.ToString("dd MMM yyyy");
                dataRow[TOTAL_COST] = shipment.TotalPrice;
                dataRow[PAID_AMOUNT] = shipment.PaidAmount;
                dataRow[REMAINING_AMOUNT] = shipment.DebtValue;
                table.Rows.Add(dataRow);
            }

            return table;
        }
        private void addNewRow(Shipments shipment) {

            DataRow dataRow = table.NewRow();
            dataRow[ORDER_DATE] = shipment.OrderDate.ToString("dd MMM yyyy");
            dataRow[TOTAL_COST] = shipment.TotalPrice;
            dataRow[PAID_AMOUNT] = shipment.PaidAmount;
            dataRow[REMAINING_AMOUNT] = shipment.DebtValue;

            table.Rows.Add(dataRow);
        }
        private void SupplierProfile_Load(object sender, EventArgs e)
        {
            if(companyObj != null)
                setTextBoxesToCompany(companyObj);
            getCurrentSupplierOrders();
            ordersData.DataSource = getOrdersTable();
        }

        private void getCurrentSupplierOrders()
        {
            sdo = new ShipmentsDatabaseOperations();
            this.ordersList = sdo.getOrders(companyObj);
        }




        #region text boxes operations

        private void setTextBoxesToCompany(Company companyObj)
        {
            companyName.Text = companyObj.CompanyName;
            mobileNumberEditBox.Text = companyObj.MobileNum;
            debtValueEditBox.Text = companyObj.DebtValue.ToString();
        }

        private void enableTextView(object sender, MouseEventArgs e)
        {
            allowTextBoxEdite(companyName);           
        }

        private void setAllTextBoxesToReadOnly() {
            companyName.BorderStyle = mobileNumberEditBox.BorderStyle = debtValueEditBox.BorderStyle = BorderStyle.None;
            companyName.ReadOnly = mobileNumberEditBox.ReadOnly = debtValueEditBox.ReadOnly = true;
            saveCancelPanel.Visible = false;
        }

        private void allowTextBoxEdite(TextBox textBox) {
            setAllTextBoxesToReadOnly();
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.ReadOnly = false;
            saveCancelPanel.Visible = true;
        }
      
        private void enableMobileNum(object sender, MouseEventArgs e)
        {
            allowTextBoxEdite(mobileNumberEditBox);
        }

        private void enableDebtValue(object sender, MouseEventArgs e)
        {
            allowTextBoxEdite(debtValueEditBox);
        }

        #endregion


        #region info and error messages operations

        private void EnableInfoMessage(object sender, EventArgs e)
        {
            infoMessage.Visible = true;
        }

        private void DisableInfoMessage(object sender, EventArgs e)
        {
            infoMessage.Visible = false;
        }

        private void showErrorMessage(string v)
        {
            errorMessage.Visible = true;
            errorMessage.Text = v;
        }

        #endregion


        #region save and cancel events

        private void save_Click(object sender, EventArgs e)
        {
            if (check()) {
                setAllTextBoxesToReadOnly();
                saveCancelPanel.Visible = false;
                
                companyObj.CompanyName = companyName.Text.ToString();
                companyObj.DebtValue = double.Parse(debtValueEditBox.Text.ToString());
                companyObj.MobileNum = mobileNumberEditBox.Text.ToString();
                operation.updateCompany(companyObj);
                // Update OrderList
            }
        }

        private bool check()
        {

            if (Companies.isEmpty(companyName) || Companies.isEmpty(debtValueEditBox) || Companies.isEmpty(debtValueEditBox))
            {
                showErrorMessage("The field cannot be empty");
                return false;
            }

            if (!Companies.isNum(debtValueEditBox.Text))
            {
                showErrorMessage("Cannot accept letters.");
                return false;
            }

            if (!Companies.isMobileNum(mobileNumberEditBox.Text))
            {
                showErrorMessage("Invalid mobile number.");
                return false;
            }
            errorMessage.Visible = false;
            return true;
        }       

        private void cancel_Click(object sender, EventArgs e)
        {
            setAllTextBoxesToReadOnly();
            setTextBoxesToCompany(companyObj);
            saveCancelPanel.Visible = false;
        }



        #endregion

        private void ordersData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = ordersData.CurrentCell.RowIndex;
            Shipments shpment = (Shipments)ordersList[index];

            if (shpment.TotalPrice == shpment.PaidAmount)
                return;

            if (!makeSure("Do you want to set that shipment as Paid?"))
                return;

            if (sdo.setCompanyOrder(shpment)) {

                this.companyObj.DebtValue -= shpment.DebtValue;
                debtValueEditBox.Text = this.companyObj.DebtValue + "";
              //  operation.updateCompany(companyObj);

                shpment.PaidAmount = shpment.TotalPrice;
                shpment.DebtValue = 0;

                ordersData.Rows.RemoveAt(index);
                addNewRow(shpment);
                
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
