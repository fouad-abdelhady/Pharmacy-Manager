using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    public class Sorter : IComparer
    {
        public int Compare(object x, object y)
        {
            Medicine med1 = (Medicine)x;
            Medicine med2 = (Medicine)y;
            return med1.MedName.CompareTo(med2.MedName);
        }       
    }
}
