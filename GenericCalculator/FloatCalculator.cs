using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FloatCalculator:GenericCalculator<float>
    {
        public override float Add(float a, float b)
        {
            return (a + b);
        }
        public override float Sub(float a, float b)
        {
            return (a - b);
        }
        public override float Multiply(float a, float b)
        {
            return (a * b);
        }
        public override float Divide(float a, float b)
        {
            return (a / b);
        }
    }
}
