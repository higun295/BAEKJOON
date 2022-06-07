using System;

namespace BarkingDog_1
{
    class Program
    {
        static void Main (string[] args)
        {
            // 시간복잡도 O(N)
            //Ex01();

            // 시간복잡도 O(N^2)
            // (N - 1) + (N - 2) + ... + 3 + 2 + 1 = (N^2 - N) / 2
            //int[] arr = { 4, 13, 63, 87 };
            //Console.WriteLine(Ex02(arr, 4));

            // 시간복잡도 O(Sqrt(N))
            //Console.WriteLine(Ex03(756580036));

            // 시간복잡도 O(logN)
            //Console.WriteLine(Ex04(1024));

            int[] arr = { 1, 2, 3 };
            Function(arr);
        }

        static void Function (int[] arr)
        {
            arr[0] = 10;
        }

        static int Ex04 (int N)
        {
            int val = 1;

            while (2 * val <= N)
            {
                val *= 2;
            }

            return val;
        }

        static int Ex03 (int N)
        {
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (i * i == N)
                    return 1;
            }

            return 0;
        }

        static int Ex02 (int[] arr, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (arr[i] + arr[j] == 100)
                        return 1;
                }
            }

            return 0;
        }

        static void Ex01 ()
        {
            int N = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine(result);
        }
    }
}