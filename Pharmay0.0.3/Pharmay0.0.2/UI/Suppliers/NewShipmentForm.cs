
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
using Pharmay0._0._2.Classes;
using System.Text.RegularExpressions;

namespace Pharmay0._0._2.UI.Suppliers
{
    public partial class NewShipmentForm : Form
    {
        private string colmMedName = "Med Name";
        private string colmAmount = "Amount";
        private string colmTotalPrice = "Price";

        private int currentSelectedIndex;

        private Home home;
        private CompaniesMedsOrder cmo;
        private Medicine med;
        private ArrayList companiesList;
        private CompaniesOperations companyOperationObj;
        private MedicienOperations medicenOperations;
        private DataTable table;
        private bool isMedNew;

        public NewShipmentForm(Home home, ArrayList companiesList)
        {
            InitializeComponent();
            setFields(home, companiesList);
        }

        #region data representation

        private void setFields(Home home, ArrayList companiesList)
        {
            currentSelectedIndex = -1;
            companyOperationObj = new CompaniesOperations();
            medicenOperations = new MedicienOperations();
            middlePanel.Visible = false;
            if (companiesList == null)
                this.companiesList = this.companyOperationObj.getAllCompanies(CompaniesOperations.ALL_COMPANIES);
            else
                this.companiesList = companiesList;

            this.home = home;
            enabelAllFields(false);
            showUpdateOrderPanel(false);
        }

        private void addCompaniesToComboBox()
        {
            foreach (Company com in companiesList)
            {
                companiesListCombox.Items.Add(com.CompanyName + " -ID-" + com.CompanyID);
            }
        }

        private void enabelAllFields(bool enable)
        {
            medicenTextBox.Enabled =
            ExpireDatePicker.Enabled =
            amoutTextBox.Enabled =
            numberOfTapesEditBox.Enabled =
            buyingPriceEditBx.Enabled =
            sellingPriceTextBx.Enabled =
            addExtraMedToOrder.Visible = enable;

        }

        private void showMedInfo(Medicine medicine)
        {
            this.isMedNew = false;
            if (medicine == null)
            {
                MessageBox.Show("The barcode is not excist, you are about to add a new medicen");
                this.med = new Medicine();
                med.Parecode = parcodeTextBx.Text.ToString();
                this.isMedNew = true;
                return;
            }
            this.med = medicine;
            medicenTextBox.Text = medicine.MedName;
            ExpireDatePicker.Value = medicine.ExpiryDate;
            numberOfTapesEditBox.Text = medicine.TabPerPackage.ToString();
            sellingPriceTextBx.Text = (medicine.TabPrice * medicine.TabPerPackage).ToString();
        }

        private void showMedInfo(Medicine medicine, CompaniesMedsOrder cmo)
        {
            showMedInfo(medicine);
            amoutTextBox.Text = medicine.AdditionalNumberOfTapes.ToString();
            buyingPriceEditBx.Text = cmo.PricePerUnit.ToString();

        }

        private void resetAllFields()
        {
            enabelAllFields(false);
            parcodeTextBx.Text =
            medicenTextBox.Text =
            numberOfTapesEditBox.Text =
            sellingPriceTextBx.Text =
            amoutTextBox.Text =
            buyingPriceEditBx.Text = "";
            this.ActiveControl = parcodeTextBx;
        }

        #endregion



        #region Eevent handelers

        private void NewShipmentForm_Load(object sender, EventArgs e)
        {
            addCompaniesToComboBox();
            setDataGridViewDefaults();
        }

        private void setDataGridViewDefaults()
        {
            table = new DataTable();
            table.Columns.Add(colmMedName);
            table.Columns.Add(colmAmount);
            table.Columns.Add(colmTotalPrice);

            shipmentMedsDetails.DataSource = table;
        }

        private void moveToAddCom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.home.openChildForm(new Companies(this.home));
        }

        private void parcodeTextBx_TextChanged(object sender, EventArgs e)
        {
            if (parcodeTextBx.Text.ToString().Length == 13)
            {
                int inx = isListed(parcodeTextBx.Text.ToString());
                if (inx != -1)
                {
                    showMedInfo(inx);
                }
                else
                    showMedInfo(medicenOperations.getMedicen(parcodeTextBx.Text.ToString()));
                enabelAllFields(true);
            }

            else
                enabelAllFields(false);
        }

