using System;
using System.IO;
using System.Text;

namespace _10866
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int MAX = 5000;
            int head = MAX;
            int tail = MAX;

            int[] array = new int[2 * MAX + 1];
            int N = int.Parse(sr.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] input = sr.ReadLine().Split(' ');
                if (input[0] == "push_front")
                    array[--head] = int.Parse(input[1]);

                else if (input[0] == "push_back")
                    array[tail++] = int.Parse(input[1]);

                else if (input[0] == "pop_front")
                {
                    if (head == tail)
                    {
                        sb.AppendLine("-1");
                        continue;
                    }

                    sb.AppendLine(array[head++].ToString());
                }

                else if (input[0] == "pop_back")
                {
                    if (head == tail)
                    {
                        sb.AppendLine("-1");
                        continue;
                    }

                    sb.AppendLine(array[--tail].ToString());
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

            sw.Write(sb);
            sw.Close();
            sr.Close();
        }
    }
}