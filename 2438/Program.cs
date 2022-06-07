using System;
using System.Text;

namespace _2438
{
    class Program
    {
        static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }

            Console.Write(sb);
        }
    }
}