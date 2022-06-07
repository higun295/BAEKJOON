using System;
using System.Text;

namespace _2445
{
    class Program
    {
        static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                    sb.Append("*");
                for (int j = 0; j < 2 * (N - i - 1); j++)
                    sb.Append(" ");
                for (int j = 0; j <= i; j++)
                    sb.Append("*");
                sb.Append("\n");
            }
            for (int i = 0; i < 2 * N; i++)
            {
                sb.Append("*");
            }

            sb.Append("\n");

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                    sb.Append("*");
                for (int j = 0; j < 2 * (i + 1); j++)
                    sb.Append(" ");
                for (int j = 0; j < N - i - 1; j++)
                    sb.Append("*");
                sb.Append("\n");
            }

            Console.Write(sb);
        }
    }
}