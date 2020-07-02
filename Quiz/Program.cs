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
        static void Main(string[] args)
        {
            Console.WriteLine("START");
            //AddQuestionToDb();
            Database.SetInitializer<QuizContext>(new QuizInitializer());
            Console.WriteLine("add question");
            Console.ReadKey();
        }
        public static void AddQuestionToDb()
        {
            using (var db = new QuizContext())
            {

                var question = new Question
                {
                    QuestionId = 1,
                    QuestionForUser = "bla bla bla test",
                    AnswerId = 1
                };
                db.Questions.Add(question);
                db.SaveChanges();


            }
        }
    }
}
