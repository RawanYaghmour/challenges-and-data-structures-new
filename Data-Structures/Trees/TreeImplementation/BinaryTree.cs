﻿using System;
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



        // Method to find the second maximum value in the tree
        public int? FindSecondMax()
        {
            if (Root == null)
                throw new InvalidOperationException("The tree is empty.");

            int max = FindMax(Root);
            return FindSecondMax(Root, max, int.MinValue);
        }

        private int FindMax(Node node)
        {
            if (node == null)
                return int.MinValue;

            int max = node.Value;
            int leftMax = FindMax(node.Left);
            int rightMax = FindMax(node.Right);

            if (leftMax > max)
                max = leftMax;
            if (rightMax > max)
                max = rightMax;

            return max;
        }

        private int? FindSecondMax(Node node, int max, int secondMax)
        {
            if (node == null)
                return secondMax == int.MinValue ? null : (int?)secondMax;

            if (node.Value < max && node.Value > secondMax)
                secondMax = node.Value;

            secondMax = FindSecondMax(node.Left, max, secondMax) ?? secondMax;
            secondMax = FindSecondMax(node.Right, max, secondMax) ?? secondMax;

            return secondMax == int.MinValue ? null : (int?)secondMax;
        }



        // Method to calculate the sum of all leaf nodes
        public int SumOfLeafNodes()
        {
            return SumOfLeafNodes(Root);
        }

        private int SumOfLeafNodes(Node node)
        {
            if (node == null)
                return 0;

            // Check if the node is a leaf node
            if (node.Left == null && node.Right == null)
                return node.Value;

            // Recursively calculate the sum of leaf nodes in both subtrees
            int leftSum = SumOfLeafNodes(node.Left);
            int rightSum = SumOfLeafNodes(node.Right);

            return leftSum + rightSum;
        }




        // Method to calculate Largest Level Value
        public List<int> LargestLevelValue()
        {
            List<int> result = new List<int>();
            if (Root == null) return result;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxLevelValue = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();
                    if (currentNode.Value > maxLevelValue)
                    {
                        maxLevelValue = currentNode.Value;
                    }

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                result.Add(maxLevelValue);
            }

            return result;
        }




        // Method to print the right view of the binary tree
        public void PrintRightView()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            // Use a queue for level order traversal
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                Node rightMostNode = null;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();

                    // The rightmost node will be the last node we encounter at each level
                    rightMostNode = currentNode;

                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }

                // Print the rightmost node of the current level
                Console.Write(rightMostNode.Value + " ");
            }
            Console.WriteLine();
        }




        //Find-Max-Level-Nodes
        public int FindMaxLevelNodes()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return -1; // Indicate empty tree
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);
            int level = 0;
            int maxNodes = 0;
            int maxLevel = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;  // Number of nodes at the current level

                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = level;
                }

                for (int i = 0; i < levelSize; i++)
                {
                    Node current = queue.Dequeue();

                    if (current.Left != null)
                        queue.Enqueue(current.Left);
                    if (current.Right != null)
                        queue.Enqueue(current.Right);
                }

                level++;
            }

            return maxLevel;
        }






        // Method to find the minimum depth of the binary tree
        public int FindMinimumDepth()
        {
            if (Root == null)
            {
                return 0; // The minimum depth of an empty tree is 0
            }

            return FindMinDepth(Root);
        }

        private int FindMinDepth(Node node)
        {
            // If the node is null, return 0
            if (node == null)
            {
                return 0;
            }

            // If the node is a leaf, return 1
            if (node.Left == null && node.Right == null)
            {
                return 1;
            }

            // If the left subtree is null, recursively find the min depth of the right subtree
            if (node.Left == null)
            {
                return FindMinDepth(node.Right) + 1;
            }

            // If the right subtree is null, recursively find the min depth of the left subtree
            if (node.Right == null)
            {
                return FindMinDepth(node.Left) + 1;
            }

            // If both subtrees are non-null, find the minimum depth of both subtrees
            return Math.Min(FindMinDepth(node.Left), FindMinDepth(node.Right)) + 1;
        }




        // Method to convert the BTree-to-BST
        public void ConvertToBST()
        {
            // Step 1: Collect values using inorder traversal
            List<int> values = new List<int>();
            InOrderCollectValues(Root, values);

            // Step 2: Sort the collected values
            values.Sort();

            // Step 3: Replace values in the tree with sorted values
            int[] index = { 0 }; // Array to track index by reference
            InOrderAssignValues(Root, values, index);
        }

        // Helper method to perform inorder traversal and collect node values
        private void InOrderCollectValues(Node node, List<int> values)
        {
            if (node == null)
                return;

            InOrderCollectValues(node.Left, values);
            values.Add(node.Value);
            InOrderCollectValues(node.Right, values);
        }

        // Helper method to perform inorder traversal and assign sorted values to nodes
        private void InOrderAssignValues(Node node, List<int> values, int[] index)
        {
            if (node == null)
                return;

            InOrderAssignValues(node.Left, values, index);
            node.Value = values[index[0]++];
            InOrderAssignValues(node.Right, values, index);
        }

        // Print the tree in inorder to display it
        public void PrintInOrder()
        {
            InOrderPrint(Root);
            Console.WriteLine();
        }

        private void InOrderPrint(Node node)
        {
            if (node == null)
                return;

            InOrderPrint(node.Left);
            Console.Write(node.Value + " ");
            InOrderPrint(node.Right);
        }

    }
}
