using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    public class OldMed
    {
        private int Id;
        private string pareCode;
        private int remainingAmount;
        private DateTime expiryDate;

        public int Id1
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public string PareCode
        {
            get
            {
                return pareCode;
            }

            set
            {
                pareCode = value;
            }
        }

        public int RemainingAmount
        {
            get
            {
                return remainingAmount;
            }

            set
            {
                remainingAmount = value;
            }
        }

        public DateTime ExpiryDate
        {
            get
            {
                return expiryDate;
            }

            set
            {
                expiryDate = value;
            }
        }

        public OldMed()
        {

        }


    }
}
