using System;

namespace CodeCalisthenics.Operations
{
    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;
        public LinkedListNode(int d)
        {
            data = d;
            next = null;
        }
    }

    public class NodeSolution
    {

        public static void Execute()
        {
            LinkedListNode head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

        public static LinkedListNode insert(LinkedListNode head, int data)
        {
            if (head == null)
                head = new LinkedListNode(data);
            else
                head.next = insert(head.next, data);

            return head;
        }

        public static LinkedListNode insertTwo(LinkedListNode head, int data)
        {
            //Complete this method
            if (head == null)
                return new LinkedListNode(data);

            if (head.next == null)
                head.next = new LinkedListNode(data);
            else
                insertTwo(head.next, data);

            return head;
        }

        public static void display(LinkedListNode head)
        {
            LinkedListNode start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
