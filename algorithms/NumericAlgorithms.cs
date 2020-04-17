using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms
{
    public class NumericAlgorithms
    {
        public int Reverse(int num)
        {
            int output = 0;
            while(num>0)
            {
                output = output*10 + num % 10;
                num = num / 10;
            }
            return output;
        }
    }
}
