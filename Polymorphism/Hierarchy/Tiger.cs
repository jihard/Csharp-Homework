using System;

namespace Hierarchy
{
    public class Tiger : FelineType
    {
        public Tiger(string name, string livingRegion, double weight, string breed)
        : base(name, weight, livingRegion, breed)
        {
        }

        public override string MakeSound()
        {
            return " <ROOARR ";
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
            $" animal breed-{this.Breed}, animal weight-{this.Weight}, Region from-{this.LivingRegion}," +
            $" food pieces given-{base.FoodEaten}]";
        }
    }
}
