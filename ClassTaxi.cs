using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    public class Taxi
    {
        public string DriverName{ get; set; }
        public string OnDuty { get; set; }
        public float NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("DriverName : {0}", DriverName);
            Console.WriteLine("OnDuty : {0}", OnDuty);
            Console.WriteLine("NumPassenger : {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang\n", DriverName);
        }
    }
}
