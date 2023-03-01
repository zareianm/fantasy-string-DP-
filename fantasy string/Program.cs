using System;

namespace fantasy_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Console.WriteLine(FantasySteps(s));
        }

        private static int FantasySteps(string s)
        {
            int len = s.Length;

            int[] DP = new int[len+1];


            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < 97)
                    count++;
            }
            DP[0] = count;

            int min = DP[0];

            for (int i = 1; i < len+1; i++)
            {

                if (s[i-1] < 97)
                    DP[i] = DP[i - 1] - 1;
                else
                {
                    DP[i] = DP[i - 1]+1;
                }

                if (DP[i] < min)
                    min = DP[i];
            }

            return min;
        }

    }
}
