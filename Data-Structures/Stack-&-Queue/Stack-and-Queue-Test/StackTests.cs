using Stack___Queue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Test
{
    public class StackTests
    {
        [Fact]
        public void TestPush()
        {
            // Arrange
            StackClass stack = new StackClass();

            // Act
            stack.Push(10);

            // Assert
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void TestPop()
        {
            // Arrange
            StackClass stack = new StackClass();

            // Act
            stack.Push(10);
            int popped = stack.Pop();

            // Assert
            Assert.Equal(10, popped);
        }

        [Fact]
        public void TestIsEmpty()
        {
            // Arrange
            StackClass stack = new StackClass();

            // Assert
            Assert.True(stack.IsEmpty());

            // Act
            stack.Push(10);

            // Assert
            Assert.False(stack.IsEmpty());
        }
    }
}
