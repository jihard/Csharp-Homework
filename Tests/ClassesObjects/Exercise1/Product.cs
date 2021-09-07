using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Product
    {
        decimal _price;
        int _amount;
        string _name;

        public Product(string name, decimal priceAtStart, int amountAtStart)
        {
            this._name = name;
            this._amount = amountAtStart;
            this._price = priceAtStart;
        }

        public void PrintProduct() => Console.WriteLine(_name + " price: " + _price + " amount: " + _amount);

        public void ReduceAmount() => _amount--;

        public void ChangePrice(decimal changeprice) => _price = changeprice;
    }
}
    
