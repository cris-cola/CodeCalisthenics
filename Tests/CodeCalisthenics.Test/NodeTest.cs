using System;
using System.Collections.Generic;
using System.Text;
using CodeCalisthenics.Operations;
using Xunit;

namespace CodeCalisthenics.Test
{
    public class NodeTest
    {
        public NodeSolution sut;

        [Theory]
        [InlineData(new int[4] { 2, 3, 4, 1})]
        public void TestMaxdiff(int[] elements)
        {
            var T = elements.Length;
            NodeSolution sut = new NodeSolution();

            Node head = null;
            foreach (var data  in elements)
            {
                head = NodeSolution.insert(head, data);
            }
            NodeSolution.display(head);
        }
    }
}
