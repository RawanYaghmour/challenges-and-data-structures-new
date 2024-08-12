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
        }
    }
}
