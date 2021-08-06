using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public abstract class AbsShape // no object
    {
        public double area;
        public double perimeter;

        public void Area()
        {
            Console.WriteLine("Area is " + area);
        }

        public void Perimeter()
        {
            Console.WriteLine("Perimeter is " + perimeter);
        }

        public abstract void GetInput();
    }

    public class SquareAbs : AbsShape
    {
        private double length;

        public override void GetInput()
        {
            Console.WriteLine("Enter the Length of square");
            length = Convert.ToDouble(Console.ReadLine());
            area = Math.Pow(length, 2);
            perimeter = 4 * length;
        }
    }

    public class RectangleAbs : AbsShape
    {
        private double length;
        private double breadth;

        public override void GetInput()
        {
            Console.WriteLine("Enter the Length of rectangle");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth of rectangle");
            breadth = Convert.ToDouble(Console.ReadLine());
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }
    }
}