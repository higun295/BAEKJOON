using System;

namespace DynamicProgrammingEx_01
{
    class Program
    {
        // 피보나치 수열 구현하기(단순 재귀함수 구현)
        // 다이나믹 프로그래밍 6:59
        static void Main (string[] args)
        {
            int result = FibonacciSequence(40);
            Console.WriteLine(result);
        }

        static int FibonacciSequence (int x)
        {
            // 종료 조건 명시(매우 중요!!!)
            if (x == 1 || x == 2)
                return 1;

            // 점화식 그대로 코드로 옮겨 놓았음
            return FibonacciSequence(x - 1) + FibonacciSequence(x - 2);
        }
    }
}