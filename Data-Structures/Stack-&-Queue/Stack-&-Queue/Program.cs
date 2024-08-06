using Stack___Queue.DeleteMiddleElement;
using Stack___Queue.Queue;
using Stack___Queue.ReverseStackUsingQueue;
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


            Console.WriteLine("\n************** Reverse Stack Test **************\n");

            StackWithReverse reverseStack = new StackWithReverse();

            // Push nodes onto the stack
            reverseStack.Push(1); // Stack: Top -> 1
            reverseStack.Push(2); // Stack: Top -> 2 -> 1
            reverseStack.Push(3); // Stack: Top -> 3 -> 2 -> 1
            reverseStack.Push(4); // Stack: Top -> 4 -> 3 -> 2 -> 1
            reverseStack.Push(5); // Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1

            Console.WriteLine("Stack before reversing:");
            Console.WriteLine(reverseStack);

            // Reverse the stack
            reverseStack.ReverseStack();

            Console.WriteLine("Stack after reversing:");
            Console.WriteLine(reverseStack);

            // Add more elements
            reverseStack.Push(6); // Stack: Top -> 6 -> 5 -> 4 -> 3 -> 2 -> 1
            reverseStack.Push(7); // Stack: Top -> 7 -> 6 -> 5 -> 4 -> 3 -> 2 -> 1

            Console.WriteLine("Stack after pushing 6 and 7:");
            Console.WriteLine(reverseStack);

            // Reverse the stack again
            reverseStack.ReverseStack();

            Console.WriteLine("Stack after reversing again:");
            Console.WriteLine(reverseStack);




            Console.WriteLine("\n************** Delete Middle Element of Stack Test **************\n");

            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();

            stackWithDeleteMiddle.Push(7);
            stackWithDeleteMiddle.Push(14);
            stackWithDeleteMiddle.Push(3);
            stackWithDeleteMiddle.Push(8);
            stackWithDeleteMiddle.Push(5);

            Console.WriteLine("Stack before deleting middle:");
            Console.WriteLine(stackWithDeleteMiddle);

            stackWithDeleteMiddle.DeleteMiddle();

            Console.WriteLine("Stack after deleting middle:");
            Console.WriteLine(stackWithDeleteMiddle);

            stackWithDeleteMiddle.Push(2);
            stackWithDeleteMiddle.Push(9);
            stackWithDeleteMiddle.Push(11);

            Console.WriteLine("Stack after pushing 2, 9, and 11:");
            Console.WriteLine(stackWithDeleteMiddle);

            stackWithDeleteMiddle.DeleteMiddle();

            Console.WriteLine("Stack after deleting middle again:");
            Console.WriteLine(stackWithDeleteMiddle);
        }
    }
}
