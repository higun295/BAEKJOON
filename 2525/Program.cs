using System;

namespace _2525
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            int input2 = int.Parse(Console.ReadLine());
            int totalMinutes = 60 * A + B;
            int result = totalMinutes + input2;

            A = result / 60;
            B = result % 60;

            if (A >= 24)
                A -= 24;

            Console.WriteLine($"{A} {B}");
        }
    }
}