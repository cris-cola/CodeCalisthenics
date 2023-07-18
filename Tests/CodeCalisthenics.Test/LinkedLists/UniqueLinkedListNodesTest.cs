using CodeCalisthenics.Operations.LinkedLists;
using Xunit;

namespace CodeCalisthenics.Test.LinkedLists
{
    public class UniqueLinkedListNodesTest
    {
        [Theory]
        [InlineData(new [] { 1, 1, 2, 2, 3, 3, 4 }, new[] { 1, 2, 3, 4 })]
        public void TestUniqueNode(int[] T, int[] expectedT)
        {
            // Arrange
            NodeU head = null;
            int i = 0;
            while (i < T.Length)
            {
                head = UniqueNodeSolution.insert(head, T[i]);
                i++;
            }

            // Act
            head = UniqueNodeSolution.removeDuplicates(head);

            // Assert
            i = 0;
            while (head != null)
            {
                Assert.Equal(expectedT[i], head.data);

                i++;
                head = head.next;
            }
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 } )]
        [InlineData(new[] { 1, 1, 2, 2, 3, 3, 4 }, new[] { 1, 1, 2, 2, 3, 3, 4 })]
        public void TestCopyNode(int[] T, int[] expectedT)
        {
            // Arrange
            NodeU head = null;
            int i = 0;
            while (i < T.Length)
            {
                head = UniqueNodeSolution.insert(head, T[i]);
                i++;
            }

            // Act
            head = UniqueNodeSolution.copyThree(head);

            // Assert
            i = 0;
            while (head != null)
            {
                Assert.Equal(expectedT[i], head.data);
             
                i++;
                head = head.next;
            }
        }
    }
}