using System;

namespace _2309
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = 9; // 난쟁이의 수
            int[] array = new int[N];

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                int item = int.Parse(Console.ReadLine());
                sum += item;
                array[i] = item;
            }

            int target = sum - 100;
            int spyA = 0;
            int spyB = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        spyA = array[i];
                        spyB = array[j];
                    }
                }
            }

            Array.Sort(array);
            for (int i = 0; i < N; i++)
            {
                if (array[i] == spyA || array[i] == spyB)
                    continue;

                Console.WriteLine(array[i]);
            }
        }
    }
}