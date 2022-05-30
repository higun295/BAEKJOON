using System;
using System.Collections.Generic;
using System.Linq;

namespace _10814
{
    class Program
    {
        public class Register : IComparable
        {
            public static int Indexer;

            public int Index;
            public int Age;
            public string Name;

            public Register (string name, int age)
            {
                Age = age;
                Name = name;
                Index = Register.Indexer++;
            }

            public int CompareTo (object obj)
            {
                Register other = obj as Register;
                if (Age == other.Age)
                    return Index.CompareTo(other.Index);

                return Age.CompareTo(other.Age);
            }
        }
        static void Main (string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Register.Indexer = 0;
            var RegisterList = new List<Register>();

            for (int i = 0; i < count; i++)
            {
                string[] strRegister = Console.ReadLine().Split(' ');
                RegisterList.Add(new Register(strRegister[1], int.Parse(strRegister[0])));
            }

            RegisterList.Sort();

            foreach (var r in RegisterList)
            {
                Console.WriteLine($"{r.Age} {r.Name}");
            }
        }
    }
}