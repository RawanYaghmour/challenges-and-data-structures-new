using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___Queue.ReverseStackUsingQueue
{
    public class StackWithReverse : Stack<int>
    {
        public void ReverseStack()
        {
            Queue<int> queue = new Queue<int>();

            // Enqueue all elements from stack
            while (this.Count > 0)
            {
                queue.Enqueue(this.Pop());
            }

            // Dequeue from queue and push back to stack
            while (queue.Count > 0)
            {
                this.Push(queue.Dequeue());
            }
        }

        public override string ToString()
        {
            var stackArray = this.ToArray();
            return "Stack: Top -> " + string.Join(" -> ", stackArray);
        }
    }
}
