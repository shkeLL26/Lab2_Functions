using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class x_3 : IFunction
    {
        public float calc(double x)
        {
            return (float)(x * x * x);
        }
    }
}
