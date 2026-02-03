using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Rectangle : Shape
    {
        public Rectangle(int x, int y) : base(x, y)
        {
        }
        public override double calcArea()
        {
            return (x * y);
        }
        public override void area()
        {
            Console.WriteLine("Area of Rectangle : " + calcArea());
        }
    }
}
