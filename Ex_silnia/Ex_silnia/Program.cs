using System;

namespace FactorialExample
{
    class Factorial
    {
        public int MaxN { get; }

        public Factorial(int maxN) => MaxN = maxN;

        private int CalculateFactorial(int n) => (n <= 1) ? 1 : n * CalculateFactorial(n - 1);

        public void Show()
        {
            for (int i = 0; i < MaxN; i++)
            {
                Console.WriteLine($"Iteration {i} : value {CalculateFactorial(i)}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Factorial f = new Factorial(7);
            f.Show();
        }
    }
}
