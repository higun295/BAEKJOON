using System;

namespace SortingEx_03
{
    class Program
    {
        // 퀵정렬
        // 정렬 알고리즘 23:30
        static void QuickSort (int[] array, int start, int end)
        {
            if (start >= end) // 원소가 1개인 경우에는 종료
                return;

            int pivot = start; // 피벗은 첫 번째 원소
            int left = start + 1;
            int right = end;

            // 엇갈릴 때까지 계속 반복하는 것
            while (left <= right)
            {
                // 왼쪽 : 피벗보다 큰 데이터를 찾을 때까지 반복
                while (left <= end && array[left] <= array[pivot])
                    left++;

                // 오른쪽 : 피벗보다 작은 데이터를 찾을 때까지 반복
                while (right > start && array[right] >= array[pivot])
                    right--;

                // 엇갈렸으면 작은 데이터와 피벗을 교체
                if (left > right)
                {
                    int temp = array[right];
                    array[right] = array[pivot];
                    array[pivot] = temp;
                }
                // 엇갈리지 않았으면 작은 데이터와 큰 데이터를 교체
                else
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }

                // 분할 이후 왼쪽 부분과 오른쪽 부분에서 각각 정렬 수행
                QuickSort(array, start, right - 1);
                QuickSort(array, right + 1, end);
            }
        }

        static void Main (string[] args)
        {
            int n = 10;
            int[] array = { 7, 5, 9, 0, 3, 1, 6, 2, 4, 8 };

            QuickSort(array, 0, n - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}