using System;
using System.IO;
using System.Text;

namespace _11659
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            string[] input = sr.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            string[] input2 = sr.ReadLine().Split(' ');
            int[] a = new int[100001];
            int[] d = new int[100001];
            d[0] = 0;
            for (int i = 1; i < N + 1; i++)
            {
                a[i] = int.Parse(input2[i - 1]);
                d[i] = d[i - 1] + a[i];
            }

            while (M > 0)
            {
                int[] range = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sb.Append(d[range[1]] - d[range[0] - 1]);
                sb.Append("\n");
                M--;
            }

            sw.Write(sb);
            sw.Close();
            sr.Close();
        }
    }
}