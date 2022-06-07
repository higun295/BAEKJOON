using System;
using System.Text;

namespace _2442
{
    class Program
    {
        static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                    sb.Append(" ");
                for (int j = 0; j < 2 * i + 1; j++)
                    sb.Append("*");

                sb.Append("\n");
            }
            Console.Write(sb);
        }
    }
}