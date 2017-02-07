// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10 001st prime number?

using System;
using ProjectEulerLib;

namespace Problem7
{
    class Problem7
    {
        const int MAXSIZE = 10001;

        static void Main(string[] args)
        {
            int primeCount = 0;
            long i = 0;

            while (primeCount < 10001)
            {
                i++;

                if (MathUtils.IsPrime(i))
                {
                    primeCount++;
                }
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
