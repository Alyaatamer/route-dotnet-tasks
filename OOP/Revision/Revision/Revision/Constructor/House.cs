using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Constructor
{
    internal class House
    {
        public int price;
        public int NumberOfRooms;
        public string Address;

        // Constructor 
        // no return type


        // defualt constructor
        // constructor chaining 
        public House() : this(10000)
        {
            Console.WriteLine("I'm Constructor");
        }

        // parameterized constructor
        public House(int Price)
        {
            price = Price;
        }

        public House(int numberOfRooms , string address)
        {
            NumberOfRooms = numberOfRooms;
            Address = address;
        }
    }
}
