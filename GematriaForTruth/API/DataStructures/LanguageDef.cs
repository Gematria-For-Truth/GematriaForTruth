using System;

namespace GematriaForTruth.API.DataStructures
{
    [Serializable]
    public class LanguageDef
    {
        public enum SupportedLanguage
        {
            English,
            Arabic,
            Greek,
            Hewbrew,
            Russian
        }

        public static string[] languageIdentifierTwoLetterStrings = { "en", "ar", "el", "iw", "ru" };
        public LanguageDef()
        { }

        public static SupportedLanguage GetSupportedLanguage(string idStringTwoChar)
        {
            if (idStringTwoChar == "en" || idStringTwoChar == "eng")
                return SupportedLanguage.English;
            else if (idStringTwoChar == "ar")
                return SupportedLanguage.Arabic;
            else if (idStringTwoChar == "el" || idStringTwoChar == "ell")
                return SupportedLanguage.Greek;
            else if (idStringTwoChar == "iw" || idStringTwoChar == "heb")
                return SupportedLanguage.Hewbrew;
            else if (idStringTwoChar == "ru" || idStringTwoChar == "rus" || idStringTwoChar == "bul") //hack for bul
                return SupportedLanguage.Russian;
            else
                throw new NotSupportedException("Language Id " + idStringTwoChar + " not supported");
        }
    }
}
