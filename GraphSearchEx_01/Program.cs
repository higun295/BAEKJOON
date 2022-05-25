using System;

namespace GraphSearchEx_01
{
    class Program
    {
        public static int N, M;
        public static int[,] graph = new int[1000, 1000];

        //public static bool DFS ()
        //{

        //}

        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(input[0]);
            int M = Convert.ToInt32(input[1]);

            for (int i = 0; i < N; i++)
            {
                char[] inputArray = Console.ReadLine().ToCharArray();
                
                for (int j = 0; j < M; j++)
                {
                    graph[i, j] = inputArray[j] - '0';
                }
            }
        }
    }
}