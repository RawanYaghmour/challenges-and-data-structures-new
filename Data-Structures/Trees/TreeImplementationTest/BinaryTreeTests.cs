using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinaryTreeTests
    {
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