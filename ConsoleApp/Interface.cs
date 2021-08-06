using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface IArea
    {
        void Area(); //declare
    }

    public interface IPerimeter
    {
        void Perimeter();
    }

    public interface IShape : IArea, IPerimeter
    {
        void GetInput();
    }

    public class Square : IShape
    {
        private double Length;

        public void Area()
        {
            Console.WriteLine("Area of the Square is " + Math.Pow(Length, 2));
        }

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of the Square is " + 4 * Length);
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length of square");
            Length = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Rectangle : IShape
    {
        private double Length;
        private double Breadth;

        public void Area()
        {
            Console.WriteLine("Area of the Square is " + Length * Breadth);
        }

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of the Square is " + 2 * (Length + Breadth));
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length of square");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of square");
            Breadth = Convert.ToDouble(Console.ReadLine());
        }
    }
}