using System;

namespace _1463
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // 정수 N
            int[] d = new int[N + 1]; // 1부터 N까지 할거니깐...
            for (int i = 2; i < N + 1; i++)
            {
                // 1을 뺀 경우
                d[i] = d[i - 1] + 1;
                // 2로 나눈 경우
                if (i % 2 == 0)
                    d[i] = Math.Min(d[i], d[i / 2] + 1);
                // 3으로 나눈 경우
                if (i % 3 == 0)
                    d[i] = Math.Min(d[i], d[i / 3] + 1);
            }

            Console.WriteLine(d[N]);
        }
    }
}