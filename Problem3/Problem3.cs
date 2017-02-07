// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?

using System;
using ProjectEulerLib;

namespace Problem3
{
    class Problem3
    {
        const long MAXSIZE = 600851475143;
        
        static void Main(string[] args)
        {
            for (long i = Convert.ToInt64(Math.Ceiling(Math.Sqrt(MAXSIZE))); i > 1; --i)
            {
                if ((MAXSIZE % i == 0) && MathUtils.IsPrime(i))
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
