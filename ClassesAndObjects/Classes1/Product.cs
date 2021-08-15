using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    class Product
    {
        decimal price;
        int amount;
        string name;

        public Product(String name, decimal priceAtStart, int amountAtStart)
        {
            this.name = name;
            this.amount = amountAtStart;
            this.price = priceAtStart;
        }

        public void PrintProduct() => Console.WriteLine(name + " price: " + price + " amount: " + amount);

        public void ReduceAmount() => amount--;

        public void ChangePrice(decimal changeprice) => price = changeprice;

    }
}
    
