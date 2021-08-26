namespace GematriaForTruth.API.Util
{
    public class PHI_Search : NumericalPattern
    {
        public static readonly int N_DIGITS_OF_PHI = 100000;
        private static PHI_Search phiSearch = null;

        private PHI_Search(int numDigits) : base(numDigits)
        {

        }
        public static PHI_Search Instance(int numDigits)
        {
            if (numDigits == 0 && phiSearch != null)
                return phiSearch;

            if (phiSearch == null || numDigits != phiSearch.NumDigits)
                phiSearch = new PHI_Search(numDigits);
            else if (numDigits == 0 && phiSearch.NumDigits == 0)
                phiSearch = new PHI_Search(PHI_Search.N_DIGITS_OF_PHI);

            return phiSearch;
        }
        public override string GetNumbericResourceTextFile()
        {
            return GematriaForTruthResources.First_OneHundredThousand_phi;
        }

        public override int GetNumericalConstantsLength()
        {
            return N_DIGITS_OF_PHI;
        }
    }
}
