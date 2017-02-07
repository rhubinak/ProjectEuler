// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

using System;
using ProjectEulerLib;

namespace Problem5
{
    class Problem5
    {
        const int MAXSIZE = 20;

        static void Main(string[] args)
        {
            Console.WriteLine(MathUtils.GetLCM(0, MAXSIZE));
            Console.ReadKey();

        }
    }
}
