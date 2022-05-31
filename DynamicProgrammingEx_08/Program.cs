using System;
using System.Linq;

namespace DynamicProgrammingEx_08
{
    class Program
    {
        // <문제> 병사 배치하기
        // 다이나믹 프로그래밍 59:51
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine()); // 병사의 수 N

            string[] input = Console.ReadLine().Split(' ');
            int[] soldiers = new int[N];

            for (int i = 0; i < N; i++)
            {
                soldiers[i] = Convert.ToInt32(input[i]);
            }

            // 순서를 뒤집어서 '최장 증가 부분 수열' 문제로 치환
            Array.Reverse(soldiers);

            // 자기 자신을 포함하는 수열의 길이를 1이라고 보고
            // 모든 값을 1로 초기화
            int[] dp = new int[N];
            Array.Fill(dp, 1);

            // LIS 알고리즘 수행
            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (soldiers[j] < soldiers[i])
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }

            Console.WriteLine(N - dp.Max());
        }
    }
}