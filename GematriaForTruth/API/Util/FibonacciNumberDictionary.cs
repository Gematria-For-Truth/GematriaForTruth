using System;

namespace GematriaForTruth.API.Util
{
    public class FibonacciNumberDictionary : SequenceNumberDictionary, IDisposable
    {
        private static FibonacciNumberDictionary FibonacciDict = null;
        public readonly static int N_DIGITS_OF_FIBONACCI = 33;

        private FibonacciNumberDictionary(int numDigits) : base(numDigits)
        {

        }

        public static FibonacciNumberDictionary Instance(int numDigits = 0)
        {
            if (numDigits == 0 && FibonacciDict != null)
                return FibonacciDict;
            if (FibonacciDict == null || numDigits != FibonacciDict.NumDigits)
                FibonacciDict = new FibonacciNumberDictionary(numDigits);
            else if (numDigits == 0 && FibonacciDict.NumDigits == 0)
                FibonacciDict = new FibonacciNumberDictionary(N_DIGITS_OF_FIBONACCI);
            return FibonacciDict;

        }
        public override string GetNumbericResourceTextFile()
        {
            return GematriaForTruthResources.First_33_Fibonacci;
        }

        public override long GetNumericalConstantsLength()
        {
            return N_DIGITS_OF_FIBONACCI;
        }

        protected override bool IsNumberSequenceType(long value)
        {
            return NumberHelper.IsFibonacci(value);
        }
    }
}
