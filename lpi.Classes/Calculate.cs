using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lpi.Classes
{
    public class AddCalculate : lpi.Contracts.ICalculate
    {
        public int ProformanceCalculate(int a, int b)
        {
            return a + b;
        }
    }
    public class SubstractCalculate : lpi.Contracts.ICalculate
    {
        public int ProformanceCalculate(int a, int b)
        {
            return a - b;
        }
    }
    public class MultiplyCalculate : lpi.Contracts.ICalculate
    {
        public int ProformanceCalculate(int a, int b)
        {
            return a * b;
        }
    }
    public class DivideCalculate : lpi.Contracts.ICalculate
    {
        public int ProformanceCalculate(int a, int b)
        {
            return a / b;
        }
    }
}
