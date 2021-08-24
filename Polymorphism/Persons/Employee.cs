using System;

namespace Persons
{
    class Employee : Person
    {
        public string _jobTitle;

        public Employee(string firstname, string lastname, int age, string address, string jobTitle)
            : base(age, firstname, lastname, address) => _jobTitle = jobTitle;

        public void DisplayEmployee()
        {
            Console.WriteLine("Employee firstname:   " + firstname);
            Console.WriteLine("Employee lastname:    " + lastname);
            Console.WriteLine("Employee Age:         " + age);
            Console.WriteLine("Employee address:     " + address);
            Console.WriteLine("Employee Job:         " + _jobTitle);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("\n\n");
        }
    }
}
