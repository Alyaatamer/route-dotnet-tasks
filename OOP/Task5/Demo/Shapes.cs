using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class Shapes
    {
        public double Dim01 { get; set; }  
        public double Dim02 { get; set; }

        public abstract double CalcArea();

        public abstract double parameter {  get; }
    }

    public abstract class RecBase : Shapes
    {
        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    public class Rectangler : RecBase
    {
        public override double parameter
        {
            get {  return Dim01 +  Dim02 * 2; }
        }
    }

}
