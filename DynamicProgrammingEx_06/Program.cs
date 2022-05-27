using System;

namespace DynamicProgrammingEx_06
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(input[0]); // 화폐의 종류 N
            int M = Convert.ToInt32(input[1]); // 가치의 합   M

            int[] valueArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                // N 종류의 화폐 배열에 저장
                valueArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // 한 번 계산된 결과를 저장하기 위한 DP 테이블 초기화
            int[] d = new int[M + 1];
            Array.Fill(d, 10001);

            // Dynamic Programming 진행(Bottom Up)
            d[0] = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = valueArray[i]; j < M + 1; j++)
                {
                    // (i - k) 원을 만드는 방법이 존재하는 경우
                    if (d[j - valueArray[i]] != 10001)
                    {
                        d[j] = Math.Min(d[j], d[j - valueArray[i]] + 1);
                    }
                }
            }

            if (d[M] == 10001) Console.WriteLine(-1);
            else Console.WriteLine(d[M]);
        }
    }
}
