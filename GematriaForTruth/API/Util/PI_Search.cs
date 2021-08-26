namespace GematriaForTruth.API.Util
{
    public class PI_Search : NumericalPattern
    {
        public readonly static int N_DIGITS_OF_PI = 10000000;
        private static PI_Search piSearch = null;

        private PI_Search(int numDigits) : base(numDigits)
        {

        }
        public static PI_Search Instance(int numDigits = 0)
        {
            if (numDigits == 0 && piSearch != null)
                return piSearch;
            else if (piSearch == null || numDigits != piSearch.NumDigits)
                piSearch = new PI_Search(numDigits);
            else if (numDigits == 0 && piSearch.NumDigits == 0)
                piSearch = new PI_Search(PI_Search.N_DIGITS_OF_PI);

            return piSearch;
        }
        public override string GetNumbericResourceTextFile()
        {
            return GematriaForTruthResources.First_million_pi;
        }

        public override int GetNumericalConstantsLength()
        {
            return N_DIGITS_OF_PI;
        }
    }
}
