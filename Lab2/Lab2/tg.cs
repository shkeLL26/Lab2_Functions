using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class tg : IFunction
    { 
        public float calc(double x)
        {
            return (float)Math.Tan(x);
        }
    }
}
