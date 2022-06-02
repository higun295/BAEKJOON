using System;
using System.Text;

namespace _17425
{
    class Program
    {
        static void Main (string[] args)
        {
            int MAX = 1000000;
            int T = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            long[] fx = new long[MAX + 1]; // 해당 자연수의 모든 약수를 더한 변수
            long[] dp = new long[MAX + 1]; // 해당 자연수 이하의 모든 fx를 더한 변수

            Array.Fill(fx, 1); // 1은 모든 자연수의 약수이기 때문에 미리 넣어놓는다.

            for (int i = 2; i < MAX + 1; i++)
            {
                for (int j = 1; i * j < MAX + 1; j++)
                {
                    fx[i * j] += i;
                }
            }

            for (int i = 1; i < MAX + 1; i++)
            {
                dp[i] += dp[i - 1] + fx[i];
            }

            while (T-- > 0)
            {
                int input = int.Parse(Console.ReadLine());
                sb.Append(dp[input]).Append("\n");
            }

            Console.WriteLine(sb);
        }
    }
}