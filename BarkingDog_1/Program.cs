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
            //int[] arr = { 4, 13, 63, 87 };
            //Console.WriteLine(Ex02(arr, 4));
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