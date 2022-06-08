using System;
using System.Text;

namespace _2577
{
    class Program
    {
        static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int sum = A * B * C;

            int[] array = new int[10];

            while (sum != 0)
            {
                array[sum % 10]++;
                sum /= 10;
            }
            for (int i = 0; i < array.Length; i++)
            {
                sb.AppendLine(array[i].ToString());
            }

            Console.Write(sb);
        }
    }
}