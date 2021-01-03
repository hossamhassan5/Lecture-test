using System;

namespace Lecture_test
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] ID = new int[30];
             for (int i = 0; i < ID.Length; i++)
             {
                 ID[i] = Convert.ToInt32(Console.ReadLine());
             }
             double max;
             double[] score = new double[30];
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = Convert.ToInt32(Console.ReadLine());
                if (score[i] < 50)
                {
                    score[i] += score[i] + 2;
                }
                for (int j = 0; j < score.Length; j++)
                {

                }



            }
        }
    }
}
