using System;

namespace ComplexDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            var test = new Stack<string>();
            var test_a = new Queue<int>();
            var test_b = new LinkedList<int>();

            test_a.Enqueue(5);
            test_a.Enqueue(6);
            test_a.Enqueue(7);
            Console.WriteLine(test_a.Dequeue());
            Console.WriteLine(test_a.Dequeue());
            Console.WriteLine(test_a.Dequeue());
            Console.WriteLine(test_a.Size());


        }
    }
}

