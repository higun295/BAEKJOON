using System;
using System.IO;

namespace _11729
{
    class Program
    {
        static StreamWriter sw;
        static void Main (string[] args)
        {
            sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int N = int.Parse(Console.ReadLine());

            sw.WriteLine((1 << N) - 1);
            Function(1, 3, N);
            sw.Close();
        }

        static void Function (int a, int b, int n)
        {
            if (n == 1)
            {
                sw.WriteLine($"{a} {b}");
                return;
            }

            Function(a, 6 - a - b, n - 1);
            sw.WriteLine($"{a} {b}");
            Function(6 - a - b, b, n - 1);
        }
    }
}