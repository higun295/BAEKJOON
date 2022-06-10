using System;

namespace _1074
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int R = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            Console.WriteLine(Function(N, R, C));
        }

        static int Function (int n, int r, int c)
        {
            if (n == 0)
                return 0;

            int half = 1 << (n - 1);

            if (r < half && c < half)
                return Function(n - 1, r, c);
            if (r < half && c >= half)
                return half * half + Function(n - 1, r, c - half);
            if (r >= half && c < half)
                return 2 * half * half + Function(n - 1, r - half, c);

            return 3 * half * half + Function(n - 1, r - half, c - half);
        }
    }
}