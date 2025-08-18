using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public struct Location
    {

        public int x {  get; set; }
        public int y { get; set; }
        public int z { get; set; }


        public Location(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Location : ({x},{y},{z})";
        }
    }
}
