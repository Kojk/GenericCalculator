using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class IntCalculator : GenericCalculator<int>
    {
        public override int Add(int a, int b)
        {
            return (a + b);
        }
        public override int Sub(int a, int b)
        {
            return (a - b);
        }
        public override int Multiply(int a, int b)
        {
            return (a * b);
        }
        public override int Divide(int a, int b)
        {
            return (a / b);
        }
    }
}
