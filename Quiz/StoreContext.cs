using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class StoreContext : DbContext
    {
        public StoreContext() : base("name = StoreContext")
        {

        }
        public DbSet<Question> Questions { get; set; }
    }
}
