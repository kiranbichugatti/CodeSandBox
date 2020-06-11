using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Enter an integer");
            var input = Console.ReadLine();
            int output = Factorial(Convert.ToInt32(input));
            Console.WriteLine($"Factorial of {input} is : {output}");
        }

        public static int Factorial(int n)
        {
            if (n < 0) return -1;

            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
    }
}
