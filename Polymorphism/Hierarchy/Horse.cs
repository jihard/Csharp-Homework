using System;

namespace Hierarchy
{
    public class Horse : MammalType
    {
        public Horse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return " <Horse sound! ";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable")
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
            $" animal wight-{this.Weight}, Region from-{this.LivingRegion}," +
            $" food pieces given-{base.FoodEaten}]";
        }
    }
}
