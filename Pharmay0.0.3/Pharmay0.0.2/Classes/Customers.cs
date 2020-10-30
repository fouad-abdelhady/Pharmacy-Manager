using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    public class Customers
    {
        private List<Orders> customerOrders;
        private int customerID;
        private string customerName;
        private double debtValue;
        private string mobileNumber;

        public Customers()
        {
            customerID = -1;
            customerName = "";
            debtValue = 0;
            mobileNumber = "";
            customerOrders = new List<Orders>();
        }
        public void addCustomerOrder(Orders order) {
            this.customerOrders.Add(order);
        }
        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
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

        public string MobileNumber
        {
            get
            {
                return mobileNumber;
            }

            set
            {
                mobileNumber = value;
            }
        }

        public List<Orders> CutomerOrders
        {
            get
            {
                return customerOrders;
            }

            set
            {
                customerOrders = value;
            }
        }
    }
}
