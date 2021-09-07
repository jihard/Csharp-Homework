using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Lexus : Car, Nitro
    {
        private int _currentSpeed = 0;

        public string ModelName()
        {
            return "Lexus ES 200 ";
        }

        public void SpeedUp()
        {
            _currentSpeed += 17;
        }

        public void SlowDown()
        {
            _currentSpeed -= 3;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 35;
        }

        public void StartEngine()
        {
            Console.WriteLine("Lexus ES 200: Rrrrrrr.....");
        }
    }
}
