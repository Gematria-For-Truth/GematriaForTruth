using GematriaForTruth.API.Util;
using System;

namespace GematriaForTruth.API.Cipher
{
    [Serializable]
    public class SumOfPrimeWithIndices : PolymorphicCipher
    {
        //sum of a prime and its subscript / indices
        //a(n) = n-th prime + n.
        //(example: 11th prime is 31 so 31+11=42)
        //https://oeis.org/A014688
        public SumOfPrimeWithIndices() : base()
        {
        }

        public override long Decode(string phrase)
        {
            long value = base.Decode(phrase);
            int numDigits = PrimeNumberDictionary.Instance().GetNumberIndex(value);
            if (numDigits != -1)
            {
                HasMorphed = true;

                value += numDigits;
            }
            else
            {
                HasMorphed = false;
            }

            return value;
        }
    }
}
