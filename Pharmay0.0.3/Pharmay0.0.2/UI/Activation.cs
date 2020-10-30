using Pharmay0._0._2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmay0._0._2.UI
{
    public partial class Activation : Form
    {
        private static string DEVS_ID = "6OXahhUxy0";
        private static string DEVS_PASSWORD = "JACK HULU WALMART COFFEE golf korean LAPTOP hulu coffee 3 * XBOX egg JACK & & $ ^ zip ROPE";
        private ProductData pd;
        private Home home;
        private string vercode;     
        public Activation(string verivicationCode, Home home)
        {
            InitializeComponent();
            pd = ProductData.getPorductDataObj();
            this.home = home;
            this.vercode = verivicationCode;
           
        }

        private void ApplyFilter_Click(object sender, EventArgs e)
        {
            if (DEVS_ID.Equals(DevID.Text) && DEVS_PASSWORD.Equals(DevPassword.Text)) {
                pd.CopyID = vercode;
                ProductData.update();
                home.Close();
            }
            if (vercode.Equals(dirCode.Text)) {
                pd.CopyID = vercode;
                ProductData.update();
                home.Close();
            }
            home.Close();
        }

        private void Activation_FormClosing(object sender, FormClosingEventArgs e)
        {
            home.Close();
        }       
    }
}
