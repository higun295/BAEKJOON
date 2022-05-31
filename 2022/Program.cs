using System;

namespace _2022
{
    class Program
    {
        static double x, y, c;

        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            x = double.Parse(input[0]); // 왼쪽 사다리 길이 x
            y = double.Parse(input[1]); // 오른쪽 사다리 길이 y
            c = double.Parse(input[2]); // 두 사다리가 교차되는 지점의 지면으로부터의 높이

            double start = 0;
            double end = 3000000000;
            double result = 0;

            while (end - start > 0.000001)
            {
                double mid = (start + end) / 2;

                if (Function(mid) >= c)
                {
                    result = mid; // 일단 주어진 조건은 만족하니까 result에 넣고 mid 값을 키운다.
                    start = mid;
                }
                else
                    end = mid; // mid 값을 줄이면서 탐색한다.
            }

            double realResult = Math.Round(result, 3);
            Console.WriteLine(realResult);
        }

        static double Function (double mid)
        {
            double h1 = Math.Sqrt(Math.Pow(x, 2) - Math.Pow(mid, 2));
            double h2 = Math.Sqrt(Math.Pow(y, 2) - Math.Pow(mid, 2));

            return (h1 * h2) / (h1 + h2);
        }
    }
}
