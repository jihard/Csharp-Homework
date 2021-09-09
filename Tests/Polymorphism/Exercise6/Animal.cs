using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class Animal
    {
        private string _name;
        private double _weight;
        private int _foodEaten;

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public int FoodEaten
        {
            get { return this._foodEaten; }
            set { this._foodEaten = value; }
        }

        public double Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public abstract string MakeSound();

        public abstract string Eat(Food food);
    }
}


