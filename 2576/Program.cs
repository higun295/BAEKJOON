using System;

namespace _2576
{
    class Program
    {
        static void Main (string[] args)
        {
            int sum = 0;
            int min = 100;

            for (int i = 0; i < 7; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 != 0)
                {
                    sum += input;
                    if (min > input)
                        min = input;
                }
            }

            if (sum == 0)
                Console.WriteLine(-1);
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }
    }
}