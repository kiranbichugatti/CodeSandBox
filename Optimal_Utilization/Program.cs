using System;
using System.Collections.Generic;
using System.Linq;

namespace Optimal_Utilization
{
    public class OptimalUtilization
    {
        private static IList<IList<int>> Find (int[][] x, int[][] y, int target)
        {
            if (x == null || y == null || x.Length == 0 || y.Length == 0)
                return new List<IList<int>>();

            x = x.OrderBy(c => c[1]).ToArray();
            y = y.OrderBy(c => c[1]).ToArray();

            var result = new List<IList<int>>();
            var i = 0;
            var j = y.Length - 1;
            var max = int.MinValue;

            while(i<x.Length && j>=0)
            {
                var sum = x[i][1] + y[j][1];

                if(sum>target)
                {
                    j--;
                    continue;
                }
                if(max<=sum)
                {
                    if(max<sum)
                    {
                        max = sum;
                        result.Clear();
                    }
                    result.Add(new List<int>() { x[i][0], y[j][0] });

                    while (i < x.Length - 1 && x[i][1] == x[i + 1][1])
                    {
                        result.Add(new List<int>() { x[i + 1][0], y[j][0] });
                        i++;
                    }
                }
                i++;
            }
            return result;
        }


        public static void Main(string[] args)
        {
            var a = new int[3][] { new int[2] { 1, 2 }, new int[2] { 2, 4 }, new int[2] { 3, 6 } };
            var b = new int[1][] { new int[2] { 1, 2 } };
            var target = 7;
            var result = Find(a, b, target);
            var list = new List<string>();
            foreach (var res in result)
                list.Add($"[{string.Join(',', res)}]");
            System.Console.WriteLine($"[{string.Join(',', list)}]");

            a = new int[4][] { new int[2] { 1, 3 }, new int[2] { 2, 5 }, new int[2] { 3, 5 }, new int[2] { 4, 10 } };
            b = new int[4][] { new int[2] { 1, 2 }, new int[2] { 2, 3 }, new int[2] { 3, 4 }, new int[2] { 4, 5 } };
            target = 10;
            result = Find(a, b, target);
            list = new List<string>();
            foreach (var res in result)
                list.Add($"[{string.Join(',', res)}]");
            System.Console.WriteLine($"[{string.Join(',', list)}]");

            a = new int[3][] { new int[2] { 1, 8 }, new int[2] { 2, 7 }, new int[2] { 3, 14 } };
            b = new int[3][] { new int[2] { 1, 5 }, new int[2] { 2, 10 }, new int[2] { 3, 14 } };
            target = 20;
            result = Find(a, b, target);
            list = new List<string>();
            foreach (var res in result)
                list.Add($"[{string.Join(',', res)}]");
            System.Console.WriteLine($"[{string.Join(',', list)}]");

            a = new int[3][] { new int[2] { 1, 8 }, new int[2] { 2, 15 }, new int[2] { 3, 9 } };
            b = new int[3][] { new int[2] { 1, 8 }, new int[2] { 2, 11 }, new int[2] { 3, 12 } };
            target = 20;
            result = Find(a, b, target);
            list = new List<string>();
            foreach (var res in result)
                list.Add($"[{string.Join(',', res)}]");
            System.Console.WriteLine($"[{string.Join(',', list)}]");
        }
    }
}
