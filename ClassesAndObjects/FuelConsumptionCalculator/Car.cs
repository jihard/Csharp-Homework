namespace FuelConsumptionCalculator
{
    public class Car
    {
       private double cars_present_Mileage;
        private double cars_liters;

        public Car(double startOdo)
        {
            cars_present_Mileage = startOdo;
        }
        
        public double CalculateConsumption()
        {
            return cars_present_Mileage / cars_liters; 
        }

        private double ConsumptionPer100Km()
        {
            return (double)100 / CalculateConsumption();
        }

        public bool GasHog()
        {
            if (ConsumptionPer100Km() > 15) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EconomyCar()
        {
            if (ConsumptionPer100Km() < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FillUp(int mileage, double liters)
        {
            cars_liters += liters;
            cars_present_Mileage += mileage;
        }
    }
}

