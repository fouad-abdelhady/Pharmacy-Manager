using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    public class SoldMeds
    {
        public static List<SoldMeds> SOLD_MEDS_LIST = new List<SoldMeds>();
        private string pareCode;
        private string medName;
        private double soldSlips;

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

        public double SoldSlips
        {
            get
            {
                return soldSlips;
            }

            set
            {
                soldSlips = value;
            }
        }

        public void addElementToSoldMdsList(SoldMeds Smed) {
            SOLD_MEDS_LIST.Add(Smed);
        }
        public void resetSoldMdsList() {
            SOLD_MEDS_LIST = new List<SoldMeds>();
        }
        public SoldMeds() {
            this.PareCode = null;
            this.MedName = null;
            this.SoldSlips = 0;
        } 


    }
}
