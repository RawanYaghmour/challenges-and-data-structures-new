using System;
using Xunit;
using LinkedList;
using Data_Structures;

namespace LinkedListTests
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void RemoveDuplicates_NoDuplicates_RemainsUnchanged()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            list.RemoveDuplicate();

            // Assert
            Assert.Equal("Head -> 1 -> 2 -> 3 -> Null", GetListString(list));
        }

        [Fact]
        public void RemoveDuplicates_WithDuplicates_RemovesDuplicates()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(3);

            // Act
            list.RemoveDuplicate();

            // Assert
            Assert.Equal("Head -> 1 -> 2 -> 3 -> Null", GetListString(list));
        }

        private string GetListString(LinkedListClass list)
        {
            Node current = list.Head;
            string result = "Head -> ";
            while (current != null)
            {
                result += current.Data + " -> ";
                current = current.Next;
            }
            result += "Null";
            return result;
        }
    }
}