using System;
using System.IO;
using System.Text;

namespace _6064
{
    class Program
    {
        static int GCD (int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
        }
        static int LCM (int a, int b)
        {
            return a * b / GCD(a, b);
        }

        static void Main (string[] args)
        {
            int T = int.Parse(Console.ReadLine()); // TestCase T
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            var sb = new StringBuilder();

            while (T-- > 0)
            {
                // 0 1 2 3
                // M N x y 순서
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                int cnt = input[2] % (input[0] + 1);
                int tempY = input[2];

                for (int i = 0; i < input[1]; i++)
                {
                    int ty = tempY % input[1] == 0 ? input[1] : tempY % input[1];
                    if (ty == input[3])
                        break;

                    tempY = ty + input[0];
                    cnt += input[0];
                }

                sb.Append(cnt > LCM(input[0], input[1]) ? "-1" : cnt);
                sb.Append("\n");
            }

            sw.Write(sb);
            sw.Close();
        }
    }
}