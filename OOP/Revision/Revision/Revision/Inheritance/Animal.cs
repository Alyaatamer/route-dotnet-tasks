using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Inheritance
{
    internal class Animal 
    {
        public string name;
        public int weight;

        public virtual void Eating()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
}
