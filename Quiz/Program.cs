using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            AddQuestionToDb();
            Console.WriteLine("add question");
            Console.ReadKey();
        }
        public static void AddQuestionToDb()
        {
            using (var db = new StoreContext())
            {

                var question = new Question
                {
                    QuestionId = 1,
                    QuestionForUser = "Michała ukochana to",
                    AnswerId = 1
                };
                db.Questions.Add(question);
                db.SaveChanges();


            }
        }
    }
}
