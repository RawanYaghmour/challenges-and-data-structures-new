using Stack___Queue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___Queue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle : StackClass
    {
        // DeleteMiddle method
        public void DeleteMiddle()
        {
            if (IsEmpty())
                return;

            int middleIndex = Count() / 2;
            if (Count() % 2 == 0)
                middleIndex--;

            DeleteMiddleRecursive(this, middleIndex);
        }

        private void DeleteMiddleRecursive(StackWithDeleteMiddle stack, int currentIndex)
        {
            if (currentIndex == 0)
            {
                stack.Pop();
                return;
            }

            int topElement = stack.Pop();
            DeleteMiddleRecursive(stack, currentIndex - 1);
            stack.Push(topElement);
        }

        // Method to count elements in the stack
        private int Count()
        {
            int count = 0;
            Node current = top;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public override string ToString()
        {
            Node current = top;
            string result = "Stack: Top -> ";
            while (current != null)
            {
                result += current.Data + " -> ";
                current = current.Next;
            }
            return result.TrimEnd(' ', '-', '>');
        }
    }
}
