using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Quiz.Migrations
{
    public class StoreInitializer : MigrateDatabaseToLatestVersion<StoreContext,Configuration>
    {
        public static void SeedStoreData(StoreContext context)
        {
            var question = new List<Question>
            {
                new Question() { QuestionId = 1, QuestionForUser = "", AnswerId = 1}
            };
        }
    }
}
