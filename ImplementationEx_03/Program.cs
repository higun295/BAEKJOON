using System;

namespace ImplementationEx_03
{
    class Program
    {
        static void Main (string[] args)
        {
            char[] charArray = Console.ReadLine().ToCharArray();

            int row = charArray[1] - '0';
            int column = charArray[0] - 'a' + 1;

            int[] dx = { -2, -1, 1, 2, 2, 1, -1, -2 };
            int[] dy = { -1, -2, -2, -1, 1, 2, 2, 1 };

            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                int nextRow = row + dx[i];
                int nextColumn = column + dy[i];

                if (nextRow >= 1 && nextRow <= 8 && nextColumn >= 1 && nextColumn <= 8)
                    result ++;
            }

            Console.WriteLine(result);

            //char[] charArray = Console.ReadLine().ToCharArray();
            //int result = 0;

            //for (int i = 1; i <= 8; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        int column = ConvertToInt(charArray[0]);
            //        int row = charArray[1] - '0';

            //        if (column + 2 == i || column -2 == i)
            //        {
            //            if (row + 1 == j || row - 1 == j)
            //                result++;
            //        }

            //        if (row + 2 == i || row - 2 == i)
            //        {
            //            if (column + 1 == j || column - 1 == j)
            //                result++;
            //        }
            //    }
            //}

            //Console.WriteLine(result);
        }

        //static int ConvertToInt (char column)
        //{
        //    switch (column)
        //    {
        //        case 'a':
        //            return 1;
        //        case 'b':
        //            return 2;
        //        case 'c':
        //            return 3;
        //        case 'd':
        //            return 4;
        //        case 'e':
        //            return 5;
        //        case 'f':
        //            return 6;
        //        case 'g':
        //            return 7;
        //        case 'h':
        //            return 8;
        //        default:
        //            return 0;
        //    }
        //}
    }
}
