using System;

namespace DynamicProgrammingEx_02
{
    class Program
    {
        public static long[] d = new long[100];

        // 피보나치 수열 구현하기(TopDown, 메모이제이션)
        // 다이나믹 프로그래밍 15:33
        static void Main (string[] args)
        {
            long result = FibonacciSequence(50);
            Console.WriteLine(result);
        }

        static long FibonacciSequence (int x)
        {
            // 종료조건(1 혹은 2일 때 1을 반환)
            if (x == 1 || x == 2) 
                return 1;

            // 이미 계산한 적이 있는 문제라면 그대로 반환
            if (d[x] != 0)
                return d[x];

            // 아직 계산하지 않은 문제라면 점화식에 따라서 피보나치 결과 반환
            d[x] = FibonacciSequence(x - 1) + FibonacciSequence(x - 2);
            return d[x];
        }
    }
}