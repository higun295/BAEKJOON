using System;
using System.IO;
using System.Text;

namespace _18258
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int[] array = new int[2000001];
            int N = int.Parse(sr.ReadLine());
            int head = 0;
            int tail = 0;

            for (int i = 0; i < N; i++)
            {
                string[] input = sr.ReadLine().Split(' ');
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

            sw.Write(sb);
            sw.Close();
            sr.Close();
        }
    }
}