using System;

namespace ImplementationEx_03
{
    class Program
    {
        // <문제> 왕실의 나이트
        // 그리디 & 구현 47:01
        static void Main (string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            int currentY = Convert.ToInt32(input[0] - 'a' + 1); // 위치를 나타내는 열
            int currentX = Convert.ToInt32(input[1] - '0'); // 위치를 나타내는 행
            int[] dy = { 2, 2, -2, -2, 1, -1, 1, -1 }; // 열방향 8가지 이동
            int[] dx = { 1, -1, 1, -1, 2, 2, -2, -2 }; // 행방향 8가지 이동

            int result = 0; // 나이트가 이동할 수 있는 경우의 수
            for (int i = 0; i < 8; i++)
            {
                int nx = currentX + dx[i];
                int ny = currentY + dy[i];

                // if (nx >= 1 && nx <= 8 && ny >= 1 && ny <= 8)
                // 이렇게도 사용 가능
                if (nx < 1 || nx > 8 || ny < 1 || ny > 8) 
                    continue;

                result++;
            }

            Console.WriteLine(result);
        }
    }
}