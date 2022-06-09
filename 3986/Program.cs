using System;
using System.Collections.Generic;
using System.IO;

namespace _3986
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine());

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                string input = sr.ReadLine();
                Stack<char> stack = new Stack<char>();
                for (int j = 0; j < input.Length; j++)
                {
                    if (stack.Count != 0 && stack.Peek() == input[j])
                    {
                        stack.Pop();
                        continue;
                    }

                    stack.Push(input[j]);
                }

                if (stack.Count == 0)
                    result++;
            }

            sw.WriteLine(result);
            sw.Close();
            sr.Close();
        }
    }
}