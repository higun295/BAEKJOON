using System;

namespace _1427
{
    class Program
    {
        static void Main (string[] args)
        {
            string input = Console.ReadLine();
         
            int inputLength = input.Length;
            int inputInt = Convert.ToInt32(input);
            int[] intArray = new int[inputLength];
            int index = 0;

            while (true)
            {
                int quotient = inputInt / Convert.ToInt32(Math.Pow(10, inputLength - 1));
                intArray[index] = quotient;
                
                inputInt -= quotient * Convert.ToInt32(Math.Pow(10, inputLength - 1));
                inputLength--;
                index++;

                if (inputLength <= 0)
                    break;
            }

            while (true)
            {
                int count = 0;

                for (int i = 0; i < intArray.Length; i++)
                {
                    if (i == intArray.Length - 1)
                        break;

                    if (intArray[i] < intArray[i + 1])
                    {
                        int temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                    else count++;
                }

                if (count == intArray.Length - 1)
                    break;
            }

            foreach (var item in intArray)
            {
                Console.Write(item);
            }
        }
    }
}