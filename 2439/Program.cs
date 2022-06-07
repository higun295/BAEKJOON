using System;
using System.Text;

namespace _2439
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                int j = 0;
                for (; j < N - i - 1; j++)
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