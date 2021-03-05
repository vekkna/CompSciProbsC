using System;

namespace CompSciProbsC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   var fib = new Fibonacci();
              for (int i = 0; i < 60; i++)
                  Console.WriteLine(i + ": " + fib.FibIter(i)); */
            var gene = "GAGTCGACGTA";
            var geneCompressor = new GeneCompressor(gene);
            Console.WriteLine(gene == geneCompressor.Decompress());
        }
    }
}