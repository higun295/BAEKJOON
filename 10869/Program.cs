using System;
using System.IO;
using System.Text;

namespace _10869
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            sb.Append(input[0] + input[1]);
            sb.Append("\n");
            sb.Append(input[0] - input[1]);
            sb.Append("\n");
            sb.Append(input[0] * input[1]);
            sb.Append("\n");
            sb.Append(input[0] / input[1]);
            sb.Append("\n");
            sb.Append(input[0] % input[1]);

            sw.Write(sb);
            sw.Close();
        }
    }
}