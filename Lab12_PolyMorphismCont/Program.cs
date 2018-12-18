using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_PolyMorphismCont
{
    class Program
    {
        static void Main()
        {
            Parent p = new Parent();
            Child1 c = new Child1();
            Child2 t = new Child2();
            p.HaveAParty();
            c.HaveAParty();
            t.HaveAParty();
            Console.ReadLine();

        }
    }

    class Parent
    {
        // Parent aka Implementation
        // virtual means can override
        internal virtual void HaveAParty()
        {
            Console.WriteLine("Parent is having a dinner party!");
        }
    }

    class Child1 : Parent
    {
        internal override void HaveAParty()
        {
            Console.WriteLine("Child is having a party!");
        }
    }

    class Child2 : Parent
    {
        internal override void HaveAParty()
        {
            Console.WriteLine("Teenager is having a party!");
            base.HaveAParty();
        }
    }
}
