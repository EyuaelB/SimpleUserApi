
using Microsoft.EntityFrameworkCore;

namespace SimpleUserApi.Data
{
    public class SimpleAppContext: DbContext
    {
        

        public DbSet<User> Users { get; set; } = null;


        public SimpleAppContext(DbContextOptions<SimpleAppContext> options)
            : base(options) { }
 
   
    }


}
