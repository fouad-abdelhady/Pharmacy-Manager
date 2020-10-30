using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    public class Orders
    {
        private ArrayList listOfOrdMeds;
        private Customers customer;
        private int orderId;
        private DateTime orderDate;
        private double totalPrice;
        private double paidAmount;
        private int customerId;
        private bool paid;
        private double debtValue;
        public Orders()
        {
            listOfOrdMeds = new ArrayList();
            customer = new Customers();
            paid = true;
            DebtValue = 0;
        }
        public void addMedOrdToList(MedAndOrder mao)
        {
            this.listOfOrdMeds.Add(mao);
        }
        public int OrderId
        {
            get
            {
                return orderId;
            }

            set
            {
                orderId = value;
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

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public bool Paid
        {
            get
            {
                return paid;
            }

            set
            {
                paid = value;
            }
        }

        public ArrayList ListOfMeds
        {
            get
            {
                return listOfOrdMeds;
            }

            set
            {
                listOfOrdMeds = value;
            }
        }

        public Customers Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
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
    }
}
