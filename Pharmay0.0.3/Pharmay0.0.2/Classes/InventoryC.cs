using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{

    public class InventoryC
    {
        #region constants vals
        public static string PARECODE = "Parcode";
        public static string MED_NAME = "MedName";
        public static string OLD_AMOUNT = "OldAmont";
        public static string OLD_VALUE = "OldValue";
        public static string NEW_AMOUNT = "NewAmount";
        public static string NEW_VALUE = "NewValue";
        public static string TOTAL_MED_VALUE = "TotalMedValue";
        #endregion

        public static List<InventoryC> INVNTRY = new List<InventoryC>();

        private string pareCode;
        private string medName;
        private double oldAmount;
        private double oldValue;
        private double newAmount;
        private double newValue;
        private double totalMedValue;
        public static double TOTAL_INVENT_VALUE = 0;

        public InventoryC() {
            this.pareCode = null;
            this.medName = null;
            this.oldAmount = 0;
            this.oldValue = 0;
            this.newAmount = 0;
            this.newValue = 0;
            this.totalMedValue = 0;
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

        public double OldAmount
        {
            get
            {
                return oldAmount;
            }

            set
            {
                oldAmount = value;
            }
        }

        public double OldValue
        {
            get
            {
                return oldValue;
            }

            set
            {
                oldValue = value;
            }
        }

        public double NewAmount
        {
            get
            {
                return newAmount;
            }

            set
            {
                newAmount = value;
            }
        }

        public double NewValue
        {
            get
            {
                return newValue;
            }

            set
            {
                newValue = value;
            }
        }

        public double TotalMedValue
        {
            get
            {
                return totalMedValue;
            }

            set
            {
                totalMedValue = value;
            }
        }

        public double TotalInventoryValue
        {
            get
            {
                return TOTAL_INVENT_VALUE;
            }

            set
            {
                TOTAL_INVENT_VALUE = value;
            }
        }

        public void restInventoryList() {
            INVNTRY = new List<InventoryC>();
        }

        public void getTotalInventoryValue() {
            TOTAL_INVENT_VALUE = 0;
            foreach (InventoryC inv in INVNTRY) {
                TOTAL_INVENT_VALUE += TotalMedValue;
            }
           
        }

    }
}
