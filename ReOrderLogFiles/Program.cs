using System;
using System.Collections.Generic;
using System.Linq;

namespace ReOrderLogFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] logs = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            var result = ReorderLogFilesMethod(logs);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
    }

        public static string[] ReorderLogFilesMethod(string[] logs)
        {

            var listOfDigits = new List<string>();
            var listOfChars = new List<string>();

            foreach (var arr in logs)
            {
                var split = arr.Split(new[] { ' ' }, 2);

                if (char.IsDigit(split[1][0]))
                {
                    listOfDigits.Add(arr);
                }
                else
                {
                    listOfChars.Add(arr);
                }
            }

            listOfChars.Sort((x, y) =>
            {
                var s1 = x.Substring(x.IndexOf(' ') + 1);
                var s2 = y.Substring(y.IndexOf(' ') + 1);
                var result = string.Compare(s1, s2, StringComparison.Ordinal);

                if (result == 0)
                {
                    result = string.Compare(x, y, StringComparison.Ordinal);
                }
                return result;
            });
            return listOfChars.Concat(listOfDigits).ToArray();
        }
    }
}
