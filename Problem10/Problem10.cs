// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
// Find the sum of all the primes below two million.

using System;
using ProjectEulerLib;


namespace Problem10
{
    class Problem10
    {
        const int MAXSIZE = 2000000;

        static void Main(string[] args)
        {
            long counter = 0;

            for (int i = 2; i < MAXSIZE; i++)
            {
                if (MathUtils.IsPrime(i))
                {
                    counter += i;
                }
            }

            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
