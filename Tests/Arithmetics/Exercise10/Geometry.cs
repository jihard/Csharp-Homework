using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius, double PI)
        {
            return  2 * PI * radius;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public static double AreaOfTriangle(double ground, double height)
        {
            return (ground * height) / 2;
        }
    }
}

 