using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmay0._0._2.Database.ClassesDatabaseOperations;

namespace Pharmay0._0._2.UI.Suppliers
{
    public partial class DeleteOrder : Form
    {
        private OrdersOperations Oo;
        private Home home;
        public DeleteOrder(Home home)
        {
            InitializeComponent();
            setValues(home);
            
        }

        private void setValues(Home home)
        {
            this.home = home;
            this.Oo = new OrdersOperations();
            deleteDatePicker.Value = DateTime.Today.AddMonths(-6);
        }

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            home.Visible = true;
            this.Close();
        }

        private void DeleteDatePicker_ValueChanged(object sender, EventArgs e)
        {           
            if (deleteDatePicker.Value > DateTime.Today)
            {
                MessageBox.Show("the date cannot be in the future.");
                deleteDatePicker.Value = DateTime.Today.AddMonths(-6);
                return;
            }          
        }

        private void deteteButton_Click(object sender, EventArgs e)
        {
            string table = "Orders";
            string message = "Are you sure you want to delete all orders older than "+deleteDatePicker.Value.Date.ToString("dd MMM yyyy");
            DialogResult dialogResult = MessageBox.Show(message, "Confirm Process", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Oo.deleteOrders(deleteDatePicker.Value, table))
                {
                    MessageBox.Show("Done");
                    home.Visible = true;
                    home.openChildForm(new AdvanceOrderViewer(home));
                    this.Close();
                }
                else
                    MessageBox.Show("some error happend");
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }           
        }
    }
}
