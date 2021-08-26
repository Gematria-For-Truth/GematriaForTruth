// Copyright (c) 2020 Gematria Tools
using System;
using System.Collections.Generic;
using System.Linq;
#pragma warning disable 0436

namespace GematriaForTruth.API.Cipher
{
    [Serializable]
    public class RandomizedGematriaCipher : GematriaCipher
    {
        public static string DefautCipherBasedOnCipher = "English Ordinal";

        public GematriaCipher CipherBasedOn { get; set; }

        public RandomizedGematriaCipher()
        { }

        public RandomizedGematriaCipher(GematriaCipher cipherBasedOn)
        {
            this.CipherBasedOn = cipherBasedOn;
        }

        public override long Decode(string phrase)
        {
            List<int> basedOnNumList = CipherBasedOn.MappingAlphaNumeric.NumMapToChars.ToList();
            List<int> radomizedNumberList = new List<int>();
            Random rnd = new Random();
            while (basedOnNumList.Count > 1)
            {
                int randomIndex = rnd.Next(0, basedOnNumList.Count - 1);
                radomizedNumberList.Add(basedOnNumList.ElementAt(randomIndex));
                basedOnNumList.RemoveAt(randomIndex);
            }
            radomizedNumberList.Add(basedOnNumList.ElementAt(0));

            MappingAlphaNumeric.NumMapToChars = radomizedNumberList.ToArray();

            return base.Decode(phrase);
        }
    }
}
