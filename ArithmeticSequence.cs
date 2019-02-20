using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            try { 
                int nextElem = number, nextSum = number;
                for (int i = 0; i < count - 1; i++) {
                    nextElem += add;
                    nextSum += nextElem;
                }
                return nextSum;
            }
            catch (NotImplementedException)
            {
                Console.WriteLine();
            }
            throw new NotImplementedException();
        }
    }
}
