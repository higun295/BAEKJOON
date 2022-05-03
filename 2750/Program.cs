using System;

namespace _2750
{
    class Program
    {
        static void Main (string[] args)
        {
            // 수의 갯수(N)를 입력받는다.
            int input = Convert.ToInt32(Console.ReadLine());
            // 크기가 N인 배열을 생성한다.
            int[] array = new int[input];

            for (int i = 0; i < input; i++)
            {
                // 숫자를 배열에 넣는다.
                array[i] = i + 1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                
            }
        }
    }
}