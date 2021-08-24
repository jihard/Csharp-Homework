using System;

namespace DragRace
{
    public interface Car
    {
        string ModelName();
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        void StartEngine();
    }
}
