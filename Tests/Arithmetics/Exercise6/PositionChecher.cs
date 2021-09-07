using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class PositionChecher
    {
        public static string GetOutput(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "CozaLoza ";
            }

            if (number % 3 == 0 && number % 7 == 0)
            {
                return "CozaWoza ";
            }
            else if (number % 3 == 0)
            {
                return "Coza ";
            }
            else if (number % 5 == 0)
            {
                return "Loza ";
            }
            else if (number % 7 == 0)
            {
                return "Woza ";
            }
            else
            {
                return number + " ";
            }
        }
    }
}
