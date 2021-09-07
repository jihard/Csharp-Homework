using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Cat : FelineType
    {
        public Cat(string name, string livingRegion, double weight, string breed)
        : base(name, weight, livingRegion, breed)
        {
        }

        public override string MakeSound()
        {
            return " <Mjjau ";
        }

        public override string Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                FoodValidator.GetValidation(this.GetType().Name, food.GetType().Name);
                base.FoodEaten = 0;
                return "Eat food.";
            }
            base.FoodEaten = food.Quantity;
            return "Eat food.";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [animal name-{this.Name}, " +
            $"animal breed-{this.Breed}, animal weight-{this.Weight}, Region from-{this.LivingRegion}, " +
            $"food pieces given-{base.FoodEaten}]";
        }
    }
}

