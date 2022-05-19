using System;
using System.Diagnostics;

namespace OnlyForTest
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            // 테스트1. 오름차순 정렬 후에 반대로 뒤집기
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = new Random().Next(0, N);
            }

            Array.Sort(A);
            Array.Reverse(A);

            Console.WriteLine($"Sort and reverse : {sw.ElapsedMilliseconds}");
            sw.Stop();


            // 테스트2. 정렬할 때 Comparison 이라는 대리자를 사용해서 정렬하기

            sw.Start();

            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                B[i] = new Random().Next(0, N);
            }

            Array.Sort(B, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            Console.WriteLine($"Sort with comparison : {sw.ElapsedMilliseconds}");
            sw.Stop();
        }
    }
}