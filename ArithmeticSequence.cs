using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int nextElem = number, nextSum = number;
            for (int i = 0; i < count-1; i++) {
                nextElem += add;
                nextSum += nextElem;
            }
            return nextSum;
            throw new NotImplementedException();
        }
    }
}
