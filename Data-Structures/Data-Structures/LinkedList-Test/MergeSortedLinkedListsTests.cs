using Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Test
{
    public class MergeSortedLinkedListsTests
    {
        [Fact]
        public void MergeSortedLists_OneListEmpty_ReturnsOtherList()
        {
            // Arrange
            LinkedListClass list1 = new LinkedListClass();
            LinkedListClass list2 = new LinkedListClass();
            list2.Add(1);
            list2.Add(3);
            list2.Add(5);

            // Act
            LinkedListClass mergedList = LinkedListClass.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> 1 -> 3 -> 5 -> Null", GetListString(mergedList));
        }

        [Fact]
        public void MergeSortedLists_BothListsEmpty_ReturnsEmptyList()
        {
            // Arrange
            LinkedListClass list1 = new LinkedListClass();
            LinkedListClass list2 = new LinkedListClass();

            // Act
            LinkedListClass mergedList = LinkedListClass.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> Null", GetListString(mergedList));
        }

        [Fact]
        public void MergeSortedLists_ExampleTestCase_ReturnsMergedList()
        {
            // Arrange
            LinkedListClass list1 = new LinkedListClass();
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);

            LinkedListClass list2 = new LinkedListClass();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);

            // Act
            LinkedListClass mergedList = LinkedListClass.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", GetListString(mergedList));
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
