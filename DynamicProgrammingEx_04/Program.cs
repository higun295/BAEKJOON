using System;
using System.Linq;

namespace DynamicProgrammingEx_04
{
    class Program
    {
        // 개미 전사 문제 풀기
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine()); // 식량 창고의 개수 N

            string[] input = Console.ReadLine().Split(' ');
            int[] warehouses = new int[N];

            // 각 식량창고에 저장된 식량의 개수 K를 배열에 저장
            for (int i = 0; i < N; i++)
            {
                warehouses[i] = Convert.ToInt32(input[i]);
            }

            int[] d = new int[100];

            d[0] = warehouses[0];
            d[1] = Math.Max(warehouses[0], warehouses[1]);

            for (int i = 2; i < warehouses.Length; i++)
            {
                d[i] = Math.Max(d[i - 1], d[i - 2] + warehouses[i]);
            }

            Console.WriteLine(d[N - 1]);
        }
    }
}