using System;

namespace ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode test1 = new ListNode(1, null);
            ListNode test2 = new ListNode(2, test1);
            ListNode test3 = new ListNode(3, test2);
            ListNode test4 = new ListNode(4, test3);
            ListNode test5 = new ListNode(5, test4);

            ListNode traverse = test5;
            while(traverse!=null)
            {
                Console.Write(traverse.val + "->");
                traverse = traverse.next;
            }

            var result = ReverseList(test5);

            traverse = result;
            Console.WriteLine("");
            while (traverse != null)
            {
                Console.Write(traverse.val + "->");
                traverse = traverse.next;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;
        }
    }
}
