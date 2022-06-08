using System;
using System.Collections.Generic;
using System.Text;

namespace _1874
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = new int[100001];

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
                array[i] = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            int iterator = 1;
            for (int i = 0; i < N; i++)
            {
                while (array[i] >= iterator)
                {
                    stack.Push(iterator++);
                    sb.AppendLine("+");
                }

                if (array[i] != stack.Peek())
                {
                    Console.WriteLine("NO");
                    return;
                }

                stack.Pop();
                sb.AppendLine("-");
            }

            Console.Write(sb);
        }
    }
}