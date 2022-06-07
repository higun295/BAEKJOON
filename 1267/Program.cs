using System;

namespace _1267
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int Y = 0;
            int M = 0;

            for (int i = 0; i < N; i++)
            {
                Y += (array[i] / 30 + 1) * 10;
                M += (array[i] / 60 + 1) * 15;
            }

            if (Y > M)
                Console.WriteLine($"M {M}");
            else if (Y < M)
                Console.WriteLine($"Y {Y}");
            else
                Console.WriteLine($"Y M {Y}");
        }
    }
}