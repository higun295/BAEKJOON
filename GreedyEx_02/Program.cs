using System;

namespace GreedyEx_02
{
    class Program
    {
        // <문제> 곱하기 혹은 더하기
        // 그리디 & 구현 18:51
        static void Main (string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            int N = input.Length;

            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = Convert.ToInt32(input[i] - '0');
            }

            int result = array[0]; // 연산 결과를 저장하는 변수
            for (int i = 0; i < N - 1; i++)
            {
                if (array[i] <= 1 || result <= 1)
                    result += array[i + 1];
                else
                    result *= array[i + 1];
            }

            Console.WriteLine(result);

            /* ==================================================================================================================================== 
            * 위는 내 코드
            * 아래는 해설 풀이
            * ==================================================================================================================================== 
            */

            //string input = Console.ReadLine();

            //int result = input[0] - '0';
            //for (int i = 1; i < input.Length; i++)
            //{
            //    int num = input[i] - '0';
            //    if (num <= 1 || result <= 1)
            //        result += num;
            //    else
            //        result *= num;
            //}

            //Console.WriteLine(result);
        }
    }
}