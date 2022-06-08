using System;
using System.Collections.Generic;

namespace _1406
{
    class Program
    {
        static void Main (string[] args)
        {
            LinkedList<char> list = new LinkedList<char>();
            char[] input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length; i++)
                list.AddLast(input[i]);

            int M = int.Parse(Console.ReadLine());
            int cursor = list.Count;
            for (int i = 0; i < M; i++)
            {
                char[] input2 = Console.ReadLine().ToCharArray();
                if (input2[0] == 'L')
                {
                }
                else if (input2[0] == 'D')
                {
                }
                else if (input2[0] == 'B')
                {
                }
                else
                {
                }
            }
        }
    }
}