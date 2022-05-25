using System;
using System.Collections.Generic;
using System.Linq;

namespace ImplementationEx_04
{
    class Program
    {
        static void Main (string[] args)
        {
            string input = Console.ReadLine();

            List<char> charList = new List<char>();
            int numberSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    charList.Add(input[i]);
                else
                    numberSum += input[i] - '0';
            }

            var orderedList = charList.OrderBy(x => x);
            foreach (var item in orderedList)
            {
                Console.Write(item);
            }

            Console.Write(numberSum);
            
            //char[] inputArray = Console.ReadLine().ToCharArray();

            //List<string> charList = new List<string>();
            //int numberSum = 0;
            //string result = string.Empty;

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    if (inputArray[i] >= 49 && inputArray[i] <= 57)
            //    {
            //        numberSum += Convert.ToInt32(inputArray[i] - '0');
            //    }
            //    else
            //    {
            //        charList.Add(inputArray[i].ToString());
            //    }
            //}

            //var list = charList.OrderBy(x => x);

            //StringBuilder sb = new StringBuilder();
            //foreach (string item in list)
            //{
            //    sb.Append(item);
            //}

            //sb.Append(numberSum);
            //Console.WriteLine(sb);
        }
    }
}