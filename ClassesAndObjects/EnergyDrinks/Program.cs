using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private static void Main(string[] args)
        {
            double NumberedSurveyed = 12467;
            double PurchasedEnergyDrinks = 0.14 * (Math.Round(NumberedSurveyed));
            double PreferCitrusDrinks = 0.64 * (Math.Round(PurchasedEnergyDrinks)); 
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("The approximately " + PurchasedEnergyDrinks + " of customers in the survey who purchased one or more energy drinks per week");
            Console.WriteLine("The approximate " + PreferCitrusDrinks + " of customers in the survey who prefer citrus flavored energy drinks");
        }
    }
}
