
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    abstract class GenericCalculator<T>
    {
        public abstract T Add(T a, T b);
        public abstract T Sub(T a, T b);
        public abstract T Multiply(T a, T b);
        public abstract T Divide(T a, T b);
    }
}
