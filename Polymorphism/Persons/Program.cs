using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("ALEX","Kaktus",37, "Atmodas iela  25","Butcher");
            Student student = new Student("Kiborgs", "Spensor",22,"Frg rajons 13",5.0);
            employee.DisplayEmployee();
            student.DisplayStudent();
        }
    }
}
