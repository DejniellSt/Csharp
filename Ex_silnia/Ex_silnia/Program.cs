using System;

namespace FactorialExample
{
    // The newest veriosn

    abstract class Sequence
    {
        public int MaxN { get; }

        public Sequence(int maxN) => MaxN = maxN;

        protected abstract int Calculate(int n);

        public virtual void Show()
        {
            for(int i = 0; i <=MaxN; i++)
            {
                Console.WriteLine($"Iteration {i} : value {Calculate(i)}");
            }
        }
    }

    class Factorial : Sequence
    {
        public Factorial(int maxN) : base(maxN) { }

        protected override int Calculate(int n) => (n <= 1) ? 1 : n * Calculate(n - 1);
        
    }

    class Fibo : Sequence
    {

        public Fibo(int maxN) : base(maxN) { }

        protected override int Calculate(int n) => (n <= 1) ? 1 : Calculate(n - 1) * Calculate(n - 2);

    }


    // Old version !!!!
    /*class Factorial
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

    class Fibo
    {
        public int MaxN { get; }

        public Fibo(int maxN) => MaxN = maxN;

        private int CalculateFibo(int n) => (n <= 1) ? 1 : CalculateFibo(n - 1) + CalculateFibo(n - 2);

        public void Show()
        {
            for(int i = 0; i< MaxN; i++)
            {
                Console.WriteLine($"Iteration : {i} value {CalculateFibo(i)}");
            }
        }
     }*/

    class Program
    {
        static void Main(string[] args)
        {
            List<Sequence> sequences = new List<Sequence>
             {
                new Factorial(6),
                new Fibo(5)
            };

            /*Sequence[] sequences =
            {
                new Factorial(6),
                new Fibo(5)
            };*/

            foreach(var seq in sequences)
            {
                seq.Show();
            }
            /*
            Factorial f = new Factorial(7);
            Fibo fibo = new Fibo(8);

            Console.WriteLine("Factorial !!");
            f.Show();
            Console.WriteLine("Fibo !!");
            fibo.Show();
            */
        }
    }
}
