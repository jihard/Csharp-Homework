using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
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

        public override string Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable")
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
            return $"{this.GetType().Name} [animal name-{this.Name}, animal weight-{this.Weight}, Region from-{this.LivingRegion}, food pieces given-{base.FoodEaten}]";
        }
    }
}

