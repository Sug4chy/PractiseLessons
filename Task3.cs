using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pohui
{
    public class Task3
    {
        public int CalcSumOfOdd(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i += 2)
                sum += i;
            return sum;
        }
    }
}
