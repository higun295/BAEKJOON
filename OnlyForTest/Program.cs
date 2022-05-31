using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OnlyForTest
{
    class Program
    {
        static void Main (string[] args)
        {
            //// 선택정렬과 기본 linq의 sort 시간 비교
            //int[] array = new int[1000000];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Random rnd = new Random();
            //    array[i] = rnd.Next(1, 1000000);
            //}

            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            //// 선택정렬
            //int[] testArray1 = array;
            //for (int i = 0; i < testArray1.Length; i++)
            //{
            //    int minIndex = i;
            //    for (int j = i + 1; j < testArray1.Length; j++)
            //    {
            //        if (testArray1[minIndex] > array[j])
            //            minIndex = j;
            //    }

            //    int temp = testArray1[minIndex];
            //    testArray1[minIndex] = testArray1[i];
            //    testArray1[i] = temp;
            //}

            //sw.Stop();
            //Console.WriteLine($"{sw.ElapsedMilliseconds}ms");
            //sw.Reset();


            //sw.Start();
            //// 기본 Sort
            //int[] testArray2 = array.OrderBy(x => x).ToArray();
            //sw.Stop();
            //Console.WriteLine($"{sw.ElapsedMilliseconds}ms");

            // 재귀함수
            //Function(1);

            // 재귀함수를 이용한 팩토리얼
            //Console.WriteLine("팩토리얼 값을 구할 숫자를 입력하세요.");
            //int readValue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"상수 {readValue}에 대한 팩토리얼 값 : {RecursiveFactorial(readValue)}");

            // 유클리드 호제법
            //int gcd = GreatestCommonDivisor(192, 162);
            //Console.WriteLine(gcd);


            // String, StringBuilder 테스트
            //Stopwatch sw = new Stopwatch();
            //string input = Console.ReadLine();

            //sw.Start();

            //for (int i = 0; i < 10000; i++)
            //{
            //    Console.WriteLine($"{i} : {input}");
            //}

            //sw.Stop();
            //long stringTime = sw.ElapsedMilliseconds;
            //Console.WriteLine($"{stringTime}ms");
            //sw.Reset();

            //sw.Start();
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < 10000; i++)
            //{
            //    sb.AppendLine($"{i} : {input}");
            //}
            //Console.Write(sb.ToString());

            //sw.Stop();
            //long stringBuilderTime = sw.ElapsedMilliseconds;
            //Console.WriteLine($"{stringBuilderTime}ms");
            //sw.Reset();

            //Console.WriteLine($"StringBuilder가 String보다 약 {stringTime / stringBuilderTime}배 정도 빠릅니다.");
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