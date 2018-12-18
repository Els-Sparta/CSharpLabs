using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class HolidayPlans
    {
        void DoThis()
        {
            // ADD CODE HERE, VISIT VENICE?
        }
        // Incomplete travel plans
        public abstract void Travel();
    }

    class HolidayPlansComplete : HolidayPlans
    {
        public override void Travel()
        {
            // Code here travel plan - COMPLETE
        }
    }
}
