using System;
using System.Collections.Generic;

namespace _1021
{
    class Program
    {
        static void Main (string[] args)
        {
            LinkedList<int> deque = new LinkedList<int>();
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            for (int i = 1; i <= N; i++)
                deque.AddLast(i);

            int result = 0;
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < array.Length; i++)
            {
                // 입력된 배열의 값과 덱의 값이 다르면
                // 이동을 시킨다.
                while (array[i] != deque.First.Value)
                {
                }

                // 입력된 배열의 값과 덱의 값이 같으면
                // 첫번째 원소를 뽑아낸다.
                deque.RemoveFirst();
            }

            Console.Write(result);
        }
    }
}