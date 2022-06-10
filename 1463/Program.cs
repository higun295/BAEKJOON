using System;

namespace _1463
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] d = new int[N + 1];

            for (int i = 2; i < N + 1; i++)
            {
                d[i] = d[i - 1] + 1;
                if (i % 3 == 0)
                    d[i] = Math.Min(d[i], d[i / 3] + 1);
                if (i % 2 == 0)
                    d[i] = Math.Min(d[i], d[i / 2] + 1);
            }

            Console.WriteLine(d[N]);
        }
    }
}