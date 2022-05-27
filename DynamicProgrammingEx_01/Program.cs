using System;
using System.Diagnostics;

namespace DynamicProgrammingEx_01
{
    class Program
    {
        // 피보나치 수열 구현하기
        static void Main (string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int result = FibonacciSequence(40);

            sw.Stop();
            Console.WriteLine(result);
            Console.WriteLine($"{sw.ElapsedMilliseconds}ms");
        }

        static int FibonacciSequence (int x)
        {
            if (x == 1 || x == 2)
                return 1;

            // 점화식 그대로 코드로 옮겨 놓았음
            return FibonacciSequence(x - 1) + FibonacciSequence(x - 2);
        }
    }
}