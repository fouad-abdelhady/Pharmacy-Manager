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
    public partial class SoldMedsReport : Form
    {
        private Home home;
        private MedicienOperations mO;
        private DataTable medsTable;
        private readonly string MED_PARECODE = "Parecode";
        private readonly string MED_NAME = "Name" ;
        private readonly string MED_AMOUNT = "Total Amount";

        public SoldMedsReport(Home home)
        {
            InitializeComponent();
            setValues(home);
            showDataInDataTable();
        }

        private void showDataInDataTable()
        {
            medsTable = new DataTable();

            medsTable.Columns.Add(MED_PARECODE);
            medsTable.Columns.Add(MED_NAME);
            medsTable.Columns.Add(MED_AMOUNT);

            MedsDataGridView.DataSource = medsTable;

            showOrdersList();
        }

        private void showOrdersList()
        {
            mO.getSoldMedsReport(FromDatePicker.Value, ToDatePicker.Value);
            DataRow dataRow;
            foreach (SoldMeds sm in SoldMeds.SOLD_MEDS_LIST)
            {
                dataRow = medsTable.NewRow();
               
                dataRow[MED_PARECODE] = sm.PareCode ;
                dataRow[MED_NAME] = sm.MedName;
                dataRow[MED_AMOUNT] = sm.SoldSlips + "";

                this.medsTable.Rows.Add(dataRow);
            }
        }

        private void setValues(Home home)
        {
            this.home = home;
            FromDatePicker.Value = DateTime.Today;
            ToDatePicker.Value = DateTime.Today.AddDays(-1);
            mO = new MedicienOperations();
        }

        private void showMessageBox(string v)
        {
            MessageBox.Show(v);
        }

        #region date section
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
        #endregion

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void ApplyFilter_Click(object sender, EventArgs e)
        {
            showDataInDataTable();
        }
    }
}
