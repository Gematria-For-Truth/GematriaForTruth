// Copyright (c) 2020 Gematria Tools

using GematriaForTruth.API.DataStructures;
using GematriaForTruth.API.Util;
using System;
using System.Linq;

namespace GematriaForTruth.API.Cipher
{

    [Serializable]
    public class GematriaCipher
    {
        public GematriaCipher()
        {
            Enabled = true;
            IsUseUpper = false;
            RGB_Color = new int[] { 0, 186, 0 };
            DisplayPriority = ++CurrentDisplayPriority;
            IsUserDefined = false;
            IsExperimental = false;
            IsForeign = false;
            IsDefault = false;
            Language = LanguageDef.SupportedLanguage.English;
            Comment = "";
        }

        private static int CurrentDisplayPriority = 0;

        public string Name { get; set; }
        public string Category { get; set; }
        public bool Enabled { get; set; }
        public bool IsBase { get; set; }
        public bool IsDefault { get; set; }
        public bool IsForeign { get; set; }
        public LanguageDef.SupportedLanguage Language { get; set; }
        public bool IsExperimental { get; set; }
        public bool IsUserDefined { get; set; }
        public bool IsCapsMatter { get; set; }
        public bool IsUseUpper { get; set; }
        public int[] RGB_Color { get; set; }
        public int DisplayPriority { get; set; }

        public string Comment { get; set; }

        public AlphNumMapping MappingAlphaNumeric { get; set; }


        public string GetShortName()
        {
            string shortName = Name;

            if(shortName.Length > 17)
            {
                shortName = shortName.Substring(0, 14) + "...";
            }
            return shortName;
           
        }

        public virtual long Decode(string phrase)
        {
            long gematriaTotalValue = 0;
            if (phrase != null && phrase.Length > 0)
            {
                string phraseValue = IsCapsMatter ? phrase : ConvertToLowerCase(phrase);

                for (int x = 0; x < phraseValue.Length; x++)
                {
                    if (char.IsNumber(phraseValue[x]))
                    {
                        try
                        {
                            gematriaTotalValue += (long)char.GetNumericValue(phraseValue[x]);
                        }
                        catch (Exception)
                        { }
                    }
                    else
                    {
                        for (int an = 0; an < MappingAlphaNumeric.AlphabetChars.Length; an++)
                        {
                            if (MappingAlphaNumeric.AlphabetChars[an] == phraseValue[x])
                            {
                                if (an < MappingAlphaNumeric.NumMapToChars.Length)
                                {
                                    gematriaTotalValue += MappingAlphaNumeric.NumMapToChars[an];
                                    break;
                                }
                                else
                                    throw new GematriaToolsException("Decode::" + Name + " : MappingAlphaNumeric.NumMapToChars out of bounds.");
                            }
                        }
                    }
                }
            }
            return gematriaTotalValue;
        }

        public void ReverseOrder()
        {
            MappingAlphaNumeric.AlphabetChars = MappingAlphaNumeric.AlphabetChars.Reverse().ToArray();
        }

        protected virtual string ConvertToLowerCase(string phrase)
        {
            return phrase.ToLower();
        }
    }
}

