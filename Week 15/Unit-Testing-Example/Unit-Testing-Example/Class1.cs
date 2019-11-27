using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_Example
{
    public class Calculator
    {
        public List<int> Values;
        public Calculator(List<int> values)
        {
            this.Values = values;
        }

        public int Sum()
        {
            var sum = 0;
            for (int i = 0; i < Values.Count; i++)
            {
                sum += Values[i];
            }
            return sum;
        }
    }
}
