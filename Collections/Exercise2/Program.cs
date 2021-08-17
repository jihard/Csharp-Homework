using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();
            mySet.Add("Red");
            mySet.Add("Black");
            mySet.Add("Yellow");
            mySet.Add("Brown");
            mySet.Add("Grey");
            Console.Write("Should have 5 elements: ");
            Console.WriteLine(String.Join(",", mySet));

            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            }

            mySet.Clear();
            Console.Write("Is mySet empty: "+mySet.Count()+"\n");
            mySet.Add("Green");
            mySet.Add("Orange");
            mySet.Add("Green");
            mySet.Add("Purple");
            Console.WriteLine(String.Join(",", mySet));
            Console.ReadKey();
        }
    }
}
        
    
