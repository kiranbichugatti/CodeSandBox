using System;
using System.Collections.Generic;
using System.IO.Pipes;

namespace LongestSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = LengthOfLongestSubstring("abba");
            Console.WriteLine(result);
        }

        public static int LengthOfLongestSubstring(string s)
        {

            var n = s.Length;
            int ans = 0, i = 0, j = 0;
            var set = new HashSet<char>();

            while (i < n && j < n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    j++;
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i]);
                    i++;
                }

            }

            return ans;
        }
    }
}
