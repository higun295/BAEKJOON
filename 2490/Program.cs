using System;
using System.Text;

namespace _2490
{
    class Program
    {
        static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string res = "DCBAE";

            for (int i = 0; i < 3; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int count = 0;
                for (int j = 0; j < 4; j++)
                    count += input[j];

                sb.Append(res[count]);
                sb.Append("\n");
            }

            Console.Write(sb);
        }
    }
}