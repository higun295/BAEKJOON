using System;
using System.Linq;

namespace SortingEx_05
{
    class Program
    {
        // <문제> 두 배열의 원소 교체
        // 정렬 알고리즘 38:34
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int N = Convert.ToInt32(input[0]); // 배열 구성 원소의 개수 N
            int K = Convert.ToInt32(input[1]); // 바꿔치기 수행 횟수 K

            int[] A = new int[N];
            int[] B = new int[N];

            string[] input2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt32(input2[i]);
            }

            string[] input3 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = Convert.ToInt32(input3[i]);
            }

            Array.Sort(A);
            Array.Sort(B);
            Array.Reverse(B);

            for (int i = 0; i < K; i++)
            {
                if (A[i] < B[i])
                {
                    int temp = A[i];
                    A[i] = B[i];
                    B[i] = temp;
                }
            }

            Console.WriteLine(A.Sum());
        }




















































        //static void Main (string[] args)
        //{
        //    // N, K 공백을 기준으로 구분되어 입력
        //    string[] input = Console.ReadLine().Split(' ');

        //    int N = Convert.ToInt32(input[0]);
        //    int K = Convert.ToInt32(input[1]);

        //    // 크기가 N인 자연수 배열 A와 B 생성
        //    int[] a = new int[N];
        //    string[] aArray = Console.ReadLine().Split(' ');
        //    for (int i = 0; i < N; i++)
        //    {
        //        a[i] = Convert.ToInt32(aArray[i]);
        //    }

        //    int[] b = new int[N];
        //    string[] bArray = Console.ReadLine().Split(' ');
        //    for (int i = 0; i < N; i++)
        //    {
        //        b[i] = Convert.ToInt32(bArray[i]);
        //    }

        //    int[] ascendingA = a.OrderBy(x => x).ToArray();
        //    int[] descendingB = b.OrderByDescending(x => x).ToArray();

        //    // K번의 바꿔치기 수행 가능
        //    for (int i = 0; i < K; i++)
        //    {
        //        int temp = ascendingA[i];
        //        ascendingA[i] = descendingB[i];
        //        descendingB[i] = temp;
        //    }

        //    int result = 0;
        //    for (int i = 0; i < ascendingA.Length; i++)
        //    {
        //        result += ascendingA[i];
        //    }

        //    Console.WriteLine(result);
        //}
    }
}