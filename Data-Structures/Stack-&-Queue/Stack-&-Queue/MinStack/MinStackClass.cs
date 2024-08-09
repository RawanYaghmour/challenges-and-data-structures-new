using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___Queue.MinStack
{
    public class MinStackClass
    {
        private Stack<int> stack;
        private Stack<int> minStack;

        public MinStackClass()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int data)
        {
            stack.Push(data);

            if (minStack.Count == 0 || data <= minStack.Peek())
            {
                minStack.Push(data);
            }
        }

        public int Pop()
        {
            if (stack.Count == 0) throw new InvalidOperationException("Stack is empty");

            int top = stack.Pop();
            if (top == minStack.Peek())
            {
                minStack.Pop();
            }

            return top;
        }

        public int Top()
        {
            if (stack.Count == 0) throw new InvalidOperationException("Stack is empty");

            return stack.Peek();
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public int GetMin()
        {
            if (minStack.Count == 0) throw new InvalidOperationException("Stack is empty");

            return minStack.Peek();
        }

        public void PrintStack()
        {
            Console.Write("Top -> ");
            foreach (var item in stack)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
        }
    }
}
