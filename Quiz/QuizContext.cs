using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Migrations
{
    public class QuizContext : DbContext
    {
        public QuizContext() : base("QuizContext")
        {

        }
        static QuizContext()
        {
            Database.SetInitializer<QuizContext>(new QuizInitializer());
        }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }
        
    }
}
