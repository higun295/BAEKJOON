using System;

namespace GreedyEx_01
{
    class Program
    {
        static void Main (string[] args)
        {
            string input = Console.ReadLine();
            if (input.Contains(',') != true)
                return;

            string[] charArray = input.Split(',');
            int N = Convert.ToInt32(charArray[0]);
            int K = Convert.ToInt32(charArray[1]);
            int result = 0;

            while (N != 1)
            {
                result++;
                if (N % K == 0)
                    N /= K;
                else
                    N -= 1;
            }

            Console.WriteLine(result);
        }
    }
}