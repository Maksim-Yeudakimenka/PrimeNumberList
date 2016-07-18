using System;
using System.Linq;
using PrimeGenerator;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var primes = PrimeSequenceGenerator.GenerateNFirst(4).ToList();

            Console.Write("List: ");
            primes.ForEach(prime => Console.Write(prime + " "));
            Console.WriteLine();

            var sum = primes.Sum(prime => (double)prime / (primes.IndexOf(prime) + 1));
            Console.WriteLine("Sum = " + sum);

            var result = Math.Floor(sum);
            Console.WriteLine("Result = " + result);

            Console.ReadKey();
        }
    }
}