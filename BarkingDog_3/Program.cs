using System;

namespace BarkingDog_3
{
    class Program
    {
        // 0x03강 - 배열[20:41]
        static void Main (string[] args)
        {
            //Function2();
        }

        static int Function2 (int[] arr, int N)
        {
            int[] array = new int[101];
            for (int i = 0; i < N; i++)
            {
                if (array[100 - i] == 1)
                    return 1;
                array[arr[i]] = 1;
            }

            return 0;
        }
    }
}
