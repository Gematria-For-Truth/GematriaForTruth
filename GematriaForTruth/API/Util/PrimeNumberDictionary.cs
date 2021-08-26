namespace GematriaForTruth.API.Util
{
    public class PrimeNumberDictionary : SequenceNumberDictionary
    {
        private static PrimeNumberDictionary primeDict = null;
        public readonly static int N_DIGITS_OF_PRIME = 100000;

        public readonly static string PATTERN_RESOURCE_NAME = "Resources.First_100000_prime_numbers.txt";

        private PrimeNumberDictionary(int numDigits) : base(numDigits)
        {

        }

        public static PrimeNumberDictionary Instance(int numDigits = 0)
        {
            if (numDigits == 0 && primeDict != null)
                return primeDict;
            if (primeDict == null || numDigits != primeDict.NumDigits)
                primeDict = new PrimeNumberDictionary(numDigits);
            else if (numDigits == 0 && primeDict.NumDigits == 0)
                primeDict = new PrimeNumberDictionary(N_DIGITS_OF_PRIME);
            return primeDict;
        }
        public override string GetNumbericResourceTextFile()
        {
            return GematriaForTruthResources.First_100000_prime_numbers;
        }

        public override long GetNumericalConstantsLength()
        {
            return N_DIGITS_OF_PRIME;
        }

        protected override bool IsNumberSequenceType(long value)
        {
            return NumberHelper.IsPrime(value);
        }
    }
}
