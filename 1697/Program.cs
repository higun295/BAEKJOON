using System;
using System.Collections.Generic;

namespace _1697
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] dist = new int[100001];
            Array.Fill(dist, -1);
            dist[N] = 0;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(N);

            int[] nx = new int[3];
            while (dist[K] == -1)
            {
                int current = queue.Dequeue();

                nx[0] = current - 1;
                nx[1] = current + 1;
                nx[2] = current * 2;

                for (int i = 0; i < 3; i++)
                {
                    if (nx[i] < 0 || nx[i] > 100000)
                        continue;
                    if (dist[nx[i]] != -1)
                        continue;

                    dist[nx[i]] = dist[current] + 1;
                    queue.Enqueue(nx[i]);
                }
            }

            Console.WriteLine(dist[K]);
        }
    }   
}