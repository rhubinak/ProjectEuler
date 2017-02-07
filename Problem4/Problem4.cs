// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
// Find the largest palindrome made from the product of two 3-digit numbers.

// 999*999 = 998001 = upper boundary for solution

using System;
using ProjectEulerLib;

namespace Problem4
{
    class Problem4
    {
        const int MAXSIZE = 998001;
        const int MINSIZE = 10000;

        static void Main(string[] args)
        {
            for (int i = MAXSIZE; i > MINSIZE; --i)
            {
                string number = Convert.ToString(i);

                if (number == StringUtils.ReverseString(number))
                {
                    for (int j = Convert.ToInt32(Math.Ceiling(Math.Sqrt(i))); j >= 100; --j)
                    {
                        if ((i % j == 0) && (i / j >= 100) && (i / j < 1000))
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(j);
                            Console.ReadKey();
                            return;
                        }
                    }
                }
            }

        }
    }
}
