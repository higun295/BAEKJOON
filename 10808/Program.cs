using System;
using System.Text;

namespace _10808
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = new int[26];
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
                array[input[i] - 'a']++;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
                sb.Append(array[i] + " ");

            Console.Write(sb);
        }
    }
}