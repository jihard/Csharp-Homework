using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Arithmetics1Extension
    {
        public static bool IsCompatibleWith15(int num1, int num2)
        {
            return (num1 == 15 || num2 == 15 || Math.Abs(num1 + num2) == 15);
        }
    }
}
