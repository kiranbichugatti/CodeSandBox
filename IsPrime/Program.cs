using System;
using System.Security.Cryptography.X509Certificates;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to find out prime or not");
            var input = Console.ReadLine();
            Console.WriteLine(IsPrime(Convert.ToInt32(input)));
        }

        public static bool IsPrime(int n)
        {
            for(int x=2; x<=Math.Sqrt(n); x++)
            {
                if (n % x == 0) return false;
            }

            return true;
        }
    }
}
