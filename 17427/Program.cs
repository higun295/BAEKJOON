using System;

namespace _17427
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // 자연수 N

            long result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += i * (N / i);
            }

            Console.WriteLine(result);
        }
    }
}