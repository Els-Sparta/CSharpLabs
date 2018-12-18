using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Lab05_Obj
{
    class Program
    {
        static void Main(string[] args)
        {

            Object object01 = new
            {
                name = "Els",
                age = 22
            };
            Console.WriteLine(object01);

            dynamic object02 = new ExpandoObject();
            object02.name = "Els";
            object02.age = 22;
            Console.WriteLine(object02.name);
        }


    }
}
