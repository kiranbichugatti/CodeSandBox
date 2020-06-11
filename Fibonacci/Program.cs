using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            var input = Console.ReadLine();
            int output = Fibonacci(Convert.ToInt32(input));
            Console.WriteLine($"Fibonacci of {input} is : {output}");
        }

        public static int Fibonacci(int n)
        {
            if (n <= 0) return 0;

            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
