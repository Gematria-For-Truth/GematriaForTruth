// Copyright (c) 2020 Gematria Tools
using GematriaForTruth.API.Util;
using System;
using System.Text.RegularExpressions;

namespace GematriaForTruth.API.Cipher
{
    [Serializable]
    public class GreekGematriaCipher : GematriaCipher
    {
        public GreekGematriaCipher()
        { }

        protected override string ConvertToLowerCase(string phrase)
        {
            return GreekToLower(phrase);
        }

        public string GreekToLower(string s)
        {
            s = StringHelper.RemoveDiacritics(s).ToUpper();

            //Matches any 'σ' followed by whitespace or end of string
            s = Regex.Replace(s, "σ(\\s+|$)", "ς$1");
            return s;
        }
    }
}
