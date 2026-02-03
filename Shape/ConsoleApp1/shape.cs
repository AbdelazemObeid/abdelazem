using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Shape
    {
        public int x;
        public int y;
        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double calcArea()
        {
            return 0;
        }
        public virtual void area()
        {
            Console.WriteLine("I am in Shape class");
        }
    }
}
