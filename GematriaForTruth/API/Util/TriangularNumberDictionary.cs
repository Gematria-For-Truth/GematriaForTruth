using System;

namespace GematriaForTruth.API.Util
{
    public class TriangularNumberDictionary : SequenceNumberDictionary, IDisposable
    {
        private static TriangularNumberDictionary triangularDict = null;
        public readonly static int N_DIGITS_OF_TRIANGULAR = 5000;

        private TriangularNumberDictionary(int numDigits) : base(numDigits)
        {

        }

        public static TriangularNumberDictionary Instance(int numDigits = 0)
        {
            if (numDigits == 0 && triangularDict != null)
                return triangularDict;

            if (triangularDict == null || numDigits != triangularDict.NumDigits)
                triangularDict = new TriangularNumberDictionary(numDigits);
            else if (numDigits == 0 && triangularDict.NumDigits == 0)
                triangularDict = new TriangularNumberDictionary(N_DIGITS_OF_TRIANGULAR);
            return triangularDict;

        }
        public override string GetNumbericResourceTextFile()
        {
            return GematriaForTruthResources.First_5000_triangular_numbers;
        }

        public override long GetNumericalConstantsLength()
        {
            return N_DIGITS_OF_TRIANGULAR;
        }

        protected override bool IsNumberSequenceType(long value)
        {
            return NumberHelper.IsTriangular(value);
        }
    }
}

