using System;
using System.Collections.Generic;

namespace CCharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rome number");
            string romeNumber = Console.ReadLine();
            Console.WriteLine($"You entered {RomeNumbersParse(romeNumber)} in Arabian format"); }
            private static Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000},
            };




        public static int RomeNumbersParse(string input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i+1 < input.Length && IsSubtracktive(input[i], input[i + 1]))
                {
                    result -= map[input[i]];
                }
                else 
                {
                    result += map[input[i]];
                }
            }


            return result;
        }

        private static bool IsSubtracktive(char c1, char c2)
        {
            return map[c1] < map[c2];
        }
    }
}

