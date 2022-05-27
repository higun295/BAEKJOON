using System;

namespace DynamicProgrammingEx_07
{
    class Program
    {
        static void Main (string[] args)
        {
            // 테스트 케이스의 값을 받는다.
            int T = Convert.ToInt32(Console.ReadLine());

            for (int tc = 0; tc < T; tc++)
            {
                // 금광의 행과 열에 관한 사용자 입력 데이터
                string[] input = Console.ReadLine().Split(' ');

                int N = Convert.ToInt32(input[0]); // N 행
                int M = Convert.ToInt32(input[1]); // M 열

                // 금광의 금 매장량에 대한 사용자 입력 데이터
                string[] input2 = Console.ReadLine().Split(' ');

                // 금광 관련된 2차원 배열 초기화
                int[,] mine = new int[N, M];
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < M; k++)
                    {
                        mine[j, k] = Convert.ToInt32(input2[M * j + k]);
                    }
                }

                // Dynamic Programming 진행
                for (int j = 0; j < M; j++)
                {
                    for (int i = 0; i < N; i++)
                    {
                        int leftUp, leftDown, left = 0;

                        // 왼쪽 위에서 오는 경우
                        if (i == 0) leftUp = 0;
                        else leftUp = mine[i - 1, j - 1];
                        // 왼쪽 아래에서 오는 경우
                        if (i == N - 1) leftDown = 0;
                        else leftDown = mine[i + 1, j - 1];
                        // 왼쪽에서 오는 경우
                        left = mine[i, j - 1];

                        mine[i, j] = mine[i, j] + Math.Max(leftUp, Math.Max(leftDown, left));
                    }
                }

                int result = 0;
                for (int i = 0; i < N; i++)
                {
                    result = Math.Max(result, mine[i, M - 1]);
                }

                Console.WriteLine(result);
            }
        }
    }
}