using System;

namespace DragRace
{
    public class Audi : Car
    {
        private int _currentSpeed = 0;

        public string ModelName()
        {
            return "Audi A4";
        }

        public void SpeedUp()
        {
            _currentSpeed += 16;
        }

        public void SlowDown()
        {
            _currentSpeed -= 6;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Audi A4: Rrrrrrr.....");
        }
    }
}