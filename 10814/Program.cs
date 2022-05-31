using System;
using System.Linq;

namespace _10814
{
    class Program
    {
        class Member
        {
            public int Index { get; set; }
            public int Age { get; set; }
            public string Name { get; set; }
        }

        static void Main (string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int index = 0;
            Member[] members = new Member[N];
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Member member = new Member
                {
                    Index = index++,
                    Age = int.Parse(input[0]),
                    Name = input[1]
                };

                members[i] = member;
            }

            var newList = members.OrderBy(x => x.Age).ThenBy(x => x.Index);
            foreach (var member in newList)
            {
                Console.WriteLine($"{member.Age} {member.Name}");
            }
        }
    }
}