using System;

namespace DynamicProgrammingEx_03
{
    class Program
    {
        public static long[] d = new long[100];

        // 피보나치 수열 구현하기(BottomUp, 메모이제이션)
        // 다이나믹 프로그래밍 16:58
        static void Main (string[] args)
        {
            // 첫번째, 두번째 피보나치 수는 1
            d[1] = 1;
            d[2] = 1;
            int n = 50; // 50번째 피보나치 수를 계산

            for (int i = 3; i <= n; i++)
            {
                d[i] = d[i - 1] + d[i - 2];
            }

            Console.WriteLine(d[n]);
        }
    }
}