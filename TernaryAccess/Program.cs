using System;

namespace TernaryAccess
{
    class Program {
        static void Main(string[] args) { 
            Console.WriteLine($" The cube of 17 is {Program.Cubed(17)}");
            //          var message = Customer.PrintNextId();
            //          Console.WriteLine(message);
            Console.WriteLine(Customer.PrintNextId());

            var cust1 = new Customer("Max Technical Training");
            cust1.NationalAccount("yes");

            Console.WriteLine(cust1);

            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Microsoft");



            var order1 = new Order { Amount = 1000 , Customer = cust1 };
            var order2 = new Order { Amount = 1500 , Customer = cust2 };
            var order3 = new Order { Amount = 2000 , Customer = cust3 };

        }
        static int Cubed(int nbr) {
            return nbr * nbr * nbr;

        }
    }
}
