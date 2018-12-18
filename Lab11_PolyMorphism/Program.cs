using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_PolyMorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Child1 child1 = new Child1();
            Child2 child2 = new Child2();

            child1.Party();
            child2.Party();
            Console.ReadLine();
        }
    }

    public class Parent
    {
        // PARENT TO HAVE A PARTY
        public virtual void Party()
        {
            Console.WriteLine("Parent is Supervising ");
        }
    }

    class Child1 : Parent
    {
        // CHILD 1 : HAVE A DIFFERENT IMPLEMENTATION OF HAVE A PARTY METHOD
        public override void Party()
        {
            base.Party();
            Console.WriteLine("18+ Party");
        }
    }

    class Child2 : Parent
    {
        // CHILD 2 : DIFFERENT ONE AGAIN
        public override void Party()
        {
            base.Party();
            Console.WriteLine("Kid Party");
        }


    }
}
