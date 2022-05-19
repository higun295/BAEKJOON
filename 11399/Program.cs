using System;
using System.Collections.Generic;

namespace _11399
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = Convert.ToInt16(Console.ReadLine());
            string[] timeArray = Console.ReadLine().Split(' ');

            List<int> list = new List<int>();
            foreach (string item in timeArray)
            {
                list.Add(Convert.ToInt16(item));
            }

            list.Sort();

            int result = 0;
            int time = 0;

            for (int i = 0; i < N; i++)
            {
                time += list[i];
                result += time;
            }

            Console.WriteLine(result);
        }
    }
}