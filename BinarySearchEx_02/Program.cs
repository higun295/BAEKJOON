using System;
using System.Linq;

namespace BinarySearchEx_02
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int N = Convert.ToInt32(input[0]); // 떡의 개수 N
            int M = Convert.ToInt32(input[1]); // 요청한 떡의 길이 M

            string[] heightInput = Console.ReadLine().Split(' ');
            int[] heightArray = new int[N];

            // 떡의 개별 높이가 주어진다.
            for (int i = 0; i < N; i++)
            {
                heightArray[i] = Convert.ToInt32(heightInput[i]);
            }

            // 떡의 개별 높이 배열을 오름차순으로 재정렬한다.
            int[] ascendingHeightArray = heightArray.OrderBy(x => x).ToArray();

            // 이진 탐색을 위한 시작점과 끝점 설정
            int start = 0;
            int end = 1000000000; // 끝점을 10억으로 설정하더라도 이진 탐색 과정에서 조율이 되기 때문에 최적의 해를 찾는데 문제 없다.

            // 이진 탐색 수행
            int result = 0;
            while (start <= end)
            {
                int total = 0;
                int mid = (start + end) / 2;

                for (int i = 0; i < N; i++)
                {
                    // 잘랐을 때 떡의 양 계산
                    if (ascendingHeightArray[i] > mid)
                        total += ascendingHeightArray[i] - mid;
                }
                // 떡의 양이 요청한 양보다 작으면 더 많이 자른다(높이를 낮춘다.)
                if (total < M)
                {
                    end = mid - 1;
                }
                // 떡의 양이 요청한 양보다 크거나 같으면 덜 자른다(높이를 높인다.)
                else
                {
                    result = mid;
                    start = mid + 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}