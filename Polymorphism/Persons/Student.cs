using System;

namespace Persons
{
    class Student : Person
    {
        private double _gpa;

        public Student(string firstname, string lastname, int age, string address, double gpa)
            : base(age, firstname, lastname, address) => _gpa = gpa;

        public double Gpa
        {
            get
            {
                return _gpa;
            }

            set
            {
                _gpa = value;
            }
        }

        public void DisplayStudent()
        {
            Console.WriteLine("Student firstname:     " + firstname);
            Console.WriteLine("Student lastname:      " + lastname);
            Console.WriteLine("Student Age:           " + age);
            Console.WriteLine("Student address:       " + address);
            Console.WriteLine("Student GPA:           " + Gpa);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("\n\n");
        }
    }
}
