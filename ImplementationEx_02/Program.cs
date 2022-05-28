using System;

namespace ImplementationEx_02
{
    class Program
    {
        // <문제> 시각
        // 그리디 & 구현 41:24
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int result = 0; // 3이 포함되는 경우의 수
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    for (int k = 0; k < 60; k++)
                    {
                        if (Check(i, j, k) == true) result++;
                    }
                }
            }

            Console.WriteLine(result);
        }

        static bool Check (int hour, int minute, int second)
        {
            if (hour % 10 == 3 ||
                minute / 10 == 3 || minute % 10 == 3 ||
                second / 10 == 3 || second % 10 == 3)
                return true;

            return false;
        }
    }
}