using System;

namespace _4375
{
    class Program
    {
        static void Main (string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                    break;

                if (int.TryParse(input, out int divisor))
                {
                    int dividend = 1;
                    int cnt = 1;
                    while (true)
                    {
                        dividend %= divisor;
                        if (dividend == 0)
                        {
                            Console.WriteLine(cnt);
                            break;
                        }

                        dividend = (dividend * 10) + 1;
                        cnt++;
                    }
                }
                else break;
            }
        }
    }
}