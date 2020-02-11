using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAccess
{
    public class Order { 


        private static int LastId = 0;

  /*      public string ToConsole() {
            return $"Id[{Id}],Amaount[{Amount}]";
        }*/

        public int Id { get; private set; }
        public double Amount { get; set; }
        public Customer Customer { get; set; }

        public void SetCustomer(Customer customer) {

        }

        static Order() { // static constructor this will run before anything else happens
            //  read file to get the nex id to be assigned
            LastId = 0;
        }
        public Order() {  // is an instance constructor
                this.Id = LastId += 7;
                this.Amount = Amount;
                this.Customer = Customer;
                
                
            }


        }
}
