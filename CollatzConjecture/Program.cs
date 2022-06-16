using System;

namespace CollatzConjecture
{
    internal class Program
    {
        static void Main (string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long count = 0;

            while (true)
            {
                if (input == 1)
                    break;

                if (input % 2 == 0)
                    input = input / 2;
                else
                    input = 3 * input + 1;

                count++;
                Console.WriteLine($"Current : {input}({count})");
            }
        }
    }
}