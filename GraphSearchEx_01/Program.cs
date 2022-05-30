using System;

namespace GraphSearchEx_01
{
    class Program
    {
        // <문제> 음료수 얼려 먹기
        // DFS & BFS 42:45
        // 틀렸음
        public static int N, M;
        public static int[,] graph = new int[1000, 1000];

        public static bool DFS (int x, int y)
        {
            if (x <= -1 || x >= N || y <= -1 || y >= M)
                return false;

            // 해당 노드를 방문하지 않았다면
            if (graph[x, y] == 0)
            {
                // 해당 노드 방문 처리
                graph[x, y] = 1;

                // 상, 하, 좌, 우의 노드들도 모두 재귀적으로 호출
                DFS(x - 1, y);
                DFS(x, y - 1);
                DFS(x + 1, y);
                DFS(x, y + 1);
                return true;
            }

            return false;
        }

        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            N = Convert.ToInt32(input[0]);
            M = Convert.ToInt32(input[1]);

            // 2차원 리스트의 맵 정보 입력 받기
            for (int i = 0; i < N; i++)
            {
                char[] inputArray = Console.ReadLine().ToCharArray();
                for (int j = 0; j < M; j++)
                    graph[i, j] = inputArray[j] - '0';
            }

            // 모든 노드(위치)에 대하여 음료수 채우기
            int result = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (DFS(i, j))
                        result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}