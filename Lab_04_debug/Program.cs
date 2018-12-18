using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 0;
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                x = i * i;
                z += x;

                Console.WriteLine("total is " + z);
            }
            Console.ReadLine();
        }
    }
}
