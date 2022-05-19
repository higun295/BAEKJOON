using System;

namespace GreedyEx_02
{
    class Program
    {
        static void Main (string[] args)
        {
            string input = Console.ReadLine();
             
            int result = input[0] - '0';
            for (int i = 1; i < input.Length; i++)
            {
                int num = input[i] - '0';
                if (num <= 1 || result <= 1)
                    result += num;
                else
                    result *= num;
            }

            Console.WriteLine(result);
        }
    }
}