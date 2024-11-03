using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinaryTreeToBST
    {
        [Fact]
        public void TestConvertToBST_ProvidedExample()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(40);
            Btree.Root.Left = new Node(10);
            Btree.Root.Right = new Node(50);
            Btree.Root.Left.Left = new Node(5);
            Btree.Root.Left.Right = new Node(30);
            Btree.Root.Right.Right = new Node(60);
            Btree.Root.Left.Right.Left = new Node(20);
            Btree.Root.Left.Right.Right = new Node(35);

            Btree.ConvertToBST();

            List<int> inorderList = new List<int>();
            CollectInOrderValues(Btree.Root, inorderList);

            // Expected inorder traversal of the converted BST
            List<int> expected = new List<int> { 5, 10, 20, 30, 35, 40, 50, 60 };
            Assert.Equal(expected, inorderList);
        }

        [Fact]
        public void TestConvertToBST_SingleSidedTree()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Right = new Node(20);
            Btree.Root.Right.Right = new Node(30);
            Btree.Root.Right.Right.Right = new Node(40);

            Btree.ConvertToBST();

            List<int> inorderList = new List<int>();
            CollectInOrderValues(Btree.Root, inorderList);

            // Expected inorder traversal of the converted BST
            List<int> expected = new List<int> { 10, 20, 30, 40 };
            Assert.Equal(expected, inorderList);
        }

        private void CollectInOrderValues(Node node, List<int> values)
        {
            if (node == null)
                return;

            CollectInOrderValues(node.Left, values);
            values.Add(node.Value);
            CollectInOrderValues(node.Right, values);
        }
    }
}
