using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Tesla : Car
    {
        private int _currentSpeed = 0;

        public string ModelName()
        {
            return "Tesla Model 3";
        }

        public void SpeedUp()
        {
            _currentSpeed += 12;
        }

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Tesla Model 3: -- silence ---");
        }
    }
}