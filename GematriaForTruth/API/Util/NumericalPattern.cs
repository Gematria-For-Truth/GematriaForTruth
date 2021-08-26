using System;
using System.IO;

namespace GematriaForTruth.API.Util
{
    public abstract class NumericalPattern
    {
        public abstract string GetNumbericResourceTextFile();
        public abstract int GetNumericalConstantsLength();

        private string DigitStringPatern;

        public int NumDigits { get; set; }

        public NumericalPattern(int numDigits)
        {
            NumDigits = numDigits;
            if (NumDigits == 0)
                NumDigits = GetNumericalConstantsLength();

            DigitStringPatern = "";
            LoadDigitPattern();
        }
        private void LoadDigitPattern()
        {
            DigitStringPatern = GetNumbericResourceTextFile();
            DigitStringPatern = DigitStringPatern.Substring(0, NumDigits);
        }
        public void Dispose()
        {
            DigitStringPatern = null;
            GC.Collect();
        }
        public int Find(long digitToSearch)
        {
            return DigitStringPatern.IndexOf(digitToSearch.ToString(), StringComparison.OrdinalIgnoreCase);
        }
    }
}
