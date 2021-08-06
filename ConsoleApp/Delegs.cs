using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Delegs
    {
        public delegate void TestDelegate(int a, int b);

        public void Implemenation()
        {
            TestDelegate t = new TestDelegate(Add);
            t(5, 4);
            t += Subtract;
            t(5, 4);
            t += Multiple;
            t(5, 4);
            t += Divide;
            t(5, 4);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum is {a + b}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"Differnece is {x - y}");
        }

        public void Multiple(int x, int y)
        {
            Console.WriteLine($"Product is {x * y}");
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine($"Division is {x / y}");
        }
    }
}