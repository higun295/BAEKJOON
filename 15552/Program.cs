using System;
using System.IO;
using System.Text;

namespace _15552
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int T = int.Parse(sr.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] input = sr.ReadLine().Split(' ');
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);
                sb.Append(A + B).Append("\n");
            }

            sw.Write(sb);
            sr.Close();
            sw.Close();
        }
    }
}