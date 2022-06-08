using System;
using System.Collections.Generic;

namespace _2164
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Queue<int> q = new Queue<int>();
            for (int i = 1; i < N + 1; i++)
                q.Enqueue(i);

            while (q.Count > 1)
            {
                q.Dequeue();
                q.Enqueue(q.Dequeue());
            }

            Console.Write(q.Dequeue());
        }
    }
}