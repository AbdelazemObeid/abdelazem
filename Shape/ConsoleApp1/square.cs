using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Square : Rectangle
    {
        public Square(int x) : base(x , x)
        {

        }
        public override double calcArea()
        {
            return (x * x);
        }
        public override void area()
        {
            Console.WriteLine("Area of Square : " + calcArea());
        }
    }
}
