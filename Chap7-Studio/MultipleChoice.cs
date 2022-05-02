using System;
using System.Collections.Generic;
using System.Text;

namespace Chap7_Studio
{
    public class MultipleChoice : Question
    {
        public List<string> PossibleAnswers { get; set; }
        private int CorrectAnswersIdx { get; set; }

        public MultipleChoice(string questionText, int pointValue, List<string> possibleAnswers, int correctAnswersIdx) : base(questionText, pointValue)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswersIdx = correctAnswersIdx;
            QuestionText = questionText;
            PointValue = pointValue;
        }

        public override void ShowAnswers()
        {
            for(int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {PossibleAnswers[i]}");
            }         
        }

        public override int GradeAnswer()
        {
            Console.WriteLine("What will your answer be? Enter the index corresponding it to correct answer: " );
            int input = int.Parse(Console.ReadLine());

            if (PossibleAnswers[input - 1] == PossibleAnswers[CorrectAnswersIdx])
            {
                return PointValue;
            }
            else
            {
                return 0;
            }
        }
    }
}
