
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    public class Shipments
    {
        private ArrayList orderMeds;
        private Company company;
        private string companyName;
        private int companyOrderId;
        private int companyId;
        private double totalPrice;
        private double paidAmount;
        private double debtValue;
        private DateTime orderDate;

        public int CompanyOrderId
        {
            get
            {
                return companyOrderId;
            }

            set
            {
                companyOrderId = value;
            }
        }

        public int CompanyId
        {
            get
            {
                return companyId;
            }

            set
            {
                companyId = value;
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

        public double PaidAmount
        {
            get
            {
                return paidAmount;
            }

            set
            {
                paidAmount = value;
            }
        }

        public double DebtValue
        {
            get
            {
                return debtValue;
            }

            set
            {
                debtValue = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }

            set
            {
                orderDate = value;
            }
        }

        public Company Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
               
            }
        }

        public ArrayList OrderMeds
        {
            get
            {
                return orderMeds;
            }

            set
            {
                orderMeds = value;
                MedDetailsInShipment.RESET_SHIPMENT_MEDS();
            }
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                companyName = value;
            }
        }

        public Shipments() {

        }


    }
}
