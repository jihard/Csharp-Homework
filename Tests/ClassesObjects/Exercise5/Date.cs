using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Date
    {
        private int month;
        private int day;
        private int year;

        public Date(int _month, int _day, int _year)
        {
            month = _month;
            day = _day;
            year = _year;
        }

        public void SetMonth(int Months)
        {
            if (Months >= 0 && Months <= 12)
            {
                month = Months;
            }
            else
            {
                month = 0;
            }
        }

        public int GetMonth()
        {
            return month;
        }

        public void SetDay(int Days)
        {
            if (Days >= 0 && Days <= 30)
            {
                day = Days;
            }
            else
            {
                day = 0;
            }
        }

        public int GetDay()
        {
            return day;
        }

        public void SetYear(int Years)
        {
            year = Years;
        }

        public int GetYear()
        {
            return year;
        }

        public void DisplayDate()
        {
            Console.WriteLine($"Entered Date is: {month}/{day}/{year}", GetMonth(), GetDay(), GetYear());
        }
    }
}

