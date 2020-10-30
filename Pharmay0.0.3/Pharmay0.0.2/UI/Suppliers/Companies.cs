
using Pharmay0._0._2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using Pharmay0._0._2.UI.Suppliers;
using Pharmay0._0._2.Database.ClassesDatabaseOperations;
using Pharmay0._0._2.Classes;

namespace Pharmay0._0._2.UI
{
    public partial class Companies : Form
    {
        private static string DEBT_VALUE = "Total Debt: ";
        private static string CURRENCY = " EGP";
        private static string COMPANY_ID = "ID";
        private static string COMPANY_NAME = "Company Name";
        private static string COMPANY_DEBTS = "Debt";
        private static string COMPANY_MOBILE = "Mobile Number";

        public static string MOBILE_NUMBER_REGX = "^01[0-9]+$";
        public static string NUMBER_REGEX = "^([0-9]|[0-9.0-9])+$";

        private double sumOfDebtValues;

        private Home home;      
        DataTable table ;
        private ArrayList companiesList;

        public Companies(Home home)
        {
            InitializeComponent();
            this.home = home;
            this.table = new DataTable();
            hide(false);

        }



        #region suppliers data presentation 

        private DataTable getCompanysTable()
        {
                        
            table.Columns.Add(COMPANY_ID);
            table.Columns.Add(COMPANY_NAME);
            table.Columns.Add(COMPANY_DEBTS);
            table.Columns.Add(COMPANY_MOBILE);
            DataRow dataRow;
            foreach (Company com in companiesList)
            {
                dataRow = table.NewRow();
                dataRow[COMPANY_ID] = com.CompanyID;
                dataRow[COMPANY_NAME] = com.CompanyName;
                dataRow[COMPANY_DEBTS] = com.DebtValue;
                dataRow[COMPANY_MOBILE] = com.MobileNum;
                table.Rows.Add(dataRow);
            }

            return table;
        }

        private void addNewRow(Company com) {
            com.CompanyID = companiesList.Count + 1;
            DataRow dataRow = table.NewRow();
            dataRow[COMPANY_ID] = com.CompanyID;
            dataRow[COMPANY_NAME] = com.CompanyName;
            dataRow[COMPANY_DEBTS] = com.DebtValue;
            dataRow[COMPANY_MOBILE] = com.MobileNum;
            table.Rows.Add(dataRow);
        }

        private void getTotalDebts() {
            foreach (Company supplier in companiesList)
                sumOfDebtValues += supplier.DebtValue;
            totalDebtValue.Text = DEBT_VALUE + sumOfDebtValues + CURRENCY;            
        }

        private void updateTotalDebtValue(double amount) {
            sumOfDebtValues += amount;
            totalDebtValue.Text = DEBT_VALUE + sumOfDebtValues + CURRENCY;
        } 

        private void Companies_Load(object sender, EventArgs e)
        {
            getCompaniesData();
            getTotalDebts();
            companiesData.DataSource = getCompanysTable();

        }

        private void getCompaniesData()
        {
            CompaniesOperations opj = new CompaniesOperations();
            this.companiesList = opj.getAllCompanies(CompaniesOperations.DEBT_COMPANIES);
        }

        #endregion



        #region add new suppliers event handlers

        private void save_Click(object sender, EventArgs e)
        {            
            if (!check())
                return;
            Company company = new Company(companyName.Text.ToString(),
               mobileNum.Text.ToString(), double.Parse(deptValue.Text.ToString()));

            CompaniesOperations operation = new CompaniesOperations();
            if (operation.addCompany(company)) {
                addNewRow(company);
                updateTotalDebtValue(company.DebtValue);
                resetNewSupplierTextBoxs();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            resetNewSupplierTextBoxs();
            hide(false);
        }

        #endregion



        #region company event handelrs 

        private void addCompany_Click(object sender, EventArgs e)
        {
            hide(true);
        }

        private void showSelectedCompanyData(object sender, DataGridViewCellEventArgs e)
        {
            int idnex = companiesData.CurrentCell.RowIndex;
            SupplierProfile obj = new SupplierProfile(this.home,(Company)companiesList[idnex]);
            home.openChildForm(obj);             
        }

        #endregion



        #region my functions

        private void hide(bool state)
        {
            newSpplierPanel.Visible = state;
        }

        private void resetNewSupplierTextBoxs()
        {
            companyName.Text = "";
            deptValue.Text = "0.0";
            mobileNum.Text = "01";
        }

        #endregion



        #region Input validation and error messages

        private bool check()
        {

            if (isEmpty(companyName) || isEmpty(deptValue) || isEmpty(mobileNum))
            {
                showErrorMessage("Please fill the missing fields");
                return false;
            }

            if (!isNum(deptValue.Text))
            {
                showErrorMessage("Please enter a number in dept field.");
                return false;
            }

            if (!isMobileNum(mobileNum.Text))
            {
                showErrorMessage("Please enter a valid Mobile Number.");
                return false;
            }
            errorMessage.Visible = false;
            return true;
        }

        public static bool isMobileNum(string text)
        {
            if (Regex.IsMatch(text, MOBILE_NUMBER_REGX))
                return true;
            return false;
        }

        private void showErrorMessage(string v)
        {
            errorMessage.Visible = true;
            errorMessage.Text = v;
        }

        public static bool isNum(string debt)
        {
            if (Regex.IsMatch(debt, NUMBER_REGEX))
                return true;
            return false;
        }

        public static bool isEmpty(TextBox companyName)
        {
            return companyName.Text.ToString().Equals("");
        }


        #endregion

        
    }
}
