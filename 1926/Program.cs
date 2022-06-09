using System;
using System.Collections.Generic;
using System.IO;

namespace _1926
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

            int[,] board = new int[N + 1, M + 1];
            bool[,] visit = new bool[N + 1, M + 1];

            for (int i = 1; i < N + 1; i++)
            {
                string[] input2 = sr.ReadLine().Split(' ');
                for (int j = 1; j < M + 1; j++)
                    board[i, j] = int.Parse(input2[j - 1]);
            }

            //           상 하 좌 우
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            int max = 0;
            int count = 0;

            for (int i = 1; i < N + 1; i++)
            {
                for (int j = 1; j < M + 1; j++)
                {
                    if (board[i, j] == 0 || visit[i, j] == true)
                        continue;

                    count++;
                    Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
                    queue.Enqueue(new Tuple<int, int>(i, j));
                    visit[i, j] = true;

                    int area = 0;
                    while (queue.Count != 0)
                    {
                        area++;
                        Tuple<int, int> cur = queue.Dequeue();
                        for (int k = 0; k < 4; k++)
                        {
                            int nx = cur.Item1 + dx[k];
                            int ny = cur.Item2 + dy[k];

                            if (nx < 1 || nx > N || ny < 1 || ny > M)
                                continue;

                            if (visit[nx, ny] == true || board[nx, ny] != 1)
                                continue;

                            visit[nx, ny] = true;
                            queue.Enqueue(new Tuple<int, int>(nx, ny));
                        }
                    }

                    max = Math.Max(max, area);
                }
            }

            sw.WriteLine(count);
            sw.WriteLine(max);
            sw.Close();
            sr.Close();
        }
    }
}