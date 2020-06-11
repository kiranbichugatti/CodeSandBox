using System;

namespace Fibonacci_Memoization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            var input = Convert.ToInt32(Console.ReadLine());
            int[] memo = new int[input + 1];
            for(int i =0; i<input; i++)
            {
                Console.WriteLine(Fibonacci(i, memo));
            }
            
            
        }

        public static int Fibonacci(int n, int[] memo)
        {
            if (n <= 0) return 0;

            if (n == 1) return 1;

            if (memo[n] > 0) return memo[n];

            memo[n] = Fibonacci(n - 1, memo) + Fibonacci(n - 2, memo);

            return memo[n];
        }
    }
}
