using System;

namespace DragRace
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
