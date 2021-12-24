using System;
using System.Collections;

namespace CsharpCodeSample
{
    class QueueExample
    {
        public QueueExample()
        {
            Queue q = new Queue();
            q.Enqueue("One");
            q.Enqueue("Two");
            q.Enqueue("Three");
            q.Enqueue("Four");
            q.Enqueue("Five");

            q.Dequeue();

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
