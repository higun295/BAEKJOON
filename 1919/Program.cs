using System;

namespace _1919
{
    class Program
    {
        static void Main (string[] args)
        {
            int[,] array = new int[2, 26];

            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            for (int i = 0; i < s1.Length; i++)
                array[0, s1[i] - 'a']++;
            for (int i = 0; i < s2.Length; i++)
                array[1, s2[i] - 'a']++;

            int result = 0;
            for (int i = 0; i < 26; i++)
            {
                if (array[0, i] - array[1, i] != 0)
                    result += Math.Abs(array[0, i] - array[1, i]);
            }

            Console.Write(result);
        }
    }
}