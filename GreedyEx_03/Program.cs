using System;

namespace GreedyEx_03
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = Console.ReadLine().Split(' ');
            Array.Sort(stringArray);

            int result = 0; // 그룹의 수
            int memberCount = 0; // 그룹에 구성된 모험가의 수

            for (int i = 0; i < stringArray.Length; i++)
            {
                memberCount++;
                if (memberCount >= Convert.ToInt32(stringArray[i]))
                {
                    result++;
                    memberCount = 0;
                }
            }

            Console.WriteLine(result);
        }
    }
}