using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ComplexDataStructures
{
    public class Queue<T>: IEnumerable<T>
    {
        private int Count { get; set; }
        private LinkedListNode<T> Head { get; set; }
        private LinkedListNode<T> Tail { get; set; }
        
        // check if queue is empty

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public int Size()
        {
            return Count;
        }

        // adds a new item to the end of a queue

        public void Enqueue(T item)
        {
            var newNode = new LinkedListNode<T>(item);

            // if head is null then the queue must be empty
            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
            }
            else
            {
                Tail.Next = newNode; // sets the newNode to the previous node Next pointer
                Tail = newNode;      // sets tail as new node;
            }
            Count++;
        }

        // removes an item from the top of a queue

        public T Dequeue()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Queue is Empty");
            }
            else
            {
            LinkedListNode<T> headToReturn = Head;
            if (Head.Next == null) // check if Head is the only item
            {
                Tail = null; // set Tail to null
            }
            Head = Head.Next;
            Count--;
            return headToReturn.Value;

            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
