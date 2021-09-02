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
            //prompt the user fir the phrase
            Console.Write("Enter Word, Phrases, or Number(s): ");
            string phrase = Console.ReadLine();

            if (phrase.Length == 0)
            {
                Console.WriteLine("Invalid Phrase");
                Console.WriteLine("Hit a key to exit.");
                Console.ReadKey();
                return;
            }

            //prompt the user fir tge cipher selection
            Console.Write("Cipher Selection[all, base, enabled]: ");
            string cipherSelection = Console.ReadLine();

            GematriaCipher[] ciphers;

            if (cipherSelection.ToLower() == "all")
            {
                ciphers = GematriaFactory.Instance().GetGematriaCiphers();
            }
            else if (cipherSelection.ToLower() == "base")
            {
                ciphers = GematriaFactory.Instance().GetBaseCiphers();
            }
            else if (cipherSelection.ToLower() == "enabled")
            {
                ciphers = GematriaFactory.Instance().GetEnabledGematriaCiphers();
            }
            else
            {
                Console.Write("Error: You did not enter a valid Cipher Selection.");
                Console.WriteLine("Hit a key to exit.");
                Console.ReadKey();
                return;
            }

            Console.Write("Pause between cipher value data[yes, no]:");
            string pauseSelection = Console.ReadLine();
            bool pauseBetweenCipherData;

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
                Console.WriteLine("Hit a key to exit.");
                Console.ReadKey();
                return;
            }

            //loop through the selected ciphers
            foreach (GematriaCipher cipher in ciphers)
            {
                //get the value for this ciphers phrase.
                long gematriaValue = cipher.Decode(phrase);

                //build a string with the phrase, value, and the cipher name
                string valueString = phrase + " = " + gematriaValue + "(" + cipher.Name + ")";

                //check to see if the value matches any of the defined match values.
                MatchValue[] enabledMatchValues = GematriaFactory.Instance().GetEnabledMatchValues();
                string matchValueString = string.Empty;

                //loop through each match value and check for a match of value
                foreach (MatchValue matchValue in enabledMatchValues)
                {
                    //if our match value is the gematria value, we have a match
                    if (matchValue.Value == gematriaValue)
                    {
                        //build a string to dispay the match value
                        matchValueString = "MATCH VALUE: " + matchValue.Comment;
                        //all done we found our match, break out of the current loops of match values
                        break;
                    }
                }

                //let's see if our gematria value is a special complex math number.
                string complexMathString = string.Empty;
                //prime
                if (NumberHelper.IsPrime(gematriaValue) == true)
                {
                    //our number is a prime number, now get the index from the dictionary utility
                    int primeIndex = PrimeNumberDictionary.Instance().GetNumberIndex(gematriaValue);
                    //build our string of complex numbers with a format of prime-index followed by ranksuffix(nd,th,rd,ect) and " Prime"
                    complexMathString += primeIndex + WrittenNumerics.GetRankSuffix(primeIndex) + " Prime";
                }
                //Triangular
                if (NumberHelper.IsTriangular(gematriaValue) == true)
                {
                    //if the complexMathString was used previously, we are going to want a new line
                    complexMathString += complexMathString.Length > 0 ? Environment.NewLine : "";
                    int triangularIndex = TriangularNumberDictionary.Instance().GetNumberIndex(gematriaValue);
                    complexMathString += triangularIndex + WrittenNumerics.GetRankSuffix(triangularIndex) + " Triangular";
                }
                //Fibonacci
                if (NumberHelper.IsFibonacci(gematriaValue) == true)
                {
                    complexMathString += complexMathString.Length > 0 ? Environment.NewLine : "";
                    int fibonacciIndex = FibonacciNumberDictionary.Instance().GetNumberIndex(gematriaValue);
                    complexMathString += fibonacciIndex + WrittenNumerics.GetRankSuffix(fibonacciIndex) + " Fibonacci";
                }
                //square Root
                if (NumberHelper.IsSquareRoot(gematriaValue) == true)
                {
                    complexMathString += complexMathString.Length > 0 ? Environment.NewLine : "";
                    long squareRootValue = NumberHelper.GetSquareRootOf(gematriaValue);
                    complexMathString += "Square Root " + squareRootValue;
                }
                //perfect number
                if (NumberHelper.IsPerfect(gematriaValue) == true)
                {
                    complexMathString += complexMathString.Length > 0 ? Environment.NewLine : "";
                    complexMathString += "Perfect Number";
                }

                //write the data we have accumulated for this cipher / value

                //first the value string
                Console.WriteLine(valueString);

                //now the complex math.  Check to see if there is something to print
                if (complexMathString.Length > 0)
                {
                    //lets change the color of the text(forground color to something eye catching
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(complexMathString);
                    //put the color back
                    Console.ResetColor();
                }

                //now the match value.  Check to see if there is something to print
                if (matchValueString.Length > 0)
                {
                    //lets change the color of the text(forground color to something eye catching
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(matchValueString);
                    //put the color back
                    Console.ResetColor();
                }

                //that's all for this cipher and its data, check for a puase if selected as such
                if (pauseBetweenCipherData == true)
                {
                    Console.Write(Environment.NewLine + "Press a Key to Continue");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Hit a key to exit.");
            Console.ReadKey();
        }
    }
}