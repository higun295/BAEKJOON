﻿using System;
using System.IO;

namespace _15651
{
    class Program
    {
        public static int N, M;
        public static int[] array;
        public static bool[] isUsed;
        public static StreamWriter sw;

        static void Main (string[] args)
        {
            sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = Console.ReadLine().Split(' ');
            N = int.Parse(input[0]);
            M = int.Parse(input[1]);

            isUsed = new bool[N + 1];
            array = new int[M + 1];

            Recursion(0);
            sw.Close();
        }

        static void Recursion (int index)
        {
            if (index == M)
            {
                for (int i = 0; i < M; i++)
                    sw.Write(array[i] + " ");

                sw.Write("\n");
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                isUsed[i] = true;
                array[index] = i;
                Recursion(index + 1);
                isUsed[i] = false;
            }
        }
    }
}