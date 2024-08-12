using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void TestAddingNode()
        {
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.True(bst.Contains(15));
        }

        [Fact]
        public void TestContainsNode()
        {
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);

            Assert.True(bst.Contains(5));
            Assert.False(bst.Contains(15));
        }

        [Fact]
        public void TestRemovingNode()
        {
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Remove(5);

            Assert.False(bst.Contains(5));
            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(15));
        }
    }
}
