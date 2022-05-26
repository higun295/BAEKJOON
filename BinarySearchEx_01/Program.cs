using System;

namespace BinarySearchEx_01
{
    class Program
    {
        static int BinarySeacrh (int[] array, int target, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
                return -1;

            // 중간점은 시작, 끝 Index의 합을 2로 나눈 것과 같다.
            // 소숫점은 모두 버린다.
            int midIndex = (startIndex + endIndex) / 2;

            if (array[midIndex] == target)
                return midIndex;
            else if (array[midIndex] > target)
            {
                // 중간점의 값보다 찾고자 하는 값이 작은 경우 왼쪽 확인
                return BinarySeacrh(array, target, startIndex, midIndex - 1);
            }
            else
            {
                // 중간점의 값보다 찾고자 하는 값이 큰 경우 오른쪽 확인
                return BinarySeacrh(array, target, midIndex + 1, endIndex);
            }
        }

        static int BinarySearchWhile (int[] array, int target, int startIndex, int endIndex)
        {
            while (startIndex <= endIndex)
            {
                // 중간점은 시작, 끝 Index의 합을 2로 나눈 것과 같다.
                // 소숫점은 모두 버린다.
                int midIndex = (startIndex + endIndex) / 2;

                if (array[midIndex] == target)
                {
                    return midIndex;
                }
                else if (array[midIndex] > target)
                {
                    // 중간점의 값보다 찾고자 하는 값이 작은 경우 왼쪽 확인
                    endIndex = midIndex - 1;
                }
                else
                {
                    // 중간점의 값보다 찾고자 하는 값이 큰 경우 오른쪽 확인
                    startIndex = midIndex + 1;
                }
            }

            return -1;
        }

        static void Main (string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(input[0]); // 원소의 개수
            int target = Convert.ToInt32(input[1]); // 찾고자 하는 값

            string[] inputArray = Console.ReadLine().Split(' ');
            int[] array = new int[N];

            // 이진 탐색을 위한 대상 배열을 정의한다.
            for (int i = 0; i < N; i++)
            {
                array[i] = Convert.ToInt32(inputArray[i]);
            }

            int result = BinarySearchWhile(array, target, 0, N - 1);
            if (result == -1)
                Console.WriteLine("원소가 존재하지 않습니다.");
            else
                Console.WriteLine(result + 1);
        }
    }
}