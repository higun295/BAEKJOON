using System;
using System.Text;

namespace _2441
{
    class Program
    {
        static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int j = 0;
                for (; j < i; j++)
                {
                    sb.Append(" ");
                }
                for (; j < N; j++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }

            Console.Write(sb);
        }
    }
}