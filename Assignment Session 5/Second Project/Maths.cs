using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session_5.Second_Project
{
    internal class Maths
    {
        // here we will use static to call it directly from class without need to create Obj.
        public static int Add(int a, int b) { return a + b; }
        public static int Subtract(int a, int b) { return a - b; }
        public static int Multiply(int a, int b) { return a * b; }
        public static double Divide(double a, double b) { return a / b; }
    }
}
