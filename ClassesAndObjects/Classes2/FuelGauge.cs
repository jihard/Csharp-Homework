using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class FuelGauge
    {
        private int _fuelLevel;
        public int Level;
        public int Fuel;
        public int ReportLevel()
        {
            return _fuelLevel;
        }
        public void Fill()
        {
            if (_fuelLevel < 70)
                _fuelLevel++;
        }
        public void DecreseLevel()
        {
            _fuelLevel--;
        }
    }
}
