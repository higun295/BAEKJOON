using System;
using System.IO;

namespace _10093
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            Array.Sort(input);

            if (input[0] == input[1])
                sw.WriteLine(input[1] - input[0]);
            else
            {
                sw.WriteLine(input[1] - input[0] - 1);
                for (long i = input[0] + 1; i < input[1]; i++)
                {
                    sw.Write(i + " ");
                }
            }

            sw.Close();
        }
    }
}