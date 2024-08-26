using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class LargestLevelValueTests
    {
        [Fact]
        public void TestLargestLevelValue()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(5);
            Btree.Root.Left = new Node(13);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(12);
            Btree.Root.Right.Right = new Node(20);
            Btree.Root.Left.Left.Left = new Node(1);
            Btree.Root.Left.Left.Right = new Node(4);
            Btree.Root.Right.Left.Right = new Node(11);

            List<int> largestValues = Btree.LargestLevelValue();
            Assert.Equal(new List<int> { 5, 13, 20, 11 }, largestValues);
        }

        [Fact]
        public void TestLargestLevelValue_SingleNode()
        {
            BinaryTree Btree = new BinaryTree(new Node(42));

            List<int> largestValues = Btree.LargestLevelValue();
            Assert.Equal(new List<int> { 42 }, largestValues);
        }

        [Fact]
        public void TestLargestLevelValue_EmptyTree()
        {
            BinaryTree Btree = new BinaryTree();

            List<int> largestValues = Btree.LargestLevelValue();
            Assert.Empty(largestValues);
        }

    }
}
