using System;

namespace _12094
{
    class Program
    {
        static void Main (string[] args)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();

            while (S.Length != T.Length)
            {
                if (T.EndsWith('A'))
                {
                    T = T.Remove(T.Length - 1, 1);
                }
                else if (T.EndsWith('B'))
                {
                    T = T.Remove(T.Length - 1, 1);
                    T = Reverse(T);
                }
            }

            if (S.Equals(T)) Console.WriteLine(1);
            else Console.WriteLine(0);
        }

        static string Reverse(string source)
        {
            string result = string.Empty;

            char[] tempArray = source.ToCharArray();
            Array.Reverse(tempArray);
            for (int i = 0; i < tempArray.Length; i++)
            {
                result += tempArray[i];
            }

            return result;
        }
    }
}