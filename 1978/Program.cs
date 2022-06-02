using System;

namespace _1978
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // 수의 개수 N

            int[] array = new int[N];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int count = 0;
            int result = 0;

            for (int i = 0; i < N; i++)
            {
                if (array[i] == 1) continue;
                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0)
                        count++;
                }

                if (count == 0)
                    result++;

                count = 0;
            }

            Console.WriteLine(result);
        }
    }
}