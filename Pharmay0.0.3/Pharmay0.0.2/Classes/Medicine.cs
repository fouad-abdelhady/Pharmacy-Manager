using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    public class Medicine
    {
        private OldMed oldmed;
        private ArrayList oldmedsList;
        private bool isNew;
        private int medID;
        private string medName;
        private double tabPrice;
        private double tabBuyingPrice;
        private int tabPerPackage;
        private int numOfTabes;
        private int additionalNumberOfTapes;
        private string parecode;        
        private DateTime expiryDate;
        private bool isItOld;
        public Medicine()
        {
            numOfTabes = 0;            
            tabPrice = 0;
            tabPerPackage = 0;
            numOfTabes = 0;
            MedName = null;
            parecode = null;
            expiryDate = new DateTime();
            IsItOld = false;
            Oldmed = null;
            OldmedsList = new ArrayList();
        }

        public int MedID
        {
            get
            {
                return medID;
            }

            set
            {
                medID = value;
            }
        }

        public void addOldMed(OldMed oldm) {
            this.OldmedsList.Add(oldm);
        }
        public string MedName
        {
            get
            {
                return medName;
            }

            set
            {
                medName = value;
            }
        }

        public double TabPrice
        {
            get
            {
                return tabPrice;
            }

            set
            {
                tabPrice = value;
            }
        }

        public int TabPerPackage
        {
            get
            {
                return tabPerPackage;
            }

            set
            {
                tabPerPackage = value;
            }
        }

        public int NumOfTabes
        {
            get
            {
                return numOfTabes;
            }

            set
            {
                numOfTabes = value;
            }
        }

        public string Parecode
        {
            get
            {
                return parecode;
            }

            set
            {
                parecode = value;
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

        public int AdditionalNumberOfTapes
        {
            get
            {
                return additionalNumberOfTapes;
            }

            set
            {
                additionalNumberOfTapes = value;
            }
        }

        public bool IsNew
        {
            get
            {
                return isNew;
            }

            set
            {
                isNew = value;
            }
        }

        public bool IsItOld
        {
            get
            {
                return isItOld;
            }

            set
            {
                isItOld = value;
            }
        }

        public OldMed Oldmed
        {
            get
            {
                return oldmed;
            }

            set
            {
                oldmed = value;
            }
        }

        public ArrayList OldmedsList
        {
            get
            {
                return oldmedsList;
            }

            set
            {
                oldmedsList = value;
            }
        }

        public double TabBuyingPrice
        {
            get
            {
                return tabBuyingPrice;
            }

            set
            {
                tabBuyingPrice = value;
            }
        }
    }
}
