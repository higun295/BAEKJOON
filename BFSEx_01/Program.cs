 using System;
using System.Collections.Generic;

namespace BFSEx_01
{
    class Program
    {
        public static bool[] visited = new bool[9];
        public static List<List<int>> graph = new List<List<int>>();

        public static void BFS (int start)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            visited[start] = true;

            while (queue.Count != 0)
            {
                int x = queue.Dequeue();
                Console.Write($"{x} ");

                for (int i = 0; i < graph[x].Count; i++)
                {
                    int y = graph[x][i];
                    if (visited[y] != true) 
                    {
                        queue.Enqueue(y);
                        visited[y] = true;
                    }
                }
            }
        }

        static void Main (string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                graph.Add(new List<int>());
            }

            graph[1].Add(2);
            graph[1].Add(3);
            graph[1].Add(8);

            graph[2].Add(1);
            graph[2].Add(7);

            graph[3].Add(1);
            graph[3].Add(4);
            graph[3].Add(5);

            graph[4].Add(3);
            graph[4].Add(5);

            graph[5].Add(3);
            graph[5].Add(4);

            graph[6].Add(7);

            graph[7].Add(2);
            graph[7].Add(6);
            graph[7].Add(8);

            graph[8].Add(1);
            graph[8].Add(7);

            BFS(1);
        }
    }
}