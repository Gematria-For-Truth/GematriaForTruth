using GematriaForTruth.API.Cipher;
using GematriaForTruth.API.DataStructures;
using GematriaForTruth.API.Factory;
using GematriaForTruth.API.Util;
using System;

namespace Gematria_Calculator
{
    class Program
    {
        static void Main()
        {
            ConsoleColor startConsoleColor = Console.ForegroundColor;
            GematriaCipher [] ciphers;

            //prompt the user for the phrase
            Console.Write("Enter Word, Phrase, or Number(s): ");
            string phrase = Console.ReadLine();

            if (phrase.Length == 0)
            {
                Console.WriteLine("Error: You did not enter a valid word, phrase, and or number.");
                Console.WriteLine("Press a key to exit.");
                Console.ReadKey();
                return;
            }

            //prompt the user for the cipher selection
            Console.Write("Cipher Selection[all, base, enabled]: ");
            string cipherSelection = Console.ReadLine();

            if (cipherSelection.ToLower() == "all")
            {
                ciphers = GematriaFactory.Instance().GetGematriaCiphers();
            }
            else if(cipherSelection.ToLower() == "base")
            {
                ciphers = GematriaFactory.Instance().GetBaseCiphers();
            }
            else if (cipherSelection.ToLower() == "enabled")
            {
                ciphers = GematriaFactory.Instance().GetEnabledGematriaCiphers();
            }
            else
            {
                Console.WriteLine("Error: You did not enter a valid gematria ciphers selection.");
                Console.WriteLine("Press a key to exit.");
                Console.ReadKey();
                return;
            }

            bool pauseBetweenCipherData;

            Console.Write("Pause between cipher value data[yes, no]: ");
            string pauseSelection = Console.ReadLine();
            Console.WriteLine("");

            if (pauseSelection.ToLower() == "yes")
            {
                pauseBetweenCipherData = true;
            }
            else if (pauseSelection.ToLower() == "no")
            {
                pauseBetweenCipherData = false;
            }
            else
            {
                Console.WriteLine("Error: You did not enter a valid selection.");
                Console.WriteLine("Press a key to exit.");
                Console.ReadKey();
                return;
            }

            foreach (GematriaCipher cipher in ciphers)
            {
                long gematriaValue = cipher.Decode(phrase);
                string valueString = phrase + " = " + gematriaValue + "(" + cipher.Name + ")";

                //check for match values
                string matchValueString = string.Empty;
                MatchValue[] enabledMatchValues = GematriaFactory.Instance().GetEnabledMatchValues();

                foreach(MatchValue matchValue in enabledMatchValues)
                {
                    if(matchValue.Value == gematriaValue)
                    {
                        matchValueString = "MATCH VALUE: " + matchValue.Comment;
                        break;
                    }
                }

                string complexMathString = string.Empty;

                if (NumberHelper.IsPrime((int)gematriaValue))
                {
                    PrimeNumberDictionary.Instance().GetNumberIndex(gematriaValue);
                    int primeIndex = PrimeNumberDictionary.Instance().GetNumberIndex(gematriaValue);
                    complexMathString += primeIndex + WrittenNumerics.GetRankSuffix(gematriaValue) + " Prime";
                }
                if (NumberHelper.IsTriangular((int)gematriaValue))
                {
                    complexMathString += complexMathString.Length > 0 ? Environment.NewLine : ""; 
                    int trigValue = TriangularNumberDictionary.Instance().GetNumberIndex(gematriaValue);
                    complexMathString += trigValue + WrittenNumerics.GetRankSuffix(gematriaValue) +  " Triangular";
                }
                if (NumberHelper.IsFibonacci((int)gematriaValue))
                {
                    complexMathString += complexMathString.Length > 0 ? Environment.NewLine : "";
                    int fibValue = FibonacciNumberDictionary.Instance().GetNumberIndex(gematriaValue);
                    complexMathString += fibValue + WrittenNumerics.GetRankSuffix(gematriaValue) + " Fibonacci";
                }
                if (NumberHelper.IsSquareRoot((int)gematriaValue))
                {
                    complexMathString += complexMathString.Length > 0 ? Environment.NewLine : "";
                    long sqrtValue = NumberHelper.GetSquareRootOf(gematriaValue);
                    complexMathString += "Square Root " + sqrtValue;
                }
                if (NumberHelper.IsPerfect((int)gematriaValue))
                {
                    complexMathString += complexMathString.Length > 0 ? Environment.NewLine : "";
                    complexMathString += "Perfect Number";
                }

                //write the data
                Console.WriteLine(valueString);
                if (complexMathString.Length > 0)
                {  
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(complexMathString);
                    Console.ForegroundColor = startConsoleColor;
                }
                if (matchValueString.Length > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(matchValueString);
                    Console.ForegroundColor = startConsoleColor;
                }

                if (pauseBetweenCipherData)
                {                    
                    Console.Write(Environment.NewLine + "Press a Key to Continue.");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("All Done.  Press a key to exit.");
            Console.ReadKey();
        }
    }
}