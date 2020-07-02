using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quiz.Migrations
{
    public class Program
    {
        private QuizContext db = new QuizContext();
        static void Main(string[] args)
        {

           
            
        }
        public string TestQuery()
        {
            var t = db.Questions.Where(a => a.QuestionId == 1).ToString();


            return t;
        }
    }
}
