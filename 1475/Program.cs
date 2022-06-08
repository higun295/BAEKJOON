using System;

namespace _1475
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[10];

            int ans = 1;
            while (N != 0)
            {
                array[N % 10]++;
                N /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 6 || i == 9) continue;
                ans = Math.Max(ans, array[i]);
            }

            ans = Math.Max(ans, (array[6] + array[9] + 1) / 2);
            Console.Write(ans);
        }
    }
}