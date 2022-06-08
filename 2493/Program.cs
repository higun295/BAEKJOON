using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2493
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine());
            int[] array = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                while (stack.Count != 0)
                {
                    if (array[i - 1] <= stack.Peek().Item2)
                    {
                        sb.Append(stack.Peek().Item1 + " ");
                        break;
                    }

                    stack.Pop();
                }
                if (stack.Count == 0)
                    sb.Append("0 ");

                stack.Push(new Tuple<int, int>(i, array[i - 1]));
            }

            sw.Write(sb);
            sw.Close();
            sr.Close();
        }
    }
}