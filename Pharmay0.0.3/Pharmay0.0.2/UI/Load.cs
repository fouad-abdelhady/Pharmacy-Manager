using Pharmay0._0._2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmay0._0._2.UI.Suppliers
{
    public partial class Load : Form
    {
        private static string PLUS_MAC = "Anoud O.Khaldi";
        //private static string DEV1_MAIL = "fouad.abd-elhady@outlook.com";
        //private static string DEV2_MAIL = "a.abdelhady47@yahoo.com";
        private static string MADD_EN = "";
        private ProductData pd = null;
        private Home home;

        public Load(Home home)
        {
            InitializeComponent();
            this.home = home;

        }

        private void Load_Load(object sender, EventArgs e)
        {
            pd = ProductData.getPorductDataObj();

        }

        private void checkProductState()
        {
            MADD_EN = encode(GetMacAddress() + PLUS_MAC);
            if (this.pd == null)
                return;
            if (pd.CopyID.Equals(MADD_EN))
            {
                home.Visible = true;
                this.Close();
                return;
            }
            setLable();
        }

        private void setLable()
        {
            if (this.pd == null)
                return;
            Eng1Name.Text = pd.Dev1Name;
            Eng1Mobile.Text = pd.Dev1Mobile;
            Eng1Email.Text = pd.Dev1Email;

            Eng2Name.Text = pd.Dev2Name;
            Eng2Mobile.Text = pd.Dev2Mobile;
            Eng2Email.Text = pd.Dev2Email;

            Notation.Text = pd.Notation;

            Website.Text = pd.FacebookLink;

        }

        public static string GetMacAddress()
        {
            String firstMacAddress = NetworkInterface
                                        .GetAllNetworkInterfaces()
                                        .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                                        .Select(nic => nic.GetPhysicalAddress().ToString())
                                        .FirstOrDefault();
            return firstMacAddress;
        }

        static string encode(string rawData)
        {

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString());
                }
                return builder.ToString();
            }
        }

        private void Load_Shown(object sender, EventArgs e)
        {
            checkProductState();
        }

        private void Load_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (home.Visible == false)
                home.Close();
        }
      

        private void Website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(pd.FacebookLink);
        }

        private void Eng1Email_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + pd.Dev1Email);
        }

        private void Eng2Email_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + pd.Dev2Email);
        }

        private void Eng1Name_Click(object sender, EventArgs e)
        {
            
        }

        private void Eng1Name_DoubleClick(object sender, EventArgs e)
        {
            Activation act = new Activation(MADD_EN, home);
            act.Show();
            this.Visible = false;
        }
    }
}
