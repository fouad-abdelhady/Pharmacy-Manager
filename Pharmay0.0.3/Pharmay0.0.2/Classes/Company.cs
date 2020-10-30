using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    public class Company
    {
        private int companyID;
        private string companyName;
        private string mobileNum;
        private double debtValue;        

        public Company(string companyName, string mobileNum, double debtValue)
        {
            this.companyName = companyName;
            this.mobileNum = mobileNum;
            this.debtValue = debtValue;
        }
        public Company()
        {

        }
        public int CompanyID
        {
            get
            {
                return this.companyID;
            }
            set
            {
                this.companyID = value;
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

        public string MobileNum
        {
            get
            {
                return mobileNum;
            }

            set
            {
                mobileNum = value;
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
