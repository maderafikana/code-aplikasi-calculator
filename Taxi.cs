using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_App
{
    internal class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine($"Driver name = {DriverName}");
        }

        public void PickUpPassanger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine($"On Duty = Yes");
                Console.WriteLine($"Number Of Pasanger = {NumPassanger}");
            }
            else
            {
                Console.WriteLine($"On Duty = No");
                Console.WriteLine($"{DriverName} tidak sedang menjamput penumpang");
            }
        }

        public void DropOffPassanger()
        {
            if (NumPassanger != 0)
            {
                Console.WriteLine($"{DriverName} sedang mengantar penumpang");
            }
        }

    }
}
