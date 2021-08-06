using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class LivingThings
    {
        protected int i;

        public LivingThings()
        {
        }

        public LivingThings(int i)
        {
            this.i = i;
        }

        public LivingThings(string s)
        {
        }

        public virtual void Eat()
        {
            Console.WriteLine("Living things can eat");
        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base("")
        {
        }

        public Animal(int i) : base(i)
        {
            this.i = i;
        }

        public override void Eat()
        {
            Console.WriteLine("Animal can eat");
        }
    }

    public class Plant : LivingThings
    {
        public Plant()
        {
        }

        public Plant(int i)
        {
        }
    }

    public class HumanBeings : Animal
    {
        public HumanBeings()
        {
        }

        public HumanBeings(int i)
        {
        }
    }

    public class Men : HumanBeings
    {
        public Men()
        {
        }

        public Men(int i)
        {
        }
    }

    public class Women : HumanBeings
    {
        public Women()
        {
        }

        public Women(int i)
        {
        }
    }
}