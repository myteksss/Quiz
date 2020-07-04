using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Migrations
{
    public class Configuration : DbMigrationsConfiguration<QuizContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(QuizContext context)
        {
            QuizInitializer.SeedQuizData(context);
        }

    }
}
