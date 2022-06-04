using System;
using System.IO;
using System.Text;

namespace _6588
{
    class Program
    {
        static void Main (string[] args)
        {
            var max = 1000000;
            bool[] isPrimes = new bool[max + 1];

            Array.Fill(isPrimes, true);
            for (int i = 2; i < Math.Sqrt(max); i++)
            {
                if (isPrimes[i] == true)
                {
                    int j = 2;
                    while (i * j <= max)
                    {
                        isPrimes[i * j] = false;
                        j++;
                    }
                }
            }

            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            var sb = new StringBuilder();
            while (true)
            {
                var N = int.Parse(Console.ReadLine()); // 테스트 케이스 N
                if (N == 0)
                    break;

                bool isProve = false;
                for (int i = 2; i <= N / 2; i++)
                {
                    if (isPrimes[i] == true &&
                        isPrimes[N - i] == true)
                    {
                        sb.AppendLine($"{N} = {i} + {N - i}");
                        isProve = true;
                        break;
                    }
                }
                if (isProve == false)
                    sb.AppendLine("Goldbach's conjecture is wrong.");
            }

            sw.Write(sb);
            sb.Clear();
            sw.Close();
        }
    }
}