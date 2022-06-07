using System;

namespace _2562
{
    class Program
    {
        static void Main (string[] args)
        {
            int max = -1;
            int index = 0;

            for (int i = 0; i < 9; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input > max)
                {
                    max = input;
                    index = i + 1;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(index);
        }
    }
}