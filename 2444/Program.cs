using System;
using System.Text;

namespace _2444
{
    class Program
    {
        static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                sb.Append(' ', N - i);
                sb.Append('*', i * 2 - 1);
                sb.Append("\n");
            }
            for (int i = N - 1; i >= 1; i--)
            {
                sb.Append(' ', N - i);
                sb.Append('*', i * 2 - 1);
                sb.Append("\n");
            }

            Console.WriteLine(sb);
        }
    }
}