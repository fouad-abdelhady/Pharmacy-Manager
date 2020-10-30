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
    public partial class Oeders : Form
    {
        private Home home;
        private DataTable ordMedsTabel;


        private List<Orders> ordersList;
        private Orders currntOrder;

        private readonly string MED_NAME = "Medicien";
        private readonly string AMOUNT = "Amount";
        private readonly string PRICE = "Cost";

        public Oeders(Home home, Orders order)
        {
            InitializeComponent();
            setobjects(home, order);
        }

        private void setobjects(Home home, Orders order)
        {
            this.home = home;            
            currntOrder = order;           
        }

        private void Oeders_Load(object sender, EventArgs e)
        {
            showOrderMainInfo();
            showOrderMeds();

        }

        private void showOrderMainInfo()
        {
            DateLabel.Text = this.currntOrder.OrderDate.Date.ToString("dd MMM yyyy");
            TotalPriceLabel.Text = "Total: " + this.currntOrder.TotalPrice + " EGP";
            PaidLabel.Text = "Paid: " + this.currntOrder.PaidAmount + " EGP";
            DebtLabel.Text = "Debt: " + this.currntOrder.DebtValue + " EGP";
            CustomerNameLabel.Text = this.currntOrder.Customer.CustomerName;
        }

        private DataTable getOrdMedsDataTabel()
        {

            ordMedsTabel = new DataTable();
            ordMedsTabel.Columns.Add(MED_NAME);
            ordMedsTabel.Columns.Add(AMOUNT);
            ordMedsTabel.Columns.Add(PRICE);

            return ordMedsTabel;
        }
            
        

        private void showOrderMeds()
        {
            OrdMedsGridView.DataSource = getOrdMedsDataTabel();
            DataRow dataRow;
            foreach (MedAndOrder mao in currntOrder.ListOfMeds)
            {
                dataRow = ordMedsTabel.NewRow();

                dataRow[MED_NAME] = mao.Medicen.MedName;
                dataRow[PRICE] = mao.TotalPrice + " EGP";
                dataRow[AMOUNT] = mao.NumOfTabes;
                
                this.ordMedsTabel.Rows.Add(dataRow);
            }
        }

        private void OrdersDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void OrdMedsGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        

    }
}
