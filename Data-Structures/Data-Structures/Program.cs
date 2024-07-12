using Data_Structures;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
