using GematriaForTruth.API.Util;
using System;

namespace GematriaForTruth.API.Cipher
{
    [Serializable]
    public class SumOfTriangularWithIndices : PolymorphicCipher
    {
        //sum of a prime and its subscript / indices
        //a(n) = n-th prime + n.
        //(example: 11th prime is 31 so 31+11=42)
        //https://oeis.org/A014688
        public SumOfTriangularWithIndices() : base()
        {
        }

        public override long Decode(string phrase)
        {
            long value = base.Decode(phrase);

            int triangularValue = TriangularNumberDictionary.Instance().GetNumberIndex(value);
            if (triangularValue != -1)
            {
                HasMorphed = true;
                value = value + triangularValue;
            }
            else
            {
                HasMorphed = false;
            }
            return value;
        }
    }
}
