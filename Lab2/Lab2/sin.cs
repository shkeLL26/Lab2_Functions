using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class sin : IFunction
    {
        public float calc(double x)
        {
            return (float)Math.Sin(x);
        }
    }
}
