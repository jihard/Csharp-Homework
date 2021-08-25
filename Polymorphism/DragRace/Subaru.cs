using System;

namespace DragRace
{
    public class Subaru : Car, Nitro
    {
        private int _currentSpeed = 0;

        public string ModelName()
        {
            return "Subaru outbreak";
        }

        public void SpeedUp()
        {
            _currentSpeed += 21;
        }

        public void SlowDown()
        {
            _currentSpeed -= 2;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 3;
        }

        public void StartEngine()
        {
            Console.WriteLine("Subaru outbreak: Rrrrrrr.....");
        }
    }
}
