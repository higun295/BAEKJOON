using System;
using System.Collections.Generic;
using System.Linq;

namespace _2667
{
    class Program
    {
        public static int N;
        public static int[,] graph = new int[25, 25];
        public static int count;
        public static List<int> list = new List<int>();

        static void Main (string[] args)
        {
            N = Convert.ToInt32(Console.ReadLine()); // 지도의 크기 N X N

            // 지도 정보 입력 완료
            for (int i = 0; i < N; i++)
            {
                string input2 = Console.ReadLine();
                for (int j = 0; j < N; j++)
                {
                    graph[i, j] = input2[j] - '0';
                }
            }

            int complex = 0;
            // 재귀적으로 DFS 수행
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    count = 0;
                    if (DFS(i, j) == true)
                    {
                        complex++;
                        list.Add(count);
                    }
                }
            }

            Console.WriteLine(complex);
            foreach (var item in list.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }
        }

        static bool DFS (int x, int y)
        {
            // 지도 정보에서 벗어나는 범위는 제외한다.
            if (x < 0 || x >= N || y < 0 || y >= N)
                return false;

            if (graph[x, y] == 1)
            {
                count++;
                graph[x, y]++;
                DFS(x + 1, y);
                DFS(x - 1, y);
                DFS(x, y + 1);
                DFS(x, y - 1);

                return true;
            }

            return false;
        }
    }
}