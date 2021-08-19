using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementList = new List<string>();
            string[] elements = { "1:", "2:","3:","4:",
            "6:", "7:","8:","9:","10:"};
            elementList.AddRange(elements);
            Console.WriteLine();
            elementList.Insert(4,"Element");
            Console.WriteLine(string.Join(", ", elementList));
            Console.WriteLine("----------------------------");
            elementList[elementList.Count() - 1] = "Last element";
            elementList.Sort();
            if (elementList.Contains("Foobar"))
            {
                Console.WriteLine("Foobar found.");
            }
            else
            {
                Console.WriteLine("foobar is not found.");
            }

            for (int i = 0; i < elementList.Count; i++)
            {
                string item = elementList[i];
                Console.WriteLine(item);
            }
        }
    }
}
