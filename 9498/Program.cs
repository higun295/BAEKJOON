using System;

namespace _9498
{
    class Program
    {
        static void Main (string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score >= 90 && score <= 100)
                Console.WriteLine('A');
            else if (score >= 80 && score <= 89)
                Console.WriteLine('B');
            else if (score >= 70 && score <= 79)
                Console.WriteLine('C');
            else if (score >= 60 && score <= 69)
                Console.WriteLine('D');
            else
                Console.WriteLine('F');
        }
    }
}