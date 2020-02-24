using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Customers_OOP
{
    class Customer
    {
        string firstName = "";
        string lastName = "";

        public Customer()
        {
            Console.WriteLine("Hello World");
        }

        public Customer(string firstName, string lastname)
        {
            Console.WriteLine("Hello" + firstName + "" + lastname);
        }


        public string Name { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
