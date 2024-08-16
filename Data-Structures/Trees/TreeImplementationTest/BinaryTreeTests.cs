using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinaryTreeTests
    {
        [Fact]
        public void TestMirrorTree()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(4);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(12);
            Btree.Root.Left.Right = new Node(9);

            // Original inorder
            List<int> originalInorder = Btree.InorderTraversal();
            Assert.Equal(new List<int> { 12, 8, 9, 4, 7 }, originalInorder);

            // Convert to mirror
            Btree.MirrorTree();

            // Mirrored inorder
            List<int> mirroredInorder = Btree.InorderTraversal();
            Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
        }

        [Fact]
        public void TestMirrorSingleTree()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);

            // Original inorder
            List<int> originalInorder = Btree.InorderTraversal();
            Assert.Equal(new List<int> { 1 }, originalInorder);

            // Convert to mirror
            Btree.MirrorTree();

            // Mirrored inorder
            List<int> mirroredInorder = Btree.InorderTraversal();
            Assert.Equal(new List<int> { 1 }, mirroredInorder);
        }

        [Fact]
        public void TestMirrorEmptyTree()
        {
            BinaryTree Btree = new BinaryTree();

            // Original inorder
            List<int> originalInorder = Btree.InorderTraversal();
            Assert.Empty(originalInorder);

            // Convert to mirror
            Btree.MirrorTree();

            // Mirrored inorder
            List<int> mirroredInorder = Btree.InorderTraversal();
            Assert.Empty(mirroredInorder);
        }


        [Fact]
        public void TestPreOrderTraversal()
        {
            var root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            var tree = new BinaryTree(root);

            var output = new List<int>();
            CaptureConsoleOutput(() => tree.PreOrder(root), output);

            Assert.Equal(new List<int> { 1, 2, 3 }, output);
        }

        [Fact]
        public void TestInOrderTraversal()
        {
            var root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            var tree = new BinaryTree(root);

            var output = new List<int>();
            CaptureConsoleOutput(() => tree.InOrder(root), output);

            Assert.Equal(new List<int> { 2, 1, 3 }, output);
        }

        [Fact]
        public void TestPostOrderTraversal()
        {
            var root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            var tree = new BinaryTree(root);

            var output = new List<int>();
            CaptureConsoleOutput(() => tree.PostOrder(root), output);

            Assert.Equal(new List<int> { 2, 3, 1 }, output);
        }

        private void CaptureConsoleOutput(Action action, List<int> output)
        {
            var originalConsoleOut = Console.Out;
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                action();
                writer.Flush();
                output.AddRange(writer.ToString().Trim().Split().Select(int.Parse));
                Console.SetOut(originalConsoleOut);
            }
        }
    }

}