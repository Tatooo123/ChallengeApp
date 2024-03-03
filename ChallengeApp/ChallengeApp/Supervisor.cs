﻿namespace ChallengeApp
{
    public class Supervisor : Employee
    {
        public Supervisor(string firstName, string lastName, char gender, int age)
        : base(firstName, lastName, gender, age)
        {
        }
    
        new public void AddPoints(string score)
        {
            string scoreTmp = score;
            int gradeHalf = 0;
            int grade = 0;
            if (score.Length == 2)
            {
                if (score.Contains('-'))
                {
                    gradeHalf = -5;
                    scoreTmp = scoreTmp.Replace("-", "");
                }
                else if (score.Contains('+'))
                {
                    gradeHalf = 5;
                    scoreTmp = scoreTmp.Replace("+", "");
                }
            }
            if ( scoreTmp.Length == 1 && "123456".Contains(scoreTmp[0]) 
                                      && int.TryParse(scoreTmp, out grade) )
            {
//                points = (grade - 1) * 20 + gradeHalf;
                this.AddPoints((grade - 1) * 20 + gradeHalf);
            }
            else
            {
                throw new Exception("score " + '"' + score + '"' + " is not proper score");
            }
        }
    }
}