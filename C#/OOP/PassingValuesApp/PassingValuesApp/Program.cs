using System;

namespace PassingValuesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 100; //
            UpdateScoreToZero(score); //
            Console.WriteLine(score);  //

            int[] manyScores = { 70, 80, 90, 100 };
            UpdateManyScoreToZero(manyScores);
            foreach(int s in manyScores)
            {
                Console.WriteLine(s);
            }
        }
        static void UpdateScoreToZero(int pscore)
        {
            pscore = 0;
        }
        static void UpdateManyScoreToZero(int[] pscores)
        {
            for (int i = 0; i < pscores.Length; i++)
            {
                pscores[i] = 0;
            }
        }
    }
}
