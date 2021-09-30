using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CodeCalisthenics.Operations
{
    public class BreadthFirstSearch
    {
        public static Queue<Node> nodeQ = new Queue<Node>();

        public void levelOrder(Node root)
        {
            //Write your code here
            nodeQ.Enqueue(root);
                
            while (nodeQ.Count > 0)
            {
                var n = nodeQ.Dequeue();
                Console.WriteLine(n.data);
                if (root.left != null)
                    nodeQ.Enqueue(n.left);

                if (root.right != null)
                    nodeQ.Enqueue(n.right);
            }
        }
        
        public Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
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

        public void Execute()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }

    }

   
}
