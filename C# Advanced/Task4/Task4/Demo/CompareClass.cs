using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class CompareClass
    {
        public static bool CompareGreater(int a, int b) { return a < b; }
        public static bool CompareSmaller(int a, int b) { return a > b; }
        public static bool CompareStringgreater(string a, string b) { return a.Length < b.Length; }
        public static bool CompareStringSmaller(string a, string b) { return a.Length > b.Length; }


    }
}
