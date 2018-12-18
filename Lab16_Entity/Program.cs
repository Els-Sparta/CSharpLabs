using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_Entity
{
    class Program
    {
        // pull in database here. DBContxt is our database object
        static NorthwindEntities DBContext = new NorthwindEntities();

        static void Main(string[] args)
        {
            var c01 = new Customer();
            c01.likesCola = true;

            foreach (Lab16_Entity.Customer customer in DBContext.Customers)
            {
                Console.WriteLine("{0} lives in {1}", customer.ContactName, customer.City);
            }
            var customers =
                from c in DBContext.Customers
                select c;

            var customers2 =
                from c in DBContext.Customers
                where c.City == "Berlin"
                select c;

            var singleCustomer = DBContext.Customers.First(c => c.Country == "Finland");

            foreach (Customer c in customers2)
            {
                Console.WriteLine("{0} lives in {1}", c.ContactName, c.Country);
            }
            var customerList = customers.ToList<Customer>();

            customerList[0].ContactName = "Phil";
       
            DBContext.SaveChanges();

            Console.WriteLine(singleCustomer.ContactName);
            singleCustomer.ContactName += "Fred";

            DBContext.SaveChanges();

            Console.WriteLine(singleCustomer.ContactName);
            Console.ReadLine();
        }
    }
    partial class Customer
    {
        public bool likesCola;
    }
}
