using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_Overload
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass instance01 = new MyClass();
            instance01.DoThis();
            instance01.DoThis(10);
            instance01.DoThis("hi");
            // set values
            instance01.DoThisAlso(10, "meh");
            // use default values
            instance01.DoThisAlso();
            int output = instance01.DoThisSometimes(out int output2);
            Console.WriteLine(output + output2);
            Console.WriteLine(output);
            Console.WriteLine(output2);
            Console.ReadLine();

        }

    }

    class MyClass
    {
       public void DoThis() {  }
       public void DoThis(int x) { }
       public void DoThis(string y) { }

        // set default values
       public void DoThisAlso(int x = 5, string y = "string")
        {
            Console.WriteLine("x is " + x + " and y is " + y);
        }

       public int DoThisSometimes(out int y)
        {
            y = 200;
            return 100;
        }
    }
}
