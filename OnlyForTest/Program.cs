using System;
using System.Collections.Generic;

namespace OnlyForTest
{
    class Program
    {
        static void Main (string[] args)
        {
            // 재귀함수
            //Function(1);

            // 재귀함수를 이용한 팩토리얼
            //Console.WriteLine("팩토리얼 값을 구할 숫자를 입력하세요.");
            //int readValue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"상수 {readValue}에 대한 팩토리얼 값 : {RecursiveFactorial(readValue)}");

            // 유클리드 호제법
            int gcd = GreatestCommonDivisor(192, 162);
            Console.WriteLine(gcd);
        }

        static int GreatestCommonDivisor (int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return GreatestCommonDivisor(b, a % b);
        }

        static int RecursiveFactorial (int input)
        {
            if (input <= 1)
                return 1;
            else
                return input * RecursiveFactorial(input - 1);
        }

        static void Function (int i)
        {
            if (i == 100)
                return;
            Console.WriteLine($"{i} call => {i + 1}.");
            Function(i + 1);
            Console.WriteLine($"{i} terminated.");
        }
    }
}