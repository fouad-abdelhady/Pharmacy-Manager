using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
   
    class MedDetailsInShipment
    {
        public static ArrayList SHIPMENT_MEDS;
        public Medicine medicen;
        public CompaniesMedsOrder cmo;
        public MedDetailsInShipment(Medicine medicen, CompaniesMedsOrder cmo) {
            this.medicen = medicen;
            this.cmo = cmo;
            if (SHIPMENT_MEDS == null)
                SHIPMENT_MEDS = new ArrayList();
            SHIPMENT_MEDS.Add(this);
        }

        public static void RESET_SHIPMENT_MEDS() {
            SHIPMENT_MEDS = new ArrayList();
        }
    }
}
