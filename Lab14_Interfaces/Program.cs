using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Child();
            c.MustDoThis();
        }


    }
    // use interface to force a certain behaviour

    interface ITools
    {
        int x { get; set; }
        void MustDoThis();
        void MustUseThis();
    }

    class Parent
    {

    }
    // child has only one Parent
    class Child : Parent, ITools
    {
        public int x = 3;
        public void MustDoThis()
        {
            Console.WriteLine("Using Tool 1");
        }

        public void MustUseThis()
        {
            Console.WriteLine("Using Tool 2");
        }
    }
}
