using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class AnimalStorage
    {
        public static Animal GetAnimal(string[] animalParts)
        {
            string animalType = animalParts[0];
            switch (animalType)
            {
                case "Horse":
                    return new Horse(animalParts[1], double.Parse(animalParts[2]), animalParts[3]);
                case "Dog":
                    return new Dog(animalParts[1], double.Parse(animalParts[2]), animalParts[3]);
                case "Cat":
                    return new Cat(animalParts[1], animalParts[2], double.Parse(animalParts[3]), animalParts[4]);
                case "Tiger":
                    return new Tiger(animalParts[1], animalParts[2], double.Parse(animalParts[3]), animalParts[4]);
                default:
                    return null;
            }
        }
    }
}
