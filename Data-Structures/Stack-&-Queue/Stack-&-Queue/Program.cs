using Stack___Queue.Queue;
using Stack___Queue.Stack;

namespace Stack___Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Stack example
            Console.WriteLine("\n************** Stack Test **************\n");

            StackClass stack = new StackClass();

            // Push nodes onto the stack
            stack.Push(10); // Stack: Top -> 10
            stack.Push(5);  // Stack: Top -> 5 -> 10

            Console.WriteLine("Stack after pushing 10 and 5:");
            stack.PrintStack();

            // Pop a node from the stack
            int popped = stack.Pop(); // popped: 5
            Console.WriteLine($"Popped: {popped}");

            Console.WriteLine("Stack after popping:");
            stack.PrintStack();

            // Peek the top node
            int peeked = stack.Peek(); // peeked: 10
            Console.WriteLine($"Peeked: {peeked}");

            // Check if the stack is empty
            bool isEmpty = stack.IsEmpty(); // isEmpty: false
            Console.WriteLine($"Is stack empty: {isEmpty}");





            // Queue example
            Console.WriteLine("\n************** Queue Test **************\n");

            QueueClass queue = new QueueClass();

            // Enqueue nodes into the queue
            queue.Enqueue(10); // Queue: 10
            queue.Enqueue(5);  // Queue: 10 -> 5

            Console.WriteLine("Queue after enqueuing 10 and 5:");
            queue.PrintQueue();

            // Dequeue a node from the queue
            int dequeued = queue.Dequeue(); // dequeued: 10
            Console.WriteLine($"Dequeued: {dequeued}");

            Console.WriteLine("Queue after dequeuing:");
            queue.PrintQueue();

            // Peek the front node
            Console.WriteLine($"Peeked: {queue.Peek()}");

            // Check if the queue is empty
            Console.WriteLine($"Is queue empty: {queue.IsEmpty()}");



            
        }
    }
}
