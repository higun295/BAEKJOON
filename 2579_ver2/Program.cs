using System;

namespace _2579_ver2
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] S = new int[301];
            int[] d = new int[301];

            int tot = 0;
            for (int i = 1; i < N + 1; i++)
            {
                S[i] = int.Parse(Console.ReadLine());
                tot += S[i];
            }

            if (N <= 2)
            {
                Console.WriteLine(tot);
                return;
            }

            d[1] = S[1];
            d[2] = S[2];
            d[3] = S[3];
            for (int i = 4; i < N; i++)
                d[i] = Math.Min(d[i - 3], d[i - 2]) + S[i];

            Console.WriteLine(tot - Math.Min(d[N - 1], d[N - 2]));
        }
    }
}