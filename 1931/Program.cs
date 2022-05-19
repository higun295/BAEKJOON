using System;
using System.Linq;

namespace _1931
{
    class Program
    {
        public class ConferenceRoom
        {
            public int Start { get; set; }
            public int End { get; set; }
        }

        static void Main (string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            ConferenceRoom[] roomArray = new ConferenceRoom[N];
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                ConferenceRoom room = new ConferenceRoom
                {
                    Start = Convert.ToInt32(input[0]),
                    End = Convert.ToInt32(input[1])
                };

                roomArray[i] = room;
            }

            var orderedRoom = roomArray.OrderBy(x => x.End).ThenBy(x => x.Start).Select(x => x).ToArray();

            int result = 0; // 회의실 갯수
            int prev_end_time = 0; // 회의실 끝나는 시간

            for (int i = 0; i < N; i++)
            {
                if (prev_end_time <= orderedRoom[i].Start)
                {
                    prev_end_time = orderedRoom[i].End;
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}