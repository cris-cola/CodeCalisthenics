using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCalisthenics.Operations
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int d)
        {
            data = d;
        }
    }

    public class SearchTree
    {

        public static int getHeight(Node root)
        {
            int heightLeft = 0;
            int heightRight = 0;
            if (root == null)
                return 0;
            else
            {
                if (root.left != null)
                    heightLeft += getHeight(root.left) + 1;

                if (root.right != null)
                    heightRight += getHeight(root.right) + 1;
            }
            return (heightRight < heightLeft 
                ? heightLeft : heightRight);
        }

        public void Execute()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);

        }

        public static Node insert(Node root, int data)
        {
            if (root == null)
                return new Node(data);
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

    }

}
