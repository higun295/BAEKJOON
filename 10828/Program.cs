using System;
using System.Text;

namespace _10828
{
    class Program
    {
        static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] stack = new int[100001];
            int pos = 0;

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "push")
                {
                    stack[pos] = int.Parse(input[1]);
                    pos++;
                }
                else if (input[0] == "pop")
                {
                    if (pos == 0)
                    {
                        sb.AppendLine("-1");
                        continue;
                    }

                    sb.AppendLine(stack[pos - 1].ToString());
                    pos--;
                }
                else if (input[0] == "size")
                {
                    sb.AppendLine(pos.ToString());
                }
                else if (input[0] == "empty")
                {
                    if (pos == 0)
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                }
                else
                {
                    if (pos == 0)
                    {
                        sb.AppendLine("-1");
                        continue;
                    }

                    sb.AppendLine(stack[pos - 1].ToString());
                }
            }

            Console.Write(sb);
        }
    }
}