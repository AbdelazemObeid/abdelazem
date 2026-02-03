using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    internal class Picture
    {
        Shape[] arr;
        
        public Picture(Shape[] arr)
        {
            this.arr = arr;
        }
        public double calcArea()
        {
            double area = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                area += arr[i].calcArea();
            }
            return area;
        }
        public void area()
        {
            Console.WriteLine("Area of Picture shapes : "+calcArea());
        }
    }
}
