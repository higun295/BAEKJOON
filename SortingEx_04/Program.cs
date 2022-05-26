using System;
using System.Linq;

namespace SortingEx_04
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = { 7, 5, 9, 0, 3, 1, 6, 2, 9, 1, 4, 8, 0, 5, 2 };
            int[] countArray = new int[array.Max() + 1];

            for (int i = 0; i < array.Length; i++)
            {
                countArray[array[i]]++;
            }

            for (int i = 0; i < countArray.Length; i++)
            {
                for (int j = 0; j < countArray[i]; j++)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}