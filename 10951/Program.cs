using System;
using System.IO;
using System.Text;

namespace _10951
{
    class Program
    {
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder();

            while (sr.EndOfStream == false)
            {
                string[] inputArray = sr.ReadLine().Split(' ');
                int A = int.Parse(inputArray[0]);
                int B = int.Parse(inputArray[1]);

                sb.Append((A + B));
                sb.Append("\n");
            }

            Console.Write(sb);
            sr.Close();
        }
    }
}