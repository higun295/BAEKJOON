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
            isPrimes[0] = true;
            isPrimes[1] = true;

            for (int i = 2; i <= max; i++)
            {
                if (isPrimes[i])
                    continue;
                for (int j = i + i; j <= max; j += i)
                {
                    isPrimes[j] = true;
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
                    if (isPrimes[i] == false && isPrimes[N - i] == false)
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