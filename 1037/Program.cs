using System;

namespace _1037
{
    class Program
    {
        public static int MAX = 1000000;
        public static int MIN = 2;

        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (array[i] >= MIN) MIN = array[i];
                if (array[i] <= MAX) MAX = array[i];
            }

            Console.WriteLine(MAX * MIN);
        }
    }
}