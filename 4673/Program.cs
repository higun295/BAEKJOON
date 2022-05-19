using System;
using System.Collections.Generic;

namespace _4673
{
    public class Program
    {
        private static int SelfCheck (int input)
        {
            int number = 0;
            if (input < 10)
            {
                number = input + input;
            }
            else if (input >= 10 && input < 100)
            {
                number = input + (input / 10) + (input % 10);
            }
            else if (input >= 100 && input < 1000)
            {
                number = input + (input / 100) + ((input % 100) / 10) + ((input % 100) % 10);
            }
            else if (input >= 1000 && input < 1000)
            {
                number = input + (input / 1000) + ((input % 1000) / 100) + (((input % 1000) % 100) / 10) + (((input % 1000) % 100) % 10);
            }
            else { }

            return number;
        }

        static void Main (string[] args)
        {
            int[] value = new int[10000];



            List<int> intList = new List<int>();

            for (int i = 1; i <= 10000; i++)
            {
                int output = SelfCheck(i);

                if (intList.Contains(output))
                    continue;

                intList.Add(output);
            }

            for (int i = 1; i <= 10000; i++)
            {
                if (intList.Contains(i) != true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}