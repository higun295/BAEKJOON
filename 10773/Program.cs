using System;
using System.Collections.Generic;

namespace _10773
{
    public class Program
    {
        static void Main (string[] args)
        {
            int count = 0;
            int.TryParse(Console.ReadLine(), out count);

            if (count == 0)
                return;

            List<int> inputList = new List<int>();
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                int input = 0;
                int.TryParse(Console.ReadLine(), out input);

                if (input == 0)
                {
                    if (inputList.Count == 0)
                        return;

                    int deletedItem = inputList[inputList.Count - 1];
                    sum -= deletedItem;
                    inputList.RemoveAt(inputList.Count - 1);
                }
                else
                {
                    inputList.Add(input);
                    sum += input;
                }
            }

            Console.WriteLine(sum);
        }
    }
}