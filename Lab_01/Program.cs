using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_02_dll;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Els els = new Els();
            els.anything = 3;
            Console.WriteLine(els.anything);
        }
    }
}
