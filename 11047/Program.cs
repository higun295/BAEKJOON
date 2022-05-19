using System;

namespace _11047
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = Convert.ToInt16(inputs[0]);
            int K = Convert.ToInt32(inputs[1]);

            int[] valueList = new int[N];
            for (int i = 0; i < N; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                valueList[i] = input;
            }

            // 이런 방법은 처음 써본다.
            Array.Sort<int>(valueList, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            int result = 0; // 동전 갯수
            int subSum = K; // 남은 계산 금액

            foreach (int item in valueList)
            {
                if (subSum == 0) break;
                if (subSum >= item)
                {
                    result += subSum / item;
                    subSum = subSum % item;
                }
            }

            Console.WriteLine(result);
        }
    }
}