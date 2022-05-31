using System;

namespace DynamicProgrammingEx_04
{
    class Program
    {
        // <문제> 개미 전사
        // 다이나믹 프로그래밍 26:49
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // 식량 창고의 개수 N

            int[] array = new int[N]; // 식량창고에 저장된 식량의 개수를 저장하는 배열
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int[] d = new int[100]; // index : 0부터 99까지
            d[0] = array[0];
            d[1] = Math.Max(array[0], array[1]);

            for (int i = 2; i < N; i++)
                d[i] = Math.Max(d[i - 1], d[i - 2] + array[i]);

            Console.WriteLine(d[N - 1]);
        }
    }
}