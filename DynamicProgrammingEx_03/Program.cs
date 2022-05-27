using System;

namespace DynamicProgrammingEx_03
{
    class Program
    {
        public static long[] d = new long[100];

        static void Main (string[] args)
        {
            // 첫번째, 두번째 피보나치 수는 1
            d[1] = 1;
            d[2] = 1;
            int n = 50; // 50번째 피보나치 수를 계산

            // 피보나치 함수를 반복문으로 구현(BottomUp Dynamic Programming)
            for (int i = 3; i <= n; i++)
            {
                d[i] = d[i - 1] + d[i - 2];
            }

            Console.WriteLine(d[n]);
        }
    }
}