        private int isListed(string v)
        {
            int indx = 0;
            if (MedDetailsInShipment.SHIPMENT_MEDS != null)
                foreach (MedDetailsInShipment mds in MedDetailsInShipment.SHIPMENT_MEDS)
                {
                    if (mds.medicen.Parecode.Equals(v))
                    {
                        currentSelectedIndex = indx;
                        return indx;
                    }
                        
                    indx++;
                }
            return -1;
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if (((MedDetailsInShipment.SHIPMENT_MEDS == null || MedDetailsInShipment.SHIPMENT_MEDS.Count == 0)) && !check())
            {
                return;
            }
            if (((MedDetailsInShipment.SHIPMENT_MEDS == null || MedDetailsInShipment.SHIPMENT_MEDS.Count == 0)) && check()) {
                MessageBox.Show("Please press Add Extra Medicen button to continue");
                return;
            }
            Company selectedCompany = getSelectedCompanyObj();
            if (selectedCompany != null) {
                ShipmentConfirmation sc = new ShipmentConfirmation(home, selectedCompany, companiesList);
                sc.Show();
                home.Visible = false;
                return;
            }
            MessageBox.Show("Please select a supplier");
        }

        private Company getSelectedCompanyObj()
        {
            string temp;
            foreach (Company com in companiesList) {
                temp = com.CompanyName + " -ID-" + com.CompanyID;
                if (companiesListCombox.Text.ToString().Equals(temp)) {
                    return com;
                }
            }
            return null;
        }

