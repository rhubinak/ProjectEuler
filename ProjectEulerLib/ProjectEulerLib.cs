using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEulerLib
{
    public static class MathUtils
    {
        /// <summary>
        /// List all numbers from Triangular series.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> GetTriangularNumbers(int number)
        {
            List<int> lstTriangularNumbers = new List<int>();
            var triangularNumber = 0;

            for (var i = 1; i < number; i++)
            {
                triangularNumber += i;
                lstTriangularNumbers.Add(triangularNumber);
            }
            return lstTriangularNumbers;
        }

        /// <summary>
        /// Return list of all integer factors.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> GetFactors(int number)
        {
            var factors = new List<int>();
            int max = (int)Math.Sqrt(number);  //round down
            for (int factor = 1; factor <= max; ++factor)
            {
                //test from 1 to the square root, or the int below it, inclusive.
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    {
                        // Don't add the square root twice!  
                        factors.Add(number / factor);
                    }
                }
            }
            return factors;
        }

        public static bool IsPrime(long number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        // Fast doubling algorithm
        public static BigInteger Fibonacci(int n)
        {
            BigInteger a = BigInteger.Zero;
            BigInteger b = BigInteger.One;
            for (int i = 31; i >= 0; i--)
            {
                BigInteger d = a * (b * 2 - a);
                BigInteger e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)n >> i) & 1) != 0)
                {
                    BigInteger c = a + b;
                    a = b;
                    b = c;
                }
            }
            return a;
        }

        /*
        public static long Fibonacci(int n)
        {
            long result = 0;
            long b = 1;

            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; ++i)
            {
                long temp = result;
                result = b;
                b = temp + b;
            }
            return result;
        }
        */

        // lcm is the Lowest Common Multiple, which starts as just 'from'
        public static int GetLCM(int from, int to)
        {
            var lcm = 1;
            var sum = lcm;

            if (from < 1)
            {
                from = 1;
            }

            for (int i = from; i <= to; i++)
            {
                while (sum % i != 0)
                {
                    sum += lcm;
                }
                lcm = sum;
            }
            return lcm;
        }

        public static int GCD(int a, int b)
        {
            int remainder;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        public static int Power(int a, int b)
        {
            if (b < 0)
            {
                throw new ApplicationException("B must be a positive integer or zero");
            }
            if (b == 0) return 1;
            if (a == 0) return 0;
            if (b % 2 == 0)
            {
                return Power(a * a, b / 2);
            }
            else if (b % 2 == 1)
            {
                return a * Power(a * a, b / 2);
            }
            return 0;
        }
    }
    public static class StringUtils
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }
}
