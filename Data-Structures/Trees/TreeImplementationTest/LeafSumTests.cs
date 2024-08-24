using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class LeafSumTests
    {
        [Fact]
        public void Test_SumOfLeafNodes_ProvidedExample()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(9);
            tree.Root.Left = new Node(8);
            tree.Root.Right = new Node(12);
            tree.Root.Left.Left = new Node(3);
            tree.Root.Left.Right = new Node(7);
            tree.Root.Right.Left = new Node(17);
            tree.Root.Right.Right = new Node(23);
            tree.Root.Left.Left.Right = new Node(4);

            // Act
            int result = tree.SumOfLeafNodes();

            // Assert
            Assert.Equal(51, result);  // 4 + 7 + 17 + 23 = 51
        }

        [Fact]
        public void Test_SumOfLeafNodes_NegativeLeafValues()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(5);
            tree.Root.Left = new Node(-3);
            tree.Root.Right = new Node(2);
            tree.Root.Left.Left = new Node(-1);
            tree.Root.Left.Right = new Node(0);

            // Act
            int result = tree.SumOfLeafNodes();

            // Assert
            Assert.Equal(-1, result);  // -1 is the only leaf node
        }

        [Fact]
        public void Test_SumOfLeafNodes_EmptyTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act
            int result = tree.SumOfLeafNodes();

            // Assert
            Assert.Equal(0, result);  // No nodes, so sum is 0
        }

        [Fact]
        public void Test_SumOfLeafNodes_SingleNodeTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree(new Node(10));

            // Act
            int result = tree.SumOfLeafNodes();

            // Assert
            Assert.Equal(10, result);  // Only one node which is also a leaf
        }
    }
}
