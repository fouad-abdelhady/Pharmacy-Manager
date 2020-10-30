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
    public partial class UpdateMeds : Form
    {
        private static string NUMBER_OF_TAPES = "Slips";
        private static string EXPIRY_DATE = "E-Date";

        private Home home;
        private Medicine med;
        private Medicine medUpdated;
        private MedicienOperations medsOper;

        private DataTable oldMedsTable;
        public UpdateMeds(Home home, Medicine med)
        {
            InitializeComponent();
            setValues(home, med);
        }

        private void setValues(Home home, Medicine med)
        {
            this.home = home;
            this.med = med;
            this.medsOper = new MedicienOperations();
            medUpdated = new Medicine();
            medUpdated.OldmedsList = med.OldmedsList;
            oldMedsGridView.DataSource = getOldMdsDataTabel();
        }

        private DataTable getOldMdsDataTabel()
        {
            oldMedsTable = new DataTable();
            oldMedsTable.Columns.Add(NUMBER_OF_TAPES);
            oldMedsTable.Columns.Add(EXPIRY_DATE);
            return oldMedsTable;
        }

        private void showOldMedsInDataGridView()
        {
            oldMedsGridView.DataSource = getOldMdsDataTabel();
            DataRow dataRow;
            foreach (OldMed med in this.med.OldmedsList)
            {
                dataRow = oldMedsTable.NewRow();
                dataRow[NUMBER_OF_TAPES] = med.RemainingAmount;
                dataRow[EXPIRY_DATE] = med.ExpiryDate.Date.ToString("dd MMM yyyy");

                this.oldMedsTable.Rows.Add(dataRow);
            }
        }

        #region disable/disable text boxes

        private void DisableAll() {
            MedicenNameTXB.ReadOnly =
                TotalAmountTXB.ReadOnly =
                TapesPerUnitTXB.ReadOnly =
                PriceTXB.ReadOnly = true;
            saveCancelPanel.Visible = false;
        }

        private void MedicenNameTXB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisableAll();
            enableTextBx(MedicenNameTXB, false);
        }

        private void enableTextBx(TextBox field, bool state)
        {
            field.ReadOnly = state;
            saveCancelPanel.Visible = !state;
        }

        private void TotalAmountTXB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisableAll();
            enableTextBx(TotalAmountTXB, false);
        }

        private void TapesPerUnitTXB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisableAll();
            enableTextBx(TapesPerUnitTXB, false);
        }

        private void PriceTXB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisableAll();
            enableTextBx(PriceTXB, false);
        }

        #endregion

        #region getting data

        private void MedicenNameTXB_TextChanged(object sender, EventArgs e)
        {
            if (Companies.isEmpty(MedicenNameTXB))
            {
                MessageBox.Show("This field cannot be empty.");
                return;
            }
            medUpdated.MedName = MedicenNameTXB.Text.ToString();
        }

        private void TotalAmountTXB_TextChanged(object sender, EventArgs e)
        {
            if (Companies.isEmpty(TotalAmountTXB) || !Companies.isNum(TotalAmountTXB.Text.ToString()))
            {
                MessageBox.Show("This field cannot be empty or hold a non integer.");
                return;
            }
            medUpdated.NumOfTabes = int.Parse(TotalAmountTXB.Text.ToString());
        }

        private void TapesPerUnitTXB_TextChanged(object sender, EventArgs e)
        {

            if (Companies.isEmpty(TapesPerUnitTXB) || !Companies.isNum(TapesPerUnitTXB.Text.ToString()))
            {
                MessageBox.Show("This field cannot be empty or hold a non integer.");
                return;
            }
            medUpdated.TabPerPackage = int.Parse(TapesPerUnitTXB.Text.ToString());
        }

        private void PriceTXB_TextChanged(object sender, EventArgs e)
        {
            if (Companies.isEmpty(PriceTXB) || !Companies.isNum(PriceTXB.Text.ToString()))
            {
                MessageBox.Show("This field cannot be empty or hold a non integer.");
                return;
            }
            medUpdated.TabPrice = double.Parse(PriceTXB.Text.ToString());
        }

        #endregion

        private void UpdateMeds_Load(object sender, EventArgs e)
        {
            showMedInfo();
            showOldMedsInDataGridView();
        }

        private void showMedInfo()
        {
            MedicenNameTXB.Text = med.MedName;
            TotalAmountTXB.Text = med.NumOfTabes + "";
            TapesPerUnitTXB.Text = med.TabPerPackage + "";
            PriceTXB.Text = med.TabPrice+"";
            pareCodeLabel.Text = med.Parecode;
            ExpireDatePicker.Value = med.ExpiryDate;
        }

        private void save_Click(object sender, EventArgs e)
        {
            UpdateMedObj();
            showMedInfo();
            medsOper.addMedicen(this.med);
            DisableAll();
            
        }

        private void UpdateMedObj()
        {
            med.MedName = medUpdated.MedName;
            med.NumOfTabes = medUpdated.NumOfTabes;
            med.TabPrice = medUpdated.TabPrice;
            med.TabPerPackage = medUpdated.TabPerPackage;
            med.ExpiryDate = medUpdated.ExpiryDate;

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            showMedInfo();
            DisableAll();
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
            medUpdated.ExpiryDate = ExpireDatePicker.Value;
        }

        private void oldMedsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure You Want To Delete That Old Med?", "Delete Old Med", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                deleteOldMed();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Okay Not Deleted");
            }
        }

        private void deleteOldMed()
        {
            int idnex = oldMedsGridView.CurrentCell.RowIndex;
            OldMed om = (OldMed)med.OldmedsList[idnex];
            medsOper.deleteOldMed(om);
            oldMedsTable.Rows.RemoveAt(idnex);
            med.OldmedsList.RemoveAt(idnex);

        }
    }
}
