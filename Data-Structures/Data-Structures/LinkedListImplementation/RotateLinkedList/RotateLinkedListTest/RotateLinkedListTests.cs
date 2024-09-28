using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using RotateLinkedList;

namespace RotateLinkedListTest
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void Test_RotateLeft_By_Zero()
        {
            // Arrange
            RotateLinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);

            // Act
            list.RotateLeft(0);

            // Assert
            Assert.Equal("1 -> 2 -> 3 -> 4 -> Null", CaptureOutput(list));
        }

        [Fact]
        public void Test_RotateLeft_By_Greater_Than_Length()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);

            // Act
            list.RotateLeft(7); // k > length

            // Assert
            Assert.Equal("4 -> 1 -> 2 -> 3 -> Null", CaptureOutput(list));
        }

        [Fact]
        public void Test_RotateLeft_By_Valid_K()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);

            // Act
            list.RotateLeft(2);

            // Assert
            Assert.Equal("3 -> 4 -> 1 -> 2 -> Null", CaptureOutput(list));
        }

        // Helper method to capture the output of Display method
        private string CaptureOutput(LinkedList list)
        {
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                list.Display();
                return sw.ToString().Trim();
            }
        }
    }
}
