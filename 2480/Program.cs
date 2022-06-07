using System;

namespace _2480
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(input);

            int result = 0;
            if (input[0] == input[2])
                result = 10000 + input[0] * 1000;
            else if (input[0] == input[1] || input[1] == input[2])
                result = 1000 + input[1] * 100;
            else
                result = input[2] * 100;

            Console.WriteLine(result);
        }
    }
}