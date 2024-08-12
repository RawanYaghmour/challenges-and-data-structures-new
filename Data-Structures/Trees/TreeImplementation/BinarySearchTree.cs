using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTree
    {
        public Node Root { get;  set; }

        public void Add(int data)
        {
            Root = AddRecursively(Root, data);
        }

        private Node AddRecursively(Node node, int data)
        {
            if (node == null)
                return new Node(data);

            if (data < node.Value)
                node.Left = AddRecursively(node.Left, data);
            else if (data > node.Value)
                node.Right = AddRecursively(node.Right, data);

            return node;
        }

        public bool Contains(int value)
        {
            Node current = Root;
            while (current != null)
            {
                if (current.Value == value)
                    return true;
                else if (value < current.Value)
                    current = current.Left;
                else
                    current = current.Right;
            }
            return false;
        }

        public void Remove(int data)
        {
            Root = RemoveRecursively(Root, data);
        }

        private Node RemoveRecursively(Node node, int data)
        {
            if (node == null)
                return node;

            if (data < node.Value)
                node.Left = RemoveRecursively(node.Left, data);
            else if (data > node.Value)
                node.Right = RemoveRecursively(node.Right, data);
            else
            {
                // Node with only one child or no child
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                // Node with two children: Get the inorder successor (smallest in the right subtree)
                node.Value = MinValue(node.Right);

                // Delete the inorder successor
                node.Right = RemoveRecursively(node.Right, node.Value);
            }
            return node;
        }

        private int MinValue(Node node)
        {
            int minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }
    }
}
