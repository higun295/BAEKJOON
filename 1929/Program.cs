using System;
using System.IO;

namespace _1929
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = Console.ReadLine().Split(' ');
            int M = int.Parse(input[0]);
            int N = int.Parse(input[1]);

            bool[] isPrimes = new bool[N + 1];
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (isPrimes[i])
                    continue;

                for (int j = i * 2; j <= N; j += i)
                {
                    isPrimes[j] = true;
                }
            }

            for (int i = Math.Max(M, 2); i <= N; i++)
            {
                if (isPrimes[i] == false)
                    sw.WriteLine(i);
            }

            sw.Close();
        }
    }
}