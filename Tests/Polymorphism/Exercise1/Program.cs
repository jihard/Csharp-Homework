using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleList = new List<Car>();
            var audi = new Audi();
            vehicleList.Add(audi);
            var bmw = new Bmw();
            vehicleList.Add(bmw);
            var lexus = new Lexus();
            vehicleList.Add(lexus);
            var tesla = new Tesla();
            vehicleList.Add(tesla);
            var toyota = new Toyota();
            vehicleList.Add(toyota);
            var subaru = new Subaru();
            vehicleList.Add(subaru);

            vehicleList.ForEach(item => item.StartEngine());

            for (var i = 1; i <= 10; i++)
            {
                for (int j = 0; j < vehicleList.Count; j++)
                {
                    Car item = vehicleList[j];
                    item.SpeedUp();
                    item.SlowDown();
                    Console.WriteLine(item + "--" + item.ShowCurrentSpeed());
                    if (i == 3 && item is Nitro speedup)
                    {
                        speedup.UseNitrousOxideEngine();
                    }
                }
            }

            Dictionary<int, string> raceResults = new Dictionary<int, string>();

            vehicleList.ForEach(item => raceResults.Add(int.Parse(item.ShowCurrentSpeed()), item.ModelName()));

            Console.WriteLine("Winner is:" + raceResults[raceResults.Keys.Max()] + ", speed:" + raceResults.Keys.Max());
            Console.ReadKey();
        }
    }
}
