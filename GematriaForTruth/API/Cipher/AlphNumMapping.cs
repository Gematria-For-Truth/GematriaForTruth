// Copyright (c) 2020 Gematria Tools
using GematriaForTruth.API.Util;
using System;

namespace GematriaForTruth.API.Cipher
{
    [Serializable]
    public class AlphNumMapping
    {
        public char[] AlphabetChars { get; set; }
        public int[] NumMapToChars { get; set; }

        public AlphNumMapping(char[] alphaCharDef, int[] numMappingToAlphaDef)
        {
            if (alphaCharDef.Length != numMappingToAlphaDef.Length)
                throw new GematriaToolsException("AlphNumMapping: alphaCharDef/numMappingToAlphaDef mismatch " + alphaCharDef.Length + "/" + numMappingToAlphaDef.Length);
            this.AlphabetChars = alphaCharDef;
            this.NumMapToChars = numMappingToAlphaDef;
        }

        public AlphNumMapping()
        {

        }

        public int GetNumericIndex(char theChar, bool doCapsMatter)
        {
            if (doCapsMatter == false)
                theChar = char.ToLower(theChar);

            int index = 0;
            foreach (char alphaChar in AlphabetChars)
            {
                if (alphaChar == theChar)
                    return index;

                index++;
            }
            return -1;
        }
    }

}
