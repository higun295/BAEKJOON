using System;

namespace _10804
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = new int[21];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < 10; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                for (int j = 0; j < (B - A + 1) / 2; j++)
                {
                    int temp = array[A + j];
                    array[A + j] = array[B - j];
                    array[B - j] = temp;
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}