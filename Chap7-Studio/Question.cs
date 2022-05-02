using System;
using System.Collections.Generic;
using System.Text;

namespace Chap7_Studio
{
    public abstract class Question
    {
        //Question text
        public string QuestionText { get; set; }
        public int PointValue { get; set; }

        //constructor
        public Question(string questionText, int pointValue)
        {
            QuestionText = questionText;
            PointValue = pointValue;
        }

        //display Question Text
        public void DisplayQuestion()
        {
            Console.WriteLine(QuestionText);
        }
        

        //display available answers for the question
        public abstract void ShowAnswers();

        //
        //Validate answers and award points
        public abstract int GradeAnswer();
       
    }
}
