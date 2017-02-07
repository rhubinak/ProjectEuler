// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
// Find the sum of all the multiples of 3 or 5 below 1000.

using System;

namespace Problem1
{
    class Problem1
    {
        const int MAXSIZE = 1000;
 
        static void Main(string[] args)
        {
            int result = 0;

            // First approach
            /*
            for (int i = 0; i < MAXSIZE; ++i)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    result += i;
                }
            }
            */

            // Second approach (faster)

            // Get sum of numbers divisible by 3
            for (int i = 3; i < MAXSIZE; i += 3)
            {
                    result += i;
            }

            // Add sum of numbers divisible by 5
            for (int i = 5; i < MAXSIZE; i += 5)
            {
                result += i;
            }

            // Substract sum of numbers divisible by 15 
            for (int i = 15; i < MAXSIZE; i += 15)
            {
                result -= i;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
