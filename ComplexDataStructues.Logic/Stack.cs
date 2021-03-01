using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ComplexDataStructures
{
    public class Stack<T> :IEnumerable<T>
    {
        private int Count { get; set; }

        public LinkedListNode<T> Head { get; set; }

        public bool IsEmpty()
        {
            return Count == 0;
        }
        // adds an item to the top of the stack
        public void Push(T item)
        {
            var newNode = new LinkedListNode<T>(item);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                LinkedListNode<T> temp = Head;
                Head = newNode;
                Head.Next = temp;
            }

            Count++;
        }
        // removes an item from the top of the stack

        public T Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {

            LinkedListNode<T> headToReturn = Head;
            Head = Head.Next;
            Count--;
            return headToReturn.Value;

            }
        }
        // returns the item to be dequeued

        public T Peek()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {
              return Head.Value;
            }
        }
        // returns the number of elements in a stack
        public int Size()
        {
            return Count;
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
        // allows iteration over the stack
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
