using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Migrations
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreContext")
        {

        }
        static StoreContext()
        {
            Database.SetInitializer<StoreContext>(new StoreInitializer());
        }
        public DbSet<Question> Questions { get; set; }
    }
}
