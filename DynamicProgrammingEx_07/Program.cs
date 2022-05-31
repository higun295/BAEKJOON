using System;

namespace DynamicProgrammingEx_07
{
    class Program
    {
        // <문제> 금광
        // 다이나믹 프로그래밍 52:32
        static void Main (string[] args)
        {
            int T = int.Parse(Console.ReadLine()); // 테스트 케이스 T

            for (int test = 0; test < T; test++) // 테스트케이스 T만큼 반복
            {
                string[] input = Console.ReadLine().Split(' ');
                int N = int.Parse(input[0]); // 금광 행 크기 N
                int M = int.Parse(input[1]); // 금광 열 크기 M

                int[,] array = new int[N, M]; // N * M 크기의 금광 
                string[] input2 = Console.ReadLine().Split(' ');
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        array[i, j] = int.Parse(input2[M * i + j]);
                    }
                }

                // Dynamic Programming 진행(BottomUp 방식)
                for (int j = 0; j < M; j++)
                {
                    for (int i = 0; i < N; i++)
                    {
                        int leftUp = 0;
                        int left = 0;
                        int leftDown = 0;

                        // 왼쪽 위에서 오는 경우
                        if (i == 0) leftUp = 0; // 범위를 벗어나는 경우 제외
                        else
                            leftUp = array[i - 1, j - 1];

                        // 왼쪽 아래에서 오는 경우
                        if (i == N - 1) leftDown = 0; // 범위를 벗어나는 경우 제외
                        else
                            leftDown = array[i + 1, j - 1];

                        // 왼쪽에서 오는 경우
                        left = array[i, j - 1];

                        array[i, j] += Math.Max(leftUp, Math.Max(leftDown, left));
                    }
                }

                int result = 0; // 채굴할 수 있는 금의 최대 크기
                for (int i = 0; i < N; i++)
                {
                    result = Math.Max(result, array[i, M - 1]);
                }

                Console.WriteLine(result);
            }
        }
    }
}