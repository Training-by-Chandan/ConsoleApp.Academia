using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //access-modifiers : if nothing then it is private/public based on the place
    //class is the keyword
    //name of class
    //{} : block: code is placed inside the block
    //class components :
    public class Human
    {
        //constructor : special function runs only once in its lifetime
        //it determines how the object is created
        public Human()
        {
            //empty
            _eyes = 2;
            _ears = 2;
            _hands = 2;
        }

        public Human(int eyes, int ears, int hands)
        {
            _eyes = eyes;
            _ears = ears;
            _hands = hands;
        }

        private int _eyes;
        private int _ears;
        private int _hands;

        public int Eyes
        {
            get { return _eyes; }
            set
            {
                if (value == 2)
                {
                    _eyes = value;
                }
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Eyes =>{_eyes}\nEars =>{_ears}\nHands => {_hands}");
        }

        public void OperationofEye(int eyes)
        {
            _eyes = eyes;
        }

        public void Test()
        {
        }

        public void Test(int i)
        {
        }
    }
}