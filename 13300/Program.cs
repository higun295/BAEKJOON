using System;

namespace _13300
{
    class Program
    {
        static void Main (string[] args)
        {
            int[,] array = new int[7, 2];

            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            for (int i = 0; i < N; i++)
            {
                int[] input2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                array[input2[1], input2[0]]++;
            }

            int room = 0;
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (array[i, j] % K == 0)
                        room += array[i, j] / K;
                    else
                        room += array[i, j] / K + 1;
                }
            }

            Console.Write(room);
        }
    }
}