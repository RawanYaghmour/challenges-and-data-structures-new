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


            Console.WriteLine("\n******************** Print-Right-View ********************");

            BinaryTree RightViewPrint = new BinaryTree();
            RightViewPrint.Root = new Node(2);
            RightViewPrint.Root.Left = new Node(3);
            RightViewPrint.Root.Right = new Node(5);
            RightViewPrint.Root.Left.Left = new Node(4);
            RightViewPrint.Root.Right.Right = new Node(6);
            RightViewPrint.Root.Left.Left.Right = new Node(7);

            RightViewPrint.PrintRightView();  // Output: 2 5 6 7





            Console.WriteLine("\n******************** Max-Level-Nodes ********************");

            // Example 1
            BinaryTree MaxLevelNodes = new BinaryTree();
            MaxLevelNodes.Root = new Node(1);
            MaxLevelNodes.Root.Left = new Node(2);
            MaxLevelNodes.Root.Right = new Node(3);
            MaxLevelNodes.Root.Left.Left = new Node(4);
            MaxLevelNodes.Root.Left.Right = new Node(5);
            MaxLevelNodes.Root.Right.Right = new Node(6);
            MaxLevelNodes.Root.Left.Left.Left = new Node(7);

            Console.WriteLine("Example 1:");
            int maxLevel = MaxLevelNodes.FindMaxLevelNodes();
            Console.WriteLine("The level with the maximum number of nodes is: " + maxLevel); // Expected output: 2

            // Example 2
            BinaryTree MaxLevelNodes2 = new BinaryTree();
            MaxLevelNodes2.Root = new Node(1);
            MaxLevelNodes2.Root.Left = new Node(2);
            MaxLevelNodes2.Root.Right = new Node(3);
            MaxLevelNodes2.Root.Left.Left = new Node(4);
            MaxLevelNodes2.Root.Left.Right = new Node(5);
            MaxLevelNodes2.Root.Right.Right = new Node(7);
            MaxLevelNodes2.Root.Left.Left.Left = new Node(8);
            MaxLevelNodes2.Root.Left.Right.Left = new Node(9);
            MaxLevelNodes2.Root.Right.Right.Left = new Node(10);

            Console.WriteLine("Example 2:");
            maxLevel = MaxLevelNodes2.FindMaxLevelNodes();
            Console.WriteLine("The level with the maximum number of nodes is: " + maxLevel); // Expected output: 2

            // Test with empty tree
            BinaryTree emptyTree = new BinaryTree();
            Console.WriteLine("Test with Empty Tree:");
            maxLevel = emptyTree.FindMaxLevelNodes();
            Console.WriteLine("The level with the maximum number of nodes is: " + maxLevel); // Expected output: -1

            // Test with a single node
            BinaryTree singleNodeTree = new BinaryTree();
            singleNodeTree.Root = new Node(1);
            Console.WriteLine("Test with Single Node Tree:");
            maxLevel = singleNodeTree.FindMaxLevelNodes();
            Console.WriteLine("The level with the maximum number of nodes is: " + maxLevel); // Expected output: 0





            Console.WriteLine("\n******************** Minimum-Depth ********************");


            BinaryTree MinimumDepth = new BinaryTree();
            MinimumDepth.Root = new Node(1);
            MinimumDepth.Root.Left = new Node(2);
            MinimumDepth.Root.Right = new Node(3);
            MinimumDepth.Root.Left.Left = new Node(4);
            MinimumDepth.Root.Left.Right = new Node(5);

            int minDepth = MinimumDepth.FindMinimumDepth();
            Console.WriteLine("Example 1: Minimum Depth = " + minDepth); // Expected output: 2

            // Example 2
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(1);
            Btree2.Root.Left = new Node(2);
            Btree2.Root.Right = new Node(3);
            Btree2.Root.Left.Right = new Node(5);
            Btree2.Root.Right.Right = new Node(6);

            minDepth = Btree2.FindMinimumDepth();
            Console.WriteLine("Example 2: Minimum Depth = " + minDepth); // Expected output: 3

            // Test with empty tree
            BinaryTree MinimumDepth2 = new BinaryTree();
            minDepth = MinimumDepth2.FindMinimumDepth();
            Console.WriteLine("Test with Empty Tree: Minimum Depth = " + minDepth); // Expected output: 0


        }

    }
}
