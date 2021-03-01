using System;
using System.Collections.Generic;

namespace ComplexDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            var test = new Stack<int>();
            var test_a = new Queue<int>();
            var test_b = new LinkedList<int>();
            //fifo
           /* test_a.Enqueue(5);
            test_a.Enqueue(6);
            test_a.Enqueue(7);
            Console.WriteLine(test_a.Dequeue());
            Console.WriteLine(test_a.Dequeue());
            Console.WriteLine(test_a.Dequeue());
            Console.WriteLine(test_a.Size());
            Console.WriteLine(test_a.IsEmpty());*/

            Console.WriteLine(test_b.Add(1));
            Console.WriteLine(test_b.Add(2));
            Console.WriteLine(test_b.Remove(1));
            Console.WriteLine(test_b.Check(1));
            Console.WriteLine(test_b.Index(1));

            //lifo
           /* test.Push(1);
            test.Push(2);
            test.Push(3);
            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Peek());
            Console.WriteLine(test.IsEmpty());
            Console.WriteLine(test.Size());*/

        }
    }
}

