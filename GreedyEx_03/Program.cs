using System;

namespace GreedyEx_03
{
    class Program
    {
        // <문제> 모험가 길드
        // 그리디 & 구현 23:34
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine()); // 모험가의 수 N
            string[] input = Console.ReadLine().Split(' ');
            
            int[] array = new int[N]; // 모험가 집단
            for (int i = 0; i < N; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }

            Array.Sort(array);

            int result = 0; // 모험가 그룹의 수
            int count = 0; // 현재 그룹에 포함된 모험가의 수
            for (int i = 0; i < N; i++)
            {
                count++;
                if (count >= array[i])
                {
                    result++;
                    count = 0;
                }
            }

            Console.WriteLine(result);

            /* ==================================================================================================================================== 
           * 위는 내 코드
           * 아래는 해설 풀이
           * ==================================================================================================================================== 
           */

            //int N = Convert.ToInt32(Console.ReadLine());
            //string[] stringArray = Console.ReadLine().Split(' ');
            //Array.Sort(stringArray);

            //int result = 0; // 그룹의 수
            //int memberCount = 0; // 그룹에 구성된 모험가의 수

            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    memberCount++;
            //    if (memberCount >= Convert.ToInt32(stringArray[i]))
            //    {
            //        result++;
            //        memberCount = 0;
            //    }
            //}

            //Console.WriteLine(result);
        }
    }
}