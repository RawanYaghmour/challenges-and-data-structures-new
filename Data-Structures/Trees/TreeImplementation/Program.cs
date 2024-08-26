namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            // Add nodes to the BST
            bst.Add(4); bst.Add(10);
            bst.Add(15);
            bst.Add(7);
            bst.Add(5);

            // Check if a node exists
            bool contains ;
            Console.WriteLine("BST Contains 7 : " + bst.Contains(7)); // true

            // Remove a node
            bst.Remove(5);

            // Check if the node is removed
            Console.WriteLine("BST Contains 5: " + bst.Contains(5));// false

            // Print tree
            BinaryTree binaryTree = new BinaryTree(bst.Root);
            binaryTree.Print();

            // Traversals
            Console.WriteLine("\nInOrder:");
            binaryTree.InOrder(bst.Root);
            Console.WriteLine();

            Console.WriteLine("\nPreOrder:");
            binaryTree.PreOrder(bst.Root);
            Console.WriteLine();

            Console.WriteLine("\nPostOrder:");
            binaryTree.PostOrder(bst.Root);
            Console.WriteLine();



            Console.WriteLine("\n******************** Mirror Tree ********************");

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(4);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(12);
            Btree.Root.Left.Right = new Node(9);

            // Original inorder traversal
            List<int> originalInorder = Btree.InorderTraversal();
            Console.WriteLine("Original Inorder: " + string.Join(", ", originalInorder));
            // Output: [12, 8, 9, 4, 7]

            // Convert to mirror
            Btree.MirrorTree();

            // Inorder traversal of the mirrored tree
            List<int> mirroredInorder = Btree.InorderTraversal();
            Console.WriteLine("Mirrored Inorder: " + string.Join(", ", mirroredInorder));
            // Output: [7, 4, 9, 8, 12]


            Console.WriteLine("\n******************** Second Maximum Value ********************");

            BinaryTree SecondMaxValue = new BinaryTree(new Node(10));
            SecondMaxValue.Root.Left = new Node(5);
            SecondMaxValue.Root.Right = new Node(20);
            SecondMaxValue.Root.Left.Left = new Node(3);
            SecondMaxValue.Root.Left.Right = new Node(7);
            SecondMaxValue.Root.Right.Left = new Node(15);
            SecondMaxValue.Root.Right.Right = new Node(25);

            int? secondMax = SecondMaxValue.FindSecondMax();

            if (secondMax.HasValue)
            {
                Console.WriteLine("The second maximum value is: " + secondMax.Value);
            }
            else
            {
                Console.WriteLine("There is no second maximum value.");
            }

            // Expected Output: The second maximum value is: 20




            Console.WriteLine("\n******************** Leaf Sum ********************");

            BinaryTree LeafSum = new BinaryTree();
            LeafSum.Root = new Node(9);
            LeafSum.Root.Left = new Node(8);
            LeafSum.Root.Right = new Node(12);
            LeafSum.Root.Left.Left = new Node(3);
            LeafSum.Root.Left.Right = new Node(7);
            LeafSum.Root.Right.Left = new Node(17);
            LeafSum.Root.Right.Right = new Node(23);
            LeafSum.Root.Left.Left.Right = new Node(4);

            int leafSum2 = LeafSum.SumOfLeafNodes();

            Console.WriteLine("Sum of all leaf nodes: " + leafSum2);




            Console.WriteLine("\n******************** Largest-Level-Value ********************");

            BinaryTree Largest = new BinaryTree();
            Largest.Root = new Node(5);
            Largest.Root.Left = new Node(13);
            Largest .Root.Right = new Node(7);
            Largest.Root.Left.Left = new Node(3);
            Largest.Root.Left.Right = new Node(7);
            Largest.Root.Right.Left = new Node(12);
            Largest.Root.Right.Right = new Node(20);
            Largest.Root.Left.Left.Left = new Node(1);
            Largest.Root.Left.Left.Right = new Node(4);
            Largest.Root.Right.Left.Right = new Node(11);

            List<int> largestValues = Largest.LargestLevelValue(); // Output: [5, 13, 20, 11]
            foreach (var value in largestValues)
            {
                Console.WriteLine(value);
            }
        }

    }
}
