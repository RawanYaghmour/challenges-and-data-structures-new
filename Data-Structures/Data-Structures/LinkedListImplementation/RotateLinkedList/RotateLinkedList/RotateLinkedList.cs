using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLinkedList
{
    public class RotateLinkedList
    {
        public Node Head;

        public RotateLinkedList()
        {
            Head = null;
        }

        // Method to append a node to the end
        public void Append(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(data);
        }

        // Rotate left by k positions
        public void RotateLeft(int k)
        {
            if (Head == null || Head.Next == null || k == 0)
                return;

            // Calculate the length of the list
            Node current = Head;
            int length = 1;
            while (current.Next != null)
            {
                current = current.Next;
                length++;
            }

            // Normalize k
            k = k % length;
            if (k == 0)
                return;

            // Connect the end of the list to the head to form a circular list
            current.Next = Head;

            // Find the new head after rotation
            for (int i = 0; i < length - k; i++)
            {
                current = current.Next;
            }

            // Break the circular list
            Head = current.Next;
            current.Next = null;
        }

        // Method to display the linked list
        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
    }

}


