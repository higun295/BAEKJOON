using System;

namespace _2752
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }

                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}