using System;
using System.Collections.Generic;
using System.IO;

namespace _4949
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string input = sr.ReadLine();
                if (input.Equals("."))
                    break;

                bool isValid = true;
                Stack<char> stack = new Stack<char>();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '(' || input[i] == '[')
                        stack.Push(input[i]);
                    else if (input[i] == ')')
                    {
                        if (stack.Count == 0 || stack.Peek() != '(')
                        {
                            isValid = false;
                            break;
                        }
                        stack.Pop();
                    }
                    else if (input[i] == ']')
                    {
                        if (stack.Count == 0 || stack.Peek() != '[')
                        {
                            isValid = false;
                            break;
                        }
                        stack.Pop();
                    }
                }

                if (stack.Count != 0) isValid = false;
                if (isValid == true) sw.WriteLine("yes");
                else sw.WriteLine("no");
            }

            sw.Close();
            sr.Close();
        }
    }
}