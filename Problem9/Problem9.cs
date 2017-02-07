// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
// a^2 + b^2 = c^2
// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
// Find the product abc.

using System;
using ProjectEulerLib;

namespace Problem9
{
    class Problem9
    {
        //const int MAXSIZE = 1000;

        static void Main(string[] args)
        {
            var c = 0;

            for (var a = 1; a < 333; ++a)
            {
                for (var b = a + 1; b < 500; ++b)
                {
                    c = 1000 - (a + b);
                    if ((a + b > c) && (a + c > b) && (b + c > a)) {
                        if ((MathUtils.Power(a, 2) + MathUtils.Power(b, 2)) == MathUtils.Power(c, 2))
                        {
                            Console.WriteLine(a.ToString() + ' ' + b.ToString() + ' ' + c.ToString());
                            Console.ReadKey();
                            return;
                        }
                    }
                    
                }
            }
            /*
            int b, c;
            // Use Euclid's formula

            // a = k(m^2 - n^2)
            // b = k(2mn)
            // c = k(m^2 + n^2)
            // where m, n, and k are positive integers with m > n, m − n odd, and with m and n coprime.
            for (int a = 1; a < MAXSIZE; ++a)
            {
                // Even
                if (a % 2 == 0)
                {
                    b = MathUtils.Power(a/2, 2) - 1;
                    c = MathUtils.Power(a/2, 2) + 1;
                    if ((a + b + c) == 1000)
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                        Console.ReadKey();
                        return;
                    }
                }
                // Odd
                else
                {
                    b = (MathUtils.Power(a, 2) - 1) / 2;
                    c = (MathUtils.Power(a, 2) + 1) / 2;
                    if ((a + b + c) == 1000)
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                        Console.ReadKey();
                        return;
                    }
                }
            }*/
            Console.WriteLine("nothing found");
            Console.ReadKey();

        }
    }
}
