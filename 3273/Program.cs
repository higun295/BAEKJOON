using System;

namespace _3273
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = new int[1000001];
            bool[] occurred = new bool[2000001];

            int N = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
                array[i] = input[i];

            int ans = 0;
            for (int i = 0; i < N; i++)
            {
                if (X - array[i] > 0 && occurred[X - array[i]])
                    ans++;

                occurred[array[i]] = true;
            }

            Console.Write(ans);
        }
    }
}