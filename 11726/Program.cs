using System;

namespace _11726
{
    class Program
    {
        static void Main (string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] d = new int[1001];
            d[1] = 1;
            d[2] = 2;

            for (int i = 3; i < n + 1; i++)
            {
                d[i] = (d[i - 1] + d[i - 2]) % 10007;
            }

            Console.WriteLine(d[n]);
        }
    }
}