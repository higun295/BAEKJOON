using System;

namespace _1748
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int result = 0;

            // 숫자만큼 1 더하고 2자리 수만큼 1 더하고 3자리 수만큼 1 더하고....
            for (int i = 1; i <= N; i *= 10)
            {
                result += N - i + 1;
            }

            Console.WriteLine(result);
        }
    }
}