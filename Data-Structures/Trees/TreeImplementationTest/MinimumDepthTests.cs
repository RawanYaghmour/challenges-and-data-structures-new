using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
   public class MinimumDepthTests
    {
        [Fact]
        public void TestMinimumDepth_VaryingDepths()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);

            int minDepth = Btree.FindMinimumDepth();
            Assert.Equal(2, minDepth);
        }

        [Fact]
        public void TestMinimumDepth_EmptyTree()
        {
            BinaryTree emptyTree = new BinaryTree();
            int minDepth = emptyTree.FindMinimumDepth();
            Assert.Equal(0, minDepth);
        }

        [Fact]
        public void TestMinimumDepth_SingleNode()
        {
            BinaryTree singleNodeTree = new BinaryTree();
            singleNodeTree.Root = new Node(1);
            int minDepth = singleNodeTree.FindMinimumDepth();
            Assert.Equal(1, minDepth);
        }

        [Fact]
        public void TestMinimumDepth_TreeWithVaryingDepths()
        {
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(1);
            Btree2.Root.Left = new Node(2);
            Btree2.Root.Right = new Node(3);
            Btree2.Root.Left.Right = new Node(5);
            Btree2.Root.Right.Right = new Node(6);

            int minDepth = Btree2.FindMinimumDepth();
            Assert.Equal(3, minDepth);
        }
    }
}
