using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    
    class MedOrderDetails
    {
        public static ArrayList MED_ORDERS_DETAILS = new ArrayList();
        private Medicine med;
        private CompaniesMedsOrder cmo;

        public MedOrderDetails(Medicine med, CompaniesMedsOrder cmo) {
            this.med = med;
            this.cmo = cmo;
            MED_ORDERS_DETAILS.Add(this);
        }

        public static void RESET_ORDERDETALIS_LIST() {
            MED_ORDERS_DETAILS = new ArrayList();
        }
    }
}
