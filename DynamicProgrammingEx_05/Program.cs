using System;

namespace DynamicProgrammingEx_05
{
    class Program
    {
        static void Main (string[] args)
        {
            // 정수 X를 입력받는다.
            int X = Convert.ToInt32(Console.ReadLine());

            // 앞서 계산된 결과를 저장하기 위한 DP 테이블 초기화
            // X의 범위가 1이상 3만 이하라고 했기 때문에 이렇게 선언
            int[] d = new int[30001];

            // Dynamic Programming 진행(Bottom Up 방식)
            for (int i = 2; i < X + 1; i++)
            {
                // 현재 수에서 1을 빼는 경우
                d[i] = d[i - 1] + 1;
                
                // 현재의 수가 2로 나누어 떨어지는 경우
                if (i % 2 == 0)
                    d[i] = Math.Min(d[i], d[i / 2] + 1);

                // 현재의 수가 3으로 나누어 떨어지는 경우
                if (i % 2 == 0)
                    d[i] = Math.Min(d[i], d[i / 3] + 1);

                // 현재의 수가 5로 나누어 떨어지는 경우
                if (i % 2 == 0)
                    d[i] = Math.Min(d[i], d[i / 5] + 1); 
            }

            Console.WriteLine(d[X]);
        }
    }
}