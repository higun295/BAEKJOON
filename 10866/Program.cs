using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10866
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < N; i++)
            {
                StringBuilder sb = new StringBuilder();
                string[] input = Console.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "push_front":
                        deque.AddFirst(Convert.ToInt32(input[1]));
                        break;
                    case "push_back":
                        deque.AddLast(Convert.ToInt32(input[1]));
                        break;
                    case "pop_front":
                        if (deque.Count == 0) 
                            sb.AppendLine("-1");
                        else
                        {
                            sb.AppendLine(deque.First().ToString());
                            deque.RemoveFirst();
                        }
                        break;
                    case "pop_back":

                        if (deque.Count == 0)
                            sb.AppendLine("-1");
                        else
                        {
                            sb.AppendLine(deque.Last().ToString());
                            deque.RemoveLast();
                        }
                        break;
                    case "size":
                        sb.AppendLine(deque.Count.ToString()); 
                        break;
                    case "empty":
                        sb.AppendLine(deque.Count == 0 ? "1" : "0");
                        break;
                    case "front":
                        sb.AppendLine(deque.Count == 0 ? "-1" : deque.First().ToString());
                        break;
                    case "back":
                        sb.AppendLine(deque.Count == 0 ? "-1" : deque.Last().ToString());
                        break;
                }

                Console.Write(sb.ToString());
            }
        }
    }
}