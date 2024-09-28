using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class RightViewTest
    {
        [Fact]
        public void Test_PrintRightView_WithExampleTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);

            // Act and Assert (Capture Console output)
            using (var consoleOutput = new ConsoleOutput())
            {
                Btree.PrintRightView();
                string expectedOutput = "2 5 6 7 \n";
                Assert.Equal(expectedOutput, consoleOutput.GetOutput());
            }
        }

        [Fact]
        public void Test_PrintRightView_WithOnlyRightNodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Right = new Node(2);
            Btree.Root.Right.Right = new Node(3);
            Btree.Root.Right.Right.Right = new Node(4);

            // Act and Assert (Capture Console output)
            using (var consoleOutput = new ConsoleOutput())
            {
                Btree.PrintRightView();
                string expectedOutput = "1 2 3 4 \n";
                Assert.Equal(expectedOutput, consoleOutput.GetOutput());
            }
        }

        [Fact]
        public void Test_PrintRightView_WithEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act and Assert (Capture Console output)
            using (var consoleOutput = new ConsoleOutput())
            {
                Btree.PrintRightView();
                string expectedOutput = "Tree is empty.\n";
                Assert.Equal(expectedOutput, consoleOutput.GetOutput());
            }
        }
    }

    // Helper class to capture Console Output for testing
    public class ConsoleOutput : IDisposable
    {
        private readonly System.IO.StringWriter _stringWriter;
        private readonly System.IO.TextWriter _originalOutput;

        public ConsoleOutput()
        {
            _stringWriter = new System.IO.StringWriter();
            _originalOutput = Console.Out;
            Console.SetOut(_stringWriter);
        }

        public string GetOutput()
        {
            return _stringWriter.ToString().Replace("\r\n", "\n");  // Normalize line endings for testing
        }

        public void Dispose()
        {
            Console.SetOut(_originalOutput);
            _stringWriter.Dispose();
        }
    }
}
