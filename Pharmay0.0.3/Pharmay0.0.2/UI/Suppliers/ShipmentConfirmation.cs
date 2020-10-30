
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
    public partial class ShipmentConfirmation : Form
    {
        private string colmMedName = "Med Name";
        private string colmAmount = "Amount";
        private string colmTotalPrice = "Price";

        private Home home;
        private Company company;
        private Shipments shipment;
        private ArrayList companiesList;

        private ShipmentsDatabaseOperations sdo;
       
    
        private DataTable table;

        private bool cancel = false;
        public ShipmentConfirmation(Home home, Company company, ArrayList companiesList)
        {
            InitializeComponent();
            setValue(home, company, companiesList);
        }

        private void setValue(Home home, Company company, ArrayList companiesList)
        {
            this.company = new Company();
            this.FormBorderStyle = FormBorderStyle.None;
            this.home = home;
            this.company = company;
            this.companiesList = companiesList;
            
            createShipment();

            setDatgridViewProps();           
        }

        private void setDatgridViewProps()
        {
            table = new DataTable();
            table.Columns.Add(colmMedName);
            table.Columns.Add(colmAmount);
            table.Columns.Add(colmTotalPrice);

            shipmentMedsDetails.DataSource = table;

            showDataInDataGridView();
        }

        private void showDataInDataGridView()
        {
            DataRow dataRow;
            foreach (MedDetailsInShipment mds in shipment.OrderMeds)
            {
                dataRow = table.NewRow();
                dataRow[colmMedName] = mds.medicen.MedName;
                dataRow[colmAmount] = mds.cmo.NumOfPackages.ToString();
                dataRow[colmTotalPrice] = mds.cmo.TotalPrice.ToString() +" EGP";
                table.Rows.Add(dataRow);
            }           
        }

        private void createShipment()
        {
            shipment = new Shipments();

            shipment.Company = this.company;
            shipment.CompanyId = this.company.CompanyID;            
            shipment.PaidAmount = 0;
            shipment.DebtValue = 0;
            shipment.OrderDate = DateTime.Today;
            shipment.OrderMeds = MedDetailsInShipment.SHIPMENT_MEDS;
            shipment.TotalPrice = getTotal();

            // reset the static medlist
            MedDetailsInShipment.RESET_SHIPMENT_MEDS();
            showData();
        }

        private double getTotal()
        {
            double total = 0;
            foreach (MedDetailsInShipment mds in shipment.OrderMeds)
            {
                total += mds.cmo.TotalPrice;
            }
            return total;
        }

        private void showData() {
            showOrderDetails();
            showOrderMeds();
        }

        private void showOrderMeds()
        {
            
        }

        private void showOrderDetails()
        {
            SupplierName.Text = shipment.Company.CompanyName;
            OrderDate.Text = shipment.OrderDate.ToString("dd/MMM/yyyy");
            Total.Text = shipment.TotalPrice + " EGP";
            Paid.Text = shipment.PaidAmount.ToString();
            Dept.Text = shipment.TotalPrice + " EGP";
        }

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            if (!cancel) {
                MessageBox.Show("Press Cancel Button Again To CANCEL the Shipment");
                cancel = true;
                return;
            }
            moveToHome();
        }

        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            sdo = new ShipmentsDatabaseOperations();
            shipment.Company.DebtValue += shipment.DebtValue;
            sdo.insertShipment(shipment);
            moveToHome();
        }

        private void moveToHome() {
            home.Visible = true;
            home.openChildForm(new NewShipmentForm(home, companiesList));
            this.Close();
        }

        private void Paid_TextChanged(object sender, EventArgs e)
        {
            if (!Companies.isNum(Paid.Text.ToString()))
            {
                Paid.Text = "0";
                return;
            }
            if (double.Parse(Paid.Text.ToString()) > shipment.TotalPrice) {
                Dept.Text = "0";
                return;
            }
            shipment.PaidAmount = double.Parse(Paid.Text.ToString());
            shipment.DebtValue = shipment.TotalPrice - shipment.PaidAmount;
            
            Dept.Text = shipment.DebtValue + "EGP";
        }
    }
}
