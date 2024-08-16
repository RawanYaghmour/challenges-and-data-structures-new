using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get;  set; }

        public BinaryTree(Node root = null)
        {
            Root = root;
        }

        public void PreOrder(Node node)
        {
            if (node == null) return;
            Console.Write(node.Value + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(Node node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Value + " ");
            InOrder(node.Right);
        }

        public void PostOrder(Node node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Value + " ");
        }

        public void Print()
        {
            PrintTree(Root, "", true);
        }

        private void PrintTree(Node node, string indent, bool last)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("└──");
                    indent += "   ";
                }
                else
                {
                    Console.Write("├──");
                    indent += "|  ";
                }
                Console.WriteLine(node.Value);

                PrintTree(node.Left, indent, false);
                PrintTree(node.Right, indent, true);
            }
        }



        // Method to convert the tree into its mirror
        public void MirrorTree()
        {
            MirrorTree(Root);
        }

        private void MirrorTree(Node node)
        {
            if (node == null) return;

            // Swap the left and right children
            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;

            // Recursively mirror the left and right subtrees
            MirrorTree(node.Left);
            MirrorTree(node.Right);
        }

        // Method to return inorder traversal as a list of integers
        public List<int> InorderTraversal()
        {
            return InorderTraversal(Root);
        }

        private List<int> InorderTraversal(Node node)
        {
            List<int> result = new List<int>();
            InorderTraversalHelper(node, result);
            return result;
        }

        private void InorderTraversalHelper(Node node, List<int> result)
        {
            if (node == null) return;
            InorderTraversalHelper(node.Left, result);
            result.Add(node.Value);
            InorderTraversalHelper(node.Right, result);
        }

    }
}
