using System;
using System.Collections.Generic;

namespace Fullfilment_Builder
{
    class Program
    {
        public static int ConnectSticks(int[] sticks)
        {
            Array.Sort(sticks);

            var totalcost = 0;
            var sumQueue = new Queue<int>();
            var listQueue = new Queue<int>(sticks);

            while(listQueue.Count + sumQueue.Count > 1)
            {
                var cost = getShortestSum(listQueue, sumQueue) + getShortestSum(listQueue, sumQueue);
                sumQueue.Enqueue(cost);
                totalcost += cost;
            }
            return totalcost;
        }

        private static int getShortestSum(Queue<int> listQueue, Queue<int> sumQueue)
        {
            if (listQueue.Count == 0)
                return sumQueue.Dequeue();

            if (sumQueue.Count == 0)
                return listQueue.Dequeue();

            return listQueue.Peek() > sumQueue.Peek() ? sumQueue.Dequeue() : listQueue.Dequeue();
        }

        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 5, 10, 35, 89 };
            Console.WriteLine(ConnectSticks(arr));
        }
    }
}
