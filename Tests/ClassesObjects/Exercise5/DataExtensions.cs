using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class DataExtensions
    {
        public DataExtensions(int month, int day, int year)
        {

        }
        public string DisplayDate(int month, int day, int year)
        {
            return $"Entered Date is: {month}/{day}/{year}";
        }
    }
}
