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
            using (var context = new QuizContext())
            {
                var t = context.Questions.SqlQuery("select QuestionId,QuestionLevel from Questions  ").OrderByDescending<Question>();//context.Questions.Select(a => a.QuestionId == 1);
                
                Console.WriteLine(t);
                Console.ReadLine();
            }
            

        }
       
    }
}
