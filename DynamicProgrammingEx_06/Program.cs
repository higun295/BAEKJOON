using System;

namespace DynamicProgrammingEx_06
{
    class Program
    {
        // <문제> 효율적인 화폐 구성
        // 다이나믹 프로그래밍 43:22   
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]); // 화폐의 종류 N
            int M = int.Parse(input[1]); // 만들고자 하는 금액 M

            int[] array = new int[N]; // 화폐의 종류 배열
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] d = new int[M + 1]; // DP 테이블 초기화
            Array.Fill(d, 10001);
            d[0] = 0;

            for (int i = 0; i < N; i++) // i 는 각각의 화폐 단위
            {
                for (int j = array[i]; j < M + 1; j++) // j 는 각각의 금액
                {
                    if (d[j - array[i]] != -1)
                        d[j] = Math.Min(d[j], d[j - array[i]] + 1);
                }
            }

            Console.WriteLine(d[M]);
        }
    }
}