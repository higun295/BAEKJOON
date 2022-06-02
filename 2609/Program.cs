using System;

namespace _2609
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            int gcd = GCD(A, B);
            int lcm = A * B / gcd;

            Console.WriteLine(gcd);
            Console.WriteLine(lcm);
        }

        static int GCD (int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;

                a = b;
                b = r;
            }

            return a;
        }
    }
}