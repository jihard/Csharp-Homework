using System;

namespace Hierarchy
{
    public class FoodStorage
    {
        public static Food GetFood(string[] foodParts)
        {
            string foodType = foodParts[0];
            switch (foodType)
            {
                case "Meat":
                    return new Meat(int.Parse(foodParts[1]));
                case "Vegetable":
                    return new Vegetable(int.Parse(foodParts[1]));
                default:
                    return null;
            }
        }
    }
}
