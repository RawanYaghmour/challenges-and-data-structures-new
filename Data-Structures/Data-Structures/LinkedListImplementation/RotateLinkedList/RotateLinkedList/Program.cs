using System.Collections.Generic;

namespace RotateLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new LinkedList instance
            RotateLinkedList list = new RotateLinkedList();

            // Append nodes to the list
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);
            list.Append(6);

            // Display the original list
            Console.WriteLine("Original List:");
            list.Display();

            // Rotate the list by k = 2
            Console.WriteLine("\nRotating by k = 2:");
            list.RotateLeft(2);
            list.Display();

            // Rotate the list by k = 4
            Console.WriteLine("\nRotating by k = 4:");
            list.RotateLeft(4);
            list.Display();

            // Rotate the list by k = 0 (no rotation)
            Console.WriteLine("\nRotating by k = 0 (no change):");
            list.RotateLeft(0);
            list.Display();

            // Rotate the list by k = 7 (greater than the length)
            Console.WriteLine("\nRotating by k = 7 (greater than list length):");
            list.RotateLeft(7);
            list.Display();
        }
    }
}
