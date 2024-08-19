using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class SecondMaxValue
    {
        [Fact]
        public void TestFindSecondMax_TreeWithDistinctValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(new Node(10));
            Btree.Root.Left = new Node(5);
            Btree.Root.Right = new Node(20);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(15);
            Btree.Root.Right.Right = new Node(25);

            // Act
            int? secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Equal(20, secondMax);
        }

        [Fact]
        public void TestFindSecondMax_TreeWithSingleValue()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(new Node(10));

            // Act
            int? secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Null(secondMax);
        }

        [Fact]
        public void TestFindSecondMax_EmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }

        [Fact]
        public void TestFindSecondMax_TreeWithNegativeValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(new Node(-10));
            Btree.Root.Left = new Node(-20);
            Btree.Root.Right = new Node(-5);

            // Act
            int? secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Equal(-10, secondMax);
        }
    }
}
