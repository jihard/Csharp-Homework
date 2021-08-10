using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            Console.WriteLine();
            int liters;
            int counter = 1;
            Car car = new(0);
            Car car1 = new(0);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Pease enter {0} reading of bmw - kilometrs: ", counter);
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter bmw raiding used litres: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car.FillUp(startKilometers, liters);
                Console.WriteLine("Please enter {0} reading of opelis - kilometrs: ", counter);
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter opelis raiding used litres: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
                counter++;
            }
            Console.WriteLine("BMW Kilometers per liter are " +(Math.Round( car.CalculateConsumption()) + " gasHog: " + car.GasHog()));
            Console.WriteLine("Opelis Kilometers per liter are " +(Math.Round(car1.CalculateConsumption()) + "  geconomyCar: " + car.EconomyCar()));
        }
    }
}
