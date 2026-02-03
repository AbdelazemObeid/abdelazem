using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Circle : Shape
    {
        public Circle(int x) : base(x, x)
        {
        }
        public override double calcArea()
        {
            return (3.14 * x * x);
        }
        public override void area()
        {
            Console.WriteLine("Area of Circle : " + calcArea());
        }
    }
}
