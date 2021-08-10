using System;

namespace Classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Logitech mouse", (decimal)70.00, 14);
            Product product2 = new Product("iPhone 5s", (decimal)999.99, 3);
            Product product3 = new Product("Epson EB-U05", (decimal)440.46, 1);
            product1.PrintProduct();
            product2.PrintProduct();
            product3.PrintProduct();
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("New product parametrs");
            Console.WriteLine("--------------------------------");
            product1.ChangePrice((decimal)30.0);
            product1.ReduceAmount();
            product1.PrintProduct();
            product2.ChangePrice((decimal)500.99);
            product2.ReduceAmount();
            product2.PrintProduct();
            product3.ChangePrice((decimal)200.0);
            product3.ReduceAmount();
            product3.PrintProduct();
        }
    }
}