using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexDataStructures
{
    class LinkedListNode<T>
    {
     public LinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; }
        public LinkedListNode<T> Next { get; set; }
    }
}
