using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAccess
{
    public class Customer {

        private static int NextId = 1;
        public int Id { get; private set; } // private before set prevents people from changing id
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }

        public override string ToString() {
            return $"Id={this.Id}, Name={this.Name}, Nacct={this.IsNationalAccount}";      
        }

        static Customer() { // static constructor this will run before anything else happens
            //  read file to get the nex id to be assigned
            NextId = 21;
        }


        
        public void NationalAccount(string yesOrNo) {
            this.IsNationalAccount = yesOrNo.Equals("yes") ? true : false;
        }

        public static string PrintNextId() {
            return $"Next id is {NextId}";
        }
        public Customer(string Name) {  // is an instance constructor
            this.Id = NextId;
            this.Name = Name;
            NextId++;
        }
    }
}
