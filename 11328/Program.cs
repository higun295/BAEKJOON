using System;
using System.Text;

namespace _11328
{
    class Program
    {
        static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int[] array = new int[26];
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < input[0].Length; j++)
                    array[input[0][j] - 'a']++;

                for (int j = 0; j < input[1].Length; j++)
                    array[input[1][j] - 'a']--;

                bool isPossible = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] != 0)
                    {
                        isPossible = false;
                        break;
                    }
                }

                if (isPossible) sb.AppendLine("Possible");
                else sb.AppendLine("Impossible");
            }

            Console.Write(sb);
        }
    }
}