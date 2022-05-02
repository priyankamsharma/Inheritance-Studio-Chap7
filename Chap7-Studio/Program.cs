using System;
using System.Collections.Generic;

namespace Chap7_Studio
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> answers = new List<string>
            {
                "Yes", "No", "Maybe", "What's Banana Cat?", "Actually, I like apple dog"
            };
        
        MultipleChoice bananaCatQuestion = new MultipleChoice("Do you like Banana Cat?", 100, answers, 0);

        bananaCatQuestion.DisplayQuestion();
        bananaCatQuestion.ShowAnswers();
        int score = bananaCatQuestion.GradeAnswer();

        if (score > 0)
        {
            Console.WriteLine("Good job, Correct Answer!");
        }
        else
        {
            Console.WriteLine("Wrong Answer, Try again");
        }
        }
    }
}
