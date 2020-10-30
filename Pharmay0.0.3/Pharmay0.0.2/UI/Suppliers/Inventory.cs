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
    public partial class Inventory : Form
    {
        private static string MED_NAME = "Name";
        private static string TAPE_PRICE = " Price/S";
        private static string TAB_PER_PACKAGE = "S/Unit";
        private static string NUMBER_OF_TAPES = "Slips";
        private static string EXPIRY_DATE = "E-Date";

        private DataTable medsTable;
        private DataTable oldMedsTable;

        private Home home;
        private ArrayList medicens;
        private MedicienOperations medsOperations;
        public Inventory(Home home)
        {
            InitializeComponent();
            setOpjs(home);
            getAllMeds();
        }

        private void setOpjs(Home home)
        {
            this.home = home;
            medicens = new ArrayList();
            medsOperations = new MedicienOperations();

            medsTable = new DataTable();
            oldMedsTable = new DataTable();
        }

        private void getAllMeds()
        {
            medicens = medsOperations.getAllMeds();
            medicens.Sort(new Sorter());
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            medsDataGridView.DataSource = getMedsDataTabel();
            oldMedsGridView.DataSource = getOldMdsDataTabel();
            showMedsInDataGridView();
        }

        private DataTable getOldMdsDataTabel()
        {
            oldMedsTable = new DataTable();       
            oldMedsTable.Columns.Add(NUMBER_OF_TAPES);
            oldMedsTable.Columns.Add(EXPIRY_DATE);
            return oldMedsTable;
        }

        private DataTable getMedsDataTabel()
        {
            medsTable.Columns.Add(MED_NAME);
            medsTable.Columns.Add(TAPE_PRICE);
            medsTable.Columns.Add(TAB_PER_PACKAGE);
            medsTable.Columns.Add(NUMBER_OF_TAPES);
            medsTable.Columns.Add(EXPIRY_DATE);

            return medsTable;
        }

        private void showMedsInDataGridView() {
            DataRow dataRow;
            foreach (Medicine med in medicens)
            {
                dataRow = medsTable.NewRow();

                dataRow[MED_NAME] = med.MedName;
                dataRow[TAPE_PRICE] = med.TabPrice+" EGP";
                dataRow[TAB_PER_PACKAGE] = med.TabPerPackage;
                dataRow[NUMBER_OF_TAPES] = med.NumOfTabes;
                dataRow[EXPIRY_DATE] = med.ExpiryDate.Date.ToString("dd MMM yyyy");

                this.medsTable.Rows.Add(dataRow);
            }
        }

        private void showOldMedsInDataGridView(Medicine medicen)
        {
            oldMedsGridView.DataSource = getOldMdsDataTabel();

            DataRow dataRow;
            foreach (OldMed med in medicen.OldmedsList)
            {
                dataRow = oldMedsTable.NewRow();                                             
                dataRow[NUMBER_OF_TAPES] = med.RemainingAmount;
                dataRow[EXPIRY_DATE] = med.ExpiryDate.Date.ToString("dd MMM yyyy");

                this.oldMedsTable.Rows.Add(dataRow);
            }
        }

        private void medsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idnex = medsDataGridView.CurrentCell.RowIndex;
            Medicine m = (Medicine)medicens[idnex];
            if(m.OldmedsList.Count == 0) 
                medsOperations.getOldMeds(m);

            showOldMedsInDataGridView(m);
        }

        private void medsDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {          
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void medsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateOrderMedsPanel.Visible = true;
            medsDataGridView_CellDoubleClick(sender,e);
        }

        private void oldMedsGridView_MouseClick(object sender, MouseEventArgs e)
        {
            updateOrderMedsPanel.Visible = false;
        }

        private void deteteButton_Click(object sender, EventArgs e)
        {
            int idnex = medsDataGridView.CurrentCell.RowIndex;
            Medicine m = (Medicine)medicens[idnex];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int idnex = medsDataGridView.CurrentCell.RowIndex;
            Medicine m = (Medicine)medicens[idnex];
            home.openChildForm(new UpdateMeds(home, m));
            this.Close();
        }
    }
}
