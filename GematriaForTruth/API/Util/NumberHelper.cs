// Copyright (c) 2020 Gematria Tools
using System;
using System.Collections.Generic;

namespace GematriaForTruth.API.Util
{
    public class NumberHelper
    {
        // private static readonly int MAX = 1000000;
        //  static ArrayList primes = new ArrayList(100000);

        // A utility function that returns 
        // true if x is perfect square 
        public static bool IsPerfectSquare(long x)
        {
            long s = (long)Math.Sqrt(x);
            return s * s == x;
        }

        public static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }


        /*   public static long GetPreviousFibonacci(long n)
           {
               int fibValue = FibonacciNumberDictionary.Instance(FibonacciNumberDictionary.N_DIGITS_OF_FIBONACCI).GetNumberIndex(n);
               if (fibValue != -1)
               {
                   return -1;

               while (n > 0)
               {
                   if (IsFibonacci(n))
                       return n;

                   n--;
               }

               return -1;
           }

           public static long GetNextFibonacci(long n)
           {
               if (IsFibonacci(n))
                   return -1;

               while (n < long.MaxValue)
               {
                   if (IsFibonacci(n))
                       return n;

                   n++;
               }

               return -1;
           }
        */

        /*  public static long GetFibonacciIndex(long number)
          {
              long fibonacciIndex = 0;
              long currentIndex = 0;

              if (number == 1)
                  return 1;

              do
              {
                  if (IsFibonacci(currentIndex))
                  {
                      if (currentIndex == number)
                          return fibonacciIndex + 2;

                      fibonacciIndex++;
                  }
                  currentIndex++;
              } while (number > currentIndex - 1);
              return -1;
          }*/

        /*  public static long GetPreviousPrime(long n)
          {
              if (IsPrime(n))
                  return -1;

              while (n > 0)
              {
                  if (IsPrime(n))
                      return n;

                  n--;
              }

              return -1;
          }

          public static long GetNextPrime(long n)
          {
              if (IsPrime(n))
                  return -1;

              while (n < long.MaxValue)
              {
                  if (IsPrime(n))
                      return n;

                  n++;
              }

              return -1;
          }*/

        // Returns true if n is a  
        // Fibonacci Number, else false 
        public static bool IsFibonacci(long n)
        {
            if (n == 0)
                return false;
            else if (n == 1)
                return true;
            else if (n == 2)
                return true;
            // n is Fibonacci if one of 
            // 5*n*n + 4 or 5*n*n - 4 or  
            // both are a perfect square 
            return IsPerfectSquare((5 * n * n) + 4) ||
               IsPerfectSquare((5 * n * n) - 4);
        }


        /*  public static long GetPreviousTriangular(long n)
          {
              if (IsTriangular(n))
                  return -1;

              while (n > 0)
              {
                  if (IsTriangular(n))
                      return n;

                  n--;
              }

              return -1;
          }

          public static long GetNextTriangular(long n)
          {
              if (IsTriangular(n))
                  return -1;

              while (n < long.MaxValue)
              {
                  if (IsTriangular(n))
                      return n;

                  n++;
              }

              return -1;
          }*/

        public static bool IsTriangular(long num)
        {
            if (num < 1)
                return false;
            long calc_num = 8 * num + 1;
            long t = (long)Math.Sqrt(calc_num);
            if (t * t == calc_num)
            {
                return true;
            }
            return false;
        }



        public static bool IsSquareRoot(long value)
        {
            if (value == 0 || value == 1 || value == 2)
                return false;
            double sqrt = Math.Sqrt(value);

            return sqrt % 1 == 0;
        }
        public static long GetSquareRootOf(long value)
        {
            if (value == 0 || value == 1 || value == 2)
                return -1;
            double sqrt = Math.Sqrt(value);
            if (sqrt % 1 != 0)
                return -1;

            return (long)sqrt;
        }

