using CodeCalisthenics.Operations.LinkedLists;
using Xunit;

namespace CodeCalisthenics.Test.LinkedLists
{
    public class LinkedListNodeTest
    {
        public NodeSolution sut;

        [Theory]
        [InlineData(new int[4] { 2, 3, 4, 1 })]
        public void TestMaxdiff(int[] elements)
        {
            var T = elements.Length;
            NodeSolution sut = new NodeSolution();

            LinkedListNode head = null;
            foreach (var data in elements)
            {
                head = NodeSolution.insert(head, data);
            }
            NodeSolution.display(head);
        }
    }
}
