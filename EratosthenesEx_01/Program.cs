using System;

namespace EratosthenesEx_01
{
    class Program
    {
        public static int n = 1000; // 2부터 1000까지의 모든 수에 대하여 소수 판별
        public static bool[] arr = new bool[n + 1];

        // 에라토스테네스의 체 알고리즘
        static void Main (string[] args)
        {
            // 처음엔 모든 수가 소수(true)인 것으로 초기화(0과 1은 제외)
            Array.Fill(arr, true);
            // 에라토스테네스의 체 알고리즘 수행
            // 2부터 n의 제곱근까지의 모든 수를 확인하며
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (arr[i] == true)
                {
                    // i가 소수인 경우 i를 제외한 모든 i의 배수 지우기
                    int j = 2;
                    while (i * j <= n)
                    {
                        arr[i * j] = false;
                        j++;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                // 모든 소수 출력
                if (arr[i] == true)
                    Console.WriteLine(i + " ");
            }
        }
    }
}
