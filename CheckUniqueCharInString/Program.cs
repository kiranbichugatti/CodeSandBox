using System;

namespace CheckUniqueCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string!");
            var str = Console.ReadLine();
            var output = IsUniqueN(str);
            Console.WriteLine(output);

        }

        public static bool IsUniqueNSquare(string s)
        {
            for(int i = 0;i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                     if(s[i] == s[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsUniqueN(string s)
        {
            if (s.Length > 128) return false;

            bool[] flag = new bool[128];

            foreach(char c in s)
            {
                if(flag[c])
                {
                    return false;
                }
                flag[c] = true;
            }

            return true;
        }
    }
}
