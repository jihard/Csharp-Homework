using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "VolksWagen", "Mercedes", "Tesla" };
            string[] country = { "Germany", "Germany", "Japan", "Germany", "Germany", "USA" };
            string join = " <--------> ";

            Dictionary<string, string> dice = new Dictionary<string, string>();
            for (int i = 0; i < country.Length; i++)
            {
                dice.Add(array[i], country[i]);
            }
            Console.WriteLine(string.Join(", ", dice));
            Console.WriteLine("----------------------------------------------------");

            var carList = array.ToList();
            for (int i = 0; i < carList.Count; i++)
            {
                string car = carList[i];
                string carModels;
                if (car == "Tesla")
                {
                    carModels = "USA";
                }
                else if (car == "Honda")
                {
                    carModels = "Japan";
                }
                else
                {
                    carModels = "Germany";
                }
                Console.WriteLine(car + join + carModels);
            }
            Console.WriteLine("--------------------------------------------");

            var hash = new HashSet<string>(array);
            foreach (var car in hash)
            {
                string carModels;
                if (car == "Tesla")
                {
                    carModels = "USA";
                }
                else if (car == "Honda")
                {
                    carModels = "Japan";
                }
                else
                {
                    carModels = "Germany";
                }
                Console.WriteLine(car + join + carModels);
            }
        }
    }
}