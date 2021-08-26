// Copyright (c) 2020 Gematria Tools
using System;

namespace GematriaForTruth.API.Util
{
    public static class WrittenNumerics
    {
        static readonly string[] ones = new string[] { "", "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth" };
        static readonly string[] teens = new string[] { "Tenth", "Eleventh", "Twelveth", "Thirteenth", "Fourteenth", "Fifteenth", "Sixteenth", "Seventeenth", "Eighteenth", "Nineteenth" };
        static readonly string[] tens = new string[] { "Twentieth", "Thirtieth", "Fortieth", "Fiftieth", "Sixtieth", "Seventieth", "Eightieth", "Ninetieth" };
        static readonly string[] thousandsGroups = new string[] { "", "Thousandth", "Millionth", "Billionth" };
        static readonly string[] ones2 = new string[] { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
        static readonly string[] teens2 = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static readonly string[] tens2 = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static readonly string[] thousandsGroups2 = new string[] { "", "Thousand", "Million", "Billion" };


        private static string FriendlyInteger(int n, string leftDigits, int thousands, bool useGroup2)
        {
            if (n == 0)
                return leftDigits;

            string friendlyInt = leftDigits;
            if (friendlyInt.Length > 0)
                friendlyInt += " ";

            if (n < 10)
            {
                if (useGroup2)
                    friendlyInt += ones2[n];
                else
                    friendlyInt += ones[n];
            }
            else if (n < 20)
            {
                if (useGroup2)
                {
                    friendlyInt += teens2[n - 10];
                }
                else
                {
                    friendlyInt += teens[n - 10];
                }
            }
            else if (n < 100)
            {
                if (useGroup2)
                {
                    if (n == 20 | n == 30 | n == 40 | n == 50 | n == 60 | n == 70 | n == 80 | n == 90)
                        friendlyInt += FriendlyInteger(n % 10, tens2[n / 10 - 2], 0, useGroup2);
                    else
                        friendlyInt += FriendlyInteger(n % 10, tens[n / 10 - 2], 0, useGroup2);
                }
                else
                {
                    if (n == 20 | n == 30 | n == 40 | n == 50 | n == 60 | n == 70 | n == 80 | n == 90)
                        friendlyInt += FriendlyInteger(n % 10, tens[n / 10 - 2], 0, useGroup2);
                    else
                        friendlyInt += FriendlyInteger(n % 10, tens2[n / 10 - 2], 0, useGroup2);
                }
            }
            else if (n < 1000)
            {
                if (useGroup2)
                {
                    if (n == 200 | n == 300 | n == 400 | n == 500 | n == 600 | n == 700 | n == 800 | n == 900)
                        friendlyInt += FriendlyInteger(n % 100, ones2[n / 100] + " Hundred", 0, useGroup2);
                    else
                        friendlyInt += FriendlyInteger(n % 100, ones[n / 100] + " Hundred", 0, useGroup2);
                }
                else
                {
                    if (n == 200 | n == 300 | n == 400 | n == 500 | n == 600 | n == 700 | n == 800 | n == 900)
                        friendlyInt += FriendlyInteger(n % 100, ones[n / 100] + " Hundred", 0, useGroup2);
                    else
                        friendlyInt += FriendlyInteger(n % 100, ones[n / 100] + " Hundred", 0, useGroup2);

                }
            }
            else
            {

                if (useGroup2)
                {
                    if (n == 2000 | n == 3000 | n == 4000 | n == 5000 | n == 6000 | n == 7000 | n == 8000 | n == 9000)
                        friendlyInt += FriendlyInteger(n % 1000, FriendlyInteger(n / 1000, "", thousands + 1, useGroup2), 0, useGroup2);
                    else
                        friendlyInt += FriendlyInteger(n % 1000, FriendlyInteger(n / 1000, "", thousands + 1, useGroup2), 0, useGroup2);
                }
                else
                {

                    friendlyInt += FriendlyInteger(n % 1000, FriendlyInteger(n / 1000, "", thousands + 1, useGroup2), 0, useGroup2);

                }
            }

            if (useGroup2)
                return friendlyInt + thousandsGroups2[thousands];
            else
                return friendlyInt + thousandsGroups[thousands];
        }

        private static string FriendlyYearInteger(int n, string leftDigits, int thousands)
        {
            if (n == 0)
                return leftDigits;

            string friendlyInt = leftDigits;
            if (friendlyInt.Length > 0)
                friendlyInt += " ";

            if (n < 10)
            {
                friendlyInt += ones2[n];

            }
            else if (n < 20)
            {

                friendlyInt += teens2[n - 10];

            }
            else if (n < 100)
            {

                friendlyInt += FriendlyYearInteger(n % 10, tens2[n / 10 - 2], 0);

            }
            else if (n < 1000)
            {
                friendlyInt += FriendlyYearInteger(n % 100, ones2[n / 100] + " Hundred", 0);
            }
            else
            {
                friendlyInt += FriendlyYearInteger(n % 1000, FriendlyYearInteger(n / 1000, "", thousands + 1), 0);
            }

            return friendlyInt + thousandsGroups2[thousands];

        }


        public static string DateToWritten(DateTime date)
        {
            String day = IntegerToWritten(date.Day, false);

            String year = IntegerToWrittenForYear(date.Year);


            return string.Format("{0} {1} {2}", date.ToString("MMMM"), day, year);
        }


        public static string IntegerToWritten(int n, bool useGroup2)
        {
            if (n == 0)
                return "Zero";
            else if (n < 0)
                return "Negative " + IntegerToWritten(-n, useGroup2);

            return FriendlyInteger(n, "", 0, useGroup2);
        }

        public static string IntegerToWrittenForYear(int n)
        {
            if (n == 0)
                return "Zero";
            else if (n < 0)
                return "Negative " + IntegerToWrittenForYear(-n);

            return FriendlyYearInteger(n, "", 0);
        }


        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        public static string GetRankSuffix(long number)
        {
            if ((Math.Abs(number) / 10) % 10 == 1)
                return "th";

            switch (Math.Abs(number) % 10)
            {
                case 1:
                    return "st";
                case 2:
                    return "nd";
                case 3:
                    return "rd";
                default:
                    return "th";
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
    }
}
