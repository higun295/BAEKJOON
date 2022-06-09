using System;
using System.Collections.Generic;
using System.IO;

namespace _7576
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            string[] input = sr.ReadLine().Split(' ');

            int N = int.Parse(input[1]); // 세로(행)
            int M = int.Parse(input[0]); // 가로(열)
            int[,] board = new int[N + 1, M + 1];
            int[,] dist = new int[N + 1, M + 1];

            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            for (int i = 1; i < N + 1; i++)
            {
                string[] input2 = sr.ReadLine().Split(' ');
                for (int j = 1; j < M + 1; j++)
                {
                    board[i, j] = int.Parse(input2[j - 1]);

                    if (board[i, j] == 1)
                        queue.Enqueue(new Tuple<int, int>(i, j));

                    if (board[i, j] == 0)
                        dist[i, j] = -1;
                }
            }

            //           상 하 좌 우
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            while (queue.Count != 0)
            {
                Tuple<int, int> current = queue.Dequeue();
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = current.Item1 + dx[dir];
                    int ny = current.Item2 + dy[dir];

                    if (nx < 1 || nx > N || ny < 1 || ny > M)
                        continue;
                    if (dist[nx, ny] >= 0)
                        continue;

                    dist[nx, ny] = dist[current.Item1, current.Item2] + 1;
                    queue.Enqueue(new Tuple<int, int>(nx, ny));
                }
            }

            int ans = 0;
            for (int i = 1; i < N + 1; i++)
            {
                for (int j = 1; j < M + 1; j++)
                {
                    if (dist[i, j] == -1)
                    {
                        sw.WriteLine("-1");
                        sw.Close();
                        sr.Close();
                        return;
                    }

                    ans = Math.Max(ans, dist[i, j]);
                }
            }

            sw.WriteLine(ans);
            sw.Close();
            sr.Close();
        }
    }
}