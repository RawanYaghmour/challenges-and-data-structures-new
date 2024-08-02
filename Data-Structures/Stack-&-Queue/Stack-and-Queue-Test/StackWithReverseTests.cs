using Stack___Queue.ReverseStackUsingQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Test
{
    public class StackWithReverseTests
    {
        [Fact]
        public void ReverseStack_WithMultipleElements_ReversesOrder()
        {
            var stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(4, stack.Pop());
            Assert.Equal(5, stack.Pop());
        }

        [Fact]
        public void ReverseStack_WithSingleElement_DoesNotChangeOrder()
        {
            var stack = new StackWithReverse();
            stack.Push(1);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void ReverseStack_WithEmptyStack_DoesNotChange()
        {
            var stack = new StackWithReverse();

            stack.ReverseStack();

            Assert.True(stack.Count == 0);
        }
    }
}
