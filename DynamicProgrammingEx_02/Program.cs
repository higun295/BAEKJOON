using System;
using System.Diagnostics;

namespace DynamicProgrammingEx_02
{
    class Program
    {
        public static long[] d = new long[200];

        // 피보나치 수열 구현하기
        // 동적계획법 사용(DynamicProgramming)
        static void Main (string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // 피보나치 함수를 재귀함수로 구현(TopDown Dynamic Programming)
            int[] d = new int[99];

            long result = FibonacciSequence(100);
            Console.WriteLine(result);

            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds}ms");
        }

        static long FibonacciSequence (int x)
        {
            // 종료조건(1 혹은 2일 때 1을 반환)
            if (x == 1 || x == 2) 
                return 1;

            // 이미 계산한 적이 있는 문제라면 그대로 반환
            if (d[x] != 0)
                return d[x];

            d[x] = FibonacciSequence(x - 1) + FibonacciSequence(x - 2);
            return d[x];
        }
    }
}