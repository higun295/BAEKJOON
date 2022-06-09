using System;
using System.Collections.Generic;
using System.IO;

namespace _4179
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = sr.ReadLine().Split(' ');

            int R = int.Parse(input[0]);
            int C = int.Parse(input[1]);
            string[] board = new string[1002];
            int[,] fDist = new int[1002, 1002];
            int[,] jDist = new int[1002, 1002];

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    fDist[i, j] = -1;
                    jDist[i, j] = -1;
                }
            }

            Queue<Tuple<int, int>> fQueue = new Queue<Tuple<int, int>>();
            Queue<Tuple<int, int>> jQueue = new Queue<Tuple<int, int>>();
            for (int i = 0; i < R; i++)
            {
                string input2 = sr.ReadLine();
                board[i] = input2;

                for (int j = 0; j < C; j++)
                {
                    if (board[i][j] == 'F')
                    {
                        fQueue.Enqueue(new Tuple<int, int>(i, j));
                        fDist[i, j] = 0;
                    }

                    if (board[i][j] == 'J')
                    {
                        jQueue.Enqueue(new Tuple<int, int>(i, j));
                        jDist[i, j] = 0;
                    }
                }
            }

            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };
            while (fQueue.Count != 0)
            {
                Tuple<int, int> current = fQueue.Dequeue();
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = current.Item1 + dx[dir];
                    int ny = current.Item2 + dy[dir];

                    if (nx < 0 || nx >= R || ny < 0 || ny >= C)
                        continue;

                    if (board[nx][ny] == '#' || fDist[nx, ny] >= 0)
                        continue;

                    fDist[nx, ny] = fDist[current.Item1, current.Item2] + 1;
                    fQueue.Enqueue(new Tuple<int, int>(nx, ny));
                }
            }
            while (jQueue.Count != 0)
            {
                Tuple<int, int> current = jQueue.Dequeue();
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = current.Item1 + dx[dir];
                    int ny = current.Item2 + dy[dir];

                    if (nx < 0 || nx >= R || ny < 0 || ny >= C)
                    {
                        sw.WriteLine(jDist[current.Item1, current.Item2] + 1);
                        sw.Close();
                        sr.Close();
                        return;
                    }

                    if (jDist[nx, ny] >= 0 || board[nx][ny] == '#')
                        continue;

                    if (fDist[nx, ny] != -1 && fDist[nx, ny] <= jDist[current.Item1, current.Item2] + 1)
                        continue;

                    jDist[nx, ny] = jDist[current.Item1, current.Item2] + 1;
                    jQueue.Enqueue(new Tuple<int, int>(nx, ny));
                }
            }

            sw.WriteLine("IMPOSSIBLE");
            sw.Close();
            sr.Close();
        }
    }
}