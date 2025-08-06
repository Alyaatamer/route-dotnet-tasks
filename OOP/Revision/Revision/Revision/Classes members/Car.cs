using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Classes___objects
{
    internal class Car
    {
        //fields
        public string Color;
        public string Model;
        public int Year;

        //Methods
        public void Start()
        {
            Console.WriteLine("The car is started");
        }
        public void Stop()
        {
            Console.WriteLine("The car is stoped");
        }

        //properties
        private double m_Price;

        public double Price
        {
            get
            {
                return m_Price;
            }
            set
            {
                m_Price = value;
            }
        }
    }
}
