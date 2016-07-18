using System;
using System.Collections.Generic;

namespace PrimeGenerator
{
    public static class PrimeSequenceGenerator
    {
        public static IEnumerable<int> GenerateNFirst(int n)
        {
            if (n < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Count 'n' must be greater than zero.");
            }

            var prime = 2;
            yield return prime;

            for (var i = 0; i < n - 1; i++)
            {
                prime = GenerateNext(prime);
                yield return prime;
            }
        }

        private static int GenerateNext(int prime)
        {
            for (var current = prime + 1; ; current++)
            {
                if (IsPrime(current))
                {
                    return current;
                }
            }
        }

        private static bool IsPrime(int number)
        {
            for (var denom = 2; denom * denom <= number; denom++)
            {
                if (number % denom == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

}