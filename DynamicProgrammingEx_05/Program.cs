using System;

namespace DynamicProgrammingEx_05
{
    class Program
    {
        // <문제> 1로 만들기
        // 다이나믹 프로그래밍 36:10
        static void Main (string[] args)
        {
            int X = int.Parse(Console.ReadLine()); // 1로 만들기 위해 주어진 정수 X

            int[] d = new int[30001]; // 1부터 3만까지 가능하기 때문에 이렇게 설정
            for (int i = 2; i < X + 1; i++)
            {
                // 현재의 수에서 1을 빼는 경우
                d[i] = d[i - 1] + 1;
                // 현재의 수가 2로 나누어 떨어지는 경우
                if (i % 2 == 0)
                    d[i] = Math.Min(d[i], d[i / 2] + 1);
                // 현재의 수가 3으로 나누어 떨어지는 경우
                if (i % 3 == 0)
                    d[i] = Math.Min(d[i], d[i / 3] + 1);
                // 현재의 수가 5로 나누어 떨어지는 경우
                if (i % 5 == 0)
                    d[i] = Math.Min(d[i], d[i / 5] + 1);
            }

            Console.WriteLine(d[X]);
        }
    }
}