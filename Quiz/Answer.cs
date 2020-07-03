using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Answer
    {
        public int AnswerId {get; set;}
        public int QuestionId { get; set; }
        public string AnswerTheQuestion { get; set; }
        public bool CorrectAnswer { get; set; }
        public virtual Question Question { get; set; }
    }
}
