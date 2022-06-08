using System;

namespace BarkingDog_2
{
    class Program
    {
        static void Main (string[] args)
        {
            InsertTest();
            EraseTest();
        }

        static void Insert (int idx, int num, int[] arr, ref int len)
        {
            for (int i = len; i > idx; i--)
                arr[i] = arr[i - 1];
            arr[idx] = num;
            len++;
        }

        static void Erase (int idx, int[] arr, ref int len)
        {
            len--;
            for (int i = idx; i < len; i++)
                arr[i] = arr[i + 1];
        }

        static void PrintArray (int[] arr, ref int len)
        {
            for (int i = 0; i < len; i++)
                Console.Write(arr[i] + ' ');

            Console.Write("\n\n");
        }

        static void InsertTest ()
        {
            Console.WriteLine("***** InsertTest *****\n");
            int[] arr = { 10, 20, 30, 0, 0, 0, 0, 0, 0, 0 };
            int len = 3;
            Insert(3, 40, arr, ref len); // 10 20 30 40
            PrintArray(arr, ref len);
            Insert(1, 50, arr, ref len); // 10 50 20 30 40
            PrintArray(arr, ref len);
            Insert(0, 15, arr, ref len); // 15 10 50 20 30 40
            PrintArray(arr, ref len);
        }
        static void EraseTest ()
        {
            Console.Write("***** erase_test *****\n");
            int[] arr = { 10, 50, 40, 30, 70, 20, 0, 0, 0, 0 };
            int len = 6;
            Erase(4, arr, ref len); // 10 50 40 30 20
            PrintArray(arr, ref len);
            Erase(1, arr, ref len); // 10 40 30 20
            PrintArray(arr, ref len);
            Erase(3, arr, ref len); // 10 40 30
            PrintArray(arr, ref len);
        }
    }
}