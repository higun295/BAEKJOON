using System;

namespace GraphTheoryEx_01
{
    class Program
    {
        // 서로소 집합 자료구조
        // 기타 그래프 이론 7:48

        public static int v; // 노드의 개수 v
        public static int e; // 간선의 개수 e
        // 노드의 개수는 최대 100,000개라고 가정
        public static int[] parent = new int[100001];// 부모 테이블 초기화하기

        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            v = int.Parse(input[0]);
            e = int.Parse(input[1]);

            // 부모 테이블 상에서, 부모를 자기 자신으로 초기화
            for (int i = 1; i < v + 1; i++)
                parent[i] = i;

            // Union 연산을 각각 수행
            for (int i = 0; i < e; i++)
            {
                string[] input2 = Console.ReadLine().Split(' ');
                int a = int.Parse(input2[0]);
                int b = int.Parse(input2[1]);
                UnionParent(a, b);
            }

            // 각 원소가 속한 집합 출력하기
            Console.Write("각 원소가 속한 집합 : ");
            for (int i = 1; i < v + 1; i++)
                Console.Write(FindParent(i) + " ");

            Console.WriteLine();

            // 부모 테이블 내용 출력하기
            Console.Write("부모 테이블 : ");
            for (int i = 1; i < v + 1; i++)
                Console.Write(parent[i] + " ");

            Console.WriteLine();
        }

        // 특정 원소가 속한 집합을 찾기
        static int FindParent (int x)
        {
            // 루트 노드를 찾을 때까지 재귀 호출(경로 압축 적용)
            if (parent[x] != x)
                parent[x] = FindParent(parent[x]);

            return parent[x];

            // 경로 압축 미적용
            //if (parent[x] != x)
            //    return FindParent(parent[x]);

            //return x;
        }

        // 두 원소가 속한 집합을 합치기
        static void UnionParent (int a, int b)
        {
            a = FindParent(a);
            b = FindParent(b);

            // 부모의 값이 더 큰 쪽이 작은 쪽을 따라간다.(관행적으로...)
            if (a > b)
                parent[a] = b;
            else
                parent[b] = a;
        }
    }
}