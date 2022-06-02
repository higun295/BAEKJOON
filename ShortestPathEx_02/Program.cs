using System;
using System.Collections.Generic;

namespace ShortestPathEx_02
{
    class Node : IComparable<Node>
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

        // 거리(비용)가 짧은 것이 높은 우선순위를 가지도록 설정
        public int CompareTo (Node other)
        {
            if (_distance < other._distance)
                return -1;

            return 1;
        }
    }
    class Program
    {
        // 다익스트라 알고리즘(개선된 구현 방법)
        // 최단 경로 알고리즘 34:52

        // 무한을 의미하는 값으로 10억을 설정
        public static int INF = 1000000000;
        // 노드의 개수 N, 간선의 개수 M, 노드 시작 번호 Start
        // 노드는 최대 100,000개라고 가정
        public static int N, M, Start;
        // 각 노드에 연결되어 있는 노드에 대한 정보를 담는 배열
        public static List<List<Node>> graph = new List<List<Node>>();
        // 최단 거리 테이블 만들기
        public static int[] d = new int[100001];

        public static void Dijkstra (int start)
        {
            // Priority Queue????
        }

        static void Main (string[] args)
        {

        }
    }
}
