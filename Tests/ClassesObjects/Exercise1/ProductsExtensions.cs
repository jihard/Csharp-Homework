using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class ProductsExtensions
    {
        public ProductsExtensions(string name, decimal price, int amount, decimal changeprice)
        {
            
        }

        public string PrintProduct(string name, decimal price, int amount)
        {
            return $"{name}, price:  {price}  amount:  {amount}";
        }

        public int ReduceAmount(int amount)
        {
            return amount--;
        }

        public decimal ChangePrice(decimal changeprice, decimal price)
        {
            return price = changeprice;
        }
    }
}
