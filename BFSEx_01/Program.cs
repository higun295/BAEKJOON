 using System;
using System.Collections.Generic;

namespace BFSEx_01
{
    class Program
    {
        // BFS 소스코드 예제
        // DFS & BFS 39:33
        public static bool[] visited = new bool[9]; // 8개로 해도 되는데 헷갈리지 않으려고 문제에서 나온 index와 맞추려 한다.
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