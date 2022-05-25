using System;

namespace ImplementationEx_01
{
    class Program
    {
        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] planArray = Console.ReadLine().Split(' ');

            int[] dX = { 0, 0, -1, 1 };
            int[] dy = { -1, 1, 0, 0 };
            char[] moveTypes = { 'L', 'R', 'U', 'D' };

            int currentX = 1; // 현재 X의 값
            int currentY = 1; // 현재 Y의 값

            for (int i = 0; i < planArray.Length; i++)
            {
                char plan = Convert.ToChar(planArray[i]);
                int tempX = 0; // 임시 저장용 X 값
                int tempY = 0; // 임시 저장용 Y 값

                for (int j = 0; j < 4; j++)
                {
                    if (plan == Convert.ToChar(moveTypes[j]))
                    {
                        tempX = currentX + dX[j];
                        tempY = currentY + dy[j];
                    }

                    if (tempX < 1 || tempY < 1 || tempX > N || tempY > N)
                        continue;

                    currentX = tempX;
                    currentY = tempY;
                }
            }

            Console.WriteLine($"{currentX} {currentY}");

            //int N = Convert.ToInt32(Console.ReadLine());
            //string[] planArray = Console.ReadLine().Split(' ');

            //int currentX = 1; // 현재 X 값
            //int currentY = 1; // 현재 Y 값

            //for (int i = 0; i < planArray.Length; i++)
            //{
            //    if (planArray[i].Equals("L"))
            //    {
            //        if (currentY == 1) 
            //            continue;

            //        currentY--;
            //    }
            //    else if (planArray[i].Equals("R"))
            //    {
            //        if (currentY == N)
            //            continue;

            //        currentY++;
            //    }
            //    else if (planArray[i].Equals("U"))
            //    {
            //        if (currentX == 1)
            //            continue;

            //        currentX--;
            //    }
            //    else if (planArray[i].Equals("D"))
            //    {
            //        if (currentX == N)
            //            continue;

            //        currentX++;
            //    }
            //}

            //Console.WriteLine($"{currentX} {currentY}");
        }
    }
}