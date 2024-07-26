using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___Queue.Queue
{
    public class QueueClass
    {
        private Node front;
        private Node rear;

        public QueueClass()
        {
            front = null;
            rear = null;
        }

        // Enqueue method
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear != null)
            {
                rear.Next = newNode;
            }
            rear = newNode;
            if (IsEmpty())
            {
                front = newNode;
            }
        }

        // Dequeue method
        public int Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");
            int data = front.Data;
            front = front.Next;
            if (IsEmpty())
            {
                rear = null;
            }
            return data;
        }

        // Peek method
        public int Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");
            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        // Print method
        public void PrintQueue()
        {
            Node current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
