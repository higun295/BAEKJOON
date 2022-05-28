using System;

namespace GreedyEx_00
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] money = { 500, 100, 50, 10 };
            int N = Convert.ToInt32(Console.ReadLine()); // 거슬러 주어야 할 돈 N

            int result = 0; // 거슬러 주는데 필요한 동전 개수의 총합
            for (int i = 0; i < money.Length; i++)
            {
                result += N / money[i]; // 거슬러 준 동전의 개수 더하기
                N = N % money[i];
            }

            Console.WriteLine(result);
        }
    }
}