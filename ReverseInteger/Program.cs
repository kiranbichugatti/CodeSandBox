using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var output = ReverseInteger(123);

            Console.WriteLine($"Output:{output}");

            var output2 = ReverseInteger(-4356);

            Console.WriteLine($"Output:{output2}");
        }

        public static int ReverseInteger(int num)
        {
            int reverse = 0;
            int pop = 0;

            while(num!=0)
            {
                pop = num % 10;
                num /= 10;

                if (reverse > Int32.MaxValue / 10 || reverse == Int32.MaxValue / 10 && pop > 7) return 0;
                if (reverse < Int32.MinValue / 10 || reverse == Int32.MinValue / 10 && pop < -8) return 0;

                reverse = reverse * 10 + pop;
            }
            return reverse;
        }

    }
}
