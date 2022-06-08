using System;

namespace _10773
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = new int[100001];
            int pos = 0;

            int result = 0;
            int K = int.Parse(Console.ReadLine());
            for (int i = 0; i < K; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    result -= array[pos - 1];
                    pos--;
                    continue;
                }

                array[pos] = input;
                result += input;
                pos++;
            }

            Console.Write(result);
        }
    }
}