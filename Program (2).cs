using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Taxi taxi = new Taxi();

            Console.WriteLine("--- DATA DRIVER TAXI ---");
            Console.WriteLine();

            Console.Write("Nama Driver :  ");
            taxi.DriverName = Console.ReadLine();

            Console.Write("On Duty [Yes or No] :  ");
            taxi.OnDuty = Console.ReadLine().ToLower() == "yes" ? true : false;

            if (taxi.OnDuty)
            {
                Console.Write("Number of Passanger:  ");
                taxi.NumPassanger = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                taxi.TaxiInfo();
                taxi.PickUpPassanger();
                taxi.DropOffPassanger();
            }
            else
            {
                Console.WriteLine();
                taxi.TaxiInfo();
                taxi.PickUpPassanger();
            }

            Console.ReadKey();

        }
    }
}
