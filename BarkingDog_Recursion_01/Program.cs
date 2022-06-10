using System;

namespace BarkingDog_Recursion_01
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("======= N부터 1까지 출력하기 =======");
            Recursion_01(N);

            Console.WriteLine("======= 1부터 N까지 합 구하기 =======");
            Console.WriteLine(Recursion_02(N));
        }

        static void Recursion_01 (int N)
        {
            if (N < 1)
                return;

            Console.WriteLine(N);
            Recursion_01(N - 1);
        }

        static int Recursion_02 (int N)
        {
            if (N < 1)
                return 0;

            return N + Recursion_02(N - 1);
        }
    }
}