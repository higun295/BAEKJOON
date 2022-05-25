using System;
using System.Collections.Generic;

namespace GraphSearchEx_02
{
    class Node
    {
        private int _x;
        private int _y;

        public Node (int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int getX ()
        {
            return _x;
        }
        public int getY ()
        {
            return _y;
        }
    }
    class Program
    {
        public static int N, M;
        public static int[,] graph = new int[200, 200];

        // 이동할 네 가지 방향 정의 (상, 하, 좌, 우)
        public static int[] dx = { -1, 1, 0, 0 };
        public static int[] dy = { 0, 0, -1, 1 };

        public static int BFS (int x, int y)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(x, y));

            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();
                x = node.getX();
                y = node.getY();

                // 현재 위치에서 4가지 방향으로 위치 확인
                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    // 미로 찾기 공간을 벗어난 경우 무시
                    if (nx < 0 || nx >= N || ny < 0 || ny >= M) 
                        continue;
                    // 벽인 경우 무시
                    if (graph[nx, ny] == 0) 
                        continue;
                    // 해당 노드를 처음 방문하는 경우에만 최단 거리 기록
                    if (graph[nx, ny] == 1)
                    {
                        graph[nx, ny] = graph[x, y] + 1;
                        queue.Enqueue(new Node(nx, ny));
                    }
                }
            }

            // 가장 오른쪽 아래까지의 최단 거리 반환
            return graph[N - 1, M - 1];
        }

        static void Main (string[] args)
        {
            // 두 정수를 입력받고 N과 M을 할당한다.
            string[] input = Console.ReadLine().Split(' ');
            N = Convert.ToInt32(input[0]); // 세로
            M = Convert.ToInt32(input[1]); // 가로

            // N줄만큼 미로 정보를 입력받는다.
            for (int i = 0; i < N; i++)
            {
                // 입력 받은 미로 정보를 그래프에 저장한다.
                char[] mapInput = Console.ReadLine().ToCharArray();
                for (int j = 0; j < M; j++)
                {
                    graph[i, j] = mapInput[j] -'0';
                }
            }

            Console.WriteLine(BFS(0, 0));
        }
    }
}