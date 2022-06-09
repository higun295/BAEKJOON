using System;
using System.Collections.Generic;
using System.IO;

namespace _2178
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = sr.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            string[] board = new string[N + 1];
            for (int i = 1; i < N + 1; i++)
                board[i] = sr.ReadLine();

            //           상 하 좌 우
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };
            int[,] dest = new int[N + 1, M + 1];

            for (int i = 1; i < N + 1; i++)
                for (int j = 1; j < M + 1; j++)
                    dest[i, j] = -1;

            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(1, 1));
            dest[1, 1] = 0;

            while (queue.Count != 0)
            {
                Tuple<int, int> current = queue.Dequeue();
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = current.Item1 + dx[dir];
                    int ny = current.Item2 + dy[dir];

                    if (nx < 1 || nx > N || ny < 1 || ny > M)
                        continue;
                    if (dest[nx, ny] >= 0 || board[nx][ny - 1] != '1')
                        continue;

                    dest[nx, ny] = dest[current.Item1, current.Item2] + 1;
                    queue.Enqueue(new Tuple<int, int>(nx, ny));
                }
            }

            sw.Write(dest[N, M] + 1);
            sw.Close();
            sr.Close();
        }
    }
}