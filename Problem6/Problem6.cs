// The sum of the squares of the first ten natural numbers is,
// 12 + 22 + ... + 102 = 385
// The square of the sum of the first ten natural numbers is,
// (1 + 2 + ... + 10)2 = 552 = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

using System;

namespace Problem6
{
    class Problem6
    {
        const int MAXSIZE = 100;

        static void Main(string[] args)
        {
            // Sum of first 100 natural numbers
            double sum = 0;

            // Sum of first 100 natural number squares
            double sumSquares = 0;

            for (int i = 1; i <= MAXSIZE; ++i)
            {
                sum += i;
                sumSquares += Math.Pow(i, 2);

            }

            Console.WriteLine(Math.Pow(sum, 2) - sumSquares);
            Console.ReadKey();
        }
    }
}
