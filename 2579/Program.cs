using System;

namespace _2579
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] S = new int[301];

            for (int i = 1; i < N + 1; i++)
                S[i] = int.Parse(Console.ReadLine());

            int[,] d = new int[301, 3];
            d[1, 1] = S[1];
            d[1, 2] = 0;
            d[2, 1] = S[2];
            d[2, 2] = S[1] + S[2];

            for (int i = 3; i < N + 1; i++)
            {
                d[i, 1] = Math.Max(d[i - 2, 1], d[i - 2, 2]) + S[i];
                d[i, 2] = d[i - 1, 1] + S[i];
            }

            Console.WriteLine(Math.Max(d[N, 1], d[N, 2]));
        }
    }
}