        // Returns true if n is perfect 
        public static bool IsPerfect(long n)
        {
            // To store sum of divisors 
            long sum = 1;

            // Find all divisors and add them 
            for (long i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i * i != n)
                        sum = sum + i + (n / i);
                    else
                        sum += i;
                }
            }
            // If sum of divisors is equal to 
            // n, then n is a perfect number 
            if (sum == n && n != 1)
                return true;

            return false;
        }

        public static long GetPreviousKeith(long n)
        {
            if (IsKeith(n))
                return -1;

            while (n > 0)
            {
                if (IsKeith(n))
                    return n;

                n--;
            }

            return -1;
        }

        public static long GetNextKeith(long n)
        {
            if (IsKeith(n))
                return -1;

            while (n < long.MaxValue)
            {
                if (IsKeith(n))
                    return n;

                n++;
            }

            return -1;
        }

        public static long GetKeithIndex(long n)
        {
            int keithIndex = 0;
            int currentIndex = 0;
            do
            {
                if (IsKeith(currentIndex))
                {
                    if (currentIndex == n)
                        return keithIndex + 1;

                    keithIndex++;
                }
                currentIndex++;
            } while (n > currentIndex - 1);
            return -1;
        }

        /*     public static long GetPreviousSmith(int n)
             {
                 if (IsSmith(n))
                     return -1;

                 while (n > 0)
                 {
                     if (IsSmith(n))
                         return n;

                     n--;
                 }

                 return -1;
             }

             public static long GetNextSmith(long n)
             {
                 if (IsSmith(n))
                     return -1;

                 while (n < long.MaxValue)
                 {
                     if (IsSmith(n))
                         return n;

                     n++;
                 }

                 return -1;
             }

             public static long GetSmithIndex(long n)
             {
                 int smithIndex = 0;
                 int currentIndex = 0;
                 do
                 {
                     if (IsSmith(currentIndex))
                     {
                         if (currentIndex == n)
                             return smithIndex + 1;

                         smithIndex++;
                     }
                     currentIndex++;
                 } while (n > currentIndex - 1);
                 return -1;
             }*/

        public static bool IsKeith(long x)
        {
            // Store all digits of x in a vector "terms" 
            // Also find number of digits and store in "n". 
            List<long> terms = new List<long>();
            long temp = x, n = 0; // n is number of digits in x 
            while (temp > 0)
            {
                terms.Add(temp % 10);
                temp /= 10;
                n++;
            }

            // To get digits in right order (from MSB to 
            // LSB) 
            terms.Reverse();

            // Keep finding next trms of a sequence generated 
            // using digits of x until we either reach x or a 
            // number greate than x 
            long next_term = 0, i = n;
            while (next_term < x)
            {
                next_term = 0;

                // Next term is sum of previous n terms 
                for (int j = 1; j <= n; j++)
                    next_term += terms[(int)i - j];

                terms.Add(next_term);
                i++;
            }

            /* When the control comes out of the while loop, 
            either the next_term is equal to the number 
            or greater than it. 
            If next_term is equal to x, then x is a 
            Keith number, else not */
            return (next_term == x);
        }

        // Returns true if n is a Smith number, else false. 
        /*   public static bool IsSmith(long n)
           {
               if (primes.Count == 0)
                   sieveSundaram();

               long original_no = n;

               // Find sum the digits of prime factors of n  
               long pDigitSum = 0;
               for (int i = 0; (int)primes[i] <= n / 2; i++)
               {
                   while (n % (int)primes[i] == 0)
                   {
                       // If primes[i] is a prime factor,  
                       // add its digits to pDigitSum.  
                       int p = (int)primes[i];
                       n /= p;
                       while (p > 0)
                       {
                           pDigitSum += (p % 10);
                           p /= 10;
                       }
                   }
               }

               // If n!=1 then one prime factor still to be  
               // summed up;  
               if (n != 1 && n != original_no)
               {
                   while (n > 0)
                   {
                       pDigitSum += n % 10;
                       n /= 10;
                   }
               }

               // All prime factors digits summed up  
               // Now sum the original number digits  
               long sumDigits = 0;
               while (original_no > 0)
               {
                   sumDigits += original_no % 10;
                   original_no /= 10;
               }

               // If sum of digits in prime factors and sum  
               // of digits in original number are same, then  
               // return true. Else return false.  
               return (pDigitSum == sumDigits);
           }
        */


        public static List<long> GetFactorization(long number)
        {
            var primes = new List<long>();

            for (long div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number /= div;
                }
            }
            return primes;
        }

        /// <summary>
        /// Converts the given decimal number to the numeral system with the
        /// specified radix (in the range [2, 36]).
        /// </summary>
        /// <param name="decimalNumber">The number to convert.</param>
        /// <param name="radix">The radix of the destination numeral system (in the range [2, 36]).</param>
        /// <returns></returns>
        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber /= radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }

        public static List<long> GetDivisors(long n)
        {
            List<long> divisors = new List<long>();
            divisors.Add(1);

            if (n < 2)
            {
                return divisors;
            }

            else if (PrimeNumberDictionary.Instance(PrimeNumberDictionary.N_DIGITS_OF_PRIME).GetNumberIndex(n) != -1)
            {
                divisors.Add(1);
                divisors.Add(n);
                return divisors;
            }
            else
            {
                for (int i = 2; i < n; i++)
                    if (n % i == 0)
                        divisors.Add(i);
            }
            divisors.Add(n);
            return divisors;
        }

        public static string ToRomanNumeral(long number)
        {
            List<string> romanNumerals = new List<string>() { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            List<int> numerals = new List<int>() { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            var romanNumeral = string.Empty;
            while (number > 0)
            {
                // find biggest numeral that is less than equal to number
                var index = numerals.FindIndex(x => x <= number);
                // subtract it's value from your number
                number -= numerals[index];
                // tack it onto the end of your roman numeral
                romanNumeral += romanNumerals[index];
            }
            return romanNumeral;
        }

        //  public static long GetNthPrime(long number)
        // {

        //  return PrimeNumberDictionary.Instance(PrimeNumberDictionary.N_DIGITS_OF_PRIME).GetNumberIndex(number);
        /*  try
          {
              long primeIndex = 1;

              // 2 and 3 are known to be prime 
              if (number > 2)
                  primeIndex++;

              if (number > 3)
                  primeIndex++;

              //Big Array is a mem hog try not to use unless we have too.
              //also throttle the multitasking if we are living large,
              //we don't want to run out of memory
              bool useBigArray;
              bool[] sieve = null;
              BigArray<bool> bigArraySieve = null;
              ParallelOptions parallelOptions = new ParallelOptions();


              if (number + 1 > UInt32.MaxValue)
              {
                  useBigArray = true;
                  bigArraySieve = new BigArray<bool>((ulong)number + 1);
                  parallelOptions.MaxDegreeOfParallelism = 4;
              }
              else
              {
                  useBigArray = false;
                  sieve = new bool[number + 1];
              }

              /* Mark siev[n] is true if one of the 
              following is true: 
              a) n = (4*x*x)+(y*y) has odd number  
                 of solutions, i.e., there exist  
                 odd number of distinct pairs  
                 (x, y) that satisfy the equation  
                 and    n % 12 = 1 or n % 12 = 5. 
              b) n = (3*x*x)+(y*y) has odd number  
                 of solutions and n % 12 = 7 
              c) n = (3*x*x)-(y*y) has odd number  
                 of solutions, x > y and n % 12 = 11 */
        /*
              for (long x = 1; x * x < number; x++)
              {
                  Parallel.Invoke(parallelOptions,
                  () =>
                  {
                      for (long y = 1; y * y < number; y++)
                      {
                          // Main part of Sieve of Atkin 
                          long n = (4 * x * x) + (y * y);
                          if (n <= number && (n % 12 == 1 || n % 12 == 5))
                          {
                              if (useBigArray)
                                  bigArraySieve[(ulong)n] ^= true;
                              else
                                  sieve[n] ^= true;
                          }

                          n = (3 * x * x) + (y * y);
                          if (n <= number && n % 12 == 7)
                          {
                              if (useBigArray)
                                  bigArraySieve[(ulong)n] ^= true;
                              else
                                  sieve[(ulong)n] ^= true;
                          }

                          n = (3 * x * x) - (y * y);
                          if (x > y && n <= number && n % 12 == 11)
                          {
                              if (useBigArray)
                                  bigArraySieve[(ulong)n] ^= true;
                              else
                                  sieve[(ulong)n] ^= true;
                              //sieve[n] ^= true;
                          }
                      }
                  });
              }


              // Mark all multiples of squares as 
              // non-prime 
              for (long r = 5; r * r < number; r++)
              {
                  Parallel.Invoke(parallelOptions,
                  () =>
                  {
                      if (useBigArray)
                      {
                          if (bigArraySieve[(ulong)r])
                          {
                              for (long i = r * r; i < number;
                                   i += r * r)
                              {
                                  bigArraySieve[(ulong)i] = false;
                              }
                          }
                      }
                      else
                      {
                          if (sieve[(ulong)r])
                          {
                              for (long i = r * r; i < number;
                                   i += r * r)
                              {
                                  sieve[(ulong)i] = false;
                              }
                          }
                      }
                  });
              }

              // Print primes using sieve[] 
              for (long a = 5; a < number; a++) 
              {
                  if (useBigArray)
                  {
                      if (bigArraySieve[(ulong)a])
                      {
                          primeIndex++;
                      }
                  }
                  else
                  {
                      if (sieve[(ulong)a])
                      {
                          primeIndex++;
                      }
                  }
              }
              if (useBigArray)
              {
                  bigArraySieve.Clear();
                  bigArraySieve.Dispose();
              }

              return primeIndex;
          }

          catch (Exception e)
          {
              LoggerFactory.Instance().LogException(e, "Error Determining prime index");
          }
          return -1;*/


        /*  public static long GetNthPrime(long number)
          {
              long primeIndex = 1;

              // 2 and 3 are known to be prime 
              if (number > 2)
                  primeIndex++;

              if (number > 3)
                  primeIndex++;

              // Initialise the sieve array with 
              // false values 
              bool[] sieve = new bool[number + 1];

              for (long i = 0; i < number; i++)
                  sieve[i] = false;

              /* Mark siev[n] is true if one of the 
              following is true: 
              a) n = (4*x*x)+(y*y) has odd number  
                 of solutions, i.e., there exist  
                 odd number of distinct pairs  
                 (x, y) that satisfy the equation  
                 and    n % 12 = 1 or n % 12 = 5. 
              b) n = (3*x*x)+(y*y) has odd number  
                 of solutions and n % 12 = 7 
              c) n = (3*x*x)-(y*y) has odd number  
                 of solutions, x > y and n % 12 = 11 
              for (long x = 1; x * x < number; x++)
              {
                  for (long y = 1; y * y < number; y++)
                  {

                      // Main part of Sieve of Atkin 
                      long n = (4 * x * x) + (y * y);
                      if (n <= number && (n % 12 == 1 || n % 12 == 5))

                          sieve[n] ^= true;

                      n = (3 * x * x) + (y * y);
                      if (n <= number && n % 12 == 7)
                          sieve[n] ^= true;

                      n = (3 * x * x) - (y * y);
                      if (x > y && n <= number && n % 12 == 11)
                          sieve[n] ^= true;
                  }
              }

              // Mark all multiples of squares as 
              // non-prime 
              for (long r = 5; r * r < number; r++)
              {
                  if (sieve[r])
                  {
                      for (long i = r * r; i < number;
                           i += r * r)
                          sieve[i] = false;
                  }
              }

              // Print primes using sieve[] 
              for (long a = 5; a < number; a++)
                  if (sieve[a])
                      primeIndex++;
              return primeIndex;
          } 

          public static long GetNthPrime(long number)
          {
              long primeIndex = 1;

              // 2 and 3 are known to be prime 
              if (number > 2)
                  primeIndex++;

              if (number > 3)
                  primeIndex++;

              // Initialise the sieve array with 
              // false values 
              bool[] sieve = new bool[number + 1];

              for (long i = 0; i < number; i++)
                  sieve[i] = false;

              /* Mark siev[n] is true if one of the 
              following is true: 
              a) n = (4*x*x)+(y*y) has odd number  
                 of solutions, i.e., there exist  
                 odd number of distinct pairs  
                 (x, y) that satisfy the equation  
                 and    n % 12 = 1 or n % 12 = 5. 
              b) n = (3*x*x)+(y*y) has odd number  
                 of solutions and n % 12 = 7 
              c) n = (3*x*x)-(y*y) has odd number  
                 of solutions, x > y and n % 12 = 11 
              Parallel.Invoke(
                 () =>
                 {
                     for (long x = 1; x * x < number; x++)
                     {
                         Parallel.Invoke(
                         () =>
                         {
                             for (long y = 1; y * y < number; y++)
                             {

                                 // Main part of Sieve of Atkin 
                                 long n = (4 * x * x) + (y * y);
                                 if (n <= number && (n % 12 == 1 || n % 12 == 5))

                                     sieve[n] ^= true;

                                 n = (3 * x * x) + (y * y);
                                 if (n <= number && n % 12 == 7)
                                     sieve[n] ^= true;

                                 n = (3 * x * x) - (y * y);
                                 if (x > y && n <= number && n % 12 == 11)
                                     sieve[n] ^= true;
                             }
                         });
                     }
                 });

              // Mark all multiples of squares as 
              // non-prime 
              for (long r = 5; r * r < number; r++)
              {
                  Parallel.Invoke(
                  () =>
                  {
                      if (sieve[r])
                      {
                          for (long i = r * r; i < number;
                               i += r * r)
                              sieve[i] = false;
                      }
                  });
              }

              // Print primes using sieve[] 
              for (long a = 5; a < number; a++)
                  if (sieve[a])
                      primeIndex++;
              return primeIndex;
        */
    }
}

