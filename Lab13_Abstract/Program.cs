using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
        }
    }

    public abstract class Parent
    {
        public abstract void DoThis();
    }

    class Child : Parent
    {
        public override void DoThis()
        {

        }
    }
}
