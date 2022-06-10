using System;
using System.Text;

namespace _9095
{
    class Program
    {
        static void Main (string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            int[] d = new int[20];
            d[1] = 1;
            d[2] = 2;
            d[3] = 4;

            for (int j = 4; j < 11; j++)
                d[j] = d[j - 1] + d[j - 2] + d[j - 3];

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                sb.AppendLine(d[N].ToString());
            }

            Console.Write(sb);
        }
    }
}