using System;

namespace BinarySearchEx_02
{
    class Program
    {
        // <문제> 떡볶이 떡 만들기
        // 이진 탐색 12:31
        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int N = int.Parse(input[0]); // 떡의 개수 N
            int M = int.Parse(input[1]); // 요청한 떡의 길이 M

            int[] array = new int[N]; // 떡의 개수 N 만큼의 배열 생성
            string[] input2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(input2[i]); // 입력 받은 순서대로 배열에 집어넣는다.
            }

            // 이진 탐색 적용을 위해서 배열 정렬을 해야겠음
            Array.Sort(array); // 오름차순 정렬 수행

            // 이진 탐색 수행
            int start = 0; // 시작점 설정
            int end = 1000000000; // 끝점 설정(단순하게 최댓값으로 설정)

            int result = 0;
            while (start <= end)
            {
                int total = 0; // 절단된 떡의 합 계산
                int mid = (start + end) / 2; // 중간점 설정

                // 배열을 순회하면서 절단한 떡의 양 계산
                for (int i = 0; i < N; i++)
                {
                    if (array[i] > mid)
                    {
                        total += array[i] - mid;
                    }
                }
                // 절단된 떡의 총 길이의 합이 요청한 값 이상이면 완료
                if (total >= M)
                {
                    result = mid;
                    start = mid + 1;
                }
                // 아니라면 mid 값을 줄인다.
                else end = mid - 1;
            }

            Console.WriteLine(result);
        }
    }
}