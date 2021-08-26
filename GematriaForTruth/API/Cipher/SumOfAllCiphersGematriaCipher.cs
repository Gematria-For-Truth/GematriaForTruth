// Copyright (c) 2020 Gematria Tools
using GematriaForTruth.API.Util;
using System;
using System.Collections.Generic;

namespace GematriaForTruth.API.Cipher
{
    [Serializable]
    public class SumOfAllCiphersGematriaCipher : GematriaCipher
    {
        public GematriaCipher[] ListOfCiphersToSum { get; set; }

        public SumOfAllCiphersGematriaCipher()
        { }

        public SumOfAllCiphersGematriaCipher(GematriaCipher[] listOfCiphersToSum)
        {
            this.ListOfCiphersToSum = listOfCiphersToSum;

            if (listOfCiphersToSum.Length < 2)
                throw new GematriaToolsException("Creation of SumOfAllCiphers with less than 2 Ciphers.");

            //confirm all character matching are the same.
            for (int a = 0; a < listOfCiphersToSum.Length; a++)
            {
                for (int b = 1; b < listOfCiphersToSum.Length; b++)
                {
                    if (listOfCiphersToSum[a].MappingAlphaNumeric.AlphabetChars.Length != listOfCiphersToSum[a].MappingAlphaNumeric.AlphabetChars.Length)
                        throw new GematriaToolsException("Alpha chars length for all ciphers must match when creating SumOfAllCiphers.");

                    for (int i = 0; i < listOfCiphersToSum[a].MappingAlphaNumeric.AlphabetChars.Length; i++)
                    {
                        if (listOfCiphersToSum[a].MappingAlphaNumeric.AlphabetChars[i] !=
                            listOfCiphersToSum[b].MappingAlphaNumeric.AlphabetChars[i])
                        {
                            throw new GematriaToolsException("Alpha chars must all match for each cipher within the list of ciphers to sum when creating SumOfAllCiphers.");
                        }
                    }
                }
            }

            //create the alpha mapping (display purposes only.  Because numerical additions of non-alpha chars need to occur at runtime.
            List<char> charList = new List<char>();
            List<int> intList = new List<int>();
            for (int i = 0; i < listOfCiphersToSum[0].MappingAlphaNumeric.AlphabetChars.Length; i++)
            {
                charList.Add(listOfCiphersToSum[0].MappingAlphaNumeric.AlphabetChars[i]);
                int numericalTotalValue = 0;
                foreach (GematriaCipher cipher in listOfCiphersToSum)
                {
                    numericalTotalValue += cipher.MappingAlphaNumeric.NumMapToChars[i];
                }
                intList.Add(numericalTotalValue);
            }

            //create the mappings
            MappingAlphaNumeric = new AlphNumMapping(charList.ToArray(), intList.ToArray());
        }

        public override long Decode(string phrase)
        {
            long total = 0;
            foreach (GematriaCipher cipher in ListOfCiphersToSum)
            {
                total += cipher.Decode(phrase);
            }
            return total;
        }
    }
}
