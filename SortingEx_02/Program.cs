using System;

namespace SortingEx_02
{
    class Program
    {
        // 삽입정렬
        // 정렬 알고리즘 11:02
        static void Main (string[] args)
        {
            int[] array = { 7, 5, 9, 0, 3, 1, 6, 2, 4, 8 };

            // 두번째 원소부터 시작!!
            for (int i = 1; i < array.Length; i++) 
            {
                // 왼쪽으로 이동해 나가면서
                for (int j = i; j > 0; j--)
                {
                    // 현재 위치의 원소와 왼쪽에 있는 원소의 크기를 비교해서
                    // 현재 위치의 원소가 더 작으면 자리 교체
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                    // 현재 위치의 원소가 더 크면 STOP
                    else break;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}