using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{

    class CompaniesMedsOrder
    {
        private int comMedsOrdID;
        private string parcode;
        private int companyOrderID;
        private int numOfPackages;
        private double totalPrice;
        private double pricePerUnit;

        public CompaniesMedsOrder()
        {

        }

        public int ComMedsOrdID
        {
            get
            {
                return comMedsOrdID;
            }

            set
            {
                comMedsOrdID = value;
            }
        }

        public string Parcode
        {
            get
            {
                return parcode;
            }

            set
            {
                parcode = value;
            }
        }

        public int CompanyOrderID
        {
            get
            {
                return companyOrderID;
            }

            set
            {
                companyOrderID = value;
            }
        }

        public int NumOfPackages
        {
            get
            {
                return numOfPackages;
            }

            set
            {
                numOfPackages = value;
            }
        }

        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }

        public double PricePerUnit
        {
            get
            {
                return pricePerUnit;
            }

            set
            {
                pricePerUnit = value;
            }
        }
    }
}