        private void companiesListCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            middlePanel.Visible = true;
        }

        private void addExtraMedToOrder_Click(object sender, EventArgs e)
        {
            if (!check())
                return;
            med.IsNew = isMedNew;
            getMed();
           
            resetAllFields();

        }

        private void getMed()
        {
           
            med.MedName = medicenTextBox.Text;
            med.TabPerPackage = int.Parse(numberOfTapesEditBox.Text);
            med.TabPrice = double.Parse(sellingPriceTextBx.Text) / int.Parse(numberOfTapesEditBox.Text);
            med.AdditionalNumberOfTapes = int.Parse(numberOfTapesEditBox.Text) * Int32.Parse(amoutTextBox.Text);
            med.NumOfTabes += med.AdditionalNumberOfTapes;
            med.ExpiryDate = ExpireDatePicker.Value;


            cmo = new CompaniesMedsOrder();
            cmo.Parcode = parcodeTextBx.Text.ToString();
            cmo.NumOfPackages = Int32.Parse(amoutTextBox.Text);
            cmo.PricePerUnit = double.Parse(buyingPriceEditBx.Text);//buying Price
            med.TabBuyingPrice = cmo.PricePerUnit / med.TabPerPackage;
            cmo.TotalPrice = cmo.PricePerUnit * cmo.NumOfPackages;
            MedDetailsInShipment mdis = new MedDetailsInShipment(med, cmo);
            addMedOrderToSideList(mdis);
            getAndDisplayTotal();
            med = new Medicine();
            cmo = new CompaniesMedsOrder();

        }

        private void addMedOrderToSideList(MedDetailsInShipment mdis)
        {
            DataRow dataRow = table.NewRow();
            dataRow[colmMedName] = mdis.medicen.MedName;
            dataRow[colmAmount] = mdis.cmo.NumOfPackages.ToString();
            dataRow[colmTotalPrice] = mdis.cmo.TotalPrice.ToString();
            table.Rows.Add(dataRow);
        }

        private void ExpireDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ExpireDatePicker.Value < DateTime.Today)
            {
                MessageBox.Show("The expire date cannot be in the past");
                return;
            }
            TimeSpan differance = ExpireDatePicker.Value - DateTime.Today;
            if (differance.TotalDays < 30)
                MessageBox.Show("only " + differance.TotalDays + " days left for this medicen");
        }

        #endregion



        #region Input validation

        private bool check()
        {

            if (isEmpty(medicenTextBox) || isEmpty(amoutTextBox) ||
                isEmpty(numberOfTapesEditBox) || isEmpty(buyingPriceEditBx) || isEmpty(sellingPriceTextBx))
            {
                showErrorMessage("Please fill the missing fields");
                return false;
            }

            if (!isNum(amoutTextBox.Text))
            {
                showErrorMessage("Please enter a number in Amount field.");
                return false;
            }

            if (!isNum(numberOfTapesEditBox.Text))
            {
                showErrorMessage("Please enter a number in Tapes / unit field.");
                return false;
            }

            if (!isNum(buyingPriceEditBx.Text))
            {
                showErrorMessage("Please enter a number in Buying Price field.");
                return false;
            }

            if (!isNum(sellingPriceTextBx.Text))
            {
                showErrorMessage("Please enter a number in selling Price field.");
                return false;
            }

            if (double.Parse(sellingPriceTextBx.Text) < double.Parse(buyingPriceEditBx.Text))
            {
                showErrorMessage("The selling price must be greater than buying price");
                return false;
            }
            if (!checkEipiryDate(ExpireDatePicker))
            {
                showErrorMessage("The medicen is expired");
                return false;
            }
            errorMessage.Visible = false;
            return true;
        }

        private bool checkEipiryDate(DateTimePicker expireDatePicker)
        {
            if (expireDatePicker.Value < DateTime.Today)
            {
                return false;
            }
            return true;
        }

        private void showErrorMessage(string v)
        {
            errorMessage.Visible = true;
            errorMessage.Text = v;
        }

        public static bool isNum(string debt)
        {
            if (Regex.IsMatch(debt, Companies.NUMBER_REGEX))
                return true;
            return false;
        }

        public static bool isEmpty(TextBox companyName)
        {
            return companyName.Text.ToString().Equals("");
        }




        #endregion

        private void shipmentMedsDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedIndex = shipmentMedsDetails.CurrentCell.RowIndex;
            MedDetailsInShipment mds = (MedDetailsInShipment)MedDetailsInShipment.SHIPMENT_MEDS[currentSelectedIndex];
            parcodeTextBx.Text = mds.medicen.Parecode;
            showUpdateOrderPanel(true);
        }

        private void showMedInfo(int inx)
        {
            MedDetailsInShipment mds = (MedDetailsInShipment)MedDetailsInShipment.SHIPMENT_MEDS[inx];
            med.Parecode = parcodeTextBx.Text;
            med.IsNew = mds.medicen.IsNew;
            medicenTextBox.Text = mds.medicen.MedName;
            ExpireDatePicker.Value = mds.medicen.ExpiryDate;
            numberOfTapesEditBox.Text = mds.medicen.TabPerPackage.ToString();
            sellingPriceTextBx.Text = (mds.medicen.TabPrice * mds.medicen.TabPerPackage).ToString();
            amoutTextBox.Text = mds.cmo.NumOfPackages.ToString();
            buyingPriceEditBx.Text = mds.cmo.PricePerUnit.ToString();
        }

        private void showUpdateOrderPanel(bool on)
        {
            updateOrderMedsPanel.Visible = on;
            addExtraMedToOrder.Visible = !on;
        }

        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (!check())
                return;
            int count = MedDetailsInShipment.SHIPMENT_MEDS.Count;
            MedDetailsInShipment.SHIPMENT_MEDS.RemoveAt(currentSelectedIndex);
            count = MedDetailsInShipment.SHIPMENT_MEDS.Count;
            table.Rows[currentSelectedIndex].Delete();
            getMed();
           
            resetAllFields();
            showUpdateOrderPanel(false);

        }

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            resetAllFields();
            showUpdateOrderPanel(false);
        }

        private void deteteButton_Click(object sender, EventArgs e)
        {
            MedDetailsInShipment.SHIPMENT_MEDS.RemoveAt(currentSelectedIndex);
            table.Rows[currentSelectedIndex].Delete();
            getAndDisplayTotal();
            resetAllFields();
            showUpdateOrderPanel(false);
        }

        private void getAndDisplayTotal() {
            double total = 0;
            if (MedDetailsInShipment.SHIPMENT_MEDS != null) {
                foreach (MedDetailsInShipment mds in MedDetailsInShipment.SHIPMENT_MEDS)
                {
                    total += mds.cmo.TotalPrice;
                }
                TotalLabel.Text = "Total : " + total + " EGP";
                return;
            }
            TotalLabel.Text = "Total";
        }

        
    }
}
