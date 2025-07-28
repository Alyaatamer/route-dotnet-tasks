using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal interface IRectangle : IShape
    {
        double Width { get; }
        double Height { get; }
    }
}
