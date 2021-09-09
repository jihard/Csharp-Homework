using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Toyota : Car
    {
        private int _currentSpeed = 0;

        public string ModelName()
        {
            return "Toyota Auris";
        }

        public void SpeedUp()
        {
            _currentSpeed += 15;
        }

        public void SlowDown()
        {
            _currentSpeed -= 7;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Toyota Auris: Rrrrrrr.....");
        }
    }
}
