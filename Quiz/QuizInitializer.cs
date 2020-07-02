using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Quiz.Migrations
{
    public class QuizInitializer : MigrateDatabaseToLatestVersion<QuizContext,Configuration>
    {
        public static void SeedQuizData(QuizContext context)
        {
            var question = new List<Question>
            {
                new Question() { QuestionId = 1, QuestionForUser = "Question from initializer", AnswerId = 1}
            };

            question.ForEach(q => context.Questions.AddOrUpdate(q));
            context.SaveChanges();
        }
    }
}
