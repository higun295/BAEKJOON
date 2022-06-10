using System;

namespace _1629
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long A = long.Parse(input[0]);
            long B = long.Parse(input[1]);
            long C = long.Parse(input[2]);

            Console.WriteLine(Power(A, B, C));
        }

        static long Power (long a, long b, long c)
        {
            if (b == 1)
                return a % c;

            long val = Power(a, b / 2, c);
            val = val * val % c;

            if (b % 2 == 0)
                return val;

            return val * a % c;
        }
    }
}
