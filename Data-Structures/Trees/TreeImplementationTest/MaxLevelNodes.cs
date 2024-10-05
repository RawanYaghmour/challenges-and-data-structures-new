using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class MaxLevelNodes
    {
        [Fact]
        public void TestMaxLevelNodesExample1()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Left = new Node(7);

            // Act
            int result = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result); // Expected output: Level 2 has the maximum nodes (3 nodes)
        }

        [Fact]
        public void TestMaxLevelNodesExample2()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(7);
            Btree.Root.Left.Left.Left = new Node(8);
            Btree.Root.Left.Right.Left = new Node(9);
            Btree.Root.Right.Right.Left = new Node(10);

            // Act
            int result = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result); // Expected output: Level 2 has the maximum nodes (3 nodes)
        }

        [Fact]
        public void TestEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act
            int result = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(-1, result); // Expected output: -1 for empty tree
        }

        [Fact]
        public void TestSingleNodeTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);

            // Act
            int result = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(0, result); // Expected output: Level 0 has 1 node
        }
    }
}
