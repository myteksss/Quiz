﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Quiz.Migrations
{
    public class QuizInitializer : MigrateDatabaseToLatestVersion<QuizContext, Configuration>
    {
        public static void SeedQuizData(QuizContext context)
        {
            var question = new List<Question>
            {
                new Question() { QuestionId = 1, QuestionLevel = 1, QuestionForUser = "Co mi wyjdzie jeśli do sproszkowanego korzenia asfodeliusa dodam nalewkę z piiunu to wyjdzie eliksir..."},
                new Question() { QuestionId = 2,QuestionLevel = 1, QuestionForUser = "co to jest beozar?"},
                new Question() { QuestionId = 3,QuestionLevel = 1, QuestionForUser = "kto podsłuchał przepowiednie o harrym i voldemorcie"},
                new Question() { QuestionId = 4,QuestionLevel = 1, QuestionForUser = "gdzie Sybilla trelevley wygłosiła przepowiednię?"},
                new Question() { QuestionId = 5,QuestionLevel = 1, QuestionForUser = "jak nazywała się pierwsza dziewczyna Herry'ego?"},
                new Question() { QuestionId = 6,QuestionLevel = 1, QuestionForUser = "kto od 3 klasy był zakochany w Ronie"},
                new Question() { QuestionId = 7,QuestionLevel = 1, QuestionForUser = "czego chciał uczyć Volbemort w hogwarcie"},
                new Question() { QuestionId = 8,QuestionLevel = 1, QuestionForUser = "jak nazywał się dziadek voldemorta?"},
                new Question() { QuestionId = 9,QuestionLevel = 1, QuestionForUser = "jak nazywał sie kiedyś lord voldemort"},
                new Question() { QuestionId = 10,QuestionLevel = 1, QuestionForUser = "kto był dziedzicem slytherina"},
                new Question() { QuestionId = 11,QuestionLevel = 1, QuestionForUser = "Kto otworzył komnate tajemnic w 1 części harry'ego?"},
                new Question() { QuestionId = 12,QuestionLevel = 1, QuestionForUser = "kto otworzył komnatę tajemnic w 2 części harryego"},
                new Question() { QuestionId = 13,QuestionLevel = 1, QuestionForUser = "czy dziennik riddla był horkusem"},
                new Question() { QuestionId = 14,QuestionLevel = 1, QuestionForUser = "z kim chodzi draco malfoy"},
                new Question() { QuestionId = 15,QuestionLevel = 1, QuestionForUser = "z kim zaczęła chodzic cho jak skonczyła z harrym"}
            };

            question.ForEach(q => context.Questions.AddOrUpdate(q));
            context.SaveChanges();

            var answer = new List<Answer>
            {
                new Answer() {AnswerId = 1, AnswerTheQuestion = "wielosokowy", QuestionId = 1, CorrectAnswer = false},
                new Answer() {AnswerId = 2, AnswerTheQuestion = "feliks felcis", QuestionId = 1, CorrectAnswer = false},
                new Answer() {AnswerId = 3, AnswerTheQuestion = "żywej śmierci", QuestionId = 1, CorrectAnswer = true},
                new Answer() {AnswerId = 4, AnswerTheQuestion = "amortencja", QuestionId = 1, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "strączek sopohorusa", QuestionId = 2, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "korzenie waleriany", QuestionId = 2, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "kamień księzycowy", QuestionId = 2, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "kamień tworzący się w zalądku kozy", QuestionId = 2, CorrectAnswer = true},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "prawie bezgłowy nick", QuestionId = 3, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "horacy slughorn", QuestionId = 3, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "Severus snape", QuestionId = 3, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "czy brat Dumbledora-barman Alberthow", QuestionId = 3, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "pod trzema miotłami", QuestionId = 4, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "u pani pudifuud", QuestionId = 4, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "pod świńskim łbem", QuestionId = 4, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "u zonka", QuestionId = 4, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "cho chang", QuestionId = 5, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "parvati patil", QuestionId = 5, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "hermiona granger", QuestionId = 5, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "ginny wesley", QuestionId = 5, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "padama patil", QuestionId = 6, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "hermiona granger", QuestionId = 6, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "levander brown", QuestionId = 6, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "herry potter :-)", QuestionId = 6, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "eliksirów", QuestionId = 7, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "zielarstwa", QuestionId = 7, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "obrony przed magicznymi stworzeniami", QuestionId = 7, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "obrony przed czarną magią", QuestionId = 7, CorrectAnswer = true},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "Morfin", QuestionId = 8, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "Marvolo", QuestionId = 8, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "Bob", QuestionId = 8, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "Tom", QuestionId = 8, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "albus dumbledore", QuestionId = 9, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "tom riddle", QuestionId = 9, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "tom gaunt", QuestionId = 9, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "bob ogden", QuestionId = 9, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "harry potter", QuestionId = 10, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "ten riddle", QuestionId = 10, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "marvolo gaunt", QuestionId = 10, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "tom riddle", QuestionId = 10, CorrectAnswer = true},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "lucjusz malfoy", QuestionId = 11, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "harry potter", QuestionId = 11, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "ginny wesley", QuestionId = 11, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "nie została otwarta", QuestionId = 11, CorrectAnswer = true},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "lucjusz malfoy", QuestionId = 12, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "harry potter", QuestionId = 12, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "ginny wesley", QuestionId = 12, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "nie została otwarta", QuestionId = 12, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "tak", QuestionId = 13, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "nie", QuestionId = 13, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "nie pamiętam", QuestionId = 13, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "no co ty xD", QuestionId = 13, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "pansy parkinson", QuestionId = 14, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "hermiona granger", QuestionId = 14, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "milicenta buldstrome", QuestionId = 14, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "padama patil", QuestionId = 14, CorrectAnswer = false},

                new Answer() {AnswerId = 1, AnswerTheQuestion = "zachariasz smitch", QuestionId = 15, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "michael cornwell", QuestionId = 15, CorrectAnswer = true},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "cedrik digeroy", QuestionId = 15, CorrectAnswer = false},
                new Answer() {AnswerId = 1, AnswerTheQuestion = "ron wesley", QuestionId = 15, CorrectAnswer = false},
            };

            answer.ForEach(a => context.Answers.AddOrUpdate(a));
            context.SaveChanges();
        }
    }
}
