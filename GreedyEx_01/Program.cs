using System;

namespace GreedyEx_01
{
    class Program
    {
        // <문제> 1이 될 때까지
        // 그리디 & 구현 12:41
        static void Main (string[] args)
        {
            //string[] input = Console.ReadLine().Split(' ');
            //int N = Convert.ToInt32(input[0]); // 1로 만들어야하는 수 N
            //int K = Convert.ToInt32(input[1]); // N을 1로 만들기 위해 나누는 수 K

            //int result = 0; // 연산 횟수
            //while (N != 1)
            //{
            //    if (N % K == 0) N /= K; // 나누어 떨어지면 나눈다.
            //    else N--; // 나누어 떨어지지 않으면 1을 뺀다.
            //    result++;
            //}

            //Console.WriteLine(result);

            /* ==================================================================================================================================== 
             * 위는 내 코드
             * 아래는 해설 풀이 (이런 생각을 어떻게 하지...)
             * ==================================================================================================================================== 
             */

            string[] input = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(input[0]); // 1로 만들어야하는 수 N
            int K = Convert.ToInt32(input[1]); // N을 1로 만들기 위해 나누는 수 K

            int result = 0; // 연산 횟수

            while (true)
            {
                // N이 K로 나누어 떨어지는 수가 될 때까지 빼기
                int target = (N / K) * K;
                result += (N - target);
                N = target;

                // N이 K보다 작을 때 (더 이상 나눌 수 없을 때) 반복문 탈출
                if (N < K) break;

                // K로 나누기
                result += 1;
                N /= K;
            }

            // 마지막으로 남은 수에 대하여 1씩 빼기
            result += (N - 1);
            Console.WriteLine(result);
        }
    }
}