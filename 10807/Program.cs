using System;

namespace _10807
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = new int[201];

            int N = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int V = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                array[input[i] + 100]++;
            }

            Console.Write(array[V + 100]);
        }
    }
}