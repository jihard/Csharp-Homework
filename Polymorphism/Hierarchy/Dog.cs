using System;

namespace Hierarchy
{
    public class Dog : MammalType
    {
        public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return " <Wooff! ";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                FoodValidator.GetValidation(this.GetType().Name, food.GetType().Name);
                base.FoodEaten = 0;
                return;
            }
            base.FoodEaten = food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [animal name-{this.Name}," +
            $" animal weight-{this.Weight}, Region from-{this.LivingRegion}," +
            $" food pieces given-{base.FoodEaten}]";
        }
    }
}

