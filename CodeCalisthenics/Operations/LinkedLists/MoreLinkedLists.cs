using System;
using static System.Int32;

namespace CodeCalisthenics.Operations.LinkedLists
{
    public class UniqueNodeSolution
    {
        public static NodeU copyThree(NodeU head)
        {
            NodeU current = head;

            while (current != null)
                current = current.next;

            return head;
        }

        /**
         * In the removeDuplicates method, you're not modifying the head reference itself,
         * but you're modifying the linked list that head points to.
         * When you pass head to the removeDuplicates method,
         * you're passing the reference to the first node of the linked list.
         *
         * Inside the method, you're using another reference (current) to traverse this list and remove duplicates.
         *
         * The key point here is that head and current are *references* to *nodes* in the linked list.
         * When you modify the *next* property of a node that *current* points to,
         * you're modifying the structure of the linked list.
         *
         * However, *head* still points to the first node of this modified list.
         */
        public static NodeU removeDuplicates(NodeU head)
        {
            NodeU current = head;

            while (current != null)
            {
                var next = current.next;

                if (next != null && current.data == next.data)
                    current.next = next.next;
                else
                    current = next;
            }
            return head;
        }

        public static NodeU insert(NodeU head, int data)
        {
            NodeU p = new NodeU(data);

            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                NodeU start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;
            }
            return head;
        }

        public static void display(NodeU head)
        {
            NodeU start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static void Execute(String[] args)
        {
            NodeU head = null;
            int T = Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }

    public class NodeU
    {
        public int data;
        public NodeU next;
        public NodeU(int d)
        {
            data = d;
            next = null;
        }
    }
}
