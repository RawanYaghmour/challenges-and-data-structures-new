using Stack___Queue.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Test
{
    public class QueueTests
    {
        [Fact]
        public void TestEnqueue()
        {
            // Arrange
            QueueClass queue = new QueueClass();

            // Act
            queue.Enqueue(10);

            // Assert
            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void TestDequeue()
        {
            // Arrange
            QueueClass queue = new QueueClass();

            // Act
            queue.Enqueue(10);
            int dequeued = queue.Dequeue();

            // Assert
            Assert.Equal(10, dequeued);
        }

        [Fact]
        public void TestIsEmpty()
        {
            // Arrange
            QueueClass queue = new QueueClass();

            // Assert
            Assert.True(queue.IsEmpty());

            // Act
            queue.Enqueue(10);

            // Assert
            Assert.False(queue.IsEmpty());
        }
    }
}
