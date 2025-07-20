using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class child : parent
    {

        public int z { get; set; }

        public child(int x, int y, int z) :base(x,y)
        {
            this.z = z;
        }

        public override int product()
        {
            return base.product() * z;
        }

        public override void print()
        {
            Console.WriteLine($"x: {x} , y : {y} , z : {z}");
        }
    }
}
