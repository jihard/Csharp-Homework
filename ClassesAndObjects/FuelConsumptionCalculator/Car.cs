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
           return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            cars_liters += liters;
            cars_present_Mileage += mileage;
        }
    }
}

