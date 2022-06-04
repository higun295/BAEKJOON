using System;

namespace _3085
{
    class Program
    {
        static int N;
        static int[,] array;
        static int max_value;

        static void Main (string[] args)
        {
            N = int.Parse(Console.ReadLine()); // 보드의 크기 N
            array = new int[N, N]; // N의 크기에 맞게 2차원 배열을 생성한다.
            for (int i = 0; i < N; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < N; j++)
                {
                    // 문자보다 숫자로 계산하고 싶어서 이렇게 바꿈
                    array[i, j] = input[j] - 'A';
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (array[i, j] != array[i, j + 1])
                    {
                        Swap(ref array[i, j], ref array[i, j + 1]);
                        Check(array);
                        Swap(ref array[i, j], ref array[i, j + 1]);
                    }
                }
            }

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array[i, j] != array[i + 1, j])
                    {
                        Swap(ref array[i, j], ref array[i + 1, j]);
                        Check(array);
                        Swap(ref array[i, j], ref array[i + 1, j]);
                    }
                }
            }

            Console.WriteLine(max_value);
        }

        static void Check (int[,] array)
        {
            for (int i = 0; i < N; i++)
            {
                int count = 1;
                for (int j = 0; j < N - 1; j++)
                {
                    if (array[i, j] == array[i, j + 1])
                        count++;
                    else
                        count = 1;

                    max_value = Math.Max(max_value, count);
                }
            }

            for (int i = 0; i < N; i++)
            {
                int count = 1;
                for (int j = 0; j < N - 1; j++)
                {
                    if (array[j, i] == array[j + 1, i])
                        count++;
                    else
                        count = 1;

                    max_value = Math.Max(max_value, count);
                }
            }
        }

        static void Swap (ref int val1, ref int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }
}