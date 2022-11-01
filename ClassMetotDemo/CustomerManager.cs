using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{

    
    internal class CustomerManager
    {
      
       public static void customerAdd(Customer customer) 
        {
            Console.WriteLine("who has name "+ customer.name+" " +  "was added");
        }
        public static void customerDelete(Customer customer) 
        {
            Console.WriteLine("who has name " + customer.name + " " + "was deleted");
        }
        public static void customerList(Customer customer) 
        {
            Console.WriteLine("who has name " + customer.name + " " + "was listed");
        }

        
    }
}
