using System;
using System.Linq;

namespace SortingEx_05
{
    class Program
    {
        static void Main (string[] args)
        {
            // N, K 공백을 기준으로 구분되어 입력
            string[] input = Console.ReadLine().Split(' ');

            int N = Convert.ToInt32(input[0]);
            int K = Convert.ToInt32(input[1]);

            // 크기가 N인 자연수 배열 A와 B 생성
            int[] a = new int[N];
            string[] aArray = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(aArray[i]);
            }

            int[] b = new int[N];
            string[] bArray = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                b[i] = Convert.ToInt32(bArray[i]);
            }

            int[] ascendingA = a.OrderBy(x => x).ToArray();
            int[] descendingB = b.OrderByDescending(x => x).ToArray();

            // K번의 바꿔치기 수행 가능
            for (int i = 0; i < K; i++)
            {
                int temp = ascendingA[i];
                ascendingA[i] = descendingB[i];
                descendingB[i] = temp;
            }

            int result = 0;
            for (int i = 0; i < ascendingA.Length; i++)
            {
                result += ascendingA[i];
            }

            Console.WriteLine(result);
        }
    }
}