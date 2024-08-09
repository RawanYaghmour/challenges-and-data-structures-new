using Stack___Queue.MinStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Test
{
    public class MinStackTest
    {
        [Fact]
        public void TestPushAndMin()
        {
            // Arrange
            var minStack = new MinStackClass();

            // Act & Assert
            minStack.Push(15);

            // Assert
            Assert.Equal(15, minStack.GetMin());

            // Act
            minStack.Push(7);

            // Assert
            Assert.Equal(7, minStack.GetMin());

            // Act
            minStack.Push(12);

            // Assert
            Assert.Equal(7, minStack.GetMin());

            // Act
            minStack.Push(3);

            // Assert
            Assert.Equal(3, minStack.GetMin());
        }

        [Fact]
        public void TestPopAndMin()
        {
            // Arrange
            var minStack = new MinStackClass();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);

            // Act & Assert
            // Act
            int poppedValue1 = minStack.Pop();

            // Assert
            Assert.Equal(3, poppedValue1);
            Assert.Equal(7, minStack.GetMin());

            // Act
            int poppedValue2 = minStack.Pop();

            // Assert
            Assert.Equal(12, poppedValue2);
            Assert.Equal(7, minStack.GetMin());
        }

        [Fact]
        public void TestTopAndIsEmpty()
        {
            // Arrange
            var minStack = new MinStackClass();
            minStack.Push(15);
            minStack.Push(7);

            // Act & Assert
            // Act
            int topValue = minStack.Top();

            // Assert
            Assert.Equal(7, topValue);

            // Act & Assert
            // Act
            bool isEmptyBeforePop = minStack.IsEmpty();

            // Assert
            Assert.False(isEmptyBeforePop);

            // Act
            minStack.Pop();
            minStack.Pop();

            // Act & Assert
            // Act
            bool isEmptyAfterPop = minStack.IsEmpty();

            // Assert
            Assert.True(isEmptyAfterPop);
        }
    }
}
