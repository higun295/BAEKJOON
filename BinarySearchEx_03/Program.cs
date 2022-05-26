using System;

namespace BinarySearchEx_03
{
    class Program
    {
        static int CountByRange (int[] array, int leftValue, int rightValue)
        {
            int rightIndex = array.GetUpperBound(rightValue);
            int leftIndex = array.GetLowerBound(leftValue);
            return rightIndex - leftIndex;
        }

        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int N = Convert.ToInt32(input[0]); // N의 값을 저장합니다.
            int x = Convert.ToInt32(input[1]); // x의 값을 저장합니다.

            // 크기가 N인 배열을 선언한다.
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] array = new int[N];
            
            // 입력 받은 수열을 배열에 집어 넣는다.
            for (int i = 0; i < N; i++)
            {
                array[i] = Convert.ToInt32(inputArray[i]);
            }

            int count = CountByRange(array, x, x);

            if (count == 0) Console.WriteLine(-1);
            else Console.WriteLine(count);
        }
    }
}