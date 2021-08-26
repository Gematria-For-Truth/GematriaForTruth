// Copyright (c) 2020 Gematria Tools
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace GematriaForTruth.API.Util
{
    public static class StringHelper
    {
        public static string[] SplitString(string stringToSplit, char[] delimiters, bool includeDelimiter, bool trimEnds)
        {
            int index = -1;
            List<string> stringList = new List<string>();
            StringBuilder sBuilder = new StringBuilder();

            while (++index < stringToSplit.Length)
            {
                sBuilder.Append(stringToSplit[index]);

                foreach (char c in delimiters)
                {
                    if (stringToSplit[index] == c)
                    {
                        if (!includeDelimiter)
                        {
                            sBuilder.Remove(sBuilder.Length - 1, 1);
                        }
                        if (trimEnds)
                        {
                            stringList.Add(sBuilder.ToString().Trim());
                        }
                        else
                        {
                            stringList.Add(sBuilder.ToString());
                        }
                        sBuilder.Clear();
                        break;
                    }
                }
            }
            return stringList.ToArray();
        }

        public static string RemoveSpecialCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string GetPerfectNumberString(long value)
        {
            if (NumberHelper.IsPerfect((int)value))
                return "Yes";
            else
                return "No";
        }

        public static string GetSquareRootString(long value)
        {
            bool isSquareRoot = NumberHelper.IsSquareRoot(value);
            if (isSquareRoot == true)
            {
                long squareRoot = NumberHelper.GetSquareRootOf(value);
                if (squareRoot == -1)
                    return "No";
                else
                    return "Square Root - " + squareRoot.ToString();
            }
            else
            {
                return "No";
            }
        }

        public static string GetTriangularString(long value)
        {
            try
            {

                int trigValue = TriangularNumberDictionary.Instance().GetNumberIndex(value);
                if (trigValue != -1)
                {
                    if (trigValue == 1)
                        return "Yes - 1st";
                    else if (trigValue == 2 || trigValue == 3)
                        return "Yes - " + trigValue.ToString() + "nd";
                    else
                        return "Yes - " + trigValue.ToString() + "th";
                }
                else
                {
                    return "No";
                }

            }
            catch (Exception)
            {
                return "error";
            }
        }

        public static string GetFibonacciString(long value)
        {
            try
            {
                int fibValue = FibonacciNumberDictionary.Instance(FibonacciNumberDictionary.N_DIGITS_OF_FIBONACCI).GetNumberIndex(value);
                if (fibValue != -1)
                {

                    if (fibValue == 1)
                        return "Yes - 1st & 2nd";
                    else if (fibValue == 2 || fibValue == 3)
                        return "Yes - " + fibValue.ToString() + "nd";
                    else
                        return "Yes - " + fibValue.ToString() + "th";
                }
                else
                {
                    return "No";
                }

            }
            catch (Exception)
            {
                return "error";
            }
        }

        public static IEnumerable<string> MakeSentenceList(string text)
        {
            char[] wordDelimeters = new[] { '!', '?', '.', ';', ':' };
            int wordStart = 0;

            while (true)
            {
                while (wordStart < text.Length && char.IsWhiteSpace(text[wordStart]))
                    ++wordStart;

                int pos = text.IndexOfAny(wordDelimeters, wordStart);
                if (pos > -1)
                {
                    yield return text.Substring(wordStart, pos - wordStart + 1);
                    wordStart = pos + 1;
                }
                else if (wordStart < text.Length)
                {
                    yield return text.Substring(wordStart, text.Length - wordStart);
                    break;
                }
                else break;
            }
        }

        public static bool IsUppper(string word, char[] ignoreChars = null)
        {
            if (word.Length < 1)
                return false;

            char[] charWord = word.ToCharArray();

            for (int c = 0; c < charWord.Length; c++)
            {
                bool isIgnore = false;
                if (ignoreChars != null)
                {
                    for (int i = 0; i < ignoreChars.Length; i++)
                    {
                        if (charWord[c].Equals(ignoreChars[i]))
                        {
                            isIgnore = true;
                            break;
                        }
                    }
                }

                if (!isIgnore)
                {
                    if (!Char.IsUpper(charWord[c]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string ReplaceNumbersWithWords(string txt)
        {
            while (Regex.IsMatch(txt, @"\d+"))
            {
                var value = Regex.Match(txt, @"\d+").Value;
                string numberString = WrittenNumerics.IntegerToWritten(Int32.Parse(value), true);
                txt = Regex.Replace(txt, @"\d+", numberString);
            }
            return txt;
        }
        public static IEnumerable<string> WordList(string Text)
        {
            int cIndex = 0;
            int nIndex;
            while ((nIndex = Text.IndexOf(' ', cIndex + 1)) != -1)
            {
                int sIndex = (cIndex == 0 ? 0 : cIndex + 1);
                yield return Text.Substring(sIndex, nIndex - sIndex);
                cIndex = nIndex;
            }
            if (Text.Substring(cIndex + 1).IndexOf(' ') != -1)
                yield return Text.Substring(cIndex + 1);
        }

        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
