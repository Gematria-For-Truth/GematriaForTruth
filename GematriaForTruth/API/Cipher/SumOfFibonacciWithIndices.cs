using GematriaForTruth.API.Util;
using System;

namespace GematriaForTruth.API.Cipher
{
    [Serializable]
    public class SumOfFibonacciWithIndices : PolymorphicCipher
    {
        //sum of a fibinacci and its subscript / indices
        //a(n) = n-th fibonacci + n.
        public SumOfFibonacciWithIndices() : base()
        {
        }
        public override long Decode(string phrase)
        {
            long value = base.Decode(phrase);
            int fibValue = FibonacciNumberDictionary.Instance(FibonacciNumberDictionary.N_DIGITS_OF_FIBONACCI).GetNumberIndex(value);

            if (fibValue != -1)
            {
                HasMorphed = true;
                if (value == 1)
                    value += 3; //first and second fib for 1
                else
                    value += fibValue;
            }
            else
            {
                HasMorphed = false;
            }

            return value;
        }
    }
}
