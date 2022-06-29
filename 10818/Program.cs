using System;

namespace _10818
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(array);
            Console.WriteLine($"{array[0]} {array[N - 1]}");
        }
    }
}