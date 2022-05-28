using System;

namespace ImplementationEx_01
{
    class Program
    {
        // <문제> 상하좌우
        // 그리디 & 구현 35:23
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine()); // 공간의 크기를 나타내는 N
            string[] input = Console.ReadLine().Split(' '); // 이동할 계획서

            ////////// 동, 서, 남, 북
            int[] dx = { 0, 0, 1, -1 };
            int[] dy = { 1, -1, 0, 0 };
            char[] directions = { 'R', 'L', 'D', 'U' };

            int x = 1, y = 1; // 현재 위치 초기화
            for (int i = 0; i < input.Length; i++)
            {
                int nx = 0, ny = 0; // 새로운 위치
                for (int j = 0; j < 4; j++)
                {
                    if (input[i] == directions[j].ToString())
                    {
                        nx = x + dx[j];
                        ny = y + dy[j];
                    }
                }

                if (nx > N || nx < 1 || ny > N || ny < 1) 
                    continue;

                x = nx;
                y = ny;
            }

            Console.WriteLine($"{x} {y}");
        }
    }
}