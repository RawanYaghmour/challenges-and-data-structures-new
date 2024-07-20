using Data_Structures;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------** Linked List Implementation **---------\n");

            LinkedListClass list = new LinkedListClass();

            // Adding nodes to the list
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Printing the list
            Console.WriteLine("Initial list:");
            list.PrintList(); // Output: Head -> 5 -> 10 -> 20 -> 30 -> Null

            // Removing a node
            list.Remove(10);
            Console.WriteLine("\nList after removing node with data 10:");
            list.PrintList(); // Output: Head -> 5 -> 20 -> 30 -> Null

            // Checking if a value is in the list
            bool contains20 = list.Includes(20);
            bool contains10 = list.Includes(10);
            Console.WriteLine($"\nList contains 20: {contains20}");
            Console.WriteLine($"List contains 10: {contains10}");


            Console.WriteLine("\n---------** Linked List Remove Duplicates **---------\n");
            LinkedListClass removelist = new LinkedListClass();
            list.Add(5);
            list.Add(20);
            list.Add(20);
            list.Add(10);
            list.Add(5);
            list.Add(10);

            Console.WriteLine("Initial list with duplicates:");
            list.PrintList(); // Output: Head -> 5 -> 20 -> 20 -> 10 -> 5 -> 10 -> Null

            list.RemoveDuplicate();

            Console.WriteLine("\nAfter removing duplicates:");
            list.PrintList(); // Output: Head -> 5 -> 20 -> 10 -> Null






            Console.WriteLine("\n---------** Linked List Merge Sorted Lists **---------\n");

            // Test Case 1: Both lists are empty
            LinkedListClass list1 = new LinkedListClass();
            LinkedListClass list2 = new LinkedListClass();
            Console.WriteLine("Test Case 1: Both lists are empty");
            PrintMergedList(list1, list2); // Expected Output: Head -> Null

            // Test Case 2: One list is empty
            list1 = new LinkedListClass();
            list2 = new LinkedListClass();
            list2.Add(1);
            list2.Add(3);
            list2.Add(5);
            Console.WriteLine("Test Case 2: One list is empty");
            PrintMergedList(list1, list2); // Expected Output: Head -> 1 -> 3 -> 5 -> Null

            // Test Case 3: Both lists have elements
            list1 = new LinkedListClass();
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);

            list2 = new LinkedListClass();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);
            Console.WriteLine("Test Case 3: Both lists have elements");
            PrintMergedList(list1, list2); // Expected Output: Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null

            // Test Case 4: Both lists have overlapping elements
            list1 = new LinkedListClass();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);

            list2 = new LinkedListClass();
            list2.Add(5);
            list2.Add(15);
            list2.Add(25);
            list2.Add(35);
            Console.WriteLine("Test Case 4: Both lists have overlapping elements");
            PrintMergedList(list1, list2); // Expected Output: Head -> 5 -> 10 -> 15 -> 20 -> 25 -> 30 -> 35 -> Null
        }

        private static void PrintMergedList(LinkedListClass list1, LinkedListClass list2)
        {
            LinkedListClass mergedList = LinkedListClass.MergeSortedLists(list1, list2);
            mergedList.PrintList();
        }
    }
    }

