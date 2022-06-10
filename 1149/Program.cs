using System;

namespace _1149
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] R = new int[1001];
            int[] G = new int[1001];
            int[] B = new int[1001];

            for (int i = 1; i < N + 1; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                R[i] = int.Parse(input[0]);
                G[i] = int.Parse(input[1]);
                B[i] = int.Parse(input[2]);
            }

            int[,] d = new int[1001, 3];
            d[1, 0] = R[1];
            d[1, 1] = G[1];
            d[1, 2] = B[1];

            for (int i = 2; i < N + 1; i++)
            {
                d[i, 0] = Math.Min(d[i - 1, 1], d[i - 1, 2]) + R[i];
                d[i, 1] = Math.Min(d[i - 1, 0], d[i - 1, 2]) + G[i];
                d[i, 2] = Math.Min(d[i - 1, 0], d[i - 1, 1]) + B[i];
            }

            Console.WriteLine(Math.Min(d[N, 0], Math.Min(d[N, 1], d[N, 2])));
        }
    }
}