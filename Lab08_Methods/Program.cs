using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANTIANTE new object p
            Parent p = new Parent();
            // STATIC CALL is attached to class
            Parent.Dothis();

            //instance variable is attached to instance
            p.Grow();
            Console.WriteLine(p.age);
        }
    }

    class Parent
    {
        public int age { get; set; }
        public void Grow()
        {
            age++;
        }
        public static void Dothis()
        {

        }
    }
}
