using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quiz.Migrations
{
    class Program
    {        
        public static void Main(string[] args)
        {            
            Console.WriteLine("Witaj w wersji Beta Quizolandu");
            Console.WriteLine("Pierwszy quiz i na ten moment jedyny jest poswięcony tematyce Harrego Pottera i jego przygód");
            Console.WriteLine("Jesteś gotowa? Y or N");
            var decide = Console.ReadLine();
            
            QuizContext context = new QuizContext();            
            var firstQuestion = context.Questions.Where(a => a.QuestionId == 1).Where(a => a.QuestionLevel == 1);
            var firstAnswers = context.Answers.Where(a => a.QuestionId == 1);
            
            if (decide == "y")
            {
                foreach (var question in firstQuestion) 
                { 
                    Console.WriteLine($"QuestionId: {question.QuestionId}, QuestionLevel:  {question.QuestionLevel}");


                }                    
                foreach (var an in firstAnswers)
                    {
                        Console.WriteLine($"A: {an.AnswerTheQuestion}, B: {an.AnswerTheQuestion}, C: {an.AnswerTheQuestion}, D: {an.AnswerTheQuestion}");
                    }
            }
            else
            {
                Console.WriteLine("Szkoda że jesteś taka zołza i nie chcesz przejść mojego quizu :(");
            }            
            
            Console.ReadLine();
        }
       
    }
}
