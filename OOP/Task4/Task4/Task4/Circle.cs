using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Circle : ICircle
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area => Math.PI * Radius * Radius;
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle:\nRadius = {Radius},\nArea = {Area}");
        }
    }
       
}
