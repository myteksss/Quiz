﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Answer
    {
        int AnswerId {get; set;}
        int QuestionId { get; set; }
        string AnswerTheQuestion { get; set; }
        private bool CorrectAnswer { get; set; }
        public virtual Question Question { get; set; }
    }
}
