using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Bmw : Car
    {
        private int _currentSpeed = 0;

        public string ModelName()
        {
            return "BMW X5";
        }

        public void SpeedUp()
        {
            _currentSpeed += 18;
        }

        public void SlowDown()
        {
            _currentSpeed -= 9;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("BMW X5: Rrrrrrr.....");
        }
    }
}