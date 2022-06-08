using System;
using System.Text;

namespace _10845
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = new int[10001];
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            int head = 0;
            int tail = 0;
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "push")
                {
                    array[tail] = int.Parse(input[1]);
                    tail++;
                }

                else if (input[0] == "pop")
                {
                    if (head == tail)
                    {
                        sb.AppendLine("-1");
                        continue;
                    }

                    sb.AppendLine(array[head].ToString());
                    head++;
                }

                else if (input[0] == "size")
                    sb.AppendLine((tail - head).ToString());

                else if (input[0] == "empty")
                {
                    if (head == tail)
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                }
                else if (input[0] == "front")
                {
                    if (head == tail)
                    {
                        sb.AppendLine("-1");
                        continue;
                    }

                    sb.AppendLine(array[head].ToString());
                }
                else
                {
                    if (head == tail)
                    {
                        sb.AppendLine("-1");
                        continue;
                    }

                    sb.AppendLine(array[tail - 1].ToString());
                }
            }

            Console.Write(sb);
        }
    }
}