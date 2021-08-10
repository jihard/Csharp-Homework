using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Odometer
    {
        public Odometer(FuelGauge fuelGauge)
        {
            _fuelGauge = fuelGauge;
        }

        private readonly FuelGauge _fuelGauge;
        private int _currentMilage;

        public int Report()
        {
            return _currentMilage;
        }
        public void Increment()
        {
            if (_currentMilage < 999999)
            {
                _currentMilage++;
                if (_currentMilage % 10 == 0)
                    _fuelGauge.DecreseLevel();
            }
            else
            {
                _currentMilage = 0;
            }
        }
    }
}
