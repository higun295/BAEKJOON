using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10845
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                StringBuilder sb = new StringBuilder();
                string[] input = Console.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "push":
                        queue.Enqueue(Convert.ToInt32(input[1]));
                        continue;
                    case "pop":
                        sb.AppendLine(queue.Count == 0 ? "-1" : queue.Dequeue().ToString());
                        break;
                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;
                    case "empty":
                        sb.AppendLine(queue.Count == 0 ? "1" : "0");
                        break;
                    case "front":
                        sb.AppendLine(queue.Count == 0 ? "-1" : queue.Peek().ToString());
                        break;
                    case "back":
                        sb.AppendLine(queue.Count == 0 ? "-1" : queue.Last().ToString());
                        break;
                }

                Console.Write(sb.ToString());
            }
        }
    }
}