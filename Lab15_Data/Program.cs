using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //32 bit
            int num01;
            // 16 bit
            short num02;
            // 64 bit
            long num03;

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            uint num04;
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MaxValue);

            // 32 bit
            float num05 = 1.2345f;
            // 64 bit, default
            double num06 = 1.2345;
            // 128 bit, money
            decimal num09 = 1.2345m;

            // string is an array of characters
            string string01 = "abc";
            // ascii ==> 0-127 BASIC CHARACTERS#
            // UNICODE UTF-8 : similar to ASCII : standard
            // UNICODE UTF-16 : C# : Represend basic English Plus characters from around the world
            char char01 = 'f';
            char char02 = (char)98;

            Console.WriteLine(char01);
            Console.WriteLine(char02);

            Console.ReadLine();

        }
    }
}
