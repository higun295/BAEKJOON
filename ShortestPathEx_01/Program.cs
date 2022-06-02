using System;
using System.Collections.Generic;

namespace ShortestPathEx_01
{
    class Node
    {
        private int _index;
        private int _distance;

        public Node (int index, int distance)
        {
            _index = index;
            _distance = distance;
        }

        public int GetIndex ()
        {
            return _index;
        }
        public int GetDistance ()
        {
            return _distance;
        }
    }
    class Program
    {
        // 다익스트라 알고리즘
        // 최단 경로 알고리즘 15:05

        // 무한을 의미하는 값으로 10억을 설정
        public static int INF = 1000000000;
        // 노드의 개수 N, 간선의 개수 M, 노드 시작 번호 Start
        // 노드는 최대 100,000개라고 가정
        public static int N, M, Start;
        // 각 노드에 연결되어 있는 노드에 대한 정보를 담는 배열
        public static List<List<Node>> graph = new List<List<Node>>();
        // 방문한 적이 있는지 체크하는 목적의 배열 만들기
        public static bool[] visited = new bool[100001];
        // 최단 거리 테이블 만들기
        public static int[] d = new int[100001];

        // 방문하지 않은 노드 중에서, 가장 최단 거리가 짧은 노드의 번호를 반환
        public static int GetSmallestNode ()
        {
            int minValue = INF;
            int index = 0; // 가장 최단 거리가 짧은 노드(index)
            for (int i = 0; i < N; i++)
            {
                if (d[i] < minValue && visited[i] != true)
                {
                    minValue = d[i];
                    index = i;
                }
            }

            return index;
        }

        public static void Dijkstra (int start)
        {
            // 시작 노드에 대해서 초기화
            d[start] = 0;
            visited[start] = true;
            for (int j = 0; j < graph[start].Count; j++)
            {
                d[graph[start][j].GetIndex()] = graph[start][j].GetDistance();
            }

            // 시작 노드를 제외한 전체 n - 1 개의 노드에 대해 반복
            for (int i = 0; i < N - 1; i++)
            {
                // 현재 최단 거리가 가장 짧은 노드를 꺼내서, 방문 처리
                int now = GetSmallestNode();
                visited[now] = true;
                // 현재 노드와 연결된 다른 노드를 확인
                for (int j = 0; j < graph[now].Count; j++)
                {
                    int cost = d[now] + graph[now][j].GetDistance();
                    // 현재 노드를 거쳐서 다른 노드로 이동하는 거리가 더 짧은 경우
                    if (cost < d[graph[now][j].GetIndex()])
                        d[graph[now][j].GetIndex()] = cost;
                }
            }
        }

        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            N = int.Parse(input[0]);
            M = int.Parse(input[1]);
            Start = int.Parse(input[2]);

            // 그래프 초기화
            for (int i = 0; i < N; i++)
            {
                graph.Add(new List<Node>());
            }

            // 모든 간선 정보를 입력받기
            for (int i = 0; i < M; i++)
            {
                string[] input2 = Console.ReadLine().Split(' ');
                int a = int.Parse(input2[0]);
                int b = int.Parse(input2[1]);
                int c = int.Parse(input2[2]);
                // a번 노드에서 b번 노드로 가는 비용이 c라는 의미
                graph[a].Add(new Node(b, c));
            }

            // 최단 거리 테이블을 모두 무한으로 초기화
            Array.Fill(d, INF);

            // 다익스트라 알고리즘을 수행
            Dijkstra(Start);

            // 모든 노드로 가기 위한 최단 거리를 출력
            for (int i = 1; i <= N; i++)
            {
                // 도달할 수 없는 경우, 무한(INFINITY)이라고 출력
                if (d[i] == INF)
                    Console.WriteLine("INFINITY");
                // 도달할 수 있는 경우, 거리를 출력
                else
                    Console.WriteLine(d[i]);
            }
        }
    }
}
