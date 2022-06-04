using System;

namespace _1476
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int year = 0;
            while (true)
            {
                year++;

                if ((year - input[0]) % 15 == 0 &&
                    (year - input[1]) % 28 == 0 &&
                    (year - input[2]) % 19 == 0) break;
            }

            Console.WriteLine(year);
        }
    }
}