using System;

namespace _1026
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N];
            string[] input_A = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt32(input_A[i]);
            }

            int[] B = new int[N];
            string[] input_B = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = Convert.ToInt32(input_B[i]);
            }

            Array.Sort(A);
            Array.Sort<int>(B, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            int result = 0; // 결과값
            for (int i = 0; i < N; i++)
            {
                result += A[i] * B[i];
            }

            Console.WriteLine(result);
        }
    }
}
