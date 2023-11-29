using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProj
{
    public class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }

    public class TestCustomer
    {
        static void Main()
        {
            List<Customer> Customers = new List<Customer>();
            Customer c1 = new Customer {CustId = 101, Name="Scott", City="Hydrabad", Balance = 25000.00};
            Customer c2 = new Customer { CustId = 102, Name = "Smith", City = "Chennai", Balance = 29000.00 };
            Customer c3 = new Customer { CustId = 103, Name = "Dave", City = "Delhi", Balance = 24000.00 };
            Customer c4 = new Customer { CustId = 104, Name = "David", City = "Banglore", Balance = 59000.00 };

            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);
            Customers.Add(c4);

            foreach(Customer obj in  Customers)
            {
                Console.WriteLine(obj.CustId + " " + obj.Name + " "+ obj.City + " "+ obj.Balance);
            }
            Console.ReadLine();
        }
    }
}
