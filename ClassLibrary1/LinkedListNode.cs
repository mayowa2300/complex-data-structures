using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexDataStructures
{
    public class LinkedListNode<T>
    {
        public T Value { get; set;}
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }
       
    }
}
