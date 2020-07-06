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
            
            
            Console.WriteLine("Witaj w wersji Beta Quizolandu");
            Console.WriteLine("Pierwszy quiz i na ten moment jedyny jest poswięcony tematyce Harrego Pottera i jego przygód");
            Console.WriteLine("Jesteś gotowa? Y or N");
            var decide = Console.ReadLine();            
            
            QuizContext context = new QuizContext();            
            var t = context.Questions.Where(a => a.QuestionId == 1);   
            
            if (decide == "y")
            {
                foreach (var question in t) 
                { 
                    Console.WriteLine($"QuestionId: {question.QuestionId}, QuestionLevel:  {question.QuestionLevel}");
                }
            }
            else
            {
                Console.WriteLine("Szkoda że jesteś taka zołza i nie chcesz przejść mojego quizu :(");
            }
                        
            
            
            
            Console.ReadLine();
        }
       
    }
}
//AdventureWorks2012_DataEntities db = new AdventureWorks2012_DataEntities();
//var employeeHiredIn2007 = db.Employee.Where(a => a.HireDate.Year == 2007);
//// Wyświetlamy przykładowe dane w konsoli
//foreach (var item in employeeHiredIn2007)
//{
//    Console.WriteLine($"Id: {item.BusinessEntityID}, Płeć: {item.Gender}, Data zatrudnienia: {item.HireDate}");
//}