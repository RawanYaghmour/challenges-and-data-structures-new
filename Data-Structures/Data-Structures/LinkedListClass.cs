using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class LinkedListClass
    {
        public Node Head { get; private set; }

        public LinkedListClass()
        {
            Head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool Includes(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Remove(int data)
        {
            if (Head == null)
            {
                return;
            }

            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public void PrintList()
        {
            Node current = Head;
            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
        public void RemoveDuplicate()
        {
            Node current = Head;

            while (current != null)
            {
                Node duplicates = current;
                while (duplicates.Next != null)
                {
                    if (duplicates.Next.Data == current.Data)
                    {
                        duplicates.Next = duplicates.Next.Next;
                    }
                    else
                    {
                        duplicates = duplicates.Next;
                    }
                }
                current = current.Next;
            }
        }

        public static LinkedListClass MergeSortedLists(LinkedListClass list1, LinkedListClass list2)
        {
            LinkedListClass mergedList = new LinkedListClass();

            Node current1 = list1.Head;
            Node current2 = list2.Head;

            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)
                {
                    mergedList.Add(current1.Data);
                    current1 = current1.Next;
                }
                else
                {
                    mergedList.Add(current2.Data);
                    current2 = current2.Next;
                }
            }

            while (current1 != null)
            {
                mergedList.Add(current1.Data);
                current1 = current1.Next;
            }

            while (current2 != null)
            {
                mergedList.Add(current2.Data);
                current2 = current2.Next;
            }

            return mergedList;
        }
    }
}
