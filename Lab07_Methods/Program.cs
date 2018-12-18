using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // in the main
            // Declare the method
            void DoThis()
            {
                Console.WriteLine("Doing Nothing)");
            }
            // invoke the method
            DoThis();
            DoThisAlso1();
            DoThisAlso.DoThisAlsoAlso();
            Console.ReadLine();

        }

        static void DoThisAlso1()
        {
            Console.WriteLine("Meh");
        }
    }
    // declare it with public static void, do this to call it from another class into another class
    class DoThisAlso
    {
        public static void DoThisAlsoAlso()
        {
            Console.WriteLine("Do this also");
        }
    }

}
