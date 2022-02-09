using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1
{
    internal class Q3
    {
        public void triangleArea(int a, int b, int c)
        {
            int s = (a + b + c) / 2;
            int triangleArea = s * ((s - a) * (s - b) * (s - c));
            double triangleAreaSqt = Math.Sqrt(triangleArea);
            Console.WriteLine($"the area of a triangle with side lengths {a}, {b}, and {c} is {triangleAreaSqt}");
        }
    }
}
