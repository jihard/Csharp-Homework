using System;

namespace Exercise8
{
    public class Employee
    {
        string _name;
        double _basepay;
        double _hour;
        public Employee()
        {
            name = _name;
            basepay = _basepay;
            workingHours = _hour;
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double basepay
        {
            get { return _basepay; }
            set { _basepay = value; }
        }
        public double workingHours
        {
            get { return _hour; }
            set { _hour = value; }
        }
        public double TotalSalary()
        {
            if (basepay < 8)
            {
                return 0;
            }

            if (workingHours <= 40)
            {
                return workingHours * basepay;
            }
            else if (workingHours > 60)
            {
                return 0;
            }
            else
            {
                return (40 * basepay) + ((workingHours - 40) * (basepay * 1.5));
            }
        }
        public void display()
        {
            Console.WriteLine("+=-------------------------------------------------------------------------=+");
            Console.WriteLine("|ID| (Employee name)    |  (Base pay)    |    (worked hr)  | (Totalsalary)   |");
            Console.WriteLine("|  |                    |Minimum is $8.00| Only 60 hr/week |                 |");
            Console.WriteLine("|  |                    |   per/hour     |     allowed     |                 |");
            Console.WriteLine("----------------------- |----------------|-----------------|-----------------|");
            Console.WriteLine($"|1.|      {name}       |  {basepay}     |{workingHours}   |{TotalSalary()}  |");
            Console.WriteLine("|2.|                    |                |                 |                 |");
            Console.WriteLine("|3.|                    |                |                 |                 |");
            Console.WriteLine("+=--------------------------------------------------------------------------=+");
        }
    }
    class Program
    {
        static void Main()
        {
            Employee _note = new Employee();
            Console.WriteLine("Enter Employee Name : ");
            _note.name = Console.ReadLine();
            Console.WriteLine("Enter Employee base pay : ");
            _note.basepay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Employee Hours : ");
            _note.workingHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Employee :  \n");
            _note.display();
            Console.ReadKey();
        }
    }
}