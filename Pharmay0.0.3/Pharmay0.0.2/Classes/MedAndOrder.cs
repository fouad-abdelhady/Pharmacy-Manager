using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    public class MedAndOrder
    {
        private Medicine medicen;
        private int medOrdI;
        private int medicenId;
        private int orderId;
        private int numOfTabes;
        private double numOfPackages;
        private double totalPrice;
        private int soldAmount;

        public int MedOrdI
        {
            get
            {
                return medOrdI;
            }

            set
            {
                medOrdI = value;
            }
        }

        public int MedicenId
        {
            get
            {
                return medicenId;
            }

            set
            {
                medicenId = value;
            }
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

        public double NumOfPackages
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

        public Medicine Medicen
        {
            get
            {
                return medicen;
            }

            set
            {
                medicen = value;
            }
        }

        public int SoldAmount
        {
            get
            {
                return soldAmount;
            }

            set
            {
                soldAmount = value;
            }
        }

        public MedAndOrder() {
            this.medicen = null;
            this.medOrdI = 0;
            this.medicenId = 0;
            this.orderId = 0;
            this.numOfTabes = 0;
            this.numOfPackages = 0;
            this.totalPrice = 0.0;
            this.soldAmount = 0;
    }
        public void setMedOpj() {
            this.medicen = new Medicine();
        }

    }
}
