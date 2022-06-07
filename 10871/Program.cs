using System;
using System.IO;

namespace _10871
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] input2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int N = 0;
            while (N < input[0])
            {
                if (input2[N] < input[1])
                {
                    sw.Write(input2[N]);
                    sw.Write(' ');
                }

                N++;
            }

            sw.Close();
        }
    }
}