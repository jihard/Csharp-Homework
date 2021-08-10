namespace FuelConsumptionCalculator
{
    public class Car
    {
       private double carspresentMileage,carliters; 
        
        public Car(double startOdo) => carspresentMileage = startOdo;
        
        public double CalculateConsumption()
        {
            return carspresentMileage / carliters;
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
            carliters += liters;
            carspresentMileage += mileage;
        }
    }
}

