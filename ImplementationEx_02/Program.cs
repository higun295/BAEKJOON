using System;

namespace ImplementationEx_02
{
    class Program
    {
        static bool Check (int hours, int minutes, int seconds)
        {
            if (hours % 10 == 3 ||
                minutes / 10 == 3 || minutes % 10 == 3 ||
                seconds / 10 == 3 || seconds % 10 == 3)
                return true;
            return false;
        }

        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    for (int k = 0; k < 60; k++)
                    {
                        if (Check(i, j, k)) result++;
                    }
                }
            }

            Console.WriteLine(result);

            //int N = Convert.ToInt32(Console.ReadLine());
            //int totalSeconds = N * 3600 + 59 * 60 + 60;

            //int result = 0; // 3을 포함하는 시각의 수를 저장

            //for (int i = 0; i <= totalSeconds; i++)
            //{
            //    if (i < 60)
            //    {
            //        if (i.ToString().Contains('3'))
            //            result++;
            //    }
            //    else
            //    {
            //        int minutes = i / 60;
            //        int seconds = i % 60;

            //        if (minutes < 60)
            //        {
            //            if (minutes.ToString().Contains('3') || 
            //                seconds.ToString().Contains('3'))
            //                result++;
            //        }
            //        else
            //        {
            //            int hours = minutes / 60;
            //            minutes = minutes % 60;

            //            if (hours.ToString().Contains('3') ||
            //                minutes.ToString().Contains('3') ||
            //                seconds.ToString().Contains('3'))
            //                result++;
            //        }
            //    }
            //}

            //Console.WriteLine(result);
        }
    }
}