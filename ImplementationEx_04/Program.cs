using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementationEx_04
{
    class Program
    {
        // <문제> 문자열 재정렬
        // 그리디 & 구현 51:24
        static void Main (string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            List<char> list = new List<char>(); // 문자를 넣을 리스트
            int number = 0; // 등장하는 숫자를 넣을 변수

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    list.Add(input[i]);
                else if (char.IsDigit(input[i]))
                    number += Convert.ToInt32(input[i] - '0');
            }

            var orderedList = list.OrderBy(x => x);
            foreach (char item in orderedList)
            {
                sb.Append(item);
            }

            Console.WriteLine(sb.Append(number));
        }
    }
}