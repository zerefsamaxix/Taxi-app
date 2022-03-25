using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Pengemudi : {0}", DriverName);

            if (OnDuty == true)
            {
                Console.WriteLine("sedang bertugas : Ya", OnDuty);
            }
            else
            {
                Console.WriteLine("sedang bertugas : Tidak", OnDuty);
            }
            Console.WriteLine("jumlah penumpang : {0}\n", NumPassenger);
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
