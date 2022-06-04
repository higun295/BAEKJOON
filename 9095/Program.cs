using System;
using System.Text;

namespace _9095
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] d = new int[11];
            d[1] = 1;
            d[2] = 2;
            d[3] = 4;
            for (int i = 4; i < 11; i++)
            {
                d[i] = d[i - 1] + d[i - 2] + d[i - 3];
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sb.AppendLine(d[input].ